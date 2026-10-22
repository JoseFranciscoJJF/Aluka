namespace Aluka.WinForms.Views;

partial class DashboardView
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
        this.lblWelcome = new System.Windows.Forms.Label();
        this.lblSubtitle = new System.Windows.Forms.Label();
        this.cardStats = new System.Windows.Forms.Panel();
        this.lblStats = new System.Windows.Forms.Label();
        this.lblStatsCaption = new System.Windows.Forms.Label();
        this.btnScanApps = new System.Windows.Forms.Button();
        this.lblScanStatus = new System.Windows.Forms.Label();

        this.cardStats.SuspendLayout();
        this.SuspendLayout();

        // lblWelcome
        this.lblWelcome.AutoSize = true;
        this.lblWelcome.Location = new System.Drawing.Point(0, 0);
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Text = "Bem-vindo ao Aluka";

        // lblSubtitle
        this.lblSubtitle.AutoSize = true;
        this.lblSubtitle.Location = new System.Drawing.Point(0, 32);
        this.lblSubtitle.Name = "lblSubtitle";
        this.lblSubtitle.Text = "Gestão de foco e produtividade";

        // cardStats
        this.cardStats.Controls.Add(this.lblStats);
        this.cardStats.Controls.Add(this.lblStatsCaption);
        this.cardStats.Location = new System.Drawing.Point(0, 80);
        this.cardStats.Name = "cardStats";
        this.cardStats.Size = new System.Drawing.Size(320, 90);

        // lblStatsCaption
        this.lblStatsCaption.AutoSize = true;
        this.lblStatsCaption.Location = new System.Drawing.Point(16, 14);
        this.lblStatsCaption.Name = "lblStatsCaption";
        this.lblStatsCaption.Text = "REGRAS DE AGENDAMENTO";

        // lblStats
        this.lblStats.AutoSize = true;
        this.lblStats.Location = new System.Drawing.Point(16, 36);
        this.lblStats.Name = "lblStats";
        this.lblStats.Text = "0 regras ativas | 0 total";

        // btnScanApps
        this.btnScanApps.Location = new System.Drawing.Point(0, 196);
        this.btnScanApps.Name = "btnScanApps";
        this.btnScanApps.Size = new System.Drawing.Size(190, 42);
        this.btnScanApps.Text = "Atualizar Aplicações";
        this.btnScanApps.UseVisualStyleBackColor = true;
        this.btnScanApps.Click += new System.EventHandler(this.BtnScanApps_Click);

        // lblScanStatus
        this.lblScanStatus.AutoSize = true;
        this.lblScanStatus.Location = new System.Drawing.Point(0, 248);
        this.lblScanStatus.Name = "lblScanStatus";
        this.lblScanStatus.Text = "";

        // DashboardView
        this.Controls.Add(this.lblScanStatus);
        this.Controls.Add(this.btnScanApps);
        this.Controls.Add(this.cardStats);
        this.Controls.Add(this.lblSubtitle);
        this.Controls.Add(this.lblWelcome);
        this.Name = "DashboardView";
        this.Size = new System.Drawing.Size(900, 500);
        this.Load += new System.EventHandler(this.DashboardView_Load);
        this.cardStats.ResumeLayout(false);
        this.cardStats.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblSubtitle;
    private System.Windows.Forms.Panel cardStats;
    private System.Windows.Forms.Label lblStatsCaption;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.Button btnScanApps;
    private System.Windows.Forms.Label lblScanStatus;
}
