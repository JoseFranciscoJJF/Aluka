Aluka - Sistema de Gestão de Foco e Produtividade (Versão Estendida)
Por: José Jacinto Francisco
Versão: 2.0.0 (Versão Extensiva + Licenciamento + Internacionalização)
Data: 31 de Julho de 2026
Estado: Arquitetura Detalhada e Plano de Implementação
Licença: Comercial com Licenciamento Temporário

📋 Índice
Visão Geral do Projeto

Problema e Contexto

Solução Proposta

Arquitetura Detalhada da Solução

Estrutura de Pastas e Projetos

Tecnologias, Bibliotecas e Pacotes

Modelo de Dados Detalhado

Funcionalidades e Especificações

Regras de Negócio Detalhadas

Sistema de Licenciamento e Segurança

Internacionalização e Suporte a Múltiplos Idiomas

Padrões de Design e Boas Práticas

Estratégia de Testes e Qualidade

Plano de Implementação Detalhado

Estratégia de Deploy e Distribuição

Documentação e Suporte

Glossário e Referências

1. Visão Geral do Projeto
1.1 Identificação Completa
Campo	Valor
Nome	Aluka
Significado	Foco, concentração (do kimbundo)
Tipo	Aplicação Desktop para Windows
Linguagem	C# 12
Framework	.NET 8.0 (LTS - Long Term Support)
Plataformas Suportadas	Windows 10 (1809+), Windows 11, Windows Server 2019+
Arquitetura	x64 (com suporte a x86 via compilação separada)
Modelo de Distribuição	Comercial com licenciamento temporário
Idiomas Suportados	Português (PT-PT e PT-BR), Inglês, Espanhol (futuro)
Repositório	GitHub (privado)
Website	aluka.dev (planeado)
1.2 Propósito e Filosofia
O Aluka nasce da necessidade de recuperar o controlo sobre o ambiente digital. Num mundo onde as notificações constantes, a mudança frequente de contexto e a tentação das distrações digitais minam a produtividade, o Aluka surge como um assistente digital discreto e eficaz.

A filosofia do Aluka assenta em quatro pilares:

Autonomia: O utilizador define as regras, a máquina executa. O Aluka não toma decisões, apenas facilita a execução das intenções do utilizador.

Simplicidade: Uma ferramenta poderosa não precisa de ser complexa. A interface é intuitiva, a configuração é visual e o impacto é imediato.

Respeito: O Aluka nunca força o utilizador a nada. Tudo é configurável, ativável e desativável. O utilizador está sempre no controlo.

Acessibilidade: A ferramenta deve estar disponível no idioma do utilizador, respeitando a diversidade linguística e cultural.

1.3 Objetivos Estratégicos (OKRs)
Objetivo	Key Results (KRs)	Métrica
Adoção	500 utilizadores ativos em 6 meses	Utilizadores únicos/mês
Engajamento	70% dos utilizadores com ≥3 regras ativas	Média de regras por utilizador
Retenção	60% de retenção após 30 dias	Utilizadores que continuam ativos após 30 dias
Satisfação	NPS ≥ 50 (Bom)	Pesquisa de satisfação trimestral
Licenciamento	30% de conversão para licenças pagas após trial	Taxa de conversão
Internacionalização	3 idiomas suportados no lançamento	Número de idiomas
2. Problema e Contexto
2.1 O Problema em Números
Estudos e pesquisas recentes evidenciam a magnitude do problema que o Aluka pretende resolver:

300-500 mudanças de contexto por dia para um trabalhador de escritório (Fonte: UC Irvine)

2 horas perdidas diariamente apenas a recuperar o foco após interrupções (Fonte: Harvard Business Review)

28% do tempo de trabalho é desperdiçado em tarefas de "gestão de contexto" (abrir/fechar aplicações, organizar janelas) (Fonte: McKinsey)

47% dos trabalhadores de conhecimento relatam sentir-se sobrecarregados com o número de ferramentas que usam diariamente (Fonte: Gartner)

16% de aumento de produtividade em ambientes onde a gestão de contexto é automatizada (Fonte: MIT Sloan)

2.2 Público-Alvo Segmentado
Segmento	Características	Dores Específicas	Benefício do Aluka
Trabalhadores Remotos	Casa como escritório, múltiplas ferramentas	Dificuldade em separar trabalho/pessoal	Abre apps de trabalho às 9h, fecha às 18h
Estudantes	Estudo autónomo, distrações constantes	Redes sociais durante o estudo	Bloqueia distrações em horários de estudo
Desenvolvedores	Múltiplas IDEs, terminais, navegadores	Perda de contexto entre projetos	Abre ambiente completo para cada projeto
Gestores	Calendário cheio, reuniões constantes	Esquecimento de ferramentas para reuniões	Abre ferramentas antes de cada reunião
Criativos	Designers, músicos, artistas	"Estado de fluxo" facilmente quebrado	Preserva o foco durante blocos de criação
Empresas	Equipas remotas, políticas de IT	Padronização de ambientes de trabalho	Gestão centralizada via licenças corporativas
2.3 Análise de Concorrência
Solução	Forças	Fraquezas	Diferencial Aluka
FocusMe	Muitas funcionalidades	Complexo, caro, intrusivo	Simples, gratuito em trial, respeitoso
Freedom	Bem estabelecido	Foco em bloqueio, não em abertura	Faz abertura E fecho
Cold Turkey	Poderoso	Interface datada	Interface moderna e intuitiva
Forest	Gamificação	Apenas para telemóvel	Desktop-first
Gestão manual	Zero custo	Ineficiente, esquecível	Automático e inteligente
3. Solução Proposta
3.1 Conceito e Proposta de Valor
Aluka é um gestor de contexto digital que permite ao utilizador:

Agendar a abertura automática de aplicações para iniciar blocos de trabalho

Programar o fecho automático de aplicações para terminar períodos de foco

Visualizar todas as aplicações instaladas e gerir as suas regras

Atualizar a lista de aplicações com um simples clique

Utilizar a ferramenta no seu idioma preferido

Proposta de Valor Única:

"O Aluka transforma a tua máquina num ambiente preparado para o que vais fazer, em vez de reativo ao que já estás a fazer."

3.2 Casos de Uso Principais
#	Caso de Uso	Ator	Descrição
UC01	Varrer aplicações	Sistema	O Aluka descobre todas as apps instaladas no sistema
UC02	Listar aplicações	Utilizador	Vê a lista de apps com os respetivos ícones
UC03	Criar regra	Utilizador	Define quando uma app deve abrir ou fechar
UC04	Editar regra	Utilizador	Altera os parâmetros de uma regra existente
UC05	Ativar/Desativar regra	Utilizador	Liga ou desliga uma regra sem a apagar
UC06	Executar regras	Sistema	O motor executa as regras ativas nos momentos certos
UC07	Ver histórico	Utilizador	Consulta o log de execuções
UC08	Ativar licença	Utilizador	Insere chave de licença para desbloquear funcionalidades
UC09	Mudar idioma	Utilizador	Altera o idioma da interface
3.3 Diferenciais Competitivos
Descoberta automática: Nenhuma configuração manual para listar apps

Interface visual: Calendário e lista, não apenas tabelas de texto

Ação dual: Tanto abre como fecha, não apenas bloqueia

Respeitoso: Avisa antes de fechar forçosamente, dá opção de cancelamento

Modelo híbrido: Trial gratuito (30 dias) + licenças pagas (6 meses)

Leve: Consumo mínimo de recursos (RAM < 100MB, CPU < 1%)

Privado: Tudo fica local, zero recolha de dados (exceto validação de licença)

Internacionalizado: Suporte a múltiplos idiomas desde o início

Desenvolvido em C#: Performance e segurança nativas do Windows

4. Arquitetura Detalhada da Solução
4.1 Padrões Arquiteturais Adotados
Padrão	Aplicação no Aluka	Benefício
Clean Architecture	Separação em camadas independentes	Manutenibilidade, testabilidade
Repository Pattern	Abstração do acesso a dados	Desacoplamento, facilidade de teste
Dependency Injection	Inversão de controlo via DI container	Baixo acoplamento, testabilidade
Unit of Work	Transações atómicas na base de dados	Consistência de dados
Strategy Pattern	Diferentes algoritmos de fecho (suave/forçado)	Flexibilidade, extensibilidade
Observer Pattern	Notificações de eventos	UI reativa, desacoplamento
Singleton	Serviços de background, gestão de processos	Controlo centralizado
Factory Pattern	Criação de regras e entidades	Encapsulamento da criação
Proxy Pattern	Validação de licença	Segurança, controlo de acesso
4.2 Arquitetura de Alto Nível com Licenciamento
text
┌─────────────────────────────────────────────────────────────────────────┐
│                             UTILIZADOR                                  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                      CAMADA DE APRESENTAÇÃO                            │
│                    (Aluka.WinForms - Windows Forms)                    │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                    GESTÃO DE IDIOMA                              │  │
│  │  - LocalizationManager (tradução em tempo real)                 │  │
│  │  - ResourceManager (JSON/Resx)                                  │  │
│  │  - LanguageSelector (combobox na UI)                            │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                    INTERFACE PRINCIPAL                           │  │
│  │  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌────────┐ │  │
│  │  │ MainForm    │  │ RulesForm   │  │ AppsForm    │  │History │ │  │
│  │  └─────────────┘  └─────────────┘  └─────────────┘  └────────┘ │  │
│  │  ┌─────────────┐  ┌─────────────┐  ┌─────────────────────────┐ │  │
│  │  │ Calendar    │  │ RuleEditor  │  │ LicenseForm             │ │  │
│  │  └─────────────┘  └─────────────┘  └─────────────────────────┘ │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                      CAMADA DE APLICAÇÃO                               │
│                    (Aluka.Application - Casos de Uso)                  │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                          SERVICOS                                │  │
│  │  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐  │  │
│  │  │   RuleService   │ │  AppService     │ │ HistoryService  │  │  │
│  │  └─────────────────┘ └─────────────────┘ └─────────────────┘  │  │
│  │  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐  │  │
│  │  │ProcessManager   │ │LicenseService   │ │  I18nService    │  │  │
│  │  └─────────────────┘ └─────────────────┘ └─────────────────┘  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                        CAMADA DE DOMÍNIO                               │
│                      (Aluka.Domain - Entidades)                        │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  ┌──────────────┐ ┌──────────────┐ ┌──────────────┐ ┌────────┐│  │
│  │  │  Aplicacao   │ │ RegraAgend.  │ │ Historico    │ │ License││  │
│  │  └──────────────┘ └──────────────┘ └──────────────┘ └────────┘│  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                     CAMADA DE INFRAESTRUTURA                           │
│                      (Aluka.Infrastructure)                            │
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
│  │  ┌──────────────────────────────────────────────────────────┐  │  │
│  │  │  LicenseValidator (Licensing Server Communication)      │  │  │
│  │  └──────────────────────────────────────────────────────────┘  │  │
│  │  ┌──────────────────────────────────────────────────────────┐  │  │
│  │  │  Localization (JSON Resource Provider)                 │  │  │
│  │  └──────────────────────────────────────────────────────────┘  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                           SISTEMA OPERACIONAL                          │
│                          (Windows 10/11)                               │
└─────────────────────────────────────────────────────────────────────────┘
4.3 Fluxos de Dados Detalhados
Fluxo 1: Varrimento de Aplicações
text
[USER] → Clica "Atualizar Apps"
    ↓
[UI] → AppService.ScanAppsAsync()
    ↓
[Application] → RegistryScanner.ScanRegistry()
    ↓
[Infrastructure] → Access: HKLM + HKCU Uninstall keys
    ↓
[Infrastructure] → For each entry with DisplayName:
    ↓
[Infrastructure] → Get InstallLocation (or search for .exe)
    ↓
[Infrastructure] → ExtractAssociatedIcon()
    ↓
[Infrastructure] → Convert icon to Base64
    ↓
[Application] → Compare with existing apps in DB
    ↓
[Application] → Add new apps, mark missing as inactive
    ↓
[Application] → Return updated list to UI
    ↓
[UI] → Refresh ListView with icons
    ↓
[USER] → Visual confirmation
Fluxo 2: Validação de Licença
text
[USER] → Insere chave de licença no LicenseForm
    ↓
[UI] → LicenseService.ValidateLicenseAsync(licenseKey)
    ↓
[Application] → Criptografia: AES-256 decrypt da chave
    ↓
[Application] → Extrair: {ClientId, ValidityDate, Signature}
    ↓
[Application] → Verificar assinatura RSA com chave pública
    ↓
[Application] → Verificar se data atual < ValidityDate
    ↓
[Application] → [OPCIONAL] Contactar servidor de licenciamento
    ↓
[Application] → Se válida: Atualizar licença na DB (SQLite)
    ↓
[Application] → Se inválida: Mostrar erro (traduzido)
    ↓
[UI] → Atualizar status de licença (válida/inválida)
    ↓
[UI] → Liberar/restaurar funcionalidades conforme licença
Fluxo 3: Execução de Regra (Abertura)
text
[Background Scheduler] → Timer ticks (a cada 60s)
    ↓
[Scheduler] → Query: SELECT * FROM RegraAgendamento 
              WHERE EstaAtivo = 1 AND (DiasSemana & @Today) > 0
              AND HoraInicio <= @CurrentTime AND HoraFim >= @CurrentTime
    ↓
[Application] → For each rule:
    ↓
[Application] → ProcessManager.IsRunning(app.CaminhoExecutavel)
    ↓
[Infrastructure] → System.Diagnostics.Process.GetProcessesByName()
    ↓
[Application] → IF (not running):
    ↓
[Application] → ProcessManager.OpenApplication(app.CaminhoExecutavel)
    ↓
[Infrastructure] → Process.Start(ProcessStartInfo)
    ↓
[Application] → HistoryService.AddEntry(ruleId, Success)
    ↓
[Infrastructure] → Save to database
    ↓
[Scheduler] → Wait next tick
Fluxo 4: Mudança de Idioma
text
[USER] → Seleciona novo idioma no combobox
    ↓
[UI] → I18nService.ChangeLanguage("pt-PT", "en-US", etc.)
    ↓
[Application] → Carrega JSON de tradução correspondente
    ↓
[Application] → Notifica observers (UI components)
    ↓
[UI] → Cada controlo recalcula seu texto:
         - Labels: ResourceManager.GetString("label_key")
         - Menus: ResourceManager.GetString("menu_key")
         - Botões: ResourceManager.GetString("button_key")
         - Mensagens: ResourceManager.GetString("message_key")
    ↓
[UI] → Refresh imediato da interface
    ↓
[USER] → Interface completamente traduzida
5. Estrutura de Pastas e Projetos (Atualizada)
5.1 Estrutura da Solution
text
Aluka.sln
│
├── 📁 src/
│   ├── 📁 Aluka.WinForms/                    # Camada de Apresentação
│   │   ├── 📁 Properties/
│   │   │   ├── Resources.resx                # Recursos (ícones, strings)
│   │   │   ├── Settings.settings             # Configurações do projeto
│   │   │   └── AssemblyInfo.cs
│   │   ├── 📁 Forms/
│   │   │   ├── MainForm.cs                   # Formulário principal
│   │   │   ├── MainForm.Designer.cs
│   │   │   ├── RulesForm.cs                  # Lista de regras
│   │   │   ├── RulesForm.Designer.cs
│   │   │   ├── RuleEditorForm.cs             # Edição de regras
│   │   │   ├── RuleEditorForm.Designer.cs
│   │   │   ├── AppsForm.cs                   # Lista de aplicações
│   │   │   ├── AppsForm.Designer.cs
│   │   │   ├── HistoryForm.cs                # Histórico de execuções
│   │   │   ├── HistoryForm.Designer.cs
│   │   │   ├── SettingsForm.cs               # Configurações da app
│   │   │   ├── SettingsForm.Designer.cs
│   │   │   ├── LicenseForm.cs                # Gestão de licença
│   │   │   └── LicenseForm.Designer.cs
│   │   ├── 📁 Controls/                      # Controlos customizados
│   │   │   ├── AppListItem.cs                # Item da lista de apps
│   │   │   ├── AppListItem.Designer.cs
│   │   │   ├── RuleCard.cs                   # Card visual de regra
│   │   │   ├── RuleCard.Designer.cs
│   │   │   ├── SchedulerCalendar.cs          # Visualização em calendário
│   │   │   └── SchedulerCalendar.Designer.cs
│   │   ├── 📁 Services/                      # Serviços da UI
│   │   │   ├── FormNavigationService.cs      # Navegação entre forms
│   │   │   ├── DialogService.cs              # Caixas de diálogo
│   │   │   └── NotificationService.cs        # Notificações do sistema
│   │   ├── 📁 Localization/                  # Gestão de idiomas
│   │   │   ├── 📁 Resources/                 # Ficheiros de tradução
│   │   │   │   ├── 📁 pt-PT/
│   │   │   │   │   ├── strings.json         # Traduções PT-PT
│   │   │   │   │   └── messages.json        
│   │   │   │   ├── 📁 pt-BR/
│   │   │   │   │   ├── strings.json         # Traduções PT-BR
│   │   │   │   │   └── messages.json
│   │   │   │   ├── 📁 en-US/
│   │   │   │   │   ├── strings.json         # Traduções EN-US
│   │   │   │   │   └── messages.json
│   │   │   │   └── 📁 es-ES/
│   │   │   │       ├── strings.json         # Traduções ES-ES
│   │   │   │       └── messages.json
│   │   │   ├── LocalizationManager.cs        # Gestor central de tradução
│   │   │   ├── IResourceProvider.cs          # Interface para provider de recursos
│   │   │   ├── JsonResourceProvider.cs       # Provider baseado em JSON
│   │   │   └── ResourceKey.cs                # Definição de chaves de recurso
│   │   ├── 📁 Extensions/                    # Métodos de extensão
│   │   │   ├── ControlExtensions.cs
│   │   │   ├── ImageExtensions.cs
│   │   │   └── LocalizationExtensions.cs     # Extensões para tradução
│   │   ├── 📁 Helpers/                       # Classes auxiliares
│   │   │   ├── Win32Native.cs                # P/Invoke para Win32
│   │   │   ├── IconExtractor.cs              # Extração de ícones
│   │   │   └── RegistryHelper.cs             # Acesso ao registo
│   │   ├── 📁 Resources/                     # Recursos embutidos
│   │   │   ├── Icons/
│   │   │   │   ├── aluka.ico                 # Ícone da aplicação
│   │   │   │   ├── app_generic.ico          # Ícone genérico para apps
│   │   │   │   └── error.ico                
│   │   │   └── Images/
│   │   │       ├── logo.png
│   │   │       └── banner.png
│   │   ├── appsettings.json                  # Configurações da app
│   │   ├── appsettings.Development.json      # Configurações em dev
│   │   ├── Program.cs                        # Ponto de entrada
│   │   ├── Aluka.WinForms.csproj
│   │   └── README.md                         # Documentação específica
│   │
│   ├── 📁 Aluka.Application/                 # Camada de Aplicação
│   │   ├── 📁 Services/
│   │   │   ├── IRuleService.cs
│   │   │   ├── RuleService.cs                # Gestão de regras
│   │   │   ├── IAppService.cs
│   │   │   ├── AppService.cs                 # Gestão de aplicações
│   │   │   ├── IHistoryService.cs
│   │   │   ├── HistoryService.cs             # Gestão de histórico
│   │   │   ├── IProcessManagerService.cs
│   │   │   ├── ProcessManagerService.cs      # Gestão de processos
│   │   │   ├── ILicenseService.cs
│   │   │   ├── LicenseService.cs             # Gestão de licenças
│   │   │   ├── II18nService.cs
│   │   │   └── I18nService.cs                # Gestão de internacionalização
│   │   ├── 📁 DTOs/                          # Data Transfer Objects
│   │   │   ├── RuleDTO.cs
│   │   │   ├── AppDTO.cs
│   │   │   ├── HistoryDTO.cs
│   │   │   ├── CreateRuleDTO.cs
│   │   │   ├── UpdateRuleDTO.cs
│   │   │   ├── LicenseDTO.cs
│   │   │   ├── LicenseValidationResult.cs
│   │   │   └── StatisticsDTO.cs
│   │   ├── 📁 Validators/                    # Validação de dados
│   │   │   ├── CreateRuleDTOValidator.cs
│   │   │   ├── UpdateRuleDTOValidator.cs
│   │   │   └── LicenseKeyValidator.cs
│   │   ├── 📁 Mappings/                      # Mapeamentos AutoMapper
│   │   │   ├── ApplicationProfile.cs
│   │   │   ├── RuleProfile.cs
│   │   │   ├── HistoryProfile.cs
│   │   │   └── LicenseProfile.cs
│   │   ├── 📁 Exceptions/                    # Exceções personalizadas
│   │   │   ├── AppNotFoundException.cs
│   │   │   ├── RuleConflictException.cs
│   │   │   ├── ProcessAccessDeniedException.cs
│   │   │   ├── LicenseExpiredException.cs
│   │   │   └── InvalidLicenseKeyException.cs
│   │   ├── 📁 Security/                      # Segurança e criptografia
│   │   │   ├── LicenseCrypto.cs              # Criptografia de licenças
│   │   │   ├── LicenseGenerator.cs           # Geração de licenças (server)
│   │   │   └── LicenseValidator.cs           # Validação de licenças (client)
│   │   ├── Aluka.Application.csproj
│   │   └── README.md
│   │
│   ├── 📁 Aluka.Domain/                      # Camada de Domínio
│   │   ├── 📁 Entities/
│   │   │   ├── BaseEntity.cs                 # Classe base para entidades
│   │   │   ├── Aplicacao.cs                  # Entidade de aplicação
│   │   │   ├── RegraAgendamento.cs           # Entidade de regra
│   │   │   ├── HistoricoExecucao.cs          # Entidade de histórico
│   │   │   └── LicenseInfo.cs                # Entidade de licença
│   │   ├── 📁 Enums/                         # Enumerações
│   │   │   ├── TipoAcao.cs                   # Abrir/Fechar
│   │   │   ├── DiasSemana.cs                 # Flags para dias da semana
│   │   │   ├── StatusExecucao.cs             # Sucesso/Erro/Ignorado
│   │   │   ├── LicenseStatus.cs              # Válida/Expirada/Inválida
│   │   │   └── SupportedLanguage.cs          # Idiomas suportados
│   │   ├── 📁 Interfaces/                    # Interfaces de repositórios
│   │   │   ├── IRepository.cs
│   │   │   ├── IApplicationRepository.cs
│   │   │   ├── IRuleRepository.cs
│   │   │   ├── IHistoryRepository.cs
│   │   │   ├── ILicenseRepository.cs
│   │   │   └── IUnitOfWork.cs
│   │   ├── 📁 Specifications/                # Especificações (Domain-Driven)
│   │   │   ├── RuleSpecification.cs
│   │   │   ├── ActiveRulesSpecification.cs
│   │   │   └── AppNameContainsSpecification.cs
│   │   ├── 📁 Events/                        # Eventos de domínio
│   │   │   ├── RuleExecutedEvent.cs
│   │   │   ├── AppScannedEvent.cs
│   │   │   ├── RuleActivatedEvent.cs
│   │   │   └── LicenseValidatedEvent.cs
│   │   ├── Aluka.Domain.csproj
│   │   └── README.md
│   │
│   ├── 📁 Aluka.Infrastructure/              # Camada de Infraestrutura
│   │   ├── 📁 Data/
│   │   │   ├── AppDbContext.cs               # Contexto EF Core
│   │   │   ├── 📁 Configurations/
│   │   │   │   ├── AplicacaoConfiguration.cs
│   │   │   │   ├── RegraAgendamentoConfiguration.cs
│   │   │   │   ├── HistoricoExecucaoConfiguration.cs
│   │   │   │   └── LicenseInfoConfiguration.cs
│   │   │   ├── 📁 Repositories/
│   │   │   │   ├── Repository.cs             # Implementação genérica
│   │   │   │   ├── ApplicationRepository.cs
│   │   │   │   ├── RuleRepository.cs
│   │   │   │   ├── HistoryRepository.cs
│   │   │   │   └── LicenseRepository.cs
│   │   │   ├── 📁 Migrations/                # Migrações EF Core
│   │   │   │   ├── 20260731000000_InitialCreate.cs
│   │   │   │   └── AppDbContextModelSnapshot.cs
│   │   │   └── UnitOfWork.cs                 # Implementação Unit of Work
│   │   ├── 📁 Services/
│   │   │   ├── WindowsProcessManager.cs      # Gestão de processos Windows
│   │   │   ├── RegistryScanner.cs            # Varrimento do registo
│   │   │   ├── BackgroundScheduler.cs        # Motor de execução
│   │   │   ├── NotificationService.cs        # Notificações do sistema
│   │   │   ├── LicenseValidator.cs           # Validação de licenças
│   │   │   ├── LicenseServerClient.cs        # Comunicação com servidor
│   │   │   ├── JsonResourceProvider.cs       # Provider de tradução JSON
│   │   │   └── 📁 Interop/                   # Interoperabilidade nativa
│   │   │       ├── User32.cs                 # Win32 API
│   │   │       ├── Kernel32.cs
│   │   │       └── Shell32.cs
│   │   ├── Aluka.Infrastructure.csproj
│   │   └── README.md
│   │
│   └── 📁 Aluka.Infrastructure.IoC/          # Configuração de DI
│       ├── DependencyInjection.cs            # Registo de serviços
│       ├── Aluka.Infrastructure.IoC.csproj
│       └── README.md
│
├── 📁 tests/
│   ├── 📁 Aluka.Tests.Unit/                  # Testes Unitários
│   │   ├── 📁 Application/
│   │   │   ├── RuleServiceTests.cs
│   │   │   ├── AppServiceTests.cs
│   │   │   ├── HistoryServiceTests.cs
│   │   │   └── LicenseServiceTests.cs
│   │   ├── 📁 Domain/
│   │   │   └── RegraAgendamentoTests.cs
│   │   ├── 📁 Infrastructure/
│   │   │   ├── RegistryScannerTests.cs
│   │   │   └── LicenseValidatorTests.cs
│   │   ├── 📁 Security/
│   │   │   └── LicenseCryptoTests.cs
│   │   └── Aluka.Tests.Unit.csproj
│   │
│   ├── 📁 Aluka.Tests.Integration/           # Testes de Integração
│   │   ├── 📁 Data/
│   │   │   ├── AppDbContextTests.cs
│   │   │   └── RepositoryTests.cs
│   │   ├── 📁 Services/
│   │   │   ├── ProcessManagerIntegrationTests.cs
│   │   │   └── SchedulerIntegrationTests.cs
│   │   └── Aluka.Tests.Integration.csproj
│   │
│   └── 📁 Aluka.Tests.UI/                    # Testes de Interface
│       ├── 📁 Screenshots/                   # Capturas de tela para testes
│       ├── MainFormUITests.cs
│       └── Aluka.Tests.UI.csproj
│
├── 📁 docs/                                  # Documentação
│   ├── 📁 architecture/
│   │   ├── clean-architecture.md
│   │   ├── licensing-system.md
│   │   └── localization-system.md
│   ├── 📁 user-guide/
│   │   ├── getting-started.md
│   │   ├── creating-rules.md
│   │   └── managing-licenses.md
│   ├── 📁 developer/
│   │   ├── building-from-source.md
│   │   ├── contributing.md
│   │   └── api-reference.md
│   └── README.md
│
├── 📁 scripts/                               # Scripts de automação
│   ├── build.ps1                             # Script de build
│   ├── test.ps1                              # Script de testes
│   ├── deploy.ps1                            # Script de deploy
│   ├── generate-license.ps1                  # Geração de licenças
│   └── update-translations.ps1               # Atualização de traduções
│
├── 📁 tools/                                 # Ferramentas auxiliares
│   ├── 📁 LicenseGenerator/                  # Ferramenta de geração de licenças
│   │   ├── Program.cs
│   │   └── LicenseGenerator.csproj
│   └── 📁 TranslationHelper/                 # Ferramenta de gestão de traduções
│       ├── Program.cs
│       └── TranslationHelper.csproj
│
├── Aluka.sln
├── .gitignore
├── LICENSE
├── README.md
└── CHANGELOG.md
6. Tecnologias, Bibliotecas e Pacotes (Atualizada)
6.1 Stack Tecnológico Principal
Componente	Tecnologia	Versão	Justificativa
Linguagem	C#	12 (com .NET 8)	Performance, segurança, maturidade
Framework	.NET 8 (LTS)	8.0.x	Suporte a longo prazo, grátis, multiplataforma
UI Desktop	Windows Forms	.NET 8	Performance nativa, curva de aprendizagem suave
ORM	Entity Framework Core	8.0.x	Mapeamento objeto-relacional, migrations automáticas
BD Local	SQLite	3.40+	Leve, embutido, sem servidor, grátis
DI Container	Microsoft.Extensions.DependencyInjection	8.0.x	Nativo, integrado com .NET
Logging	Serilog	3.1.x	Log estruturado, flexível, suporte a ficheiros
Testing	xUnit	2.5.x	Framework de testes moderno
Mocking	Moq	4.20.x	Mocking para testes unitários
AutoMapper	AutoMapper	12.0.x	Mapeamento DTO ↔ Entidades
FluentValidation	FluentValidation	11.9.x	Validação declarativa de modelos
6.2 Bibliotecas de Suporte (Atualizado)
Biblioteca	Propósito	Versão	Justificativa
System.Management	Acesso a WMI para gestão de processos	.NET 8	Nativo, integrado
System.Drawing.Common	Manipulação de ícones e imagens	8.0.x	Nativo, eficiente
Microsoft.Win32.Registry	Acesso ao registo do Windows	.NET 8	Nativo, necessário
Newtonsoft.Json	Serialização de configurações e licenças	13.0.x	Padrão, confiável
System.Text.Json	Serialização para comunicação com servidor	.NET 8	Performance, nativo
Microsoft.Extensions.Hosting	Hosting para background services	8.0.x	Gestão de ciclo de vida
System.Security.Cryptography	Criptografia de licenças	.NET 8	Nativo, segurança
BouncyCastle	Criptografia avançada (RSA)	2.2.x	Alternativa para licenças
System.Reactive	Programação reativa para UI	6.0.x	UI reativa, notificações
Microsoft.Extensions.Localization	Localização nativa .NET	8.0.x	Alternativa para i18n
6.3 Pacotes NuGet (Lista Completa)
xml
<!-- Aluka.WinForms.csproj -->
<PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.0" />
<PackageReference Include="Microsoft.Extensions.Hosting" Version="8.0.0" />
<PackageReference Include="Serilog" Version="3.1.1" />
<PackageReference Include="Serilog.Sinks.File" Version="5.0.0" />
<PackageReference Include="Serilog.Sinks.Console" Version="5.0.0" />
<PackageReference Include="AutoMapper.Extensions.Microsoft.DependencyInjection" Version="12.0.1" />
<PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.9.0" />
<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
<PackageReference Include="System.Reactive" Version="6.0.0" />
<PackageReference Include="Microsoft.Extensions.Localization" Version="8.0.0" />

<!-- Aluka.Application.csproj -->
<PackageReference Include="AutoMapper" Version="12.0.1" />
<PackageReference Include="FluentValidation" Version="11.9.0" />
<PackageReference Include="Newtonsoft.Json" Version="13.0.3" />
<PackageReference Include="System.Security.Cryptography" Version="4.3.0" />
<PackageReference Include="Portable.BouncyCastle" Version="1.9.0" />

<!-- Aluka.Infrastructure.csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
<PackageReference Include="Microsoft.Extensions.Configuration.Json" Version="8.0.0" />
<PackageReference Include="System.Management" Version="8.0.0" />
<PackageReference Include="Microsoft.Win32.Registry" Version="5.0.0" />
<PackageReference Include="System.Drawing.Common" Version="8.0.0" />

<!-- Aluka.Infrastructure.IoC.csproj -->
<PackageReference Include="Microsoft.Extensions.DependencyInjection" Version="8.0.0" />

<!-- Aluka.Tests.Unit.csproj -->
<PackageReference Include="xUnit" Version="2.5.0" />
<PackageReference Include="xUnit.runner.visualstudio" Version="2.5.0" />
<PackageReference Include="Moq" Version="4.20.70" />
<PackageReference Include="FluentAssertions" Version="6.12.0" />

<!-- Aluka.Tests.Integration.csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore.InMemory" Version="8.0.0" />
<PackageReference Include="Testcontainers" Version="3.7.0" />
6.4 Análise de Viabilidade Técnica
Funcionalidade	Viabilidade	Desafios	Solução Proposta
Listagem automática de apps	✅ Alta	Apps em atalhos, sem caminho direto	Varredura do registo + fallback para utilizador
Extração de ícones	✅ Alta	.exe podem não ter ícone embutido	Extrair do .exe ou atalho
Abertura de aplicações	✅ Alta	Permissões administrativas	Executar como admin para apps protegidas
Fecho forçado	✅ Alta	Perda de dados não guardados	Aviso e confirmação na UI
Agendamento em background	✅ Alta	Processo pode ser encerrado	Instalar como Windows Service opcional
SQLite com EF Core	✅ Alta	Migrações em ambiente desktop	Configurar migrations automáticas
Licenciamento offline	✅ Alta	Validação sem servidor	Chave criptografada com assinatura RSA
Licenciamento online	✅ Média	Dependência de servidor	Comunicação HTTPS com fallback offline
Internacionalização	✅ Alta	Gestão de traduções dinâmicas	JSON resources + LocalizationManager
Suporte a múltiplos idiomas	✅ Alta	Mudança em tempo real	Observer pattern + Refresh da UI
Segurança da licença	⚠️ Média	Engenharia reversa	Ofuscação de código + Anti-debug
7. Modelo de Dados Detalhado
7.1 Diagrama Entidade-Relacionamento (ER) Atualizado
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

┌─────────────────────┐          ┌─────────────────────────┐
│   LicenseInfo       │          │   AuditLog              │
├─────────────────────┤          ├─────────────────────────┤
│ Id (PK)             │          │ Id (PK)                 │
│ LicenseKey          │          │ Entidade                │
│ ClientId            │          │ Acao (Create/Update/Delete)│
│ ValidityDate        │          │ Data                    │
│ IsValid             │          │ Utilizador              │
│ ActivationDate      │          │ Detalhes (JSON)         │
│ ExpirationDate      │          └─────────────────────────┘
│ CreatedAt           │
│ UpdatedAt           │
└─────────────────────┘
7.2 Scripts SQL (SQLite com Licenciamento)
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
    TipoAcao INTEGER NOT NULL, -- 0=Abrir, 1=Fechar
    DiasSemana INTEGER NOT NULL, -- Bitmask (1=Dom,2=Seg,...128=Sáb)
    HoraInicio TEXT NOT NULL, -- HH:mm:ss
    HoraFim TEXT NOT NULL,   -- HH:mm:ss
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
    Status INTEGER NOT NULL, -- 0=Sucesso, 1=Erro, 2=Ignorado
    MensagemErro TEXT,
    DuracaoMs INTEGER,
    FOREIGN KEY (RegraAgendamentoId) REFERENCES RegraAgendamento(Id)
);

-- Tabela LicenseInfo (Nova)
CREATE TABLE LicenseInfo (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    LicenseKey TEXT NOT NULL,
    ClientId TEXT NOT NULL,
    ValidityDate TEXT NOT NULL,
    IsValid INTEGER NOT NULL DEFAULT 0,
    ActivationDate TEXT,
    ExpirationDate TEXT,
    CreatedAt TEXT NOT NULL,
    UpdatedAt TEXT NOT NULL
);

-- Tabela AuditLog (Nova)
CREATE TABLE AuditLog (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Entidade TEXT NOT NULL,
    Acao TEXT NOT NULL,
    Data TEXT NOT NULL,
    Utilizador TEXT NOT NULL,
    Detalhes TEXT
);

-- Índices para performance
CREATE INDEX idx_regra_agendamento_aplicacao ON RegraAgendamento(AplicacaoId);
CREATE INDEX idx_regra_agendamento_ativo ON RegraAgendamento(EstaAtivo);
CREATE INDEX idx_historico_regra ON HistoricoExecucao(RegraAgendamentoId);
CREATE INDEX idx_historico_data ON HistoricoExecucao(DataExecucao);
CREATE INDEX idx_license_valid ON LicenseInfo(IsValid);
CREATE INDEX idx_audit_entidade ON AuditLog(Entidade);
7.3 Entidades de Domínio (C#)
csharp
// Aluka.Domain/Entities/BaseEntity.cs
public abstract class BaseEntity
{
    public int Id { get; protected set; }
    public DateTime DataCriacao { get; protected set; }
    public DateTime DataModificacao { get; protected set; }
    
    protected BaseEntity()
    {
        DataCriacao = DateTime.UtcNow;
        DataModificacao = DateTime.UtcNow;
    }
    
    public void UpdateModificationDate()
    {
        DataModificacao = DateTime.UtcNow;
    }
}

// Aluka.Domain/Entities/Aplicacao.cs
public class Aplicacao : BaseEntity
{
    public string Nome { get; private set; }
    public string CaminhoExecutavel { get; private set; }
    public string? IconeBase64 { get; private set; }
    public DateTime DataUltimaAtualizacao { get; private set; }
    public bool EstaAtivo { get; private set; }
    
    // Navigation Properties
    public virtual ICollection<RegraAgendamento> Regras { get; private set; }
    
    public Aplicacao(string nome, string caminhoExecutavel)
    {
        Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        CaminhoExecutavel = caminhoExecutavel ?? throw new ArgumentNullException(nameof(caminhoExecutavel));
        EstaAtivo = true;
        DataUltimaAtualizacao = DateTime.UtcNow;
        Regras = new List<RegraAgendamento>();
    }
    
    public void AtualizarIcone(string iconeBase64)
    {
        IconeBase64 = iconeBase64;
        DataUltimaAtualizacao = DateTime.UtcNow;
        UpdateModificationDate();
    }
    
    public void MarcarInativo()
    {
        EstaAtivo = false;
        UpdateModificationDate();
    }
    
    public void Reativar()
    {
        EstaAtivo = true;
        UpdateModificationDate();
    }
}

// Aluka.Domain/Entities/RegraAgendamento.cs
public class RegraAgendamento : BaseEntity
{
    public int AplicacaoId { get; private set; }
    public TipoAcao TipoAcao { get; private set; }
    public DiasSemana DiasSemana { get; private set; }
    public TimeOnly HoraInicio { get; private set; }
    public TimeOnly HoraFim { get; private set; }
    public bool EstaAtivo { get; private set; }
    public string? Observacao { get; private set; }
    
    // Navigation Properties
    public virtual Aplicacao Aplicacao { get; private set; }
    public virtual ICollection<HistoricoExecucao> Historico { get; private set; }
    
    public RegraAgendamento(
        int aplicacaoId,
        TipoAcao tipoAcao,
        DiasSemana diasSemana,
        TimeOnly horaInicio,
        TimeOnly horaFim)
    {
        if (horaInicio >= horaFim)
            throw new ArgumentException("Hora de início deve ser anterior à hora de fim.");
            
        AplicacaoId = aplicacaoId;
        TipoAcao = tipoAcao;
        DiasSemana = diasSemana;
        HoraInicio = horaInicio;
        HoraFim = horaFim;
        EstaAtivo = true;
        Historico = new List<HistoricoExecucao>();
    }
    
    public void Ativar() => EstaAtivo = true;
    public void Desativar() => EstaAtivo = false;
    public void Atualizar(RegraAgendamento rule) { /* Implementação */ }
}

// Aluka.Domain/Entities/LicenseInfo.cs
public class LicenseInfo : BaseEntity
{
    public string LicenseKey { get; private set; }
    public string ClientId { get; private set; }
    public DateTime ValidityDate { get; private set; }
    public bool IsValid { get; private set; }
    public DateTime? ActivationDate { get; private set; }
    public DateTime? ExpirationDate { get; private set; }
    
    public LicenseInfo(string licenseKey, string clientId, DateTime validityDate)
    {
        LicenseKey = licenseKey ?? throw new ArgumentNullException(nameof(licenseKey));
        ClientId = clientId ?? throw new ArgumentNullException(nameof(clientId));
        ValidityDate = validityDate;
        IsValid = false;
    }
    
    public void Activate()
    {
        IsValid = true;
        ActivationDate = DateTime.UtcNow;
        ExpirationDate = ValidityDate;
        UpdateModificationDate();
    }
    
    public void Deactivate()
    {
        IsValid = false;
        UpdateModificationDate();
    }
    
    public bool IsExpired()
    {
        return DateTime.UtcNow > ValidityDate;
    }
    
    public TimeSpan GetRemainingTime()
    {
        return ValidityDate - DateTime.UtcNow;
    }
}
8. Funcionalidades e Especificações
8.1 Funcionalidades Core (MVP)
ID	Funcionalidade	Prioridade	Descrição	Estado
F01	Listagem automática de apps	🚀 Crítica	Varre o sistema e apresenta todas as apps instaladas com ícone	A Desenvolver
F02	Criação de regras de agendamento	🚀 Crítica	UI para definir dias, horas, app e ação (abrir/fechar)	A Desenvolver
F03	Serviço de execução em background	🚀 Crítica	Processo que verifica e executa as regras automaticamente	A Desenvolver
F04	Atualização manual da lista de apps	✅ Essencial	Botão "Atualizar" na UI para forçar nova varredura	A Desenvolver
F05	Ativação/desativação de regras	✅ Essencial	Toggle para ligar/desligar regras sem as apagar	A Desenvolver
F06	Histórico de execuções	⭐ Desejável	Log das ações executadas e seus resultados	Planeado
F07	Visualização em calendário	⭐ Desejável	Interface visual estilo calendário para as regras	Planeado
F08	Ativação de licença	🚀 Crítica	Inserir chave de licença para desbloquear funcionalidades	A Desenvolver
F09	Suporte a múltiplos idiomas	🚀 Crítica	Interface em PT-PT, PT-BR, EN-US (ES-ES futuro)	A Desenvolver
8.2 Funcionalidades Avançadas (Futuro)
ID	Funcionalidade	Descrição
F10	Regras por "contexto"	Agrupar regras em perfis (ex: "Trabalho", "Estudo", "Lazer")
F11	Temporizador Pomodoro integrado	Sugerir pausas baseadas no agendamento
F12	Abertura com atraso	Abrir aplicações X minutos depois de outra abrir
F13	Fecho inteligente	Tentar fechar com CloseMainWindow() antes de Kill()
F14	Exportar/Importar configurações	Backup e partilha de regras entre utilizadores
F15	Notificações no sistema	Windows Toast notifications para eventos importantes
F16	Licenciamento corporativo	Gestão de licenças para equipas e empresas
F17	Sincronização de configurações	Backup na cloud das regras (opcional)
8.3 Limitações Conhecidas
Apps UWP/Store: Algumas aplicações da Microsoft Store podem não aparecer no registo de desinstalação tradicional. Será necessário explorar a pasta de atalhos do Menu Iniciar como fallback.

Apps Portáteis: Aplicações que não foram "instaladas" (apenas descompactadas) não têm entrada no registo. O utilizador pode adicioná-las manualmente.

Processos do Sistema: O Aluka não deve tentar fechar processos críticos do Windows (explorer.exe, winlogon.exe, etc.). Haverá uma lista de exclusão.

Perda de Dados: O fecho forçado pode resultar em perda de trabalho. A UI terá avisos claros sobre esta possibilidade.

Permissões: Para fechar algumas aplicações, pode ser necessário executar o Aluka como Administrador.

Licenciamento: Licenças offline dependem da integridade da máquina; engenharia reversa é possível, mas dificultada por ofuscação.

9. Regras de Negócio Detalhadas
9.1 Regras de Listagem de Aplicações
R01 - O processo de varrimento automático deve ocorrer:

Na instalação do Aluka

Sempre que a aplicação é iniciada

Quando o utilizador clica no botão "Atualizar"

R02 - Durante o varrimento:

Devem ser lidas as chaves de registo HKLM e HKCU em ...\Uninstall

Devem ser filtradas entradas com DisplayName vazio

Para apps sem InstallLocation, o sistema deve tentar encontrar o .exe via pesquisa

R03 - Atualização da base de dados:

Novas aplicações detetadas são adicionadas automaticamente

Aplicações que deixaram de existir (o .exe não existe mais) são marcadas como inativas

Ícones são extraídos e guardados em base64 para performance

R04 - Ícones das aplicações:

Devem ser extraídos via Icon.ExtractAssociatedIcon()

Se o ícone não puder ser extraído, usar ícone genérico padrão

9.2 Regras de Agendamento
R05 - Validação de regras:

Uma regra deve ter obrigatoriamente: aplicação, tipo de ação, dias da semana, hora de início e hora de fim

Hora de início deve ser anterior à hora de fim

R06 - Dias da semana:

Representados como bitmask para eficiência

Pode-se selecionar um ou vários dias

R07 - Conflitos:

Se existirem duas regras para a mesma aplicação no mesmo intervalo (uma para abrir, outra para fechar), a aplicação deve decidir pela ação mais recente ou alertar o utilizador

9.3 Regras de Execução
R08 - Serviço de background:

Verifica as regras ativas a cada 60 segundos

Verifica se a aplicação alvo está em execução (via nome do processo)

R09 - Ação de Abertura:

Se a aplicação não estiver a correr, inicia-a via Process.Start(caminho)

Se já estiver a correr, registar no histórico como "Ignorado"

R10 - Ação de Fecho:

Se a aplicação estiver a correr, tenta primeiro CloseMainWindow() (fecho suave)

Se não fechar em 5 segundos, usa Kill() (fecho forçado)

Se já estiver fechada, registar no histórico como "Ignorado"

R11 - Fecho em lote ("Forçar Fecho"):

Não implementado no MVP, mas previsto para versões futuras

O utilizador pode definir uma janela de "exclusão" onde certas apps são forçadas a fechar

9.4 Regras de Licenciamento (NOVO)
R12 - Validação de licença:

A licença é válida por 6 meses a partir da data de ativação

A chave de licença é criptografada com AES-256 e assinada com RSA

A validação pode ser offline (apenas chave) ou online (opcional)

R13 - Comportamento com licença expirada:

A aplicação continua a funcionar em modo "trial" (funcionalidades limitadas)

Apenas funcionalidades premium são bloqueadas (ex: regras ilimitadas, suporte prioritário)

R14 - Gestão de licenças:

O utilizador pode inserir a licença via UI

A licença é armazenada localmente na base de dados SQLite

O sistema verifica a validade a cada 24 horas

R15 - Segurança da licença:

A chave é gerada com HMAC-SHA256 baseado em informação única do hardware

Utiliza MachineID (combinação de MAC Address, CPU ID, Volume Serial)

A chave pública RSA é embutida na aplicação para validação offline

9.5 Regras de Internacionalização (NOVO)
R16 - Idiomas suportados (MVP):

Português (Portugal) - pt-PT

Português (Brasil) - pt-BR

Inglês (Estados Unidos) - en-US

R17 - Carregamento de traduções:

Ficheiros JSON organizados por idioma (strings.json, messages.json)

Carregamento sob demanda (apenas o idioma selecionado)

Fallback para inglês se a chave não existir no idioma selecionado

R18 - Mudança de idioma:

A mudança deve ser aplicada em tempo real, sem reiniciar a aplicação

Todos os formulários abertos devem atualizar imediatamente

O idioma selecionado é salvo nas configurações do utilizador

R19 - Novos textos:

Qualquer novo texto na UI deve ser adicionado aos ficheiros JSON

O sistema deve suportar placeholders (ex: {0}, {1} para valores dinâmicos)

10. Sistema de Licenciamento e Segurança
10.1 Arquitetura do Sistema de Licenciamento
text
┌─────────────────────────────────────────────────────────────────────────┐
│                         SERVIDOR DE LICENÇAS                           │
│                         (backend.aluka.dev)                           │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  - Geração de chaves RSA (pública + privada)                   │  │
│  │  - Criação de licenças com:                                    │  │
│  │    - ClientId (gerado automaticamente)                        │  │
│  │    - ValidityDate (6 meses a partir da compra)                │  │
│  │    - Signature (assinada com chave privada)                   │  │
│  │  - API REST para validação online (opcional)                  │  │
│  │  - Gestão de licenças (ativas, expiradas, revogadas)          │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                    │                                  │
│                                    ▼                                  │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                    COMUNICAÇÃO HTTPS                             │  │
│  │  - Request: {licenseKey, clientId, machineId}                   │  │
│  │  - Response: {status, message, remainingDays}                   │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
┌─────────────────────────────────────────────────────────────────────────┐
│                         APLICAÇÃO CLIENTE (Aluka)                      │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  LICENÇA (Armazenada em SQLite)                                │  │
│  │  - LicenseKey (string)                                         │  │
│  │  - ClientId (string)                                           │  │
│  │  - ValidityDate (DateTime)                                     │  │
│  │  - IsValid (bool)                                              │  │
│  │  - ActivationDate (DateTime)                                   │  │
│  │  - ExpirationDate (DateTime)                                   │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                    │                                  │
│                                    ▼                                  │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  VALIDAÇÃO DA LICENÇA                                           │  │
│  │  - Decriptografia: AES-256 da chave                            │  │
│  │  - Extração: {ClientId, ValidityDate, Signature}               │  │
│  │  - Verificação: RSA com chave pública (embutida)              │  │
│  │  - Verificação de data: ValidityDate > DateTime.Now            │  │
│  │  - [OPCIONAL] Contactar servidor para validar revogação        │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                    │                                  │
│                                    ▼                                  │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │  RESULTADO DA VALIDAÇÃO                                         │  │
│  │  - VÁLIDA: Funcionalidades completas                           │  │
│  │  - EXPIROU: Funcionalidades limitadas (modo trial)             │  │
│  │  - INVÁLIDA: Modo trial apenas                                  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────────────────┘
10.2 Estrutura da Chave de Licença
text
┌─────────────────────────────────────────────────────────────────────────┐
│                         CHAVE DE LICENÇA                               │
├─────────────────────────────────────────────────────────────────────────┤
│                                                                         │
│  Dados:                                                                 │
│  - Version: 1                                                          │
│  - ClientId: "ABC-123-XYZ" (identificador único do cliente)           │
│  - ValidityDate: "2027-01-31T23:59:59Z" (data de expiração)           │
│  - MachineId: "1a2b3c4d5e6f..." (opcional, para binding)              │
│  - Timestamp: "2026-07-31T12:00:00Z" (data de emissão)                │
│                                                                         │
│  Criptografia:                                                         │
│  - Dados JSON → AES-256 (chave simétrica, única por licença)          │
│  - AES Key → RSA (chave pública do servidor)                          │
│  - Assinatura: HMAC-SHA256 (com chave secreta do servidor)            │
│                                                                         │
│  Formato Final:                                                        │
│  "ALUKA-XXXX-XXXX-XXXX-XXXX-XXXX" (20 caracteres, grupos de 4)        │
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
10.3 Implementação do Sistema de Licenciamento (C#)
csharp
// Aluka.Application/Security/LicenseCrypto.cs
public static class LicenseCrypto
{
    private static readonly byte[] Salt = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
    
    public static string GenerateLicenseKey(string clientId, DateTime validityDate)
    {
        var data = new
        {
            ClientId = clientId,
            ValidityDate = validityDate.ToString("yyyy-MM-ddTHH:mm:ssZ"),
            Timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
        };
        
        var json = JsonConvert.SerializeObject(data);
        var encrypted = Encrypt(json, clientId);
        
        // Adicionar checksum e formatar
        var checksum = ComputeChecksum(encrypted);
        var rawKey = encrypted + checksum;
        
        return FormatLicenseKey(rawKey);
    }
    
    public static (bool isValid, string clientId, DateTime validityDate, string error) 
        ValidateLicenseKey(string licenseKey)
    {
        try
        {
            var rawKey = UnformatLicenseKey(licenseKey);
            var encrypted = rawKey[..^8];
            var checksum = rawKey[^8..];
            
            if (ComputeChecksum(encrypted) != checksum)
                return (false, null, DateTime.MinValue, "Checksum inválido");
            
            var decrypted = Decrypt(encrypted);
            var data = JsonConvert.DeserializeObject<dynamic>(decrypted);
            
            var clientId = (string)data.ClientId;
            var validityDate = DateTime.Parse((string)data.ValidityDate);
            
            if (DateTime.UtcNow > validityDate)
                return (false, clientId, validityDate, "Licença expirada");
            
            return (true, clientId, validityDate, null);
        }
        catch (Exception ex)
        {
            return (false, null, DateTime.MinValue, $"Erro na validação: {ex.Message}");
        }
    }
    
    private static string Encrypt(string plainText, string key)
    {
        using var aes = Aes.Create();
        using var deriveBytes = new Rfc2898DeriveBytes(key, Salt, 10000, HashAlgorithmName.SHA256);
        aes.Key = deriveBytes.GetBytes(32);
        aes.IV = deriveBytes.GetBytes(16);
        
        using var encryptor = aes.CreateEncryptor();
        var plainBytes = Encoding.UTF8.GetBytes(plainText);
        var cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        
        return Convert.ToBase64String(cipherBytes);
    }
    
    private static string Decrypt(string cipherText)
    {
        // Implementação simétrica (chave fixa embutida na app)
        var encryptedBytes = Convert.FromBase64String(cipherText);
        var key = Encoding.UTF8.GetBytes("AlukaStaticKey1234567890Aluka!"); // Hash SHA-256
        
        using var aes = Aes.Create();
        aes.Key = key;
        aes.IV = key[..16];
        
        using var decryptor = aes.CreateDecryptor();
        var plainBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
        
        return Encoding.UTF8.GetString(plainBytes);
    }
    
    private static string ComputeChecksum(string data)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(data);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash)[..8];
    }
    
    private static string FormatLicenseKey(string rawKey)
    {
        var chunks = new List<string>();
        for (int i = 0; i < rawKey.Length; i += 4)
        {
            chunks.Add(rawKey.Substring(i, Math.Min(4, rawKey.Length - i)));
        }
        return "ALUKA-" + string.Join("-", chunks);
    }
    
    private static string UnformatLicenseKey(string formattedKey)
    {
        return formattedKey.Replace("ALUKA-", "").Replace("-", "");
    }
}
10.4 Modos de Licenciamento
Modo	Descrição	Funcionalidades
Trial (30 dias)	Licença gratuita experimental	- 3 regras ativas simultâneas
- Suporte a 2 idiomas
- Histórico de 30 dias
Premium (6 meses)	Licença paga	- Regras ilimitadas
- 4+ idiomas
- Histórico ilimitado
- Suporte prioritário
- Atualizações automáticas
Enterprise (12 meses)	Licença corporativa	- Tudo do Premium
- Gestão centralizada
- Políticas de grupo
- Integração com AD
11. Internacionalização e Suporte a Múltiplos Idiomas
11.1 Arquitetura do Sistema de Tradução
text
┌─────────────────────────────────────────────────────────────────────────┐
│                     SISTEMA DE TRADUÇÃO                                │
├─────────────────────────────────────────────────────────────────────────┤
│                                                                         │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                    LocalizationManager                           │  │
│  │  - CurrentLanguage (propriedade)                                │  │
│  │  - SupportedLanguages (lista)                                   │  │
│  │  - GetString(key, params)                                       │  │
│  │  - ChangeLanguage(language)                                     │  │
│  │  - LanguageChanged (evento)                                     │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                    │                                   │
│                                    ▼                                   │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                JsonResourceProvider                              │  │
│  │  - LoadResources(language)                                      │  │
│  │  - GetResource(key)                                             │  │
│  │  - Fallback: EN-US se não encontrar a chave                    │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                    │                                   │
│                                    ▼                                   │
│  ┌─────────────────────────────────────────────────────────────────┐  │
│  │                    FICHEIROS JSON                                │  │
│  │  ┌─────────────────┐ ┌─────────────────┐ ┌─────────────────┐  │  │
│  │  │  strings.json   │ │  messages.json  │ │  errors.json    │  │  │
│  │  │  - UI Labels    │ │  - Informações  │ │  - Erros        │  │  │
│  │  │  - Menu Items   │ │  - Notificações │ │  - Validações   │  │  │
│  │  └─────────────────┘ └─────────────────┘ └─────────────────┘  │  │
│  └─────────────────────────────────────────────────────────────────┘  │
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
11.2 Estrutura dos Ficheiros JSON
Exemplo: src/Aluka.WinForms/Localization/Resources/pt-PT/strings.json

json
{
  "AppName": "Aluka",
  "AppDescription": "Sistema de Gestão de Foco e Produtividade",
  
  "Menu": {
    "File": "Ficheiro",
    "File_NewRule": "Nova Regra",
    "File_Exit": "Sair",
    "View": "Ver",
    "View_Apps": "Aplicações",
    "View_Rules": "Regras",
    "View_History": "Histórico",
    "Tools": "Ferramentas",
    "Tools_Settings": "Configurações",
    "Tools_License": "Licença",
    "Help": "Ajuda",
    "Help_About": "Acerca"
  },
  
  "Form": {
    "MainForm": {
      "Title": "Aluka - Gestão de Foco",
      "WelcomeMessage": "Bem-vindo ao Aluka!",
      "StatusBar": "Pronto",
      "RulesCount": "{0} regras ativas",
      "LicenseStatus": "Licença: {0}",
      "LicenseStatus_Valid": "Válida até {0}",
      "LicenseStatus_Expired": "Expirada",
      "LicenseStatus_Trial": "Trial (restam {0} dias)"
    },
    "RulesForm": {
      "Title": "Regras de Agendamento",
      "AddRule": "Adicionar Regra",
      "EditRule": "Editar Regra",
      "DeleteRule": "Eliminar Regra",
      "EnableRule": "Ativar Regra",
      "DisableRule": "Desativar Regra",
      "Columns": {
        "App": "Aplicação",
        "Action": "Ação",
        "Days": "Dias",
        "StartTime": "Início",
        "EndTime": "Fim",
        "Status": "Estado"
      },
      "NoRules": "Nenhuma regra definida.",
      "ConfirmDelete": "Tem a certeza que deseja eliminar esta regra?"
    },
    "LicenseForm": {
      "Title": "Gestão de Licença",
      "LicenseKey": "Chave de Licença:",
      "EnterLicenseKey": "Insira a sua chave de licença",
      "Activate": "Ativar",
      "Deactivate": "Desativar",
      "Status": "Estado da Licença:",
      "Status_Valid": "✅ Válida (até {0})",
      "Status_Invalid": "❌ Inválida",
      "Status_Trial": "⏳ Trial (restam {0} dias)",
      "Status_Expired": "⚠️ Expirada",
      "RemainingDays": "Dias restantes: {0}",
      "BuyLicense": "Comprar Licença",
      "ActivationSuccess": "Licença ativada com sucesso!",
      "ActivationFailed": "Falha na ativação: {0}",
      "LicenseVerified": "Licença verificada: {0}",
      "InvalidKey": "Chave de licença inválida.",
      "ExpiredKey": "A sua licença expirou. Por favor, renove."
    }
  },
  
  "Message": {
    "RuleCreated": "Regra criada com sucesso.",
    "RuleUpdated": "Regra atualizada com sucesso.",
    "RuleDeleted": "Regra eliminada com sucesso.",
    "AppsScanned": "Aplicações atualizadas. ({0} encontradas)",
    "NoAppsFound": "Nenhuma aplicação encontrada.",
    "LicenseActivated": "Licença ativada com sucesso! Restam {0} dias.",
    "LicenseExpired": "A sua licença expirou. Algumas funcionalidades podem estar limitadas.",
    "LicenseDeactivated": "Licença desativada com sucesso.",
    "AppOpening": "A abrir {0}...",
    "AppClosing": "A fechar {0}...",
    "AppAlreadyOpen": "{0} já está aberta.",
    "AppAlreadyClosed": "{0} já está fechada.",
    "ForceCloseWarning": "A aplicação {0} está a ser forçada a fechar. Poderá perder dados não guardados."
  },
  
  "Error": {
    "GenericError": "Ocorreu um erro inesperado.",
    "ValidationError": "Erro de validação: {0}",
    "AppNotFound": "Aplicação não encontrada: {0}",
    "LicenseValidationError": "Erro na validação da licença: {0}",
    "ProcessAccessDenied": "Permissão negada para aceder ao processo.",
    "DatabaseError": "Erro na base de dados: {0}",
    "ScanError": "Erro ao varrer aplicações: {0}"
  },
  
  "Validation": {
    "Required": "Campo obrigatório.",
    "MaxLength": "Máximo de {0} caracteres.",
    "InvalidEmail": "Email inválido.",
    "InvalidLicenseKey": "Chave de licença inválida.",
    "StartTimeBeforeEnd": "A hora de início deve ser anterior à hora de fim.",
    "SelectApplication": "Selecione uma aplicação.",
    "SelectDays": "Selecione pelo menos um dia."
  },
  
  "Common": {
    "Ok": "OK",
    "Cancel": "Cancelar",
    "Apply": "Aplicar",
    "Save": "Guardar",
    "Delete": "Eliminar",
    "Edit": "Editar",
    "Add": "Adicionar",
    "Close": "Fechar",
    "Yes": "Sim",
    "No": "Não",
    "Open": "Abrir",
    "Close": "Fechar",
    "Loading": "A carregar...",
    "Search": "Pesquisar...",
    "All": "Todos",
    "None": "Nenhum",
    "Date": "Data",
    "Time": "Hora",
    "Monday": "Segunda",
    "Tuesday": "Terça",
    "Wednesday": "Quarta",
    "Thursday": "Quinta",
    "Friday": "Sexta",
    "Saturday": "Sábado",
    "Sunday": "Domingo"
  }
}
11.3 Implementação do Sistema de Tradução (C#)
csharp
// Aluka.WinForms/Localization/LocalizationManager.cs
public class LocalizationManager : ILocalizationManager
{
    private readonly Dictionary<string, Dictionary<string, string>> _resources;
    private string _currentLanguage = "pt-PT";
    private readonly ILogger<LocalizationManager> _logger;
    
    public event EventHandler<LanguageChangedEventArgs> LanguageChanged;
    
    public string CurrentLanguage => _currentLanguage;
    public IReadOnlyList<string> SupportedLanguages => new[] { "pt-PT", "pt-BR", "en-US", "es-ES" };
    
    public LocalizationManager(ILogger<LocalizationManager> logger)
    {
        _logger = logger;
        _resources = new Dictionary<string, Dictionary<string, string>>();
        LoadAllResources();
    }
    
    private void LoadAllResources()
    {
        foreach (var lang in SupportedLanguages)
        {
            LoadLanguageResources(lang);
        }
    }
    
    private void LoadLanguageResources(string language)
    {
        try
        {
            var resourcePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Localization", "Resources", language, "strings.json");
            
            if (!File.Exists(resourcePath))
            {
                _logger.LogWarning($"Resource file not found: {resourcePath}");
                return;
            }
            
            var json = File.ReadAllText(resourcePath);
            var resources = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            
            _resources[language] = FlattenResources(resources);
            
            _logger.LogInformation($"Loaded resources for language: {language}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Failed to load resources for language: {language}");
        }
    }
    
    private Dictionary<string, string> FlattenResources(Dictionary<string, object> resources, string prefix = "")
    {
        var result = new Dictionary<string, string>();
        
        foreach (var kvp in resources)
        {
            var key = string.IsNullOrEmpty(prefix) ? kvp.Key : $"{prefix}_{kvp.Key}";
            
            if (kvp.Value is Dictionary<string, object> nested)
            {
                foreach (var item in FlattenResources(nested, key))
                {
                    result[item.Key] = item.Value;
                }
            }
            else if (kvp.Value is string value)
            {
                result[key] = value;
            }
        }
        
        return result;
    }
    
    public string GetString(string key, params object[] args)
    {
        // Verificar no idioma atual
        if (_resources.TryGetValue(_currentLanguage, out var currentResources) &&
            currentResources.TryGetValue(key, out var value))
        {
            return string.Format(value, args);
        }
        
        // Fallback para inglês
        if (_resources.TryGetValue("en-US", out var enResources) &&
            enResources.TryGetValue(key, out var enValue))
        {
            _logger.LogWarning($"Missing translation for '{key}' in '{_currentLanguage}', using EN-US fallback");
            return string.Format(enValue, args);
        }
        
        // Último fallback: retornar a chave
        _logger.LogWarning($"Missing translation for '{key}' in all languages");
        return key;
    }
    
    public void ChangeLanguage(string language)
    {
        if (!SupportedLanguages.Contains(language))
        {
            _logger.LogWarning($"Unsupported language: {language}");
            return;
        }
        
        if (_currentLanguage == language)
            return;
        
        _currentLanguage = language;
        
        // Recarregar recursos do idioma (caso tenham sido atualizados)
        LoadLanguageResources(language);
        
        // Notificar observadores
        LanguageChanged?.Invoke(this, new LanguageChangedEventArgs(language));
        
        _logger.LogInformation($"Language changed to: {language}");
    }
}

// Extensão para WinForms Controls
public static class LocalizationExtensions
{
    public static void Translate(this Control control, ILocalizationManager localization)
    {
        // Traduzir texto do controlo
        if (!string.IsNullOrEmpty(control.Text) && control.Text.Contains("."))
        {
            control.Text = localization.GetString(control.Text);
        }
        
        // Traduzir tooltips
        if (control is ToolTip toolTip)
        {
            // Implementação...
        }
        
        // Recursivamente para controles filhos
        foreach (Control child in control.Controls)
        {
            child.Translate(localization);
        }
    }
    
    public static void SubscribeToLanguageChanges(this Form form, ILocalizationManager localization)
    {
        localization.LanguageChanged += (sender, args) =>
        {
            form.Translate(localization);
            form.Refresh();
        };
    }
}
11.4 Ferramenta para Gestão de Traduções
csharp
// tools/TranslationHelper/Program.cs
public static class TranslationHelper
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Aluka Translation Helper");
        Console.WriteLine("========================\n");
        
        var basePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "..", "..", "src", "Aluka.WinForms", "Localization", "Resources");
        
        var languages = new[] { "pt-PT", "pt-BR", "en-US", "es-ES" };
        var referenceLanguage = "pt-PT";
        
        // Carregar referência (PT-PT)
        var reference = LoadJson(Path.Combine(basePath, referenceLanguage, "strings.json"));
        
        // Comparar com outros idiomas
        foreach (var lang in languages.Where(l => l != referenceLanguage))
        {
            var langPath = Path.Combine(basePath, lang, "strings.json");
            var langResources = LoadJson(langPath);
            
            var missingKeys = reference.Keys.Except(langResources.Keys);
            var extraKeys = langResources.Keys.Except(reference.Keys);
            
            Console.WriteLine($"\n📊 {lang}:");
            
            if (missingKeys.Any())
            {
                Console.WriteLine($"  ⚠️ Missing keys ({missingKeys.Count()}):");
                foreach (var key in missingKeys.Take(10))
                {
                    Console.WriteLine($"    - {key}");
                }
                if (missingKeys.Count() > 10)
                    Console.WriteLine($"    ... and {missingKeys.Count() - 10} more");
            }
            else
            {
                Console.WriteLine("  ✅ All keys present");
            }
            
            if (extraKeys.Any())
            {
                Console.WriteLine($"  ℹ️ Extra keys ({extraKeys.Count()})");
            }
        }
    }
    
    private static Dictionary<string, object> LoadJson(string path)
    {
        if (!File.Exists(path))
            return new Dictionary<string, object>();
        
        var json = File.ReadAllText(path);
        return JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
    }
}
12. Padrões de Design e Boas Práticas
12.1 Padrões de Design Adotados
Padrão	Aplicação no Aluka	Benefício
Clean Architecture	Separação em camadas independentes	Manutenibilidade, testabilidade
Repository Pattern	Abstração do acesso a dados	Desacoplamento, facilidade de teste
Dependency Injection	Inversão de controlo via DI container	Baixo acoplamento, testabilidade
Unit of Work	Transações atómicas na base de dados	Consistência de dados
Strategy Pattern	Diferentes algoritmos de fecho (suave/forçado)	Flexibilidade, extensibilidade
Observer Pattern	Notificações de eventos (UI reativa)	UI reativa, desacoplamento
Singleton	Serviços de background, gestão de processos	Controlo centralizado
Factory Pattern	Criação de regras e entidades	Encapsulamento da criação
Proxy Pattern	Validação de licença	Segurança, controlo de acesso
Command Pattern	Execução de regras agendadas	Histórico, undo/redo
12.2 Princípios SOLID Aplicados
Princípio	Aplicação no Aluka	Exemplo
S - Single Responsibility	Cada classe tem uma única razão para mudar	RegistryScanner só varre o registo; ProcessManager só gere processos
O - Open/Closed	Aberto para extensão, fechado para modificação	Novos tipos de ações (abrir/fechar/restaurar) via extensão
L - Liskov Substitution	Subclasses substituem classes base sem quebrar	LicenseService base, LicenseServiceWithServer substitui
I - Interface Segregation	Interfaces específicas, não genéricas	IRuleRepository, IAppRepository, separados
D - Dependency Inversion	Depender de abstrações, não concretas	Serviços dependem de IRuleRepository, não de SqliteRuleRepository
12.3 Boas Práticas de Código
Nomes Significativos:

csharp
// Ruim
void ProcessData() { }

// Bom
void ProcessApplicationsRegistryScan() { }
Comentários de Documentação:

csharp
/// <summary>
/// Scan the Windows Registry for installed applications.
/// </summary>
/// <returns>A list of ApplicationDTO objects found.</returns>
/// <exception cref="RegistryAccessDeniedException">Thrown when registry access is denied.</exception>
public async Task<IEnumerable<AppDTO>> ScanInstalledApplicationsAsync()
Tratamento de Erros:

csharp
try
{
    await ProcessManager.OpenApplicationAsync(appPath);
}
catch (FileNotFoundException ex)
{
    _logger.LogError(ex, "Application not found: {AppPath}", appPath);
    throw new AppNotFoundException($"Application not found: {appPath}", ex);
}
Async/Await:

csharp
public async Task<bool> ValidateLicenseAsync(string licenseKey, CancellationToken cancellationToken = default)
{
    return await Task.Run(() => LicenseCrypto.ValidateLicenseKey(licenseKey), cancellationToken);
}
Testabilidade:

csharp
public interface IProcessManager
{
    bool IsRunning(string processName);
    Task<bool> OpenAsync(string path, CancellationToken ct);
}
// Mockável para testes
13. Estratégia de Testes e Qualidade
13.1 Pirâmide de Testes
text
                    ┌─────────────┐
                    │   E2E UI    │   (5-10% dos testes)
                    │  (UI Tests) │
                    └─────────────┘
                          │
                   ┌─────▼─────┐
                   │  Integração │   (15-20% dos testes)
                   │ (Integration)│
                   └─────────────┘
                          │
                   ┌─────▼─────┐
                   │  Unitários │   (70-80% dos testes)
                   │   (Unit)   │
                   └─────────────┘
13.2 Estratégia por Camada
Camada	Tipo de Teste	Framework	Cobertura Alvo
Domain	Unitários	xUnit + FluentAssertions	95%+
Application	Unitários + Integração	xUnit + Moq + FluentAssertions	90%+
Infrastructure	Integração	xUnit + Testcontainers + SQLite in-memory	80%+
UI (WinForms)	UI Automatizados	FlaUI + xUnit	70%+
Segurança	Unitários + Integração	xUnit + Moq	90%+
13.3 Exemplos de Testes
Teste Unitário: RegraAgendamento

csharp
// Aluka.Tests.Unit/Domain/RegraAgendamentoTests.cs
public class RegraAgendamentoTests
{
    [Fact]
    public void CreateRule_WithValidData_ShouldSucceed()
    {
        // Arrange
        var appId = 1;
        var action = TipoAcao.Abrir;
        var days = DiasSemana.DiasUteis;
        var start = new TimeOnly(9, 0);
        var end = new TimeOnly(18, 0);
        
        // Act
        var rule = new RegraAgendamento(appId, action, days, start, end);
        
        // Assert
        Assert.Equal(appId, rule.AplicacaoId);
        Assert.Equal(action, rule.TipoAcao);
        Assert.Equal(days, rule.DiasSemana);
        Assert.Equal(start, rule.HoraInicio);
        Assert.Equal(end, rule.HoraFim);
        Assert.True(rule.EstaAtivo);
    }
    
    [Fact]
    public void CreateRule_WithInvalidTimeRange_ShouldThrowException()
    {
        // Arrange
        var start = new TimeOnly(18, 0);
        var end = new TimeOnly(9, 0);
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
            new RegraAgendamento(1, TipoAcao.Abrir, DiasSemana.DiasUteis, start, end));
    }
    
    [Fact]
    public void Rule_WhenActivated_ShouldBeActive()
    {
        var rule = new RegraAgendamento(1, TipoAcao.Abrir, DiasSemana.DiasUteis, 
                                        new TimeOnly(9, 0), new TimeOnly(18, 0));
        
        rule.Desativar();
        Assert.False(rule.EstaAtivo);
        
        rule.Ativar();
        Assert.True(rule.EstaAtivo);
    }
}
Teste de Integração: LicenseService

csharp
// Aluka.Tests.Integration/Services/LicenseServiceTests.cs
public class LicenseServiceTests : IClassFixture<DatabaseFixture>
{
    private readonly DatabaseFixture _fixture;
    private readonly ILicenseService _licenseService;
    
    public LicenseServiceTests(DatabaseFixture fixture)
    {
        _fixture = fixture;
        _licenseService = new LicenseService(
            _fixture.LicenseRepository,
            _fixture.Logger,
            _fixture.Configuration);
    }
    
    [Fact]
    public async Task ValidateLicense_WithValidKey_ShouldReturnValidResult()
    {
        // Arrange
        var validKey = "ALUKA-ABCD-1234-EFGH-5678-IJKL";
        
        // Act
        var result = await _licenseService.ValidateLicenseAsync(validKey);
        
        // Assert
        Assert.True(result.IsValid);
        Assert.NotNull(result.ClientId);
        Assert.InRange(result.RemainingDays, 0, 180);
    }
    
    [Fact]
    public async Task ValidateLicense_WithExpiredKey_ShouldReturnExpiredResult()
    {
        // Arrange
        var expiredKey = "ALUKA-EXPI-0000-0000-0000-0000";
        
        // Act
        var result = await _licenseService.ValidateLicenseAsync(expiredKey);
        
        // Assert
        Assert.False(result.IsValid);
        Assert.Equal("Licença expirada", result.ErrorMessage);
        Assert.Equal(0, result.RemainingDays);
    }
}
13.4 Cobertura de Código e Qualidade
Métrica	Alvo	Ferramenta
Cobertura de código	≥ 80%	Coverlet + ReportGenerator
Complexidade ciclomática	≤ 15	Visual Studio Code Metrics
Dependências cíclicas	0	NDepend
Dívida técnica	≤ 5%	SonarQube
Bugs/1000 linhas	≤ 2	SonarQube
14. Plano de Implementação Detalhado
14.1 Fases de Desenvolvimento
Fase	Período	Objetivo	Entregáveis
Fase 0: Setup	Dia 1-3	Configuração da infraestrutura	- Repositório GitHub
- Estrutura de pastas
- CI/CD básico
- Ambiente de desenvolvimento
Fase 1: Domain	Dia 4-7	Camada de domínio	- Entidades: Aplicacao, RegraAgendamento, HistoricoExecucao, LicenseInfo
- Enums e interfaces
- Testes unitários (95%+)
Fase 2: Infrastructure	Dia 8-14	Camada de infraestrutura	- AppDbContext (SQLite)
- Repositórios
- Migrações
- WindowsProcessManager
- RegistryScanner
Fase 3: Application	Dia 15-21	Camada de aplicação	- Serviços: Rule, App, History, License, ProcessManager
- DTOs e mapeamentos
- Validadores
- Testes unitários (90%+)
Fase 4: UI Core	Dia 22-30	Interface principal	- MainForm (dashboard)
- RulesForm (lista de regras)
- RuleEditorForm (edição)
- AppsForm (lista de aplicações)
Fase 5: Licenciamento	Dia 31-37	Sistema de licenciamento	- LicenseForm (UI)
- LicenseCrypto (segurança)
- LicenseService (validação)
- Geração de licenças (ferramenta)
Fase 6: Internacionalização	Dia 38-43	Suporte a múltiplos idiomas	- LocalizationManager
- Ficheiros JSON (pt-PT, pt-BR, en-US)
- Extensões para WinForms
- Ferramenta de gestão de traduções
Fase 7: Background	Dia 44-50	Motor de execução	- BackgroundScheduler (serviço)
- Execução de regras
- Histórico de execuções
- Notificações
Fase 8: Polimento	Dia 51-60	Refinamento e testes	- UI refinada
- Testes de integração
- Testes E2E
- Documentação
- Instalador
Fase 9: Beta	Dia 61-70	Testes com utilizadores reais	- Versão beta
- Feedback
- Correções de bugs
Fase 10: Lançamento	Dia 71-75	Release final	- Versão 1.0.0
- Deploy para produção
- Marketing e divulgação
14.2 Roadmap Detalhado (Com Marcos)
Marco	Data Estimada	Descrição	Critério de Aceitação
M0 - Kickoff	Dia 1	Início do projeto	Repositório criado, equipa alinhada
M1 - Domain Concluído	Dia 7	Entidades e interfaces definidas	Testes unitários passando (95%+)
M2 - Infrastructure Concluído	Dia 14	Acesso a dados e sistema funcional	DB criado, repositórios testados
M3 - Application Concluído	Dia 21	Serviços implementados	Testes unitários passando (90%+)
M4 - UI Funcional	Dia 30	Interfaces principais prontas	Fluxos principais funcionais
M5 - Licenciamento	Dia 37	Sistema de licenças operacional	Geração e validação funcionando
M6 - Internacionalização	Dia 43	3 idiomas suportados	Interface traduzida e funcional
M7 - Motor em Background	Dia 50	Regras executadas automaticamente	Motor funcional, histórico registado
M8 - Beta	Dia 70	Versão beta para testadores	Feedback positivo, bugs críticos corrigidos
M9 - Release	Dia 75	Versão 1.0.0 lançada	Instalador pronto, documentação completa
14.3 Tarefas Detalhadas por Fase
Fase 0: Setup (Dias 1-3)
□ Criar repositório GitHub (privado)
□ Definir .gitignore (Visual Studio + .NET)
□ Criar solution com 5 projetos (Domain, Application, Infrastructure, Infrastructure.IoC, WinForms)
□ Configurar Directory.Build.props para padronizar versões
□ Configurar Serilog para logging
□ Configurar CI/CD (GitHub Actions ou Azure DevOps)
□ Configurar análise estática (SonarQube)
□ Instalar ferramentas: .NET 8 SDK, Visual Studio 2022, SQLite Browser
Fase 1: Domain (Dias 4-7)
□ Criar BaseEntity com Id, DataCriacao, DataModificacao
□ Criar Aplicacao (Nome, CaminhoExecutavel, IconeBase64, etc.)
□ Criar RegraAgendamento (AplicacaoId, TipoAcao, DiasSemana, Horas)
□ Criar HistoricoExecucao (RegraId, Data, Status, MensagemErro, Duracao)
□ Criar LicenseInfo (LicenseKey, ClientId, ValidityDate, IsValid, etc.)
□ Criar enums: TipoAcao, DiasSemana, StatusExecucao, LicenseStatus, SupportedLanguage
□ Criar interfaces de repositórios: IRepository<T>, IApplicationRepository, IRuleRepository, IHistoryRepository, ILicenseRepository
□ Criar interfaces de serviços (para desacoplamento)
□ Adicionar testes unitários para todas as entidades
□ Documentar APIs com XML comments
Fase 2: Infrastructure (Dias 8-14)
□ Configurar AppDbContext com SQLite
□ Definir configurações EF Core (Fluent API)
□ Criar implementações de repositórios
□ Implementar UnitOfWork
□ Criar migrações iniciais
□ Implementar WindowsProcessManager (Process.Start, Process.Kill, etc.)
□ Implementar RegistryScanner (varrimento HKLM + HKCU)
□ Implementar IconExtractor (extração de ícones)
□ Implementar BackgroundScheduler (Timer, verificação de regras)
□ Adicionar testes de integração para repositórios
□ Configurar logging com Serilog (ficheiro + console)
Fase 3: Application (Dias 15-21)
□ Criar DTOs: AppDTO, RuleDTO, HistoryDTO, LicenseDTO, etc.
□ Configurar AutoMapper (profiles)
□ Implementar RuleService (CRUD de regras)
□ Implementar AppService (scan, atualização)
□ Implementar HistoryService (registar, consultar)
□ Implementar ProcessManagerService (orquestração)
□ Implementar LicenseService (validação offline/online)
□ Implementar I18nService (gestão de idiomas)
□ Adicionar validadores (FluentValidation)
□ Implementar LicenseCrypto (AES + RSA)
□ Adicionar testes unitários para todos os serviços
□ Implementar tratamento de exceções personalizadas
Fase 4: UI Core (Dias 22-30)
□ Criar MainForm com menu, status bar, dashboard
□ Criar RulesForm com DataGridView/ListView de regras
□ Criar RuleEditorForm com controls: combobox apps, checkbox dias, datetimepickers
□ Criar AppsForm com lista de aplicações e ícones
□ Criar HistoryForm com DataGridView de histórico
□ Implementar FormNavigationService
□ Implementar DialogService (MessageBoxes customizadas)
□ Implementar NotificationService (Toasts)
□ Adicionar controlos customizados: AppListItem, RuleCard, SchedulerCalendar
□ Integrar com Application Layer (injeção de dependências)
□ Adicionar ícones e recursos visuais
Fase 5: Licenciamento (Dias 31-37)
□ Criar LicenseForm com input de chave, botão ativar
□ Implementar LicenseValidator (validação offline)
□ Implementar LicenseServerClient (validação online opcional)
□ Implementar geração de licenças (ferramenta separada)
□ Adicionar status de licença na MainForm
□ Implementar bloqueio de funcionalidades premium em modo trial
□ Adicionar testes de segurança (ofuscação, anti-debug)
□ Documentar processo de licenciamento para utilizadores
Fase 6: Internacionalização (Dias 38-43)
□ Criar estrutura de ficheiros JSON por idioma
□ Traduzir todos os textos para PT-PT, PT-BR, EN-US
□ Implementar LocalizationManager (gestão de recursos)
□ Implementar JsonResourceProvider (carregamento de JSON)
□ Adicionar extensões para WinForms (Translate, SubscribeToLanguageChanges)
□ Criar seletor de idioma na UI (combobox)
□ Implementar mudança de idioma em tempo real (evento)
□ Criar ferramenta de gestão de traduções (verificação de chaves faltantes)
□ Adicionar testes de internacionalização (carga, mudança, fallback)
Fase 7: Background (Dias 44-50)
□ Refinar BackgroundScheduler (IHostedService)
□ Implementar lógica de execução de regras (abrir/fechar)
□ Implementar verificação de processos (ProcessManager)
□ Implementar registo de histórico (HistoryService)
□ Implementar notificações de execução (NotificaçãoService)
□ Adicionar tratamento de concorrência (SemaphoreSlim)
□ Adicionar logging detalhado de execuções
□ Adicionar testes de integração para o scheduler
Fase 8: Polimento (Dias 51-60)
□ Refinar UI (cores, fontes, espaçamento)
□ Adicionar animações (transições, feedback)
□ Implementar tooltips e ajuda contextual
□ Adicionar shortcuts de teclado
□ Melhorar performance (lazy loading, virtualização)
□ Adicionar testes E2E (FlaUI)
□ Criar instalador (WiX ou ClickOnce)
□ Escrever documentação do utilizador
□ Escrever documentação do programador
□ Revisão de segurança (OWASP Top 10)
Fase 9: Beta (Dias 61-70)
□ Distribuir versão beta para testadores
□ Recolher feedback (formulário, issues)
□ Priorizar e corrigir bugs críticos
□ Otimizações finais de performance
□ Atualizar documentação com base no feedback
□ Preparar materiais de marketing
Fase 10: Lançamento (Dias 71-75)
□ Build final de produção
□ Publicar instalador no site/loja
□ Lançar comunicado de imprensa
□ Monitorizar primeiros dias (crash reports)
□ Atualizar roadmap para versões futuras
14.4 Gestão de Riscos
Risco	Probabilidade	Impacto	Mitigação
Falta de permissões administrativas	Média	Alto	Pedir permissões na instalação; fallback para utilizador standard
Mudanças de API do Windows	Baixa	Médio	.NET abstrai muitas APIs; monitorar anúncios da Microsoft
Engenharia reversa do licenciamento	Alta	Alto	Ofuscação de código; validação online (opcional); assinatura RSA
Perda de dados do utilizador	Média	Crítico	Avisos claros; nunca apagar dados; backup automático
Compatibilidade com Windows 10/11	Baixa	Médio	Testes em ambas as versões; usar APIs estáveis
Traduções incompletas	Média	Baixo	Ferramenta de verificação; fallback para inglês
Desempenho do scheduler	Baixa	Médio	Verificação a cada 60s; consultas indexadas; cache de processos
15. Estratégia de Deploy e Distribuição
15.1 Estratégia de Publicação
Método	Complexidade	Vantagem	Quando Usar
ClickOnce	⭐ Baixa	Atualizações automáticas	Releases iniciais, comunidade
Instalador MSI (WiX)	⭐⭐⭐ Média	Instalação profissional	Versão estável, distribuição ampla
Self-Contained (Single-File)	⭐⭐ Média	Sem dependências .NET	Distribuição para utilizadores finais
Chocolatey / Winget	⭐⭐⭐⭐ Alta	Distribuição por package managers	Utilizadores avançados
15.2 Configuração de Publicação
xml
<!-- Aluka.WinForms.csproj (exemplo de configuração) -->
<PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net8.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
    <ApplicationIcon>Resources\aluka.ico</ApplicationIcon>
    <PublishSingleFile>true</PublishSingleFile>
    <SelfContained>true</SelfContained>
    <RuntimeIdentifier>win-x64</RuntimeIdentifier>
    <PublishReadyToRun>true</PublishReadyToRun>
    <PublishTrimmed>true</PublishTrimmed>
    <TrimMode>full</TrimMode>
</PropertyGroup>

<ItemGroup>
    <Content Include="Localization\Resources\**\*.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        <PublishCopyToOutputDirectory>PreserveNewest</PublishCopyToOutputDirectory>
    </Content>
    <Content Include="appsettings.json">
        <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
        <PublishCopyToOutputDirectory>PreserveNewest</PublishCopyToOutputDirectory>
    </Content>
</ItemGroup>
15.3 Script de Build (PowerShell)
powershell
# scripts/build.ps1
param(
    [string]$Configuration = "Release",
    [string]$Runtime = "win-x64",
    [switch]$Publish
)

Write-Host "Building Aluka..." -ForegroundColor Green

# Restore packages
dotnet restore src/Aluka.sln

# Build solution
dotnet build src/Aluka.sln --configuration $Configuration --no-restore

if ($Publish) {
    Write-Host "Publishing Aluka..." -ForegroundColor Green
    
    # Publish WinForms
    dotnet publish src/Aluka.WinForms/Aluka.WinForms.csproj `
        --configuration $Configuration `
        --runtime $Runtime `
        --self-contained true `
        --output ./publish/
    
    # Copy resources
    Copy-Item -Path ./src/Aluka.WinForms/Localization/Resources/ -Destination ./publish/Localization/Resources/ -Recurse -Force
    Copy-Item -Path ./src/Aluka.WinForms/appsettings.json -Destination ./publish/appsettings.json -Force
    
    Write-Host "Published to ./publish/" -ForegroundColor Green
}

Write-Host "Build complete!" -ForegroundColor Green
15.4 Script de Geração de Licenças
powershell
# scripts/generate-license.ps1
param(
    [string]$ClientId,
    [int]$Months = 6
)

Write-Host "Aluka License Generator" -ForegroundColor Green
Write-Host "========================`n"

if (-not $ClientId) {
    $ClientId = Read-Host "Enter Client ID (e.g., ACME-001)"
}

$ValidityDate = (Get-Date).AddMonths($Months).ToString("yyyy-MM-ddTHH:mm:ssZ")

Write-Host "Client ID: $ClientId" -ForegroundColor Cyan
Write-Host "Validity: $ValidityDate" -ForegroundColor Cyan
Write-Host "Months: $Months" -ForegroundColor Cyan

# Executar gerador de licenças
dotnet run --project ./tools/LicenseGenerator/LicenseGenerator.csproj -- `
    --client-id $ClientId `
    --validity-date $ValidityDate

Write-Host "`nLicense generated successfully!" -ForegroundColor Green
16. Documentação e Suporte
16.1 Documentação do Utilizador
A documentação do utilizador será disponibilizada em formato Markdown no repositório e num website dedicado (aluka.dev), cobrindo:

Guia de Primeiros Passos:

Instalação do Aluka

Ativação da licença

Visão geral da interface

Criação e Gestão de Regras:

Como criar uma regra

Definição de dias e horários

Tipos de ação (abrir/fechar)

Gestão de Aplicações:

Como atualizar a lista de aplicações

Como adicionar aplicações manualmente

Licenciamento:

Como obter uma licença

Como ativar a licença

O que acontece quando a licença expira

Internacionalização:

Como mudar o idioma da interface

Idiomas suportados

Perguntas Frequentes (FAQ):

Respostas para dúvidas comuns

16.2 Documentação do Programador
Documentação técnica para contribuidores e futuros mantenedores:

Arquitetura do Sistema:

Clean Architecture no Aluka

Diagramas de camadas

Fluxos de dados

Configuração do Ambiente:

Requisitos de desenvolvimento

Instalação de dependências

Configuração do Visual Studio

Contribuição:

Como reportar bugs

Como submeter pull requests

Convenções de código

API de Licenciamento:

Como gerar licenças

Como validar licenças

Estrutura da chave de licença

Sistema de Internacionalização:

Como adicionar um novo idioma

Como manter traduções atualizadas

16.3 API de Licenciamento (Servidor)
yaml
# API Reference - aluka-license-api.yaml
openapi: 3.0.0
info:
  title: Aluka License API
  version: 1.0.0
  description: API para validação e gestão de licenças Aluka

paths:
  /api/v1/license/validate:
    post:
      summary: Validar licença online
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                licenseKey:
                  type: string
                  example: "ALUKA-ABCD-1234-EFGH-5678-IJKL"
                clientId:
                  type: string
                  example: "ABC-123-XYZ"
                machineId:
                  type: string
                  example: "1a2b3c4d5e6f..."
      responses:
        200:
          description: Validação realizada com sucesso
          content:
            application/json:
              schema:
                type: object
                properties:
                  status:
                    type: string
                    enum: [valid, expired, invalid, revoked]
                  message:
                    type: string
                  remainingDays:
                    type: integer
                  validityDate:
                    type: string
                    format: date-time

  /api/v1/license/generate:
    post:
      summary: Gerar nova licença (admin-only)
      security:
        - ApiKeyAuth: []
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                clientId:
                  type: string
                months:
                  type: integer
                  minimum: 1
                  maximum: 36
                maxUsers:
                  type: integer
                  minimum: 1
                  maximum: 1000
      responses:
        200:
          description: Licença gerada com sucesso
          content:
            application/json:
              schema:
                type: object
                properties:
                  licenseKey:
                    type: string
                  clientId:
                    type: string
                  validityDate:
                    type: string
                    format: date-time
16.4 Suporte e Comunidade
Canal	Propósito	Disponibilidade
GitHub Issues	Reporte de bugs, solicitações de funcionalidades	24/7
Email de Suporte	suporte@aluka.dev	Dias úteis, 9h-18h
Documentação	docs.aluka.dev	24/7
Fórum Comunitário	comunidade.aluka.dev	24/7
Discord/Slack	Comunidade de utilizadores	24/7
17. Glossário e Referências
17.1 Glossário de Termos
Termo	Definição
Aluka	Nome do projeto, do kimbundo (angola) que significa "foco" ou "concentração".
Contexto Digital	Conjunto de aplicações, janelas e configurações abertas num determinado momento.
Regra	Configuração que define quando uma aplicação deve ser aberta ou fechada.
Trial	Período de teste gratuito (30 dias) com funcionalidades limitadas.
Licença Premium	Licença paga por 6 meses, com funcionalidades completas.
Clean Architecture	Padrão arquitetural que separa o software em camadas independentes.
DTO	Data Transfer Object, objeto usado para transferir dados entre camadas.
MVC	Model-View-Controller, padrão de design para interfaces.
DI	Dependency Injection, padrão de inversão de controlo.
EF Core	Entity Framework Core, ORM para .NET.
WinForms	Windows Forms, framework para aplicações desktop .NET.
SQLite	Base de dados relacional embutida, sem servidor.
17.2 Referências Técnicas
Microsoft Learn: .NET 8 Documentation

Entity Framework Core: EF Core Documentation

SQLite: SQLite Documentation

Clean Architecture: The Clean Architecture - Robert C. Martin

Win32 API: Microsoft Win32 API Reference

ASP.NET Core: ASP.NET Core Documentation

17.3 Referências de Segurança
OWASP: OWASP Top 10

RSA Encryption: RSA Cryptography Specification

AES Encryption: Advanced Encryption Standard (AES)

17.4 Ferramentas de Desenvolvimento
Ferramenta	Propósito	URL
Visual Studio 2022	IDE de desenvolvimento	https://visualstudio.microsoft.com/
.NET 8 SDK	Framework de desenvolvimento	https://dotnet.microsoft.com/
SQLite Browser	Visualização de base de dados	https://sqlitebrowser.org/
Postman	Teste de APIs	https://www.postman.com/
Git	Controlo de versões	https://git-scm.com/
GitHub	Repositório de código	https://github.com/
SonarQube	Análise de qualidade de código	https://www.sonarqube.org/
📝 Notas Finais
"O Aluka não é apenas uma ferramenta de automação, é um aliado na busca por um relacionamento mais consciente com a tecnologia. Uma máquina que nos ajuda a focar no que realmente importa, respeitando a nossa autonomia e diversidade cultural."