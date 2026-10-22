using System.Drawing;
using System.Windows.Forms;

namespace Aluka.WinForms.UI;

public partial class NavSidebar : UserControl
{
    public event EventHandler<string>? NavigationRequested;

    private readonly List<Button> _navButtons;

    public NavSidebar()
    {
        InitializeComponent();
        _navButtons = new List<Button> { btnDashboard, btnRules, btnApps, btnHistory };

        BackColor = Theme.Colors.SidebarBackground;
        pnlHeader.BackColor = Theme.Colors.SidebarBackground;
        pnlFiller.BackColor = Theme.Colors.SidebarBackground;
        lblAppTitle.ForeColor = Theme.Colors.SidebarTextActive;
        lblAppTitle.Font = Theme.Fonts.Heading;

        foreach (var button in _navButtons)
        {
            StyleNavButton(button, active: false);
        }

        SetActive("Dashboard");
    }

    public void SetActive(string key)
    {
        foreach (var button in _navButtons)
        {
            StyleNavButton(button, active: (string?)button.Tag == key);
        }
    }

    private static void StyleNavButton(Button button, bool active)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.TextAlign = ContentAlignment.MiddleLeft;
        button.Font = active ? Theme.Fonts.BodyBold : Theme.Fonts.Body;
        button.ForeColor = active ? Theme.Colors.SidebarTextActive : Theme.Colors.SidebarText;
        button.BackColor = active ? Theme.Colors.SidebarItemActive : Theme.Colors.SidebarBackground;
        button.FlatAppearance.MouseOverBackColor = active ? Theme.Colors.SidebarItemActive : Theme.Colors.SidebarItemHover;
        button.Cursor = Cursors.Hand;
    }

    private void NavButton_Click(object? sender, EventArgs e)
    {
        if (sender is Button button && button.Tag is string key)
        {
            SetActive(key);
            NavigationRequested?.Invoke(this, key);
        }
    }
}
