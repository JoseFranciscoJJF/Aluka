using Aluka.WinForms.UI;
using Aluka.WinForms.Views;

namespace Aluka.WinForms;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly Dictionary<string, UserControl> _views = new();

    public MainForm(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        InitializeComponent();

        BackColor = Theme.Colors.Background;
        pnlContent.BackColor = Theme.Colors.Background;
        pnlContent.Padding = new Padding(Theme.Spacing.L);
        statusStrip.BackColor = Theme.Colors.Surface;
        statusStrip.SizingGrip = false;
        toolStripStatusLabel.ForeColor = Theme.Colors.TextSecondary;

        navSidebar.NavigationRequested += NavSidebar_NavigationRequested;

        var dashboard = new DashboardView(_serviceProvider);
        _views["Dashboard"] = dashboard;
        pnlContent.Controls.Add(dashboard);
        dashboard.Dock = DockStyle.Fill;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
    }

    private async void NavSidebar_NavigationRequested(object? sender, string key)
    {
        if (!_views.TryGetValue(key, out var view))
        {
            view = key switch
            {
                "Dashboard" => new DashboardView(_serviceProvider),
                "Rules" => new RulesView(_serviceProvider),
                "Apps" => new AppsView(_serviceProvider),
                "History" => new HistoryView(_serviceProvider),
                _ => throw new ArgumentOutOfRangeException(nameof(key), key, "Unknown navigation key")
            };
            view.Dock = DockStyle.Fill;
            _views[key] = view;
        }

        pnlContent.Controls.Clear();
        pnlContent.Controls.Add(view);

        await (view switch
        {
            DashboardView dashboard => dashboard.RefreshAsync(),
            RulesView rules => rules.RefreshAsync(),
            AppsView apps => apps.RefreshAsync(),
            HistoryView history => history.RefreshAsync(),
            _ => Task.CompletedTask
        });
    }
}
