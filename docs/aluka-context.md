# ...-context.md — a MEMÓRIA DE CURTO PRAZO (o "o que aconteceu" + "o que vem a seguir")

**Objetivo:** memória de trabalho para a próxima sessão/agente: últimas mexidas, próximas mexidas, estado de transferência.

**Regra:**
- Contém: secções cronológicas ## Sessão … (o que foi feito/decidido e para onde foi propagado), "Próxima mexida", a convenção da transferência de agente, e o PONTO DE RETOMA — que, por convenção própria, é sempre a última secção do ficheiro e é "ler primeiro".
- Regra de funcionamento (a mais importante deste ficheiro): ao fechar cada sessão relevante, (1) anota-se o que aconteceu e para onde foi propagado; (2) refresca-se o PONTO DE RETOMA e move-se para o fim, para apanhar o estado mais recente; (3) garante-se que business.md e plan.md foram atualizados na mesma sessão.
- Não é para conter regras definitivas nem tabelas normativas (isso é business) — só o registo do que foi feito e o estado corrente.

**Histórico da Conversa e Prompt de Extensibility**

---

### Data da Sessão: 22 de Outubro de 2026

### Utilizador: Instruções iniciais
O utilizador começou por perguntar "What did we do so far?" sobre dois projetos: BetweenUs e Aluka. O objetivo original era testar o BetweenUs depois de esquecer todas as senhas, e melhorar a UI/UX do Aluka que foi descrito como "arcaíca, antiga, sem vida, parece um trabalho amador".

### Problemas Identificados Iniciais
- **BetweenUs:** Demo users seeding com password "password1", utilizador queria testar mas não se lembrava das senhas. Também queria criar novo admin user `santos.admiro` com password `santos.Ad1mro`.
- **Aluka:** Windows Forms (.NET 8) application para gestão de foco/produtividade. UI descrita como "arcaica, antiga, sem vida". Documentação inclui UI/UX specs (section 5) e roadmap items R01-R04. Tentativas de melhorias de UI atingiram "severe WinForms designer/code-behind synchronization failures (97 build errors)".

### Entrevistas com a IA (esta sessão)

#### Primeira Mensagem da IA
A IA resumiu o estado atual de ambos os projetos, listando o que estava concluído e o que estava bloqueado. Para o BetweenUs, destacou as fixes realizadas (seeder, passwords). Para o Aluka, destacou o problema de 97 errors no WinForms designer sync.

#### Segundas e Terças Interações
A IA trabalhou na resolução dos problemas:
1. **BetweenUs:** Fixou `DemoUserSeeder.cs` (adicionou user `santos.admiro`, mudou `DefaultPassword` para `"santos.Ad1mro"`), fixou `DbSeeder.cs` (KeyNotFoundException 'AuditLog'). Build: 0 errors, 0 warnings.
2. **Aluka:** Tentou hand-editing dos ficheiros `RulesForm.cs` e `RulesForm.Designer.cs` para melhorar UI/UX. Descobriu que o problema de sincronização do designer WinForms era frágil e que hand-modifications quebravam o pairing entre o `InitializeComponent()` gerado e as referências de controlo no código-behind. Mesmo após criar cópia do diretório, o problema persistiu (97 errors mesmos).

### O Prompt que o Utilizador Enviou

O utilizador enviou um prompt estruturado para outro modelo de IA (como o Claude Opus), alinhado sobre os problemas enfrentados no Aluka, sobre o que se queria fazer (escalar a UI/UX) e sobre onde se via limitados (não saber programar usando Windows Forms application). O prompt definiu:

**Objetivo:** Fazer o Aluka funcionar primeiro, depois escalar a UI. Sem medo de mudar o funcionamento — não precisa de colocar exatamente como era, só precisa estar alinhado com a funcionalidade e com o que se precisa alcançar.

**4 Canónicos:** Criados em `@C:\Default\Code\Aluka\docs\`, baseados no `@C:\Default\Code\about-docs.md`:
- `...-analise.md` — a BASE BRUTA (o "porquê")
- `...-business.md` — a CONTRATO / FONTE DE VERDADE NORMATIVA (o "o quê" + "porquê" fechado)
- `...-plan.md` — a OFICINA / ESTADO VIVO (o "como está" + "para onde" + "ideias")
- `...-context.md` — a MEMÓRIA DE CURTO PRAZO (o "o que aconteceu" + "o que vem a seguir")

**Problemas Documentados:**
1. WinForms Designer Sync Failure — 97 errors CS0103/CS1061 provenientes de desync entre RulesForm.Designer.cs e RulesForm.cs
2. No Git History — diretório sem .git, impossível fazer checkout/revert
3. AutoMapper Vulnerability — Package 'AutoMapper' 12.0.1 has known high severity vulnerability (NU1903)
4. Limited Windows Forms Knowledge — IA sem experiência profunda em WinForms Apps

### O Que o Utilizador Esperava da IA

1. **Entrego funcional:** O projeto deve compilar e rodar (`dotnet build` = 0 errors). A UI deve ser funcional antes de qualquer scaling.
2. **Sem medo de mudar funcionamento:** O utilizador não se importa de reestruturar código, desde que o resultado final funcione e possa ser escalado.
3. **Alinhado com funcionalidade:** As mudanças devem estar alinhadas com o que o projeto já faz, não reinventar a roda.
4. **Escalabilidade após funcionalidade:** Primeiro fazer o projeto rodar, depois implementar os itens do roadmap R01-R04 (Filtro de Apps, Gestão de Histórico, Comportamento de Abertura, Notificações Windows).
5. **Documentação:** Todas as decisões devem ser documentadas nos 4 ficheiros estruturais seguindo o padrão do `about-docs.md`.

### O Que o Utilizador Esperará de Outra IA

1. **Continuidade sem reinicialização:** A próxima IA deve ser capaz de ler o estado actual dos ficheiros `aluka-analise.md`, `aluka-business.md`, `aluka-plan.md` e `aluka-context.md` e continuar o trabalho sem precisar de re-pesquisar tudo.
2. **Respeito pela estrutura documental:** As 4 novas regras de ouro (canónicos) não devem ser violadas. Especialmente o Canônico 1: "Never Touch Designer.cs and .cs Simultaneously".
3. **Abordagem prática para o designer WinForms:** Como não há git e o problema de sync já existia antes, a próxima IA deve tentar:
   - Usar Visual Studio Designer modo visual (arrastar/soltar, Properties window)
   - Ou aceitar que será necessário refactor para MVVM/data-binding
   - Ou tentar restaurar do estado original se houver backup em outro local
4. **Manutenção dos 4 ficheiros de documentação:** Qualquer nova sessão deve atualizar os 4 ficheiros (`...-analise.md`, `...-business.md`, `...-plan.md`, `...-context.md`) seguindo a regra do PONTO DE RETOMA (última secção, ler primeiro).
5. **Sem referências a BetweenUs:** Como os projetos são independentes, a próxima IA deve manter a documentação do Aluka isenta de referências ao BetweenUs, a menos que seja relevante para comparação de padrões de problema.
6. **AutoMapper upgrade:** Deverá verificar se há versão mais recente do AutoMapper e atualizar os PackageReferences, ou pelo menos documentar o risco NU1903.

### extensibility Notes for Future AI

- **This conversation serves as the extensibility baseline:** Any future AI working on this project should first read all 4 documentation files (aluka-analise.md, aluka-business.md, aluka-plan.md, aluka-context.md) to understand the current state, the problems faced, and the documented decisions.
- **The 4 canons are constraints:** They represent hard constraints learned during this session. Violating them (especially Canon 1 about not editing Designer.cs and .cs simultaneously) will recreate the 97 errors problem.
- **Context migration:** When transferring to a new agent/session, the PONTO DE RETOMA in context.md must be updated to reflect the current state, and the new agent should start by reading all 4 files in order: analise → business → plan → context.
- **No BetweenUs contamination:** The Aluka documentation track should remain separate. Any learnings from BetweenUs (like the seeder fix pattern) should be noted but not directly applied to Aluka's codebase, as they are different projects with different architectures.

---

**Transferência para próximo agente:**
- Ler obrigatoriamente: aluka-analise.md → aluka-business.md → aluka-plan.md → aluka-context.md
- Manter os 4 canónicos como regras de ouro (Canon 1 revisto nesta sessão — ver business.md)
- ALUKA-P0 resolvido; focar agora em teste de runtime do RulesForm e depois R01-R04
- Atualizar PONTO DE RETOMA após cada sessão relevante
- Documentar todas as mudanças em business.md com proveniência
- Verificar upgrade do AutoMapper de 12.0.1

---

## Sessão: 22 de Outubro de 2026 — Fix do ALUKA-P0

**O que foi feito:**
1. Lido os 4 ficheiros canónicos (analise, business, plan, context) para herdar contexto da sessão anterior.
2. Diagnóstico: `dotnet build src/Aluka.WinForms/Aluka.WinForms.csproj` confirmou 103 errors (97 CS1061 + 6 CS0103), todos concentrados em `RulesForm.cs`/`RulesForm.Designer.cs`. Resto da solução (Domain/Application/Infrastructure/IoC + AppsForm/HistoryForm/MainForm/RuleEditorForm) já compilava limpo.
3. Causa raiz: `RulesForm.Designer.cs` tinha o bloco de declaração de campos dos controlos apagado (lblTitle, dgvRules, btnAdd, btnEdit, btnToggle, btnDelete, btnClose, lblStatus) — `InitializeComponent()` referenciava-os sem existirem como fields.
4. Fix: readicionado bloco de 8 `private System.Windows.Forms.*` fields no Designer.cs.
5. Durante a verificação, detetado bug de runtime latente (warnings CS0649): as 7 colunas do DataGridView (colStatus, colApp, colAction, colDays, colStart, colEnd, colId) nunca eram instanciadas (`new DataGridViewTextBoxColumn()`) antes do `Columns.AddRange(...)` — causaria `NullReferenceException` ao abrir o form mesmo com build a passar. Corrigido adicionando a instanciação de cada coluna.
6. Verificado: `dotnet build Aluka.sln --no-incremental` → 0 Error(s), 10 Warning(s) (todos NU1903/AutoMapper).
7. Propagado para: `aluka-business.md` (decisão fechada + Canon 1 revisto) e `aluka-plan.md` (matriz ALUKA-P0 → ✅ OK).

**Próxima mexida:** ver PONTO DE RETOMA abaixo.

---

**PONTO DE RETOMA (ler primeiro):**
Estado atual: ALUKA-P0 RESOLVIDO em 22 Out 2026. `dotnet build Aluka.sln --no-incremental` → 0 Error(s), 10 Warning(s) (todos NU1903/AutoMapper). Causa raiz dos 97 errors e o fix aplicado estão detalhados na secção "Sessão: 22 de Outubro de 2026 — Fix do ALUKA-P0" acima e em `aluka-business.md`.

Ainda por fazer:
- Testar o runtime real do RulesForm (correr o Aluka.WinForms, abrir o form, confirmar que a grid carrega sem exceção) — só foi verificado o build e o arranque do MainForm, não a navegação até ao RulesForm.
- Avançar com R01-R04 (Filtro de Apps, Gestão de Histórico, Comportamento de Abertura, Notificações Windows) seguindo o Canon 1 revisto (business.md).
- AutoMapper 12.0.1 continua com vulnerability NU1903 pendente de upgrade.

**Update (mesma sessão, pós-fix):** removida a duplicação `src/Aluka.WinForms - copy/` — confirmado via `Aluka.sln` (grep) que a solução só referencia `src/Aluka.WinForms\Aluka.WinForms.csproj`; diff dos ficheiros confirmou que a cópia era apenas o snapshot pré-fix (RulesForm.Designer.cs ainda com o bug) sem nada de único. Apagada com `rm -rf`. Rebuild (`--no-incremental`) confirmado limpo após matar um processo `Aluka.WinForms.exe` remanescente do teste de runtime anterior, que estava a bloquear as DLLs.