using System.Drawing;
using System.Windows.Forms;

namespace Aluka.WinForms.UI;

internal static class Theme
{
    public static class Colors
    {
        public static readonly Color Background = Color.FromArgb(0xF3, 0xF4, 0xF6);
        public static readonly Color Surface = Color.White;
        public static readonly Color SidebarBackground = Color.FromArgb(0x1E, 0x29, 0x3B);
        public static readonly Color SidebarItemHover = Color.FromArgb(0x2B, 0x38, 0x4E);
        public static readonly Color SidebarItemActive = Color.FromArgb(0x3B, 0x82, 0xF6);
        public static readonly Color SidebarText = Color.FromArgb(0xC9, 0xD2, 0xE0);
        public static readonly Color SidebarTextActive = Color.White;

        public static readonly Color PrimaryAccent = Color.FromArgb(0x3B, 0x82, 0xF6);
        public static readonly Color PrimaryAccentHover = Color.FromArgb(0x2F, 0x6F, 0xDB);

        public static readonly Color TextPrimary = Color.FromArgb(0x11, 0x18, 0x27);
        public static readonly Color TextSecondary = Color.FromArgb(0x6B, 0x72, 0x80);

        public static readonly Color Border = Color.FromArgb(0xE2, 0xE5, 0xEA);

        public static readonly Color Success = Color.FromArgb(0x16, 0xA3, 0x4A);
        public static readonly Color Warning = Color.FromArgb(0xD9, 0x7A, 0x06);
        public static readonly Color Danger = Color.FromArgb(0xDC, 0x26, 0x26);
    }

    public static class Fonts
    {
        public static readonly Font Heading = new("Segoe UI Semibold", 16F, FontStyle.Bold);
        public static readonly Font SubHeading = new("Segoe UI Semibold", 12F, FontStyle.Bold);
        public static readonly Font Body = new("Segoe UI", 10F);
        public static readonly Font BodyBold = new("Segoe UI Semibold", 10F, FontStyle.Bold);
        public static readonly Font Caption = new("Segoe UI", 9F);
        public static readonly Font Icon = new("Segoe Fluent Icons", 11F);
    }

    public static class Spacing
    {
        public const int XS = 4;
        public const int S = 8;
        public const int M = 16;
        public const int L = 24;
        public const int XL = 32;
        public const int XXL = 48;
    }

    public static void StylePrimaryButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.BackColor = Colors.PrimaryAccent;
        button.ForeColor = Color.White;
        button.Font = Fonts.BodyBold;
        button.Cursor = Cursors.Hand;
        button.FlatAppearance.MouseOverBackColor = Colors.PrimaryAccentHover;
    }

    public static void StyleSecondaryButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderColor = Colors.Border;
        button.FlatAppearance.BorderSize = 1;
        button.BackColor = Colors.Surface;
        button.ForeColor = Colors.TextPrimary;
        button.Font = Fonts.Body;
        button.Cursor = Cursors.Hand;
        button.FlatAppearance.MouseOverBackColor = Colors.Background;
    }

    public static void StyleCard(Panel panel)
    {
        panel.BackColor = Colors.Surface;
        panel.Padding = new Padding(Spacing.M);
    }

    public static void StyleGrid(DataGridView grid)
    {
        grid.BorderStyle = BorderStyle.None;
        grid.BackgroundColor = Colors.Surface;
        grid.GridColor = Colors.Border;
        grid.EnableHeadersVisualStyles = false;
        grid.ColumnHeadersDefaultCellStyle.BackColor = Colors.Background;
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Colors.TextSecondary;
        grid.ColumnHeadersDefaultCellStyle.Font = Fonts.BodyBold;
        grid.ColumnHeadersHeight = 36;
        grid.DefaultCellStyle.BackColor = Colors.Surface;
        grid.DefaultCellStyle.ForeColor = Colors.TextPrimary;
        grid.DefaultCellStyle.Font = Fonts.Body;
        grid.DefaultCellStyle.SelectionBackColor = Colors.PrimaryAccent;
        grid.DefaultCellStyle.SelectionForeColor = Color.White;
        grid.RowTemplate.Height = 32;
        grid.AlternatingRowsDefaultCellStyle.BackColor = Colors.Background;
    }
}
