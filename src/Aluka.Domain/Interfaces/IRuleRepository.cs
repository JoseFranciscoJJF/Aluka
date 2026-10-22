using Aluka.Domain.Entities;
using Aluka.Domain.Enums;

namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface específica para o repositório de RegraAgendamento.
/// </summary>
public interface IRuleRepository : IRepository<RegraAgendamento>
{
    /// <summary>
    /// Obtém as regras ativas para um determinado dia e hora.
    /// </summary>
    Task<IEnumerable<RegraAgendamento>> GetActiveRulesAsync(DayOfWeek dia, TimeOnly hora);

    /// <summary>
    /// Obtém todas as regras ativas.
    /// </summary>
    Task<IEnumerable<RegraAgendamento>> GetActiveRulesAsync();

    /// <summary>
    /// Obtém as regras associadas a uma aplicação específica.
    /// </summary>
    Task<IEnumerable<RegraAgendamento>> GetByApplicationAsync(int aplicacaoId);

    /// <summary>
    /// Obtém as regras de um determinado tipo (Abrir/Fechar).
    /// </summary>
    Task<IEnumerable<RegraAgendamento>> GetByActionAsync(TipoAcao tipoAcao);
}