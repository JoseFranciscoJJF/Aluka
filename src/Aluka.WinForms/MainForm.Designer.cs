namespace Aluka.WinForms;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        // ============================================================
        // CONTROLES
        // ============================================================

// Label de boas-vindas
        this.lblWelcome = new System.Windows.Forms.Label();
        
        // Label de estatísticas
        this.lblStats = new System.Windows.Forms.Label();
        
        // Botão para abrir regras
        this.btnRules = new System.Windows.Forms.Button();
        
        // Botão para abrir aplicações
        this.btnApps = new System.Windows.Forms.Button();
        
        // Botão para abrir histórico
        this.btnHistory = new System.Windows.Forms.Button();
        
        // Botão para atualizar apps
        this.btnScanApps = new System.Windows.Forms.Button();
        
        // Status strip
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();

        // ============================================================
        // lblWelcome
        // ============================================================
        this.lblWelcome.AutoSize = true;
        this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblWelcome.Location = new System.Drawing.Point(20, 20);
        this.lblWelcome.Name = "lblWelcome";
        this.lblWelcome.Size = new System.Drawing.Size(180, 25);
        this.lblWelcome.TabIndex = 0;
        this.lblWelcome.Text = "Bem-vindo ao Aluka!";

        // ============================================================
        // lblStats
        // ============================================================
        this.lblStats.AutoSize = true;
        this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblStats.Location = new System.Drawing.Point(22, 52);
        this.lblStats.Name = "lblStats";
        this.lblStats.Size = new System.Drawing.Size(150, 19);
        this.lblStats.TabIndex = 1;
        this.lblStats.Text = "0 regras ativas | 0 apps";

        // ============================================================
        // btnRules
        // ============================================================
        this.btnRules.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnRules.Location = new System.Drawing.Point(20, 100);
        this.btnRules.Name = "btnRules";
        this.btnRules.Size = new System.Drawing.Size(150, 40);
        this.btnRules.TabIndex = 2;
        this.btnRules.Text = "Gerir Regras";
        this.btnRules.UseVisualStyleBackColor = true;
        this.btnRules.Click += new System.EventHandler(this.BtnRules_Click);

        // ============================================================
        // btnApps
        // ============================================================
        this.btnApps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnApps.Location = new System.Drawing.Point(20, 150);
        this.btnApps.Name = "btnApps";
        this.btnApps.Size = new System.Drawing.Size(150, 40);
        this.btnApps.TabIndex = 3;
        this.btnApps.Text = "Aplicações";
        this.btnApps.UseVisualStyleBackColor = true;
        this.btnApps.Click += new System.EventHandler(this.BtnApps_Click);

        // ============================================================
        // btnHistory
        // ============================================================
        this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnHistory.Location = new System.Drawing.Point(20, 200);
        this.btnHistory.Name = "btnHistory";
        this.btnHistory.Size = new System.Drawing.Size(150, 40);
        this.btnHistory.TabIndex = 4;
        this.btnHistory.Text = "Histórico";
        this.btnHistory.UseVisualStyleBackColor = true;
        this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);

        // ============================================================
        // btnScanApps
        // ============================================================
        this.btnScanApps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.btnScanApps.Location = new System.Drawing.Point(20, 250);
        this.btnScanApps.Name = "btnScanApps";
        this.btnScanApps.Size = new System.Drawing.Size(150, 40);
        this.btnScanApps.TabIndex = 5;
        this.btnScanApps.Text = "Atualizar Apps";
        this.btnScanApps.UseVisualStyleBackColor = true;
        this.btnScanApps.Click += new System.EventHandler(this.BtnScanApps_Click);

        // ============================================================
        // statusStrip
        // ============================================================
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
        this.statusStrip.Location = new System.Drawing.Point(0, 336);
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.Size = new System.Drawing.Size(800, 22);
        this.statusStrip.TabIndex = 6;
        this.statusStrip.Text = "statusStrip";

        // ============================================================
        // toolStripStatusLabel
        // ============================================================
        this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        this.toolStripStatusLabel.Size = new System.Drawing.Size(120, 17);
        this.toolStripStatusLabel.Text = "Pronto para trabalhar!";

        // ============================================================
        // MainForm
        // ============================================================
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 352);
        this.Controls.Add(this.statusStrip);
        this.Controls.Add(this.btnScanApps);
        this.Controls.Add(this.btnHistory);
        this.Controls.Add(this.btnApps);
        this.Controls.Add(this.btnRules);
        this.Controls.Add(this.lblStats);
        this.Controls.Add(this.lblWelcome);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Aluka - Gestão de Foco e Produtividade";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.statusStrip.ResumeLayout(false);
        this.statusStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    // ============================================================
    // DECLARAÇÃO DOS CONTROLES
    // ============================================================
    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.Button btnRules;
    private System.Windows.Forms.Button btnApps;
    private System.Windows.Forms.Button btnHistory;
    private System.Windows.Forms.Button btnScanApps;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
}