namespace Aluka.WinForms.Views;

partial class HistoryView
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
        this.lblStats = new System.Windows.Forms.Label();
        this.dgvHistory = new System.Windows.Forms.DataGridView();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.btnRefresh = new System.Windows.Forms.Button();
        this.btnDeleteSelected = new System.Windows.Forms.Button();
        this.btnClearAll = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.grpFilters = new System.Windows.Forms.GroupBox();
        this.lblStatusFilter = new System.Windows.Forms.Label();
        this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
        this.lblRuleFilter = new System.Windows.Forms.Label();
        this.cmbRuleFilter = new System.Windows.Forms.ComboBox();
        this.lblDateRange = new System.Windows.Forms.Label();
        this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
        this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
        this.lblTo = new System.Windows.Forms.Label();

        // Colunas do DataGridView
        this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colRule = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colError = new System.Windows.Forms.DataGridViewTextBoxColumn();

        this.pnlHeader.SuspendLayout();
        this.pnlActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
        this.grpFilters.SuspendLayout();
        this.SuspendLayout();

        // dgvHistory (Fill — added first)
        this.dgvHistory.AllowUserToAddRows = false;
        this.dgvHistory.AllowUserToDeleteRows = false;
        this.dgvHistory.AllowUserToResizeRows = false;
        this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
        this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colId,
            this.colDate,
            this.colRule,
            this.colApp,
            this.colAction,
            this.colStatus,
            this.colDuration,
            this.colError
        });
        this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvHistory.Name = "dgvHistory";
        this.dgvHistory.RowHeadersVisible = false;
        this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHistory.TabIndex = 0;

        // colSelect
        this.colSelect.HeaderText = "";
        this.colSelect.Name = "colSelect";
        this.colSelect.Width = 30;

        // colId
        this.colId.HeaderText = "ID";
        this.colId.Name = "colId";
        this.colId.ReadOnly = true;
        this.colId.Width = 40;

        // colDate
        this.colDate.HeaderText = "Data/Hora";
        this.colDate.Name = "colDate";
        this.colDate.ReadOnly = true;
        this.colDate.Width = 140;

        // colRule
        this.colRule.HeaderText = "Regra";
        this.colRule.Name = "colRule";
        this.colRule.ReadOnly = true;
        this.colRule.Width = 100;

        // colApp
        this.colApp.HeaderText = "Aplicação";
        this.colApp.Name = "colApp";
        this.colApp.ReadOnly = true;
        this.colApp.Width = 120;

        // colAction
        this.colAction.HeaderText = "Ação";
        this.colAction.Name = "colAction";
        this.colAction.ReadOnly = true;
        this.colAction.Width = 60;

        // colStatus
        this.colStatus.HeaderText = "Status";
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        this.colStatus.Width = 80;

        // colDuration
        this.colDuration.HeaderText = "Duração";
        this.colDuration.Name = "colDuration";
        this.colDuration.ReadOnly = true;
        this.colDuration.Width = 70;

        // colError
        this.colError.HeaderText = "Erro";
        this.colError.Name = "colError";
        this.colError.ReadOnly = true;
        this.colError.Width = 120;

        // pnlActions (Bottom)
        this.pnlActions.Controls.Add(this.lblStatus);
        this.pnlActions.Controls.Add(this.btnClearAll);
        this.pnlActions.Controls.Add(this.btnDeleteSelected);
        this.pnlActions.Controls.Add(this.btnRefresh);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(784, 68);

        // btnRefresh
        this.btnRefresh.Location = new System.Drawing.Point(0, 8);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(120, 36);
        this.btnRefresh.Text = "🔄 Atualizar";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

        // btnDeleteSelected
        this.btnDeleteSelected.Location = new System.Drawing.Point(132, 8);
        this.btnDeleteSelected.Name = "btnDeleteSelected";
        this.btnDeleteSelected.Size = new System.Drawing.Size(170, 36);
        this.btnDeleteSelected.Text = "🗑️ Eliminar Selecionados";
        this.btnDeleteSelected.UseVisualStyleBackColor = true;
        this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);

        // btnClearAll
        this.btnClearAll.Location = new System.Drawing.Point(314, 8);
        this.btnClearAll.Name = "btnClearAll";
        this.btnClearAll.Size = new System.Drawing.Size(140, 36);
        this.btnClearAll.Text = "🧹 Limpar Todo";
        this.btnClearAll.UseVisualStyleBackColor = true;
        this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(0, 50);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Pronto para carregar...";

        // grpFilters (Top)
        this.grpFilters.Controls.Add(this.lblStatusFilter);
        this.grpFilters.Controls.Add(this.cmbStatusFilter);
        this.grpFilters.Controls.Add(this.lblRuleFilter);
        this.grpFilters.Controls.Add(this.cmbRuleFilter);
        this.grpFilters.Controls.Add(this.lblDateRange);
        this.grpFilters.Controls.Add(this.dtpStartDate);
        this.grpFilters.Controls.Add(this.dtpEndDate);
        this.grpFilters.Controls.Add(this.lblTo);
        this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
        this.grpFilters.Name = "grpFilters";
        this.grpFilters.Size = new System.Drawing.Size(784, 80);
        this.grpFilters.Text = "🔍 Filtros";

        // lblStatusFilter
        this.lblStatusFilter.AutoSize = true;
        this.lblStatusFilter.Location = new System.Drawing.Point(16, 30);
        this.lblStatusFilter.Name = "lblStatusFilter";
        this.lblStatusFilter.Text = "Status:";

        // cmbStatusFilter
        this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatusFilter.Location = new System.Drawing.Point(64, 27);
        this.cmbStatusFilter.Name = "cmbStatusFilter";
        this.cmbStatusFilter.Size = new System.Drawing.Size(120, 23);
        this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.CmbStatusFilter_SelectedIndexChanged);

        // lblRuleFilter
        this.lblRuleFilter.AutoSize = true;
        this.lblRuleFilter.Location = new System.Drawing.Point(200, 30);
        this.lblRuleFilter.Name = "lblRuleFilter";
        this.lblRuleFilter.Text = "Regra:";

        // cmbRuleFilter
        this.cmbRuleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbRuleFilter.Location = new System.Drawing.Point(250, 27);
        this.cmbRuleFilter.Name = "cmbRuleFilter";
        this.cmbRuleFilter.Size = new System.Drawing.Size(200, 23);
        this.cmbRuleFilter.SelectedIndexChanged += new System.EventHandler(this.CmbRuleFilter_SelectedIndexChanged);

        // lblDateRange
        this.lblDateRange.AutoSize = true;
        this.lblDateRange.Location = new System.Drawing.Point(470, 30);
        this.lblDateRange.Name = "lblDateRange";
        this.lblDateRange.Text = "Período:";

        // dtpStartDate
        this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpStartDate.Location = new System.Drawing.Point(549, 27);
        this.dtpStartDate.Name = "dtpStartDate";
        this.dtpStartDate.ShowCheckBox = true;
        this.dtpStartDate.Size = new System.Drawing.Size(100, 23);
        this.dtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);

        // lblTo
        this.lblTo.AutoSize = true;
        this.lblTo.Location = new System.Drawing.Point(655, 31);
        this.lblTo.Name = "lblTo";
        this.lblTo.Text = "a";

        // dtpEndDate
        this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpEndDate.Location = new System.Drawing.Point(680, 27);
        this.dtpEndDate.Name = "dtpEndDate";
        this.dtpEndDate.ShowCheckBox = true;
        this.dtpEndDate.Size = new System.Drawing.Size(100, 23);
        this.dtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);

        // pnlHeader (Top, added last among Top siblings so it stays above grpFilters)
        this.pnlHeader.Controls.Add(this.lblStats);
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(784, 64);

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Location = new System.Drawing.Point(0, 8);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "📊 Histórico";

        // lblStats
        this.lblStats.AutoSize = true;
        this.lblStats.Location = new System.Drawing.Point(0, 38);
        this.lblStats.Name = "lblStats";
        this.lblStats.Text = "Total: 0 | ✅ 0 | ❌ 0 | ⏭️ 0";

        // HistoryView
        this.Controls.Add(this.dgvHistory);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.grpFilters);
        this.Controls.Add(this.pnlHeader);
        this.Name = "HistoryView";
        this.Size = new System.Drawing.Size(784, 520);
        this.Load += new System.EventHandler(this.HistoryView_Load);

        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.pnlActions.ResumeLayout(false);
        this.pnlActions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
        this.grpFilters.ResumeLayout(false);
        this.grpFilters.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.DataGridView dgvHistory;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Button btnDeleteSelected;
    private System.Windows.Forms.Button btnClearAll;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.GroupBox grpFilters;
    private System.Windows.Forms.Label lblStatusFilter;
    private System.Windows.Forms.ComboBox cmbStatusFilter;
    private System.Windows.Forms.Label lblRuleFilter;
    private System.Windows.Forms.ComboBox cmbRuleFilter;
    private System.Windows.Forms.Label lblDateRange;
    private System.Windows.Forms.DateTimePicker dtpStartDate;
    private System.Windows.Forms.DateTimePicker dtpEndDate;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRule;
    private System.Windows.Forms.DataGridViewTextBoxColumn colApp;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
    private System.Windows.Forms.DataGridViewTextBoxColumn colError;
}
