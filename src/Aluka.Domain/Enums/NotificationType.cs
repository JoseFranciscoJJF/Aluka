namespace Aluka.Domain.Enums;

/// <summary>
/// Tipos de notificação do Aluka.
/// </summary>
public enum NotificationType
{
    /// <summary>Informação geral (ícone ℹ️)</summary>
    Information = 0,

    /// <summary>Aviso (ícone ⚠️)</summary>
    Warning = 1,

    /// <summary>Erro (ícone ❌)</summary>
    Error = 2,

    /// <summary>Sucesso (ícone ✅)</summary>
    Success = 3
}