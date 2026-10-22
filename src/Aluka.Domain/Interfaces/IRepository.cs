using Aluka.Domain.Entities;

namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface genérica para repositórios.
/// Define as operações básicas de CRUD.
/// </summary>
/// <typeparam name="T">Tipo da entidade.</typeparam>
public interface IRepository<T> where T : BaseEntity
{
    /// <summary>Obtém uma entidade pelo seu ID.</summary>
    Task<T?> GetByIdAsync(int id);

    /// <summary>Obtém todas as entidades.</summary>
    Task<IEnumerable<T>> GetAllAsync();

    /// <summary>Adiciona uma nova entidade.</summary>
    Task AddAsync(T entity);

    /// <summary>Atualiza uma entidade existente.</summary>
    Task UpdateAsync(T entity);

    /// <summary>Remove uma entidade.</summary>
    Task DeleteAsync(T entity);
}