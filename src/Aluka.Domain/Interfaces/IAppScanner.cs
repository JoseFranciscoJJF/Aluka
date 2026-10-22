namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface para varrer aplicações instaladas no sistema.
/// </summary>
public interface IAppScanner
{
    /// <summary>
    /// Varre o sistema em busca de aplicações instaladas.
    /// </summary>
    Task<IEnumerable<(string Nome, string Caminho, string? IconeBase64)>> ScanInstalledAppsAsync();
}