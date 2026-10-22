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
        this.navSidebar = new Aluka.WinForms.UI.NavSidebar();
        this.pnlContent = new System.Windows.Forms.Panel();
        this.statusStrip = new System.Windows.Forms.StatusStrip();
        this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();

        this.SuspendLayout();

        // ============================================================
        // navSidebar
        // ============================================================
        this.navSidebar.Dock = System.Windows.Forms.DockStyle.Left;
        this.navSidebar.Name = "navSidebar";
        this.navSidebar.Size = new System.Drawing.Size(220, 761);
        this.navSidebar.TabIndex = 0;

        // ============================================================
        // pnlContent
        // ============================================================
        this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pnlContent.Name = "pnlContent";
        this.pnlContent.TabIndex = 1;

        // ============================================================
        // statusStrip
        // ============================================================
        this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
        this.statusStrip.Name = "statusStrip";
        this.statusStrip.TabIndex = 2;
        this.statusStrip.Text = "statusStrip";

        // ============================================================
        // toolStripStatusLabel
        // ============================================================
        this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        this.toolStripStatusLabel.Text = "Aluka pronto.";

        // ============================================================
        // MainForm
        // ============================================================
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1280, 800);
        this.MinimumSize = new System.Drawing.Size(1024, 650);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        this.MaximizeBox = true;
        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.navSidebar);
        this.Controls.Add(this.statusStrip);
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
    private Aluka.WinForms.UI.NavSidebar navSidebar;
    private System.Windows.Forms.Panel pnlContent;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
}
