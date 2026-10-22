Documentação Técnica do Projeto Aluka
Versão: 3.0.0
Data: 20 de Agosto de 2026
Estado: MVP Funcional - Em Refinamento
Autor: José Jacinto Francisco

📋 Índice
Visão Geral do Sistema

Arquitetura do Sistema

Modelo de Dados

Funcionalidades Implementadas (MVP)

Requisitos de UI/UX

Problemas Conhecidos e Soluções Propostas

Requisitos para Próximas Versões

Guia de Configuração e Desenvolvimento

Especificações Técnicas Detalhadas

1. Visão Geral do Sistema
1.1 Identificação
Campo	Valor
Nome	Aluka
Significado	Foco, concentração (do kimbundo)
Tipo	Aplicação Desktop para Windows
Linguagem	C# 12
Framework	.NET 8.0 (LTS)
Plataformas	Windows 10 (1809+), Windows 11
Arquitetura	x64
Modelo de Distribuição	Open Source (Core) + Comercial (Premium)
1.2 Propósito
O Aluka é um Gestor de Contexto Digital que permite ao utilizador:

Agendar a abertura automática de aplicações para iniciar blocos de trabalho

Programar o fecho automático de aplicações para terminar períodos de foco

Visualizar todas as aplicações instaladas e gerir as suas regras

Atualizar a lista de aplicações com um simples clique

1.3 Filosofia
Pilar	Descrição
Autonomia	O utilizador define as regras, a máquina executa
Simplicidade	Interface intuitiva, configuração visual, impacto imediato
Respeito	Nunca força o utilizador; tudo é configurável
2. Arquitetura do Sistema
2.1 Padrões Arquiteturais
Padrão	Aplicação	Benefício
Clean Architecture	Separação em camadas independentes	Manutenibilidade, testabilidade
Repository Pattern	Abstração do acesso a dados	Desacoplamento, facilidade de teste
Dependency Injection	Inversão de controlo via DI container	Baixo acoplamento, testabilidade
Unit of Work	Transações atómicas na base de dados	Consistência de dados
Strategy Pattern	Diferentes algoritmos de fecho	Flexibilidade, extensibilidade
Observer Pattern	Notificações de eventos	UI reativa, desacoplamento
Singleton	Serviços de background	Controlo centralizado
2.2 Estrutura de Camadas
text
┌─────────────────────────────────────────────────────────────────────────┐
│                         CAMADA DE APRESENTAÇÃO                        │
│                         (Aluka.WinForms)                              │
│  ┌─────────────┐ ┌─────────────┐ ┌─────────────┐ ┌─────────────┐   │
│  │  MainForm   │ │  RulesForm  │ │  AppsForm   │ │ HistoryForm │   │
│  └─────────────┘ └─────────────┘ └─────────────┘ └─────────────┘   │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                         CAMADA DE APLICAÇÃO                           │
│                         (Aluka.Application)                           │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                         SERVIÇOS                                │  │
│  │  ┌───────────────┐ ┌───────────────┐ ┌─────────────────────┐  │  │
│  │  │  AppService   │ │  RuleService  │ │  HistoryService     │  │  │
│  │  └───────────────┘ └───────────────┘ └─────────────────────┘  │  │
│  │  ┌─────────────────────────────────────────────────────────┐  │  │
│  │  │              ProcessManagerService                       │  │  │
│  │  └─────────────────────────────────────────────────────────┘  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                          CAMADA DE DOMÍNIO                            │
│                          (Aluka.Domain)                               │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  ┌──────────────┐ ┌──────────────┐ ┌──────────────────────┐   │  │
│  │  │  Aplicacao   │ │ RegraAgend.  │ │  HistoricoExecucao   │   │  │
│  │  └──────────────┘ └──────────────┘ └──────────────────────┘   │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                       CAMADA DE INFRAESTRUTURA                        │
│                       (Aluka.Infrastructure)                          │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  ┌──────────────────────────────────────────────────────────┐  │  │
│  │  │  Data (EF Core + SQLite)                                 │  │  │
│  │  └──────────────────────────────────────────────────────────┘  │  │
│  │  ┌──────────────────────────────────────────────────────────┐  │  │
│  │  │  WindowsProcessManager (Native/Interop)                 │  │  │
│  │  └──────────────────────────────────────────────────────────┘  │  │
│  │  ┌──────────────────────────────────────────────────────────┐  │  │
│  │  │  BackgroundScheduler (Hosted Service)                   │  │  │
│  │  └──────────────────────────────────────────────────────────┘  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
2.3 Estrutura de Pastas do Projeto
text
Aluka.sln
│
├── 📁 src/
│   ├── 📁 Aluka.Domain/                    # Camada de Domínio
│   │   ├── 📁 Entities/
│   │   │   ├── BaseEntity.cs
│   │   │   ├── Aplicacao.cs
│   │   │   ├── RegraAgendamento.cs
│   │   │   └── HistoricoExecucao.cs
│   │   ├── 📁 Enums/
│   │   │   ├── TipoAcao.cs
│   │   │   ├── DiasSemana.cs
│   │   │   └── StatusExecucao.cs
│   │   └── 📁 Interfaces/
│   │       ├── IRepository.cs
│   │       ├── IApplicationRepository.cs
│   │       ├── IRuleRepository.cs
│   │       ├── IHistoryRepository.cs
│   │       └── IUnitOfWork.cs
│   │
│   ├── 📁 Aluka.Application/               # Camada de Aplicação
│   │   ├── 📁 DTOs/
│   │   │   ├── AppDTO.cs
│   │   │   ├── RuleDTO.cs
│   │   │   ├── CreateRuleDTO.cs
│   │   │   ├── UpdateRuleDTO.cs
│   │   │   ├── HistoryDTO.cs
│   │   │   └── HistoryStatisticsDTO.cs
│   │   ├── 📁 Mappings/
│   │   │   ├── ApplicationProfile.cs
│   │   │   ├── RuleProfile.cs
│   │   │   └── HistoryProfile.cs
│   │   ├── 📁 Services/
│   │   │   ├── IAppService.cs
│   │   │   ├── AppService.cs
│   │   │   ├── IRuleService.cs
│   │   │   ├── RuleService.cs
│   │   │   ├── IHistoryService.cs
│   │   │   └── HistoryService.cs
│   │   └── 📁 Validators/
│   │       ├── CreateRuleDTOValidator.cs
│   │       └── UpdateRuleDTOValidator.cs
│   │
│   ├── 📁 Aluka.Infrastructure/            # Camada de Infraestrutura
│   │   ├── 📁 Data/
│   │   │   ├── AppDbContext.cs
│   │   │   ├── 📁 Configurations/
│   │   │   │   ├── AplicacaoConfiguration.cs
│   │   │   │   ├── RegraAgendamentoConfiguration.cs
│   │   │   │   └── HistoricoExecucaoConfiguration.cs
│   │   │   └── 📁 Repositories/
│   │   │       ├── Repository.cs
│   │   │       ├── ApplicationRepository.cs
│   │   │       ├── RuleRepository.cs
│   │   │       ├── HistoryRepository.cs
│   │   │       └── UnitOfWork.cs
│   │   └── 📁 Services/
│   │       ├── RegistryScanner.cs
│   │       ├── IconExtractor.cs
│   │       ├── WindowsProcessManager.cs
│   │       └── BackgroundScheduler.cs
│   │
│   ├── 📁 Aluka.Infrastructure.IoC/        # Injeção de Dependências
│   │   └── DependencyInjection.cs
│   │
│   └── 📁 Aluka.WinForms/                  # Camada de Apresentação
│       ├── 📁 Forms/
│       ├── 📁 Controls/
│       └── Program.cs
│
├── 📁 tests/
│   ├── 📁 Aluka.Tests.Unit/
│   └── 📁 Aluka.Tests.Integration/
│
└── 📁 docs/
3. Modelo de Dados
3.1 Diagrama Entidade-Relacionamento
text
┌─────────────────────┐          ┌─────────────────────────┐          ┌─────────────────────┐
│     Aplicacao       │          │      RegraAgendamento    │          │   HistoricoExecucao │
├─────────────────────┤          ├─────────────────────────┤          ├─────────────────────┤
│ Id (PK)             │◄─────────┤ Id (PK)                 │          │ Id (PK)             │
│ Nome                │          │ AplicacaoId (FK)        │          │ RegraAgendamentoId  │
│ CaminhoExecutavel   │          │ TipoAcao (Abrir/Fechar) │          │ DataExecucao        │
│ IconeBase64         │          │ DiasSemana (bitmask)    │          │ Status (Sucesso/Err)│
│ DataUltimaAtualizacao│          │ HoraInicio (TimeOnly)   │          │ MensagemErro        │
│ EstaAtivo           │          │ HoraFim (TimeOnly)      │          │ DuracaoMs           │
│ DataCriacao         │          │ EstaAtivo               │          │ DataCriacao         │
└─────────────────────┘          │ DataCriacao             │          └─────────────────────┘
                                  │ DataModificacao         │
                                  │ Observacao              │
                                  └─────────────────────────┘
3.2 Script SQL (SQLite)
sql
-- Tabela Aplicacao
CREATE TABLE Aplicacao (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    CaminhoExecutavel TEXT NOT NULL UNIQUE,
    IconeBase64 TEXT,
    DataUltimaAtualizacao TEXT NOT NULL,
    EstaAtivo INTEGER NOT NULL DEFAULT 1,
    DataCriacao TEXT NOT NULL
);

-- Tabela RegraAgendamento
CREATE TABLE RegraAgendamento (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    AplicacaoId INTEGER NOT NULL,
    TipoAcao INTEGER NOT NULL,
    DiasSemana INTEGER NOT NULL,
    HoraInicio TEXT NOT NULL,
    HoraFim TEXT NOT NULL,
    EstaAtivo INTEGER NOT NULL DEFAULT 1,
    DataCriacao TEXT NOT NULL,
    DataModificacao TEXT NOT NULL,
    Observacao TEXT,
    FOREIGN KEY (AplicacaoId) REFERENCES Aplicacao(Id) ON DELETE CASCADE
);

-- Tabela HistoricoExecucao
CREATE TABLE HistoricoExecucao (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    RegraAgendamentoId INTEGER NOT NULL,
    DataExecucao TEXT NOT NULL,
    Status INTEGER NOT NULL,
    MensagemErro TEXT,
    DuracaoMs INTEGER,
    DataCriacao TEXT NOT NULL,
    DataModificacao TEXT NOT NULL,
    FOREIGN KEY (RegraAgendamentoId) REFERENCES RegraAgendamento(Id) ON DELETE CASCADE
);

-- Índices
CREATE INDEX idx_regra_agendamento_aplicacao ON RegraAgendamento(AplicacaoId);
CREATE INDEX idx_regra_agendamento_ativo ON RegraAgendamento(EstaAtivo);
CREATE INDEX idx_historico_regra ON HistoricoExecucao(RegraAgendamentoId);
CREATE INDEX idx_historico_data ON HistoricoExecucao(DataExecucao);
3.3 Enums
TipoAcao
csharp
public enum TipoAcao
{
    Abrir = 0,
    Fechar = 1
}
DiasSemana (Flags)
csharp
[Flags]
public enum DiasSemana
{
    Domingo = 1,
    Segunda = 2,
    Terca = 4,
    Quarta = 8,
    Quinta = 16,
    Sexta = 32,
    Sabado = 64,
    DiasUteis = Segunda | Terca | Quarta | Quinta | Sexta,
    FimDeSemana = Domingo | Sabado,
    TodosOsDias = DiasUteis | FimDeSemana
}
StatusExecucao
csharp
public enum StatusExecucao
{
    Sucesso = 0,
    Erro = 1,
    Ignorado = 2
}
4. Funcionalidades Implementadas (MVP)
4.1 Core Features
ID	Funcionalidade	Descrição	Status
F01	Listagem automática de apps	Varre o sistema e apresenta todas as apps instaladas com ícone	✅
F02	Criação de regras de agendamento	UI para definir dias, horas, app e ação (abrir/fechar)	✅
F03	Serviço de execução em background	Processo que verifica e executa as regras automaticamente	✅
F04	Atualização manual da lista de apps	Botão "Atualizar" na UI para forçar nova varredura	✅
F05	Ativação/desativação de regras	Toggle para ligar/desligar regras sem as apagar	✅
F06	Histórico de execuções	Log das ações executadas e seus resultados	✅
4.2 Telas Implementadas
MainForm
Dashboard com estatísticas (regras ativas, total)

Botões de navegação para todas as funcionalidades

Barra de status com feedback

AppsForm
Lista de aplicações com ícones

Colunas: Nome, Caminho, Estado

Botão para atualizar lista

Indicador de progresso

RulesForm
Lista de regras com estado (ativa/inativa)

Colunas: Estado, Aplicação, Ação, Dias, Início, Fim

Botões: Adicionar, Editar, Ativar/Desativar, Eliminar

Cores diferentes para regras inativas

RuleEditorForm
Combobox para selecionar aplicação

RadioButtons para tipo de ação (Abrir/Fechar)

CheckBoxes para dias da semana

DateTimePickers para horas de início/fim

Validação de dados (hora início < hora fim, pelo menos um dia selecionado)

HistoryForm
Lista de execuções com data/hora

Colunas: Data/Hora, Regra, Aplicação, Ação, Status, Duração, Erro

Filtros: Status (Todos/Sucesso/Erro/Ignorado), intervalo de datas

Cores por status: Verde (Sucesso), Vermelho (Erro), Cinza (Ignorado)

5. Requisitos de UI/UX
5.1 Layout Consistente
Elemento	Especificação
Títulos	Segoe UI, 14pt, Bold
Labels	Segoe UI, 10pt
Botões	Segoe UI, 10pt, tamanho mínimo 110x35
Cores de Fundo	Branco para listas
Espaçamento	12px entre controles
Tamanho Mínimo	784x441
5.2 Feedback Visual
Evento	Feedback
Carregando dados	Label de status com mensagem
Erro	MessageBox com ícone de erro
Sucesso	Label de status com ícone ✅
Operação em andamento	Botão desativado com texto "A processar..."
5.3 Cores por Status
Status	Cor
Sucesso	🟢 Verde
Erro	🔴 Vermelho
Ignorado	⚪ Cinza
Ativa	🟢 Verde
Inativa	🔴 Cinza escuro
6. Problemas Conhecidos e Soluções Propostas
6.1 Multiplas Janelas e Roubo de Foco (Critico)
Descrição do Problema
Quando o scheduler executa uma regra de abertura para uma aplicação que já está em execução, alguns aplicativos (como Docker Desktop, Postman, Visual Studio) criam uma nova janela ou instância e roubam o foco do trabalho atual do utilizador. Este comportamento é indesejado porque:

Interrompe o fluxo de trabalho do utilizador

Pode causar perda de contexto e produtividade

Cria multiplas janelas da mesma aplicação (ex: Docker)

Causa Raiz
O ProcessManager.OpenApplicationAsync() utiliza Process.Start() com UseShellExecute = true. Algumas aplicações, quando chamadas novamente, interpretam isto como um pedido para criar uma nova instância, mesmo quando já estão em execução.

Solução Proposta
Fase 1: Verificação Robusta de Processos (Imediato)
Modificar o WindowsProcessManager para:

Verificar se a aplicação já está em execução antes de tentar abrir

Trazer a janela existente para primeiro plano em vez de abrir nova

Não roubar o foco ao utilizar SW_SHOWNOACTIVATE

Código de Referência:

csharp
// src/Aluka.Infrastructure/Services/WindowsProcessManager.cs

[DllImport("user32.dll")]
private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

[DllImport("user32.dll")]
private static extern bool SetForegroundWindow(IntPtr hWnd);

[DllImport("user32.dll")]
private static extern IntPtr GetForegroundWindow();

private const int SW_SHOWNOACTIVATE = 4;
private const int SW_RESTORE = 9;

public async Task<bool> BringToFrontAsync(string processName)
{
    // Encontrar a janela principal do processo
    var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(processName));
    if (processes.Length == 0) return false;

    foreach (var process in processes)
    {
        var hWnd = process.MainWindowHandle;
        if (hWnd != IntPtr.Zero)
        {
            // Restaurar se minimizada
            ShowWindow(hWnd, SW_RESTORE);
            // Mostrar sem ativar (não rouba foco)
            ShowWindow(hWnd, SW_SHOWNOACTIVATE);
            return true;
        }
    }
    return false;
}
Fase 2: Configuração de Comportamento (Futuro)
Adicionar nas configurações da regra:

☐ "Não abrir se já estiver em execução" (comportamento atual → apenas ignorar)

☐ "Trazer janela para primeiro plano" (foco, mas sem nova instância)

☐ "Restaurar janela minimizada" (útil para apps minimizadas)

☐ "Abrir nova instância" (forçar nova janela - comportamento atual)

6.2 Validação de Dias da Semana (Bug)
Descrição do Problema
O utilizador não consegue criar regras com todos os dias da semana selecionados. O validador retorna:

"Pelo menos um dia da semana deve ser selecionado."

Causa Raiz
O CreateRuleDTOValidator.cs continha a validação:

csharp
RuleFor(x => x.DiasSemana)
    .NotEqual(DiasSemana.TodosOsDias)  // ← BLOQUEIA TODOS OS DIAS!
    .WithMessage("Pelo menos um dia da semana deve ser selecionado.")
Esta validação está incorreta. A intenção era verificar se nenhum dia foi selecionado (dias == 0), mas acabou por bloquear também o caso legítimo de TodosOsDias.

Solução Aplicada
Remover a validação incorreta:

csharp
RuleFor(x => x.DiasSemana)
    .Must(dias => dias != 0)
    .WithMessage("Pelo menos um dia da semana deve ser selecionado.");
6.3 Filtragem de Aplicações no Editor de Regras (Requisito)
Descrição do Problema
Na lista de aplicações do RuleEditorForm, estão a aparecer todas as aplicações detetadas, incluindo:

Aplicações de sistema

Processos em segundo plano

Aplicações desinstaladas mas ainda no registo

Isto torna difícil encontrar a aplicação desejada.

Solução Proposta
Adicionar Filtro de Busca no RuleEditorForm:

Campo de texto "Pesquisar aplicação..."

Filtrar em tempo real enquanto o utilizador digita

Excluir Aplicações de Sistema:

Filtrar por caminhos típicos de sistema:

C:\Windows\

C:\Program Files\WindowsApps\

Processos com nome msiexec, svchost, etc.

Checkbox "Mostrar aplicações de sistema" (opcional)

Código de Referência:

csharp
// src/Aluka.WinForms/RuleEditorForm.cs

private void FilterApps(string searchText)
{
    var filtered = _allApps
        .Where(a => a.Nome.Contains(searchText, StringComparison.OrdinalIgnoreCase))
        .OrderBy(a => a.Nome)
        .ToList();
    
    cboApp.DataSource = filtered;
    cboApp.DisplayMember = "Nome";
    cboApp.ValueMember = "Id";
}

// Evento de texto alterado
private void TxtSearch_TextChanged(object sender, EventArgs e)
{
    FilterApps(txtSearch.Text);
}

// Excluir aplicações de sistema
private bool IsSystemApp(AppDTO app)
{
    var systemPaths = new[]
    {
        @"C:\Windows\",
        @"C:\Program Files\WindowsApps\",
        @"C:\ProgramData\Package Cache\"
    };
    
    return systemPaths.Any(p => app.CaminhoExecutavel.StartsWith(p, StringComparison.OrdinalIgnoreCase));
}
6.4 Gestão de Histórico (Requisito)
Descrição do Problema
O HistoryForm não permite:

Eliminar registos de histórico

Selecionar múltiplos registos para eliminação em lote

Solução Proposta
Adicionar Coluna de Seleção no HistoryForm:

DataGridViewCheckBoxColumn no início da grelha

Permitir seleção múltipla (Ctrl+Click, Shift+Click)

Adicionar Botões no HistoryForm:

"Eliminar Selecionados" (ícone: 🗑️)

"Limpar Todo o Histórico" (com confirmação)

Confirmar Ações:

"Tem certeza que deseja eliminar N registos selecionados?"

"Tem certeza que deseja LIMPAR TODO o histórico?"

Opções Avançadas:

"Eliminar registos com mais de X dias" (filtro por idade)

"Eliminar apenas registos de Sucesso/Ignorado/Erro" (filtro por status)

Código de Referência:

csharp
// src/Aluka.WinForms/HistoryForm.cs

private async void BtnDeleteSelected_Click(object sender, EventArgs e)
{
    var selectedIds = new List<int>();
    
    foreach (DataGridViewRow row in dgvHistory.Rows)
    {
        if (Convert.ToBoolean(row.Cells[colSelect.Name].Value))
        {
            var id = (int)row.Cells[colId.Name].Value;
            selectedIds.Add(id);
        }
    }

    if (selectedIds.Count == 0)
    {
        MessageBox.Show("Selecione pelo menos um registo para eliminar.", "Aviso", 
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    var result = MessageBox.Show(
        $"Tem certeza que deseja eliminar {selectedIds.Count} registos do histórico?",
        "Confirmar Eliminação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (result == DialogResult.Yes)
    {
        await _historyService.DeleteHistoryAsync(selectedIds);
        await LoadHistoryAsync();
    }
}
6.5 Notificações do Windows (Roadmap)
Descrição do Requisito
O Aluka deve ser capaz de enviar notificações Toast do Windows para informar o utilizador sobre eventos importantes.

Especificação
Propriedade	Descrição	Valores Possíveis
Evento	O que desencadeia a notificação	Execução de regra, erro, aviso
Tipo	Nível de importância	Informação, Aviso, Erro
Atraso	Tempo entre evento e notificação	0s, 5s, 10s, 30s, 60s
Repetição	Número de vezes que a notificação é enviada	1, 2, 3, 5, 10, Infinito
Intervalo	Tempo entre repetições	1min, 5min, 10min, 30min, 1h
Duração	Tempo que a notificação fica visível	Curto (5s), Longo (25s)
Configuração por Regra
Na criação/edição de regras, adicionar secção de notificações:

text
┌─────────────────────────────────────────────────────┐
│  🔔 NOTIFICAÇÕES                                  │
│  ☑️ Notificar quando executar                     │
│  Tipo: [Informação ▼]                             │
│  Atraso: [0 ▼] segundos                          │
│  Repetir: [1 ▼] vez(es)                          │
│  Intervalo: [5 ▼] minutos                        │
│  Duração: [Curta ▼]                              │
└─────────────────────────────────────────────────────┘
Implementação Técnica
csharp
// src/Aluka.Infrastructure/Services/NotificationService.cs

using Microsoft.Toolkit.Uwp.Notifications;

public class NotificationService
{
    public void SendToast(string title, string message, NotificationType type = NotificationType.Information)
    {
        var builder = new ToastContentBuilder()
            .AddText(title)
            .AddText(message)
            .AddAppLogoOverride(new Uri("ms-appx:///Assets/aluka.png"), ToastGenericAppLogoCrop.Circle);

        switch (type)
        {
            case NotificationType.Success:
                builder.AddVisualChild(new ToastGenericAttributionText() { Text = "✅" });
                break;
            case NotificationType.Warning:
                builder.AddVisualChild(new ToastGenericAttributionText() { Text = "⚠️" });
                break;
            case NotificationType.Error:
                builder.AddVisualChild(new ToastGenericAttributionText() { Text = "❌" });
                break;
        }

        builder.Show();
    }
}
7. Requisitos para Próximas Versões
7.1 Funcionalidades Prioritárias (V1.1)
ID	Funcionalidade	Descrição	Prioridade
R01	Filtro de Apps no Editor	Pesquisa e exclusão de apps de sistema	🔴 Alta
R02	Gestão de Histórico	Eliminar registos individuais e em lote	🔴 Alta
R03	Comportamento de Abertura	Trazer janela ao primeiro plano sem roubar foco	🔴 Alta
R04	Notificações Windows	Toast notifications configuráveis	🔴 Alta
7.2 Funcionalidades de Médio Prazo (V1.2)
ID	Funcionalidade	Descrição	Prioridade
R05	Contextos/Perfis	Agrupar regras em perfis (ex: "Trabalho", "Estudo")	🟡 Média
R06	Fecho Inteligente	Tentar guardar documentos antes de fechar	🟡 Média
R07	Exportar/Importar Configurações	Backup e partilha de regras	🟡 Média
7.3 Funcionalidades de Longo Prazo (V2.0)
ID	Funcionalidade	Descrição	Prioridade
R08	Licenciamento Premium	Regras ilimitadas, suporte prioritário	🟢 Baixa
R09	Sincronização na Cloud	Backup das regras online	🟢 Baixa
R10	Internacionalização	Suporte a PT-BR, EN-US, ES-ES	🟢 Baixa
8. Guia de Configuração e Desenvolvimento
8.1 Requisitos de Desenvolvimento
Ferramenta	Versão	Propósito
Visual Studio 2022	17.8+	IDE de desenvolvimento
.NET SDK	8.0.x	Framework
SQLite Browser	3.12+	Visualização de base de dados
Git	2.40+	Controlo de versões
8.2 Configuração do Ambiente
powershell
# Clonar o repositório
git clone <repository-url>
cd Aluka

# Restaurar pacotes
dotnet restore

# Compilar
dotnet build

# Executar
dotnet run --project src\Aluka.WinForms
8.3 Estrutura da Base de Dados
Localização: src\Aluka.WinForms\bin\Debug\net8.0-windows\aluka.db

Acesso via DBeaver/SQLiteBrowser:

Abrir conexão SQLite

Selecionar ficheiro aluka.db

Navegar pelas tabelas

8.4 Logs
Localização: src\Aluka.WinForms\logs\aluka-YYYYMMDD.txt

Níveis de Log:

Information (Info)

Warning (Warn)

Error (Error)

Debug (Debug)

9. Especificações Técnicas Detalhadas
9.1 Tecnologias e Bibliotecas
Componente	Tecnologia	Versão
Linguagem	C#	12
Framework	.NET	8.0 (LTS)
UI Desktop	Windows Forms	.NET 8
ORM	Entity Framework Core	8.0.x
BD Local	SQLite	3.40+
DI Container	Microsoft.Extensions.DependencyInjection	8.0.x
Logging	Serilog	3.1.x
Testing	xUnit	2.5.x
Mocking	Moq	4.20.x
AutoMapper	AutoMapper	12.0.x
FluentValidation	FluentValidation	11.9.x
9.2 Pacotes NuGet
xml
<!-- Aluka.Infrastructure.csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
<PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="8.0.0" />
<PackageReference Include="System.Management" Version="8.0.0" />
<PackageReference Include="Microsoft.Win32.Registry" Version="5.0.0" />
<PackageReference Include="System.Drawing.Common" Version="8.0.0" />
<PackageReference Include="Microsoft.Extensions.Hosting" Version="8.0.0" />

<!-- Aluka.Application.csproj -->
<PackageReference Include="AutoMapper" Version="12.0.1" />
<PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
<PackageReference Include="FluentValidation" Version="11.9.0" />
<PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.9.0" />
<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />

<!-- Aluka.WinForms.csproj -->
<PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.0" />
<PackageReference Include="Microsoft.Extensions.Hosting" Version="8.0.0" />
<PackageReference Include="Serilog" Version="3.1.1" />
<PackageReference Include="Serilog.Sinks.File" Version="5.0.0" />
<PackageReference Include="Serilog.Sinks.Console" Version="5.0.0" />
9.3 Variáveis de Configuração
json
// appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=aluka.db"
  },
  "Logging": {
    "MinimumLevel": "Information"
  },
  "Scheduler": {
    "IntervalSeconds": 30
  }
}
📝 Notas Finais
Documentação Complementar
Documentação do Utilizador

Documentação do Programador

Guia de Contribuição

Contacto
Autor: José Jacinto Francisco
Email: [adicionar email]
Website: aluka.dev (planeado)

Última Atualização: 20 de Agosto de 2026
Versão: 3.0.0