using Aluka.Domain.Entities;

namespace Aluka.Domain.Interfaces;

public interface IApplicationRepository : IRepository<Aplicacao>
{
    Task<Aplicacao?> GetByCaminhoAsync(string caminhoExecutavel);
    Task<IEnumerable<Aplicacao>> GetActiveAsync();
    Task<bool> ExistsByCaminhoAsync(string caminhoExecutavel);

    /// <summary>
    /// Obtém apenas as aplicações ativas e configuráveis.
    /// </summary>
    Task<IEnumerable<Aplicacao>> GetConfigurableAppsAsync();
}