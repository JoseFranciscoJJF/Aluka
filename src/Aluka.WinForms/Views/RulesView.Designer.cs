namespace Aluka.WinForms.Views;

partial class RulesView
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Panel pnlHeader;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.DataGridView dgvRules;
    private System.Windows.Forms.Panel pnlActions;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnToggle;
    private System.Windows.Forms.Button btnDelete;
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
        this.pnlHeader = new System.Windows.Forms.Panel();
        this.lblTitle = new System.Windows.Forms.Label();
        this.dgvRules = new System.Windows.Forms.DataGridView();
        this.pnlActions = new System.Windows.Forms.Panel();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnEdit = new System.Windows.Forms.Button();
        this.btnToggle = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();

        this.pnlHeader.SuspendLayout();
        this.pnlActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).BeginInit();
        this.SuspendLayout();

        // dgvRules (Fill — added first so Top/Bottom docked panels claim their edges around it)
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
        this.dgvRules.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvRules.MultiSelect = false;
        this.dgvRules.Name = "dgvRules";
        this.dgvRules.ReadOnly = true;
        this.dgvRules.RowHeadersVisible = false;
        this.dgvRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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

        // pnlHeader
        this.pnlHeader.Controls.Add(this.lblTitle);
        this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
        this.pnlHeader.Name = "pnlHeader";
        this.pnlHeader.Size = new System.Drawing.Size(784, 48);

        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Location = new System.Drawing.Point(0, 8);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Text = "Regras de Agendamento";

        // pnlActions
        this.pnlActions.Controls.Add(this.lblStatus);
        this.pnlActions.Controls.Add(this.btnDelete);
        this.pnlActions.Controls.Add(this.btnToggle);
        this.pnlActions.Controls.Add(this.btnEdit);
        this.pnlActions.Controls.Add(this.btnAdd);
        this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.pnlActions.Name = "pnlActions";
        this.pnlActions.Size = new System.Drawing.Size(784, 68);

        // btnAdd
        this.btnAdd.Location = new System.Drawing.Point(0, 8);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(120, 36);
        this.btnAdd.Text = "Adicionar";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

        // btnEdit
        this.btnEdit.Location = new System.Drawing.Point(132, 8);
        this.btnEdit.Name = "btnEdit";
        this.btnEdit.Size = new System.Drawing.Size(110, 36);
        this.btnEdit.Text = "Editar";
        this.btnEdit.UseVisualStyleBackColor = true;
        this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);

        // btnToggle
        this.btnToggle.Location = new System.Drawing.Point(254, 8);
        this.btnToggle.Name = "btnToggle";
        this.btnToggle.Size = new System.Drawing.Size(130, 36);
        this.btnToggle.Text = "Ativar/Desativar";
        this.btnToggle.UseVisualStyleBackColor = true;
        this.btnToggle.Click += new System.EventHandler(this.BtnToggle_Click);

        // btnDelete
        this.btnDelete.Location = new System.Drawing.Point(396, 8);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(110, 36);
        this.btnDelete.Text = "Eliminar";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Location = new System.Drawing.Point(0, 50);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Pronto para carregar...";

        // RulesView
        this.Controls.Add(this.dgvRules);
        this.Controls.Add(this.pnlActions);
        this.Controls.Add(this.pnlHeader);
        this.Name = "RulesView";
        this.Size = new System.Drawing.Size(784, 441);
        this.Load += new System.EventHandler(this.RulesView_Load);

        this.pnlHeader.ResumeLayout(false);
        this.pnlHeader.PerformLayout();
        this.pnlActions.ResumeLayout(false);
        this.pnlActions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvRules)).EndInit();
        this.ResumeLayout(false);
    }
}
