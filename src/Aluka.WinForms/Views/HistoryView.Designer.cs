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
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblStats = new System.Windows.Forms.Label();
        this.dgvHistory = new System.Windows.Forms.DataGridView();
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

        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
        this.grpFilters.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(12, 9);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(149, 25);
        this.lblTitle.Text = "📊 Histórico";

        // lblStats
        this.lblStats.AutoSize = true;
        this.lblStats.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblStats.Location = new System.Drawing.Point(12, 40);
        this.lblStats.Name = "lblStats";
        this.lblStats.Size = new System.Drawing.Size(164, 19);
        this.lblStats.Text = "Total: 0 | ✅ 0 | ❌ 0 | ⏭️ 0";

        // grpFilters
        this.grpFilters.Controls.Add(this.lblStatusFilter);
        this.grpFilters.Controls.Add(this.cmbStatusFilter);
        this.grpFilters.Controls.Add(this.lblRuleFilter);
        this.grpFilters.Controls.Add(this.cmbRuleFilter);
        this.grpFilters.Controls.Add(this.lblDateRange);
        this.grpFilters.Controls.Add(this.dtpStartDate);
        this.grpFilters.Controls.Add(this.dtpEndDate);
        this.grpFilters.Controls.Add(this.lblTo);
        this.grpFilters.Location = new System.Drawing.Point(12, 70);
        this.grpFilters.Name = "grpFilters";
        this.grpFilters.Size = new System.Drawing.Size(760, 80);
        this.grpFilters.Text = "🔍 Filtros";

        // lblStatusFilter
        this.lblStatusFilter.AutoSize = true;
        this.lblStatusFilter.Location = new System.Drawing.Point(6, 22);
        this.lblStatusFilter.Name = "lblStatusFilter";
        this.lblStatusFilter.Size = new System.Drawing.Size(42, 15);
        this.lblStatusFilter.Text = "Status:";

        // cmbStatusFilter
        this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatusFilter.Location = new System.Drawing.Point(54, 19);
        this.cmbStatusFilter.Name = "cmbStatusFilter";
        this.cmbStatusFilter.Size = new System.Drawing.Size(120, 23);
        this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.CmbStatusFilter_SelectedIndexChanged);

        // lblRuleFilter
        this.lblRuleFilter.AutoSize = true;
        this.lblRuleFilter.Location = new System.Drawing.Point(190, 22);
        this.lblRuleFilter.Name = "lblRuleFilter";
        this.lblRuleFilter.Size = new System.Drawing.Size(44, 15);
        this.lblRuleFilter.Text = "Regra:";

        // cmbRuleFilter
        this.cmbRuleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbRuleFilter.Location = new System.Drawing.Point(240, 19);
        this.cmbRuleFilter.Name = "cmbRuleFilter";
        this.cmbRuleFilter.Size = new System.Drawing.Size(200, 23);
        this.cmbRuleFilter.SelectedIndexChanged += new System.EventHandler(this.CmbRuleFilter_SelectedIndexChanged);

        // lblDateRange
        this.lblDateRange.AutoSize = true;
        this.lblDateRange.Location = new System.Drawing.Point(460, 22);
        this.lblDateRange.Name = "lblDateRange";
        this.lblDateRange.Size = new System.Drawing.Size(73, 15);
        this.lblDateRange.Text = "Período:";

        // dtpStartDate
        this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpStartDate.Location = new System.Drawing.Point(539, 19);
        this.dtpStartDate.Name = "dtpStartDate";
        this.dtpStartDate.ShowCheckBox = true;
        this.dtpStartDate.Size = new System.Drawing.Size(100, 23);
        this.dtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);

        // lblTo
        this.lblTo.AutoSize = true;
        this.lblTo.Location = new System.Drawing.Point(645, 23);
        this.lblTo.Name = "lblTo";
        this.lblTo.Size = new System.Drawing.Size(19, 15);
        this.lblTo.Text = "a";

        // dtpEndDate
        this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpEndDate.Location = new System.Drawing.Point(670, 19);
        this.dtpEndDate.Name = "dtpEndDate";
        this.dtpEndDate.ShowCheckBox = true;
        this.dtpEndDate.Size = new System.Drawing.Size(100, 23);
        this.dtpEndDate.ValueChanged += new System.EventHandler(this.DtpEndDate_ValueChanged);

        // dgvHistory
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
        this.dgvHistory.Location = new System.Drawing.Point(12, 160);
        this.dgvHistory.Name = "dgvHistory";
        this.dgvHistory.RowHeadersVisible = false;
        this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHistory.Size = new System.Drawing.Size(760, 280);
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

        // btnRefresh
        this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnRefresh.Location = new System.Drawing.Point(12, 450);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(120, 35);
        this.btnRefresh.Text = "🔄 Atualizar";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

        // btnDeleteSelected
        this.btnDeleteSelected.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnDeleteSelected.Location = new System.Drawing.Point(140, 450);
        this.btnDeleteSelected.Name = "btnDeleteSelected";
        this.btnDeleteSelected.Size = new System.Drawing.Size(140, 35);
        this.btnDeleteSelected.Text = "🗑️ Eliminar Selecionados";
        this.btnDeleteSelected.UseVisualStyleBackColor = true;
        this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelected_Click);

        // btnClearAll
        this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnClearAll.Location = new System.Drawing.Point(290, 450);
        this.btnClearAll.Name = "btnClearAll";
        this.btnClearAll.Size = new System.Drawing.Size(140, 35);
        this.btnClearAll.Text = "🧹 Limpar Todo";
        this.btnClearAll.UseVisualStyleBackColor = true;
        this.btnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStatus.Location = new System.Drawing.Point(12, 495);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(124, 15);
        this.lblStatus.Text = "Pronto para carregar...";

        // HistoryView
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnClearAll);
        this.Controls.Add(this.btnDeleteSelected);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.dgvHistory);
        this.Controls.Add(this.grpFilters);
        this.Controls.Add(this.lblStats);
        this.Controls.Add(this.lblTitle);
        this.Name = "HistoryView";
        this.Size = new System.Drawing.Size(784, 520);
        this.Load += new System.EventHandler(this.HistoryView_Load);

        ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
        this.grpFilters.ResumeLayout(false);
        this.grpFilters.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblStats;
    private System.Windows.Forms.DataGridView dgvHistory;
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
