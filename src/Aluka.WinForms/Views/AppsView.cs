using Aluka.Application.DTOs;
using Aluka.Application.Services;
using Aluka.WinForms.UI;
using Microsoft.Extensions.DependencyInjection;
using System.Drawing;
using System.Drawing.Imaging;

namespace Aluka.WinForms.Views;

public partial class AppsView : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppService? _appService;
    private List<AppDTO> _allApps = new();
    private bool _isLoading = false;
    private bool _isUpdating = false;
    private bool _isLoadingGrid = false;
    private int _processingRowIndex = -1;
    private bool _isProgrammaticChange = false;
    private bool _isInitialized = false;

    // =========================================================
    // NOVO: Controlo para distinguir clique do utilizador vs recarga
    // =========================================================
    private bool _isApplyingFilter = false;
    private bool _isUserInitiatedChange = false;

    public AppsView(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _appService = serviceProvider.GetService<IAppService>();
        InitializeComponent();

        // Garantir que os eventos estão ligados corretamente
        this.dgvApps.CellValueChanged -= DgvApps_CellValueChanged!;
        this.dgvApps.CellValueChanged += DgvApps_CellValueChanged!;

        this.dgvApps.CurrentCellDirtyStateChanged -= DgvApps_CurrentCellDirtyStateChanged!;
        this.dgvApps.CurrentCellDirtyStateChanged += DgvApps_CurrentCellDirtyStateChanged!;

        // Desativar temporariamente o TextChanged durante a inicialização
        this.txtSearch.TextChanged -= TxtSearch_TextChanged!;

        BackColor = Theme.Colors.Background;
        pnlHeader.BackColor = Theme.Colors.Background;
        pnlHeader.Padding = new Padding(0, Theme.Spacing.S, 0, Theme.Spacing.S);
        pnlActions.BackColor = Theme.Colors.Background;
        pnlActions.Padding = new Padding(0, Theme.Spacing.S, 0, 0);

        lblTitle.Font = Theme.Fonts.SubHeading;
        lblTitle.ForeColor = Theme.Colors.TextPrimary;

        txtSearch.Font = Theme.Fonts.Body;

        Theme.StyleGrid(dgvApps);
        Theme.StyleSecondaryButton(btnRefresh);

        lblStatus.Font = Theme.Fonts.Caption;
        lblStatus.ForeColor = Theme.Colors.TextSecondary;
    }

    public async Task RefreshAsync()
    {
        await LoadAppsAsync();
    }

    private async void AppsView_Load(object sender, EventArgs e)
    {
        _isInitialized = false;
        await LoadAppsAsync();
        _isInitialized = true;

        // Reativar o TextChanged após a inicialização
        this.txtSearch.TextChanged += TxtSearch_TextChanged!;
    }

    private async Task LoadAppsAsync()
    {
        if (_isLoading || _appService == null) return;

        _isLoading = true;
        _isLoadingGrid = true;
        _isProgrammaticChange = true;
        btnRefresh.Enabled = false;
        lblStatus.Text = "A carregar aplicações...";

        // Limpar a grelha de forma segura
        try
        {
            dgvApps.Rows.Clear();
        }
        catch
        {
            // Ignorar erros ao limpar
        }

        try
        {
            _allApps = (await _appService.GetAllAppsAsync()).ToList();

            var configurableApps = _allApps
                .Where(a => a.EstaAtivo && a.IsConfigurable)
                .ToList();

            if (configurableApps.Any())
            {
                lblStatus.Text = $"✅ {_allApps.Count} apps carregadas, {configurableApps.Count} configuráveis.";
            }
            else
            {
                lblStatus.Text = $"✅ {_allApps.Count} apps carregadas. Nenhuma configurável.";
            }

            ApplyFilter();
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Erro: {ex.Message}";
            MessageBox.Show($"Erro ao carregar aplicações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isProgrammaticChange = false;
            _isLoadingGrid = false;
            _isLoading = false;
            btnRefresh.Enabled = true;
        }
    }

    private void ApplyFilter()
    {
        // =========================================================
        // Marcar que estamos a aplicar o filtro
        // =========================================================
        _isApplyingFilter = true;

        try
        {
            if (dgvApps == null || dgvApps.Columns.Count == 0)
            {
                return;
            }

            try
            {
                dgvApps.Rows.Clear();
            }
            catch
            {
                return;
            }

            if (_allApps == null || !_allApps.Any())
            {
                lblStatus.Text = "✅ Nenhuma aplicação encontrada.";
                return;
            }

            var searchText = txtSearch.Text;
            bool isSearching = searchText != "Pesquisar aplicação..." && !string.IsNullOrWhiteSpace(searchText);

            var filtered = _allApps
                .Where(a => a.EstaAtivo)
                .Where(a => !isSearching || a.Nome.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                .OrderBy(a => a.Nome)
                .ToList();

            foreach (var app in filtered)
            {
                try
                {
                    if (dgvApps.Columns.Count < 5)
                    {
                        continue;
                    }

                    var rowIndex = dgvApps.Rows.Add();

                    if (rowIndex < 0 || rowIndex >= dgvApps.Rows.Count)
                    {
                        continue;
                    }

                    var icon = Base64ToImage(app.IconeBase64);

                    if (dgvApps.Rows[rowIndex].Cells.Count > 0)
                        dgvApps.Rows[rowIndex].Cells[0].Value = icon ?? GetDefaultIcon();
                    if (dgvApps.Rows[rowIndex].Cells.Count > 1)
                        dgvApps.Rows[rowIndex].Cells[1].Value = app.Nome ?? "Desconhecido";
                    if (dgvApps.Rows[rowIndex].Cells.Count > 2)
                        dgvApps.Rows[rowIndex].Cells[2].Value = app.CaminhoExecutavel ?? "";
                    if (dgvApps.Rows[rowIndex].Cells.Count > 3)
                        dgvApps.Rows[rowIndex].Cells[3].Value = app.EstaAtivo ? "Ativa" : "Inativa";
                    if (dgvApps.Rows[rowIndex].Cells.Count > 4)
                        dgvApps.Rows[rowIndex].Cells[4].Value = app.IsConfigurable;

                    dgvApps.Rows[rowIndex].Tag = app.Id;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Erro ao adicionar app {app.Nome}: {ex.Message}");
                }
            }

            var activeCount = _allApps.Count(a => a.EstaAtivo);
            lblStatus.Text = $"✅ {filtered.Count} aplicações ativas ({activeCount} total)";
        }
        finally
        {
            // =========================================================
            // IMPORTANTE: Libertar a flag APÓS aplicar o filtro
            // =========================================================
            _isApplyingFilter = false;
        }
    }

    private void DgvApps_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
    {
        // =========================================================
        // IGNORAR se estiver a carregar ou a aplicar filtro
        // =========================================================
        if (_isLoadingGrid || _isUpdating || _isProgrammaticChange || _isApplyingFilter) return;

        try
        {
            if (dgvApps.CurrentCell is DataGridViewCell cell &&
                cell.ColumnIndex == colConfigurable.Index &&
                cell.RowIndex >= 0)
            {
                // =========================================================
                // Marcar que o utilizador está a fazer a alteração
                // =========================================================
                _isUserInitiatedChange = true;
                dgvApps.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        catch
        {
            // Ignorar erros
        }
        finally
        {
            _isUserInitiatedChange = false;
        }
    }

    private async void DgvApps_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
    {
        // =========================================================
        // VERIFICAÇÕES CRÍTICAS:
        // 1. Só processar se for a coluna Configurável
        // 2. Só processar se NÃO estiver a carregar/aplicar filtro
        // 3. Só processar se a alteração foi iniciada pelo utilizador
        // 4. Só processar se NÃO for uma alteração programática
        // =========================================================
        if (e.ColumnIndex != colConfigurable.Index || e.RowIndex < 0)
            return;

        if (_isLoadingGrid || _isUpdating || _isProgrammaticChange || _isApplyingFilter)
            return;

        if (!_isUserInitiatedChange)
            return;

        if (_processingRowIndex == e.RowIndex)
            return;

        if (_appService == null)
        {
            MessageBox.Show("Serviço de aplicações não disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        _isUpdating = true;
        _processingRowIndex = e.RowIndex;

        try
        {
            var row = dgvApps.Rows[e.RowIndex];
            var newValue = (bool)row.Cells[e.ColumnIndex].Value;

            var appId = row.Tag as int?;
            if (!appId.HasValue || appId.Value == 0)
            {
                var appName = row.Cells[colName.Index].Value?.ToString();
                var foundApp = _allApps.FirstOrDefault(a => a.Nome == appName);
                if (foundApp == null) return;
                appId = foundApp.Id;
            }

            // =========================================================
            // SÓ mostrar o modal se for ATIVAÇÃO (newValue == true)
            // =========================================================
            if (newValue)
            {
                await Task.Delay(50);

                var result = MessageBox.Show(
                    $"Ao ativar '{row.Cells[colName.Index].Value}' como configurável, esta aplicação poderá ser utilizada para criar regras na tela de 'Regras'.\n\nDeseja continuar?",
                    "Ativar Configuração",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information);

                if (result != DialogResult.OK)
                {
                    _isProgrammaticChange = true;
                    row.Cells[e.ColumnIndex].Value = false;
                    _isProgrammaticChange = false;
                    return;
                }
            }

            await _appService.ToggleConfigurableAsync(appId.Value, newValue);

            var appToUpdate = _allApps.FirstOrDefault(a => a.Id == appId.Value);
            if (appToUpdate != null)
            {
                appToUpdate.IsConfigurable = newValue;
            }

            await LoadAppsAsync();

            lblStatus.Text = $"✅ Configuração da aplicação atualizada.";
        }
        catch (Exception ex)
        {
            _isProgrammaticChange = true;
            try
            {
                var row = dgvApps.Rows[e.RowIndex];
                var currentValue = (bool)row.Cells[e.ColumnIndex].Value;
                row.Cells[e.ColumnIndex].Value = !currentValue;
            }
            catch
            {
                // Ignorar erros ao reverter
            }
            _isProgrammaticChange = false;

            MessageBox.Show($"Erro ao atualizar configuração: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isUpdating = false;
            _processingRowIndex = -1;
            _isUserInitiatedChange = false;
        }
    }

    private void TxtSearch_TextChanged(object sender, EventArgs e)
    {
        if (!_isInitialized) return;
        if (_isLoading) return;

        ApplyFilter();
    }

    private void TxtSearch_Enter(object sender, EventArgs e)
    {
        if (txtSearch.Text == "Pesquisar aplicação...")
        {
            txtSearch.TextChanged -= TxtSearch_TextChanged!;
            txtSearch.Text = "";
            txtSearch.ForeColor = System.Drawing.Color.Black;
            txtSearch.TextChanged += TxtSearch_TextChanged!;
        }
    }

    private void TxtSearch_Leave(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtSearch.Text))
        {
            txtSearch.TextChanged -= TxtSearch_TextChanged!;
            txtSearch.Text = "Pesquisar aplicação...";
            txtSearch.ForeColor = System.Drawing.Color.Gray;
            txtSearch.TextChanged += TxtSearch_TextChanged!;
        }
    }

    private async void BtnRefresh_Click(object sender, EventArgs e)
    {
        if (_appService == null) return;

        if (_isUpdating)
        {
            MessageBox.Show("Aguarde a conclusão da operação atual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        btnRefresh.Enabled = false;
        btnRefresh.Text = "⏳ A varrer...";
        lblStatus.Text = "A varrer o sistema...";

        try
        {
            await _appService.ScanAndUpdateAppsAsync();
            await LoadAppsAsync();
            lblStatus.Text = "✅ Varrimento concluído com sucesso!";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Erro no varrimento: {ex.Message}";
            MessageBox.Show($"Erro ao varrer aplicações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnRefresh.Enabled = true;
            btnRefresh.Text = "🔄 Atualizar Lista";
        }
    }

    private Image? Base64ToImage(string? base64String)
    {
        if (string.IsNullOrEmpty(base64String))
            return null;

        try
        {
            var bytes = Convert.FromBase64String(base64String);
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
        catch
        {
            return null;
        }
    }

    private Image GetDefaultIcon()
    {
        var bitmap = new Bitmap(32, 32);
        using var g = Graphics.FromImage(bitmap);
        g.Clear(Color.LightGray);
        using var font = new Font("Segoe UI", 12, FontStyle.Bold);
        using var brush = new SolidBrush(Color.Gray);
        g.DrawString("A", font, brush, 8, 6);
        return bitmap;
    }
}
