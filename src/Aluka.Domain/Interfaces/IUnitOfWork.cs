using Aluka.Domain.Entities;

namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface para o padrão Unit of Work.
/// Coordena as operações entre múltiplos repositórios e garante transações atómicas.
/// </summary>
public interface IUnitOfWork : IDisposable
{
    /// <summary>Repositório de aplicações.</summary>
    IApplicationRepository Applications { get; }

    /// <summary>Repositório de regras de agendamento.</summary>
    IRuleRepository Rules { get; }

    /// <summary>Repositório de histórico de execuções.</summary>
    IHistoryRepository History { get; }

    /// <summary>
    /// Persiste todas as alterações pendentes no banco de dados.
    /// </summary>
    Task<int> CompleteAsync();

    // =========================================================
    // MÉTODOS DE TRANSAÇÃO (OPCIONAL)
    // =========================================================
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}