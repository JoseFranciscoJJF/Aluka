namespace Aluka.WinForms.UI;

partial class NavSidebar
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblAppTitle = new System.Windows.Forms.Label();
        this.btnDashboard = new System.Windows.Forms.Button();
        this.btnRules = new System.Windows.Forms.Button();
        this.btnApps = new System.Windows.Forms.Button();
        this.btnHistory = new System.Windows.Forms.Button();
        this.pnlFiller = new System.Windows.Forms.Panel();

        this.tableLayout.SuspendLayout();
        this.pnlHeader.SuspendLayout();
        this.SuspendLayout();

        // tableLayout
        this.tableLayout.ColumnCount = 1;
        this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayout.RowCount = 6;
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
        this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayout.Controls.Add(this.pnlHeader, 0, 0);
        this.tableLayout.Controls.Add(this.btnDashboard, 0, 1);
        this.tableLayout.Controls.Add(this.btnRules, 0, 2);
        this.tableLayout.Controls.Add(this.btnApps, 0, 3);
        this.tableLayout.Controls.Add(this.btnHistory, 0, 4);
        this.tableLayout.Controls.Add(this.pnlFiller, 0, 5);
        this.tableLayout.Name = "tableLayout";

        // pnlHeader
        this.pnlHeader.Controls.Add(this.lblAppTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlHeader.Name = "pnlHeader";

        // lblAppTitle
        this.lblAppTitle.AutoSize = true;
        this.lblAppTitle.Location = new System.Drawing.Point(20, 24);
        this.lblAppTitle.Name = "lblAppTitle";
        this.lblAppTitle.Text = "Aluka";

        // btnDashboard
        this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnDashboard.Name = "btnDashboard";
        this.btnDashboard.Tag = "Dashboard";
        this.btnDashboard.Text = "   Início";
        this.btnDashboard.Click += new System.EventHandler(this.NavButton_Click);

        // btnRules
        this.btnRules.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnRules.Name = "btnRules";
        this.btnRules.Tag = "Rules";
        this.btnRules.Text = "   Regras";
        this.btnRules.Click += new System.EventHandler(this.NavButton_Click);

        // btnApps
        this.btnApps.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnApps.Name = "btnApps";
        this.btnApps.Tag = "Apps";
        this.btnApps.Text = "   Aplicações";
        this.btnApps.Click += new System.EventHandler(this.NavButton_Click);

        // btnHistory
        this.btnHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        this.btnHistory.Name = "btnHistory";
        this.btnHistory.Tag = "History";
        this.btnHistory.Text = "   Histórico";
        this.btnHistory.Click += new System.EventHandler(this.NavButton_Click);

        // pnlFiller
        this.pnlFiller.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlFiller.Name = "pnlFiller";

        // NavSidebar
        this.Controls.Add(this.tableLayout);
        this.Name = "NavSidebar";
        this.Size = new System.Drawing.Size(220, 800);

        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.tableLayout.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TableLayoutPanel tableLayout;
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblAppTitle;
    private System.Windows.Forms.Button btnDashboard;
    private System.Windows.Forms.Button btnRules;
    private System.Windows.Forms.Button btnApps;
    private System.Windows.Forms.Button btnHistory;
    private System.Windows.Forms.Panel pnlFiller;
}
