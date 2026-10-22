# ...-business.md — a CONTRATO / FONTE DE VERDADE NORMATIVA (o "o quê" + "porquê" fechado)

**Objetivo:** a única fonte de verdade do produto. Aqui é onde uma decisão, uma vez tomada, vive para sempre.

**Regra:**
- Contém tudo o que é decidido e fechado: decisões arquiteturais, validações/gates, Registo de decisões (incluindo reversões).
- Cada regra guarda proveniência (RuleSource, vigência, RuleTestCase) — é o "código de leis" do projecto.
- Regra dura: só entra aqui o que está decidido. Pergunta em aberto, ideia solta, rascunho → não. E nada se apaga da história: reversão regista-se como reversão, não se esconde.
- É o ficheiro de referência para qualquer agente/IA implementar sem re-pesquisar.

**Decisões fechadas nesta sessão (22 Out 2026):**
1. **ALUKA-P0 RESOLVIDO — build zerado:** Causa raiz encontrada: `RulesForm.Designer.cs` tinha a declaração de campos dos controlos (lblTitle, dgvRules, btnAdd, btnEdit, btnToggle, btnDelete, btnClose, lblStatus) apagada — `InitializeComponent()` referenciava-os sem existirem como fields na partial class. Fix: readicionado o bloco `private System.Windows.Forms.* campo;` para cada controlo. Adicionalmente encontrado bug latente de runtime: as colunas do DataGridView (colStatus, colApp, colAction, colDays, colStart, colEnd, colId) eram declaradas mas nunca instanciadas (`new DataGridViewTextBoxColumn()`) antes do `Columns.AddRange(...)` — isto causaria `NullReferenceException` ao abrir o RulesForm mesmo com o build a passar. Corrigido adicionando a instanciação de cada coluna em `InitializeComponent()`. Resultado: `dotnet build Aluka.sln --no-incremental` → 0 errors, apenas warnings NU1903 (AutoMapper) e nenhum CS0649 remanescente. Apenas `RulesForm`/`RulesForm.Designer.cs` estavam afetados — AppsForm, HistoryForm, MainForm, RuleEditorForm já compilavam.
2. **Revisão do Canon 1 ("Never Touch Designer.cs and .cs Simultaneously"):** o problema real não era editar os dois ficheiros ao mesmo tempo — era apagar a secção de campos do Designer.cs sem reconciliar com o code-behind. Regra revista: ao editar Designer.cs, nunca remover declarações de campo (`private System.Windows.Forms.X nomeDoControlo;`) sem também remover todas as referências em `InitializeComponent()` e no code-behind, e vice-versa. Fazer isto manualmente é viável desde que se confirme simetria campo-declarado ↔ campo-instanciado ↔ campo-usado antes de cada build.
3. **Aluka core projects:** Aluka.Domain, Aluka.Application, Aluka.Infrastructure, Aluka.Infrastructure.IoC — todos compilam com 0 errors (inalterado).
4. **Aluka UI/UX roadmap:** Itens R01-R04 (Filtro de Apps, Gestão de Histórico, Comportamento de Abertura, Notificações Windows) podem agora avançar — build já não bloqueia. Hand-editing cuidadoso dos ficheiros .cs/.Designer.cs é viable desde que a regra do Canon 1 revisto seja seguida; VS Designer visual continua alternativa válida.
5. **AutoMapper vulnerability:** Package 'AutoMapper' 12.0.1 has known high severity vulnerability (GHSA-rvv3-g6hj-g44x) — registado como warning NU1903 em todos os projects, pendente upgrade. Sem alteração nesta sessão.

**Proveniência:**
- RuleSource: Sessão de 22 Out 2026 (fix do ALUKA-P0)
- Vigência: Em vigor até upgrade de AutoMapper ou nova regressão de designer sync
- RuleTestCase: `dotnet build Aluka.sln --no-incremental` → 0 Error(s), 10 Warning(s) (todos NU1903)