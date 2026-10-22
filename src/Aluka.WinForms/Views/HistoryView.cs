using Aluka.Application.DTOs;
using Aluka.Application.Services;
using Aluka.Domain.Enums;
using Aluka.WinForms.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Aluka.WinForms.Views;

public partial class HistoryView : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IHistoryService? _historyService;
    private readonly IRuleService? _ruleService;
    private List<HistoryDTO> _allHistory = new();
    private bool _isLoading = false;

    public HistoryView(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _historyService = serviceProvider.GetService<IHistoryService>();
        _ruleService = serviceProvider.GetService<IRuleService>();
        InitializeComponent();

        // Inicializar combo de filtro de status
        cmbStatusFilter.Items.Clear();
        cmbStatusFilter.Items.Add("Todos");
        cmbStatusFilter.Items.Add("Sucesso");
        cmbStatusFilter.Items.Add("Erro");
        cmbStatusFilter.Items.Add("Ignorado");
        cmbStatusFilter.SelectedIndex = 0;

        // =========================================================
        // CORREÇÃO: Chamar o método assíncrono sem await
        // Para evitar o warning CS4014, usamos _ =
        // =========================================================
        _ = LoadRuleFilterAsync();

        BackColor = Theme.Colors.Background;
        pnlHeader.BackColor = Theme.Colors.Background;
        pnlHeader.Padding = new Padding(0, Theme.Spacing.S, 0, Theme.Spacing.S);
        pnlActions.BackColor = Theme.Colors.Background;
        pnlActions.Padding = new Padding(0, Theme.Spacing.S, 0, 0);

        lblTitle.Font = Theme.Fonts.SubHeading;
        lblTitle.ForeColor = Theme.Colors.TextPrimary;
        lblStats.Font = Theme.Fonts.Caption;
        lblStats.ForeColor = Theme.Colors.TextSecondary;

        grpFilters.BackColor = Theme.Colors.Background;
        grpFilters.Font = Theme.Fonts.Body;

        Theme.StyleGrid(dgvHistory);

        Theme.StyleSecondaryButton(btnRefresh);
        Theme.StyleSecondaryButton(btnDeleteSelected);
        Theme.StyleSecondaryButton(btnClearAll);

        lblStatus.Font = Theme.Fonts.Caption;
        lblStatus.ForeColor = Theme.Colors.TextSecondary;
    }

    public async Task RefreshAsync()
    {
        await LoadHistoryAsync();
    }

    private async void HistoryView_Load(object sender, EventArgs e)
    {
        await LoadHistoryAsync();
    }

    private async Task LoadRuleFilterAsync()
    {
        try
        {
            if (_ruleService == null) return;

            var rules = await _ruleService.GetAllRulesAsync();

            cmbRuleFilter.Items.Clear();
            cmbRuleFilter.Items.Add("Todas as regras");

            foreach (var rule in rules.OrderBy(r => r.AplicacaoNome))
            {
                cmbRuleFilter.Items.Add($"{rule.Id} - {rule.AplicacaoNome} ({rule.TipoAcao})");
            }

            cmbRuleFilter.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            // Ignorar erros ao carregar regras para o filtro
            System.Diagnostics.Debug.WriteLine($"Erro ao carregar regras: {ex.Message}");
        }
    }

    private async Task LoadHistoryAsync()
    {
        if (_isLoading || _historyService == null) return;

        _isLoading = true;
        btnRefresh.Enabled = false;
        lblStatus.Text = "A carregar histórico...";
        dgvHistory.Rows.Clear();

        try
        {
            int? ruleId = null;
            StatusExecucao? status = null;
            DateTime? startDate = null;
            DateTime? endDate = null;

            // Filtrar por regra
            if (cmbRuleFilter.SelectedIndex > 0)
            {
                var ruleText = cmbRuleFilter.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(ruleText))
                {
                    var parts = ruleText.Split(' ');
                    if (parts.Length > 0 && int.TryParse(parts[0], out int id))
                    {
                        ruleId = id;
                    }
                }
            }

            // Filtrar por status
            if (cmbStatusFilter.SelectedIndex > 0)
            {
                var statusText = cmbStatusFilter.SelectedItem?.ToString();
                status = statusText switch
                {
                    "Sucesso" => StatusExecucao.Sucesso,
                    "Erro" => StatusExecucao.Erro,
                    "Ignorado" => StatusExecucao.Ignorado,
                    _ => null
                };
            }

            // Filtrar por data
            if (dtpStartDate.Checked)
            {
                startDate = dtpStartDate.Value.Date;
            }
            if (dtpEndDate.Checked)
            {
                endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);
            }

            _allHistory = (await _historyService.GetFilteredHistoryAsync(
                ruleId: ruleId,
                status: status,
                startDate: startDate,
                endDate: endDate,
                limit: null)).ToList();

            ApplyHistoryToGrid();

            var stats = await _historyService.GetStatisticsAsync(startDate, endDate);
            UpdateStatistics(stats);

            lblStatus.Text = $"✅ {_allHistory.Count} registos carregados.";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"❌ Erro: {ex.Message}";
            MessageBox.Show($"Erro ao carregar histórico: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            _isLoading = false;
            btnRefresh.Enabled = true;
        }
    }

    private void ApplyHistoryToGrid()
    {
        dgvHistory.Rows.Clear();

        foreach (var item in _allHistory)
        {
            var rowIndex = dgvHistory.Rows.Add();

            dgvHistory.Rows[rowIndex].Cells[colSelect.Index].Value = false;
            dgvHistory.Rows[rowIndex].Cells[colId.Index].Value = item.Id;
            dgvHistory.Rows[rowIndex].Cells[colDate.Index].Value = item.DataExecucao.ToString("dd/MM/yyyy HH:mm:ss");

            // =========================================================
            // CORREÇÃO: Usar as propriedades do DTO
            // =========================================================
            dgvHistory.Rows[rowIndex].Cells[colRule.Index].Value = item.RegraNome ?? "N/A";
            dgvHistory.Rows[rowIndex].Cells[colApp.Index].Value = item.AplicacaoNome ?? "N/A";
            dgvHistory.Rows[rowIndex].Cells[colAction.Index].Value = item.TipoAcao ?? "N/A";

            dgvHistory.Rows[rowIndex].Cells[colStatus.Index].Value = GetStatusText(item.Status);
            dgvHistory.Rows[rowIndex].Cells[colDuration.Index].Value = item.DuracaoMs.HasValue ? $"{item.DuracaoMs}ms" : "-";
            dgvHistory.Rows[rowIndex].Cells[colError.Index].Value = item.MensagemErro ?? "";

            // Cor por status
            var statusColor = GetStatusColor(item.Status);
            dgvHistory.Rows[rowIndex].DefaultCellStyle.ForeColor = statusColor;

            dgvHistory.Rows[rowIndex].Tag = item.Id;
        }
    }

    private string GetStatusText(StatusExecucao status)
    {
        return status switch
        {
            StatusExecucao.Sucesso => "✅ Sucesso",
            StatusExecucao.Erro => "❌ Erro",
            StatusExecucao.Ignorado => "⏭️ Ignorado",
            _ => "❓ Desconhecido"
        };
    }

    private Color GetStatusColor(StatusExecucao status)
    {
        return status switch
        {
            StatusExecucao.Sucesso => Color.Green,
            StatusExecucao.Erro => Color.Red,
            StatusExecucao.Ignorado => Color.Gray,
            _ => Color.Black
        };
    }

    private void UpdateStatistics(HistoryStatisticsDTO stats)
    {
        lblStats.Text = $"Total: {stats.Total} | ✅ {stats.Success} | ❌ {stats.Errors} | ⏭️ {stats.Ignored}";
    }

    // =========================================================
    // FILTROS
    // =========================================================
    private async void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoading) return;
        await LoadHistoryAsync();
    }

    private async void CmbRuleFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_isLoading) return;
        await LoadHistoryAsync();
    }

    private async void DtpStartDate_ValueChanged(object sender, EventArgs e)
    {
        if (_isLoading) return;
        await LoadHistoryAsync();
    }

    private async void DtpEndDate_ValueChanged(object sender, EventArgs e)
    {
        if (_isLoading) return;
        await LoadHistoryAsync();
    }

    // =========================================================
    // ELIMINAÇÃO
    // =========================================================
    private async void BtnDeleteSelected_Click(object sender, EventArgs e)
    {
        if (_historyService == null) return;

        var selectedIds = new List<int>();

        foreach (DataGridViewRow row in dgvHistory.Rows)
        {
            if (row.Cells[colSelect.Index].Value is bool isSelected && isSelected)
            {
                var id = (int)row.Cells[colId.Index].Value;
                selectedIds.Add(id);
            }
        }

        if (!selectedIds.Any())
        {
            MessageBox.Show("Selecione pelo menos um registo para eliminar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show(
            $"Tem certeza que deseja eliminar {selectedIds.Count} registos do histórico?",
            "Confirmar Eliminação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                await _historyService.DeleteHistoryAsync(selectedIds);
                await LoadHistoryAsync();
                lblStatus.Text = $"✅ {selectedIds.Count} registos eliminados.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar registos: {ex.Message}", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void BtnClearAll_Click(object sender, EventArgs e)
    {
        if (_historyService == null) return;

        var result = MessageBox.Show(
            "Tem certeza que deseja LIMPAR TODO o histórico?\n\nEsta ação não pode ser desfeita!",
            "Confirmar Limpeza Total",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            var confirm = MessageBox.Show(
                "Tem a certeza ABSOLUTA?\nTodos os registos de histórico serão eliminados permanentemente.",
                "Última Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var count = await _historyService.ClearAllHistoryAsync();
                    await LoadHistoryAsync();
                    lblStatus.Text = $"✅ {count} registos eliminados.";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao limpar histórico: {ex.Message}", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    private async void BtnRefresh_Click(object sender, EventArgs e)
    {
        await LoadHistoryAsync();
    }
}
