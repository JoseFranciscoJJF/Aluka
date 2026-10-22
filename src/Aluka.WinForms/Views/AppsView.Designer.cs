namespace Aluka.WinForms.Views;

partial class AppsView
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
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.dgvApps = new System.Windows.Forms.DataGridView();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.btnRefresh = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();

        // Colunas
        this.colIcon = new System.Windows.Forms.DataGridViewImageColumn();
        this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colConfigurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();

        this.pnlHeader.SuspendLayout();
        this.pnlActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).BeginInit();
        this.SuspendLayout();

        // dgvApps (Fill — added first so Top/Bottom panels claim their edges)
        this.dgvApps.AllowUserToAddRows = false;
        this.dgvApps.AllowUserToDeleteRows = false;
        this.dgvApps.AllowUserToResizeRows = false;
        this.dgvApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvApps.BackgroundColor = System.Drawing.Color.White;
        this.dgvApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIcon,
            this.colName,
            this.colPath,
            this.colStatus,
            this.colConfigurable
        });
        this.dgvApps.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvApps.MultiSelect = false;
        this.dgvApps.Name = "dgvApps";
        this.dgvApps.ReadOnly = false;
        this.dgvApps.RowHeadersVisible = false;
        this.dgvApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvApps.TabIndex = 0;

        this.dgvApps.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvApps_CurrentCellDirtyStateChanged);
        this.dgvApps.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvApps_CellValueChanged);

        // colIcon
        this.colIcon.HeaderText = "";
        this.colIcon.Name = "colIcon";
        this.colIcon.ReadOnly = true;
        this.colIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
        this.colIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
        this.colIcon.Width = 40;

        // colName
        this.colName.HeaderText = "Nome";
        this.colName.Name = "colName";
        this.colName.ReadOnly = true;
        this.colName.Width = 180;

        // colPath
        this.colPath.HeaderText = "Caminho";
        this.colPath.Name = "colPath";
        this.colPath.ReadOnly = true;
        this.colPath.Width = 300;

        // colStatus
        this.colStatus.HeaderText = "Estado";
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        this.colStatus.Width = 60;

        // colConfigurable
        this.colConfigurable.HeaderText = "Configurável";
        this.colConfigurable.Name = "colConfigurable";
        this.colConfigurable.ReadOnly = false;
        this.colConfigurable.Width = 80;

        // pnlHeader
        this.pnlHeader.Controls.Add(this.txtSearch);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(784, 72);

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Location = new System.Drawing.Point(0, 8);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "📱 Aplicações";

        // txtSearch
        this.txtSearch.Location = new System.Drawing.Point(0, 38);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(280, 25);
        this.txtSearch.Text = "Pesquisar aplicação...";
        this.txtSearch.ForeColor = System.Drawing.Color.Gray;
        this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
        this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
        this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);

        // pnlActions
        this.pnlActions.Controls.Add(this.lblStatus);
        this.pnlActions.Controls.Add(this.btnRefresh);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(784, 68);

        // btnRefresh
        this.btnRefresh.Location = new System.Drawing.Point(0, 8);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(160, 36);
        this.btnRefresh.Text = "🔄 Atualizar Lista";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(0, 50);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Pronto para carregar...";

        // AppsView
        this.Controls.Add(this.dgvApps);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.pnlHeader);
        this.Name = "AppsView";
        this.Size = new System.Drawing.Size(784, 476);
        this.Load += new System.EventHandler(this.AppsView_Load);

        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.pnlActions.ResumeLayout(false);
        this.pnlActions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvApps)).EndInit();
        this.ResumeLayout(false);
    }

    // Declarações
    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.DataGridView dgvApps;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.DataGridViewImageColumn colIcon;
    private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colConfigurable;
}
