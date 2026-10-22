using Aluka.Application.Services;
using Aluka.WinForms.UI;
using Microsoft.Extensions.DependencyInjection;

namespace Aluka.WinForms.Views;

public partial class DashboardView : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppService? _appService;
    private readonly IRuleService? _ruleService;

    public DashboardView(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _appService = serviceProvider.GetService<IAppService>();
        _ruleService = serviceProvider.GetService<IRuleService>();
        InitializeComponent();

        BackColor = Theme.Colors.Background;

        lblWelcome.Font = Theme.Fonts.Heading;
        lblWelcome.ForeColor = Theme.Colors.TextPrimary;

        lblSubtitle.Font = Theme.Fonts.Body;
        lblSubtitle.ForeColor = Theme.Colors.TextSecondary;

        Theme.StyleCard(cardStats);
        lblStatsCaption.Font = Theme.Fonts.Caption;
        lblStatsCaption.ForeColor = Theme.Colors.TextSecondary;
        lblStats.Font = Theme.Fonts.SubHeading;
        lblStats.ForeColor = Theme.Colors.TextPrimary;

        Theme.StylePrimaryButton(btnScanApps);

        lblScanStatus.Font = Theme.Fonts.Caption;
        lblScanStatus.ForeColor = Theme.Colors.TextSecondary;
    }

    public async Task RefreshAsync()
    {
        await LoadStatsAsync();
    }

    private async void DashboardView_Load(object sender, EventArgs e)
    {
        await LoadStatsAsync();
    }

    private async Task LoadStatsAsync()
    {
        try
        {
            if (_ruleService != null)
            {
                var rules = await _ruleService.GetAllRulesAsync();
                var activeRules = rules.Count(r => r.EstaAtivo);
                lblStats.Text = $"{activeRules} regras ativas | {rules.Count()} total";
            }
        }
        catch
        {
            lblStats.Text = "Erro ao carregar estatísticas";
        }
    }

    private async void BtnScanApps_Click(object sender, EventArgs e)
    {
        if (_appService == null)
        {
            MessageBox.Show("Serviço de aplicações não disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        btnScanApps.Enabled = false;
        lblScanStatus.Text = "A varrer aplicações...";

        try
        {
            await _appService.ScanAndUpdateAppsAsync();
            lblScanStatus.Text = "Varrimento concluído com sucesso!";
            await LoadStatsAsync();
        }
        catch (Exception ex)
        {
            lblScanStatus.Text = "Erro no varrimento";
            MessageBox.Show($"Erro ao varrer aplicações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnScanApps.Enabled = true;
        }
    }
}
