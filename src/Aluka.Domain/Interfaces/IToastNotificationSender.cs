using Aluka.Domain.Enums;

namespace Aluka.Domain.Interfaces;

/// <summary>
/// Interface para enviar notificações Toast do Windows.
/// Esta abstração permite desacoplar a Application da Infrastructure.
/// </summary>
public interface IToastNotificationSender
{
    /// <summary>
    /// Envia uma notificação Toast.
    /// </summary>
    /// <param name="title">Título da notificação.</param>
    /// <param name="message">Mensagem da notificação.</param>
    /// <param name="type">Tipo de notificação.</param>
    /// <param name="duration">Duração: "Short" (5s) ou "Long" (25s).</param>
    /// <param name="onClickAction">Ação a executar quando clicada.</param>
    void SendToast(
        string title,
        string message,
        NotificationType type = NotificationType.Information,
        string duration = "Short",
        Action? onClickAction = null);

    /// <summary>
    /// Verifica se as notificações estão disponíveis no sistema.
    /// </summary>
    bool IsAvailable();
}