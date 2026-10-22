using Aluka.Domain.Entities;
using Aluka.Domain.Enums;

namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface para o repositório de histórico de execuções.
/// </summary>
public interface IHistoryRepository : IRepository<HistoricoExecucao>
{
    /// <summary>
    /// Obtém o histórico de uma regra específica.
    /// </summary>
    Task<IEnumerable<HistoricoExecucao>> GetByRuleIdAsync(int ruleId);

    /// <summary>
    /// Obtém o histórico com filtros opcionais.
    /// </summary>
    Task<IEnumerable<HistoricoExecucao>> GetFilteredAsync(
        int? ruleId = null,
        StatusExecucao? status = null,
        DateTime? startDate = null,
        DateTime? endDate = null,
        int? limit = null);

    /// <summary>
    /// Obtém estatísticas do histórico.
    /// </summary>
    Task<(int Total, int Success, int Errors, int Ignored)> GetStatisticsAsync(
        DateTime? startDate = null,
        DateTime? endDate = null);

    /// <summary>
    /// Obtém registos de histórico mais antigos que uma data específica.
    /// </summary>
    /// <param name="cutoffDate">Data limite (registos anteriores a esta data).</param>
    /// <returns>Lista de registos antigos.</returns>
    Task<IEnumerable<HistoricoExecucao>> GetOlderThanAsync(DateTime cutoffDate);

    /// <summary>
    /// Obtém a contagem de registos mais antigos que uma data específica.
    /// </summary>
    /// <param name="cutoffDate">Data limite (registos anteriores a esta data).</param>
    /// <returns>Número de registos antigos.</returns>
    Task<int> CountOlderThanAsync(DateTime cutoffDate);

    /// <summary>
    /// Elimina registos mais antigos que uma data específica (em lote).
    /// </summary>
    /// <param name="cutoffDate">Data limite (registos anteriores a esta data).</param>
    /// <param name="batchSize">Tamanho do lote (padrão: 100).</param>
    /// <returns>Número total de registos eliminados.</returns>
    Task<int> DeleteOlderThanAsync(DateTime cutoffDate, int batchSize = 100);
}