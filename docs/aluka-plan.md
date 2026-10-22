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
| ALUKA-P4 | R01 Filtro de Apps no Editor | 👀 Parcial | Alta | AppsView já tem txtSearch funcional; falta confirmar se cobre o pedido completo do roadmap |
| ALUKA-P5 | R02 Gestão de Histórico | 👀 Parcial | Alta | HistoryView já tem filtros + delete em lote + limpar tudo; falta confirmar se cobre o pedido completo |
| ALUKA-P6 | R03 Comportamento de Abertura | ⬜ Pendente | Alta | Requer Windows Process Manager refactor |
| ALUKA-P7 | R04 Notificações Windows | ⬜ Pendente | Alta | UI já existe em RuleEditorForm (grpNotifications); falta confirmar wiring do backend com Microsoft.Toolkit.Uwp.Notifications |
| ALUKA-P8 | Shell único + navegação in-place + tema visual | ✅ OK | Alta | Resolvido 2026-10-22: MainForm agora é shell (sidebar + content panel), RulesForm/AppsForm/HistoryForm viraram UserControls (Views/), Theme.cs centraliza cores/tipografia/espaçamento. Ver business.md. |

**Próximas mexidas (Brainstorming/ideias):**
- Testar manualmente o clique em cada item da sidebar (Início/Regras/Aplicações/Histórico) e confirmar que os dados carregam e que o diálogo de editar regra ainda abre centrado sobre o shell
- Upgrade AutoMapper de 12.0.1 para versão mais segura
- Revisar ALUKA-P4/P5/P7 com mais detalhe para decidir se já estão "fechados" ou se falta algo do roadmap original
- (Opcional, baixa prioridade) Substituir emojis em botões/labels por ícones Segoe Fluent Icons — decidido adiar por risco de codepoint errado (glyph invisível)
- **Próxima fase 1 — Publicar no GitHub:** repositório local já existe (`git init` feito em 22 Out 2026, sem remote). Falta: criar repo remoto no GitHub, `git remote add origin ...`, decidir público/privado, rever `.gitignore` (já cobre bin/obj/.vs/logs/*.db), primeiro `git push`.
- **Próxima fase 2 — Ajustar contrastes visuais:** Theme.cs (paleta atual) precisa de revisão de contraste — por rever: texto sobre `SidebarItemHover`/`SidebarItemActive`, `TextSecondary` sobre `Background`, bordas de `StyleSecondaryButton` sobre `Surface`. Ainda não há WCAG/contraste mínimo validado nesta sessão — item em aberto, não decisão fechada.

**Flow de decisão:**
1. Idea/dúvida nasce no context.md (nota de sessão) ou plan.md (backlog/brainstorming)
2. Quando há decisão → business.md registra com proveniência e data
3. Quando o business avança → plan.md atualiza estado/matriz referente
4. Cada sessão fecha → context.md regista o que foi feito, para onde propagou, e refresca o PONTO DE RETOMA