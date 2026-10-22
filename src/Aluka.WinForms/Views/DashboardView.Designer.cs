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
        this.lblStats = new System.Windows.Forms.Label();
        this.btnScanApps = new System.Windows.Forms.Button();
        this.lblScanStatus = new System.Windows.Forms.Label();

        this.SuspendLayout();

        // lblWelcome
        this.lblWelcome.AutoSize = true;
        this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblWelcome.Location = new System.Drawing.Point(20, 20);
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Text = "Bem-vindo ao Aluka!";

        // lblStats
        this.lblStats.AutoSize = true;
        this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblStats.Location = new System.Drawing.Point(22, 52);
        this.lblStats.Name = "lblStats";
        this.lblStats.Text = "0 regras ativas | 0 apps";

        // btnScanApps
        this.btnScanApps.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnScanApps.Location = new System.Drawing.Point(20, 100);
        this.btnScanApps.Name = "btnScanApps";
        this.btnScanApps.Size = new System.Drawing.Size(170, 40);
        this.btnScanApps.Text = "Atualizar Apps";
        this.btnScanApps.UseVisualStyleBackColor = true;
        this.btnScanApps.Click += new System.EventHandler(this.BtnScanApps_Click);

        // lblScanStatus
        this.lblScanStatus.AutoSize = true;
        this.lblScanStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblScanStatus.Location = new System.Drawing.Point(22, 152);
        this.lblScanStatus.Name = "lblScanStatus";
        this.lblScanStatus.Text = "";

        // DashboardView
        this.Controls.Add(this.lblScanStatus);
        this.Controls.Add(this.btnScanApps);
        this.Controls.Add(this.lblStats);
        this.Controls.Add(this.lblWelcome);
        this.Name = "DashboardView";
        this.Size = new System.Drawing.Size(900, 500);
        this.Load += new System.EventHandler(this.DashboardView_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.Button btnScanApps;
    private System.Windows.Forms.Label lblScanStatus;
}
