namespace Aluka.WinForms;

partial class RulesForm
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView dgvRules;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnToggle;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblStatus;

    // Colunas do DataGridView
    private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colApp;
    private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDays;
    private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
    private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
    private System.Windows.Forms.DataGridViewTextBoxColumn colId;

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
        this.dgvRules = new System.Windows.Forms.DataGridView();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnEdit = new System.Windows.Forms.Button();
        this.btnToggle = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClose = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();

        ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.Location = new System.Drawing.Point(12, 9);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Regras de Agendamento";

        // dgvRules
        this.dgvRules.AllowUserToAddRows = false;
        this.dgvRules.AllowUserToDeleteRows = false;
        this.dgvRules.AllowUserToResizeRows = false;
        this.dgvRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvRules.BackgroundColor = System.Drawing.Color.White;
        this.dgvRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStatus,
            this.colApp,
            this.colAction,
            this.colDays,
            this.colStart,
            this.colEnd,
            this.colId
        });
        this.dgvRules.Location = new System.Drawing.Point(12, 46);
        this.dgvRules.MultiSelect = false;
        this.dgvRules.Name = "dgvRules";
        this.dgvRules.ReadOnly = true;
        this.dgvRules.RowHeadersVisible = false;
        this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvRules.Size = new System.Drawing.Size(760, 320);
        this.dgvRules.TabIndex = 0;

        // colStatus
        this.colStatus.HeaderText = "Status";
        this.colStatus.Name = "colStatus";
        this.colStatus.ReadOnly = true;
        this.colStatus.Width = 60;

        // colApp
        this.colApp.HeaderText = "Aplicacao";
        this.colApp.Name = "colApp";
        this.colApp.ReadOnly = true;
        this.colApp.Width = 150;

        // colAction
        this.colAction.HeaderText = "Action";
        this.colAction.Name = "colAction";
        this.colAction.ReadOnly = true;
        this.colAction.Width = 60;

        // colDays
        this.colDays.HeaderText = "Days";
        this.colDays.Name = "colDays";
        this.colDays.ReadOnly = true;
        this.colDays.Width = 150;

        // colStart
        this.colStart.HeaderText = "Start";
        this.colStart.Name = "colStart";
        this.colStart.ReadOnly = true;
        this.colStart.Width = 80;

        // colEnd
        this.colEnd.HeaderText = "End";
        this.colEnd.Name = "colEnd";
        this.colEnd.ReadOnly = true;
        this.colEnd.Width = 80;

        // colId (oculto)
        this.colId.HeaderText = "Id";
        this.colId.Name = "colId";
        this.colId.ReadOnly = true;
        this.colId.Visible = false;

        // btnAdd
        this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnAdd.Location = new System.Drawing.Point(12, 372);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(130, 35);
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

        // btnEdit
        this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnEdit.Location = new System.Drawing.Point(148, 372);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new System.Drawing.Size(110, 35);
        this.btnEdit.Text = "Edit";
        this.btnEdit.UseVisualStyleBackColor = true;
        this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

        // btnToggle
        this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnToggle.Location = new System.Drawing.Point(244, 372);
        this.btnToggle.Name = "btnToggle";
        this.btnToggle.Size = new System.Drawing.Size(130, 35);
        this.btnToggle.Text = "Toggle";
        this.btnToggle.UseVisualStyleBackColor = true;
        this.btnToggle.Click += new System.EventHandler(this.BtnToggle_Click);

        // btnDelete
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnDelete.Location = new System.Drawing.Point(380, 372);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(110, 35);
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

        // btnClose
        this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.btnClose.Location = new System.Drawing.Point(662, 372);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(110, 35);
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblStatus.Location = new System.Drawing.Point(12, 415);
        this.lblStatus.Text = "Ready to load...";

        // RulesForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(784, 441);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnToggle);
        this.Controls.Add(this.btnEdit);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.dgvRules);
        this.Controls.Add(this.lblTitle);
        this.Name = "RulesForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Aluka - Scheduling Rules";
        this.Load += new System.EventHandler(this.RulesForm_Load);

        ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}