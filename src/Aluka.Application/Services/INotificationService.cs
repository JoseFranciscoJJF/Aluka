namespace Aluka.Application.Services;

/// <summary>
/// Interface para o serviço de notificações do Aluka.
/// </summary>
public interface INotificationService
{
    /// <summary>
    /// Envia uma notificação de sucesso para uma regra.
    /// </summary>
    Task<bool> SendSuccessNotificationAsync(int ruleId, string appName, string action);

    /// <summary>
    /// Envia uma notificação de erro para uma regra.
    /// </summary>
    Task<bool> SendErrorNotificationAsync(int ruleId, string appName, string errorMessage);

    /// <summary>
    /// Verifica se as notificações estão globalmente ativas.
    /// </summary>
    bool IsGloballyEnabled();

    /// <summary>
    /// Verifica se uma regra específica pode notificar.
    /// </summary>
    Task<bool> CanNotifyAsync(int ruleId);

    /// <summary>
    /// Obtém a mensagem de notificação para um tipo de evento.
    /// </summary>
    string GetNotificationMessage(string appName, string action, bool isSuccess);
}