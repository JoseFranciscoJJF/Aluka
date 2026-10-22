namespace Aluka.Domain.Enums;

/// <summary>
/// Indica o resultado da execução de uma regra.
/// </summary>
public enum StatusExecucao
{
    /// <summary>A execução foi bem-sucedida.</summary>
    Sucesso = 0,
    
    /// <summary>Ocorreu um erro durante a execução.</summary>
    Erro = 1,
    
    /// <summary>A execução foi ignorada (ex: app já estava no estado desejado).</summary>
    Ignorado = 2
}