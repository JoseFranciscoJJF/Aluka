using Aluka.Application.DTOs;
using Aluka.Application.Services;
using Aluka.Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Aluka.WinForms.Views;

public partial class RulesView : UserControl
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IRuleService? _ruleService;

    public RulesView(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        _ruleService = serviceProvider.GetService<IRuleService>();
        InitializeComponent();
    }

    public async Task RefreshAsync()
    {
        await LoadRulesAsync();
    }

    private async void RulesView_Load(object sender, EventArgs e)
    {
        await LoadRulesAsync();
    }

    private async Task LoadRulesAsync()
    {
        if (_ruleService == null)
        {
            this.lblStatus.Text = "Service not available";
            return;
        }

        this.dgvRules.Rows.Clear();
        this.lblStatus.Text = "Loading rules...";

        try
        {
            var rules = await _ruleService.GetAllRulesAsync();

            foreach (var rule in rules.OrderBy(r => r.EstaAtivo ? 0 : 1).ThenBy(r => r.HoraInicio))
            {
                var rowIndex = this.dgvRules.Rows.Add();

                this.dgvRules.Rows[rowIndex].Cells[0].Value = rule.EstaAtivo ? "Active" : "Inactive";
                this.dgvRules.Rows[rowIndex].Cells[1].Value = rule.AplicacaoNome ?? $"App ID: {rule.AplicacaoId}";
                this.dgvRules.Rows[rowIndex].Cells[2].Value = rule.TipoAcao == TipoAcao.Abrir ? "Open" : "Close";
                this.dgvRules.Rows[rowIndex].Cells[3].Value = GetDaysDisplay(rule.DiasSemana);
                this.dgvRules.Rows[rowIndex].Cells[4].Value = rule.HoraInicio.ToString();
                this.dgvRules.Rows[rowIndex].Cells[5].Value = rule.HoraFim.ToString();
                this.dgvRules.Rows[rowIndex].Cells[6].Value = rule.Id;

                // Color for inactive rules
                if (!rule.EstaAtivo)
                {
                    this.dgvRules.Rows[rowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
            }

            this.lblStatus.Text = $"{rules.Count()} rules found";
        }
        catch (Exception ex)
        {
            this.lblStatus.Text = $"Error: {ex.Message}";
            MessageBox.Show($"Error loading rules: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string GetDaysDisplay(DiasSemana days)
    {
        if (days == DiasSemana.TodosOsDias)
            return "All days";

        if (days == DiasSemana.DiasUteis)
            return "Weekdays";

        if (days == DiasSemana.FimDeSemana)
            return "Weekend";

        var parts = new List<string>();
        foreach (DiasSemana day in Enum.GetValues(typeof(DiasSemana)))
        {
            if (day == 0 || day == DiasSemana.TodosOsDias || day == DiasSemana.DiasUteis || day == DiasSemana.FimDeSemana)
                continue;

            if (days.HasFlag(day))
                parts.Add(day.ToString());
        }
        return string.Join(", ", parts);
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        var editor = new RuleEditorForm(_serviceProvider);
        editor.ShowDialog(this.FindForm());
        _ = LoadRulesAsync();
    }

    private void BtnEdit_Click(object sender, EventArgs e)
    {
        if (dgvRules.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select a rule to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedRow = dgvRules.SelectedRows[0];
        var id = (int)selectedRow.Cells[6].Value;

        var editor = new RuleEditorForm(_serviceProvider, id);
        editor.ShowDialog(this.FindForm());
        _ = LoadRulesAsync();
    }

    private async void BtnToggle_Click(object sender, EventArgs e)
    {
        if (_ruleService == null) return;

        if (dgvRules.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select a rule to activate/deactivate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedRow = dgvRules.SelectedRows[0];
        var id = (int)selectedRow.Cells[6].Value;
        var isActive = selectedRow.Cells[0].Value.ToString()?.Contains("Active") ?? false;

        try
        {
            bool success;
            if (isActive)
                success = await _ruleService.DeactivateRuleAsync(id);
            else
                success = await _ruleService.ActivateRuleAsync(id);

            if (success)
                await LoadRulesAsync();
            else
                MessageBox.Show("Failed to change rule state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void BtnDelete_Click(object sender, EventArgs e)
    {
        if (_ruleService == null) return;

        if (dgvRules.SelectedRows.Count == 0)
        {
            MessageBox.Show("Select a rule to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var selectedRow = dgvRules.SelectedRows[0];
        var id = (int)selectedRow.Cells[6].Value;
        var appName = selectedRow.Cells[1].Value.ToString();

        var result = MessageBox.Show($"Are you sure you want to delete the rule for '{appName}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            try
            {
                await _ruleService.DeleteRuleAsync(id);
                await LoadRulesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting rule: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
