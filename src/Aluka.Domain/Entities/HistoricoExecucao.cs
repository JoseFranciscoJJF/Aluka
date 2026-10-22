using Aluka.Domain.Enums;

namespace Aluka.Domain.Entities;

/// <summary>
/// Representa o histórico de execução de uma regra de agendamento.
/// </summary>
public class HistoricoExecucao : BaseEntity
{
    /// <summary>Identificador da regra de agendamento.</summary>
    public int RegraAgendamentoId { get; private set; }

    /// <summary>Data e hora da execução (UTC).</summary>
    public DateTime DataExecucao { get; private set; }

    /// <summary>Status do resultado da execução.</summary>
    public StatusExecucao Status { get; private set; }

    /// <summary>Mensagem de erro (se houver).</summary>
    public string? MensagemErro { get; private set; }

    /// <summary>Duração da execução em milissegundos.</summary>
    public int? DuracaoMs { get; private set; }

    /// <summary>Regra de agendamento associada.</summary>
    public virtual RegraAgendamento RegraAgendamento { get; set; } = null!;

    /// <summary>
    /// Construtor para criar um novo registo de histórico.
    /// </summary>
    /// <param name="regraAgendamentoId">ID da regra.</param>
    /// <param name="status">Status da execução.</param>
    /// <param name="mensagemErro">Mensagem de erro (opcional).</param>
    /// <param name="duracaoMs">Duração em ms (opcional).</param>
    public HistoricoExecucao(
        int regraAgendamentoId,
        StatusExecucao status,
        string? mensagemErro = null,
        int? duracaoMs = null)
    {
        if (regraAgendamentoId <= 0)
            throw new ArgumentException("O ID da regra deve ser válido.", nameof(regraAgendamentoId));

        RegraAgendamentoId = regraAgendamentoId;
        DataExecucao = DateTime.UtcNow;
        Status = status;
        MensagemErro = mensagemErro;
        DuracaoMs = duracaoMs;
    }

    /// <summary>
    /// Cria um registo de histórico para uma execução bem-sucedida.
    /// </summary>
    public static HistoricoExecucao CriarSucesso(int regraId, int? duracaoMs = null)
    {
        return new HistoricoExecucao(regraId, StatusExecucao.Sucesso, duracaoMs: duracaoMs);
    }

    /// <summary>
    /// Cria um registo de histórico para uma execução com erro.
    /// </summary>
    public static HistoricoExecucao CriarErro(int regraId, string mensagemErro, int? duracaoMs = null)
    {
        return new HistoricoExecucao(regraId, StatusExecucao.Erro, mensagemErro, duracaoMs);
    }

    /// <summary>
    /// Cria um registo de histórico para uma execução ignorada.
    /// </summary>
    public static HistoricoExecucao CriarIgnorado(int regraId)
    {
        return new HistoricoExecucao(regraId, StatusExecucao.Ignorado);
    }
}