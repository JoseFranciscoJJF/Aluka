# ...-plan.md — a OFICINA / ESTADO VIVO (o "como está" + "para onde" + "ideias")

**Objetivo:** o espaço de trabalho: roteiro, estado geral, backlog, brainstorming, e a matriz do levantamento jurídico em andamento.

**Regra:**
- Contém: Estado Geral (§1 — foto instantânea de onde estamos)
- Aqui as coisas nascem e vivem enquanto não fecham: um item entra como "⬜/⏳/👀", o business.md só o acolhe quando vira decisão/regra ✅.
- Regra: a secção 1 (Estado Geral) tem de ser atualizada a cada sessão — é o seu "pulse". Linhas na matriz só mudam de estado quando a regra correspondente do business.md é confirmada.
- Brainstorming/ideias que ainda não mereceram decisão ficam aqui (§5), não no business.

**Estado Geral (§1):**

| ID | Funcionalidade | Status | Prioridade | Comentário |
|----|-----------------|--------|------------|------------|
| ALUKA-P0 | Aluka.WinForms build zerado | ✅ OK | Crítica | Resolvido 2026-10-22: `dotnet build Aluka.sln` → 0 errors. Ver business.md para causa raiz. |
| ALUKA-P1 | Core projects (Domain/Application/IoC) compilam | ✅ OK | Alta | 0 errors, apenas warning NU1903 AutoMapper |
| ALUKA-P3 | AutoMapper vulnerability (NU1903) | ⚠️ Warning | Média | Pendente upgrade para versão segura |
| ALUKA-P4 | R01 Filtro de Apps no Editor | ⬜ Pendente | Alta | Requer Visual Studio Designer modo visual |
| ALUKA-P5 | R02 Gestão de Histórico | ⬜ Pendente | Alta | Requer Visual Studio Designer modo visual |
| ALUKA-P6 | R03 Comportamento de Abertura | ⬜ Pendente | Alta | Requer Windows Process Manager refactor |
| ALUKA-P7 | R04 Notificações Windows | ⬜ Pendente | Alta | Requer Microsoft.Toolkit.Uwp.Notifications |

**Próximas mexidas (Brainstorming/ideias):**
- ALUKA-P0 resolvido: implementar R01-R04 usando VS Designer interativo (ou hand-edit cuidadoso — ver Canon 1 atualizado em business.md)
- Upgrade AutoMapper de 12.0.1 para versão mais segura
- Documentar todas as mudanças em business.md com proveniência
- Refatorar HistoryForm para adicionar gestão de histórico (batch delete)
- Verificar se existe git remoto para repositórios

**Flow de decisão:**
1. Idea/dúvida nasce no context.md (nota de sessão) ou plan.md (backlog/brainstorming)
2. Quando há decisão → business.md registra com proveniência e data
3. Quando o business avança → plan.md atualiza estado/matriz referente
4. Cada sessão fecha → context.md regista o que foi feito, para onde propagou, e refresca o PONTO DE RETOMA