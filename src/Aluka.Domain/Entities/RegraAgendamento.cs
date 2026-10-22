using Aluka.Domain.Enums;

namespace Aluka.Domain.Entities;

public class RegraAgendamento : BaseEntity
{
    // =========================================================
    // CAMPOS EXISTENTES
    // =========================================================
    public int AplicacaoId { get; private set; }
    public virtual Aplicacao Aplicacao { get; private set; } = null!;
    public TipoAcao TipoAcao { get; private set; }
    public DiasSemana DiasSemana { get; private set; }
    public TimeOnly HoraInicio { get; private set; }
    public TimeOnly HoraFim { get; private set; }
    public bool EstaAtivo { get; private set; }
    public string? Observacao { get; private set; }

    // =========================================================
    // NOVOS CAMPOS PARA NOTIFICAÇÕES
    // =========================================================

    /// <summary>
    /// Indica se a regra deve gerar notificações quando executada.
    /// </summary>
    public bool NotificarExecucao { get; private set; }

    /// <summary>
    /// Tipo de notificação: "Information", "Warning", "Error", "Success".
    /// </summary>
    public string? TipoNotificacao { get; private set; }

    /// <summary>
    /// Atraso em segundos antes de mostrar a notificação.
    /// Valores: 0, 5, 10, 30, 60.
    /// </summary>
    public int? AtrasoNotificacaoSegundos { get; private set; }

    /// <summary>
    /// Duração da notificação: "Short" (5s) ou "Long" (25s).
    /// </summary>
    public string? DuracaoNotificacao { get; private set; }

    /// <summary>
    /// Última vez que uma notificação foi enviada para esta regra.
    /// Usado para controlar o cooldown de 1 hora.
    /// </summary>
    public DateTime? UltimaNotificacao { get; private set; }

    // =========================================================
    // CONSTRUTORES
    // =========================================================

    // Construtor EF Core
    protected RegraAgendamento() { }

    public RegraAgendamento(
        int aplicacaoId,
        TipoAcao tipoAcao,
        DiasSemana diasSemana,
        TimeOnly horaInicio,
        TimeOnly horaFim,
        string? observacao = null)
    {
        AplicacaoId = aplicacaoId;
        TipoAcao = tipoAcao;
        DiasSemana = diasSemana;
        HoraInicio = horaInicio;
        HoraFim = horaFim;
        EstaAtivo = true;
        Observacao = observacao;

        // Valores padrão para notificações
        NotificarExecucao = false;
        TipoNotificacao = NotificationType.Information.ToString();
        AtrasoNotificacaoSegundos = 0;
        DuracaoNotificacao = "Short";
    }

    // =========================================================
    // MÉTODOS DE DOMÍNIO EXISTENTES
    // =========================================================

    public void Ativar()
    {
        EstaAtivo = true;
        UpdateModificationDate();
    }

    public void Desativar()
    {
        EstaAtivo = false;
        UpdateModificationDate();
    }

    public void AtualizarObservacao(string? observacao)
    {
        Observacao = observacao;
        UpdateModificationDate();
    }

    public void AtualizarHorario(TimeOnly horaInicio, TimeOnly horaFim)
    {
        if (horaInicio >= horaFim)
            throw new ArgumentException("A hora de início deve ser anterior à hora de fim.");

        HoraInicio = horaInicio;
        HoraFim = horaFim;
        UpdateModificationDate();
    }

    public void AtualizarDias(DiasSemana diasSemana)
    {
        if (diasSemana == 0)
            throw new ArgumentException("Pelo menos um dia deve ser selecionado.");

        DiasSemana = diasSemana;
        UpdateModificationDate();
    }

    // =========================================================
    // NOVOS MÉTODOS DE DOMÍNIO PARA NOTIFICAÇÕES
    // =========================================================

    /// <summary>
    /// Regista que uma notificação foi enviada para esta regra.
    /// </summary>
    public void RegistrarNotificacao()
    {
        UltimaNotificacao = DateTime.UtcNow;
        UpdateModificationDate();
    }

    /// <summary>
    /// Verifica se a regra pode enviar uma notificação.
    /// Regras: notificação ativa E (sem notificação anterior OU passou 1 hora).
    /// </summary>
    public bool PodeNotificar()
    {
        if (!NotificarExecucao) return false;
        if (!UltimaNotificacao.HasValue) return true;
        return (DateTime.UtcNow - UltimaNotificacao.Value).TotalHours >= 1;
    }

    /// <summary>
    /// Atualiza as configurações de notificação da regra.
    /// </summary>
    public void AtualizarNotificacao(
        bool notificar,
        string? tipo = null,
        int? atraso = null,
        string? duracao = null)
    {
        NotificarExecucao = notificar;
        if (tipo != null) TipoNotificacao = tipo;
        if (atraso.HasValue) AtrasoNotificacaoSegundos = atraso.Value;
        if (duracao != null) DuracaoNotificacao = duracao;
        UpdateModificationDate();
    }

    /// <summary>
    /// Obtém o tipo de notificação como enum.
    /// </summary>
    public NotificationType ObterTipoNotificacao()
    {
        if (string.IsNullOrEmpty(TipoNotificacao))
            return NotificationType.Information;

        return Enum.TryParse<NotificationType>(TipoNotificacao, out var result)
            ? result
            : NotificationType.Information;
    }

    /// <summary>
    /// Obtém a duração da notificação (Short/Long).
    /// </summary>
    public string ObterDuracaoNotificacao()
    {
        return string.IsNullOrEmpty(DuracaoNotificacao) ? "Short" : DuracaoNotificacao;
    }
}