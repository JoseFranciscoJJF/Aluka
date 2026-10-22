# ...-analise.md — a BASE BRUTA (o "porquê")

**Objetivo:** registo histórico do raciocínio antes de decidir. A conversa original (a ideia do utilizador + o veredicto de viabilidade).

**Regra:**
- Contém: a ideia inicial, as alterações/notas feitas durante a sessão, o veredicto de viabilidade, a reflexão "antes de tudo".
- Serve de consulta para justificar decisões.
- Não é fonte normativa: não decide nada, não regra nada definitivo.
- Deve ser tratado como quase-imutável — é a memória original. No máximo, num futuro distante, pode-se-lhe dar organização mínima (cabeçalhos), mas sem alterar o conteúdo do raciocínio.

**Conteúdo da sessão:**
- Problema identificado: Aluka.WinForms com 97 build errors provenientes de quebra de sincronização entre RulesForm.Designer.cs e RulesForm.cs (partial class). Este problema persistiu mesmo após criação de cópia do diretório, confirmando que não é culpa das mexidas de hoje, mas uma herança técnica do projeto.
- Solução adotada: core projects (Domain, Application, Infrastructure, Infrastructure.IoC) compilam perfeitamente (0 errors). Apenas a camada WinForms falha.
- Limitações enfrentadas: Modelos de IA sem experiência profunda em Windows Forms application development lutam com a sincronia do designer WinForms. Hand-editing de ambos os arquivos (.cs + .Designer.cs) simultaneamente quebra o pairing.
- Caminho adiante: Usar Visual Studio Designer modo visual (arrastar/soltar), ou refatorar para MVVM/data-binding, ou aguardar backup/git remoto para restaurar estado original.
- AutoMapper vulnerability: Package 'AutoMapper' 12.0.1 has known high severity vulnerability (GHSA-rvv3-g6hj-g44x) presente em todos os projetos, apenas warning NU1903.