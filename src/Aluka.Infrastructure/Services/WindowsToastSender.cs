using Aluka.Domain.Enums;
using Aluka.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace Aluka.Infrastructure.Services;

/// <summary>
/// Implementação do enviador de notificações Toast do Windows.
/// Utiliza MessageBox como fallback para não depender de pacotes externos.
/// </summary>
public class WindowsToastSender : IToastNotificationSender
{
    private readonly ILogger<WindowsToastSender> _logger;

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

    private const uint MB_OK = 0x00000000;
    private const uint MB_ICONINFORMATION = 0x00000040;
    private const uint MB_ICONWARNING = 0x00000030;
    private const uint MB_ICONERROR = 0x00000010;

    public WindowsToastSender(ILogger<WindowsToastSender> logger)
    {
        _logger = logger;
    }

    public void SendToast(
        string title,
        string message,
        NotificationType type = NotificationType.Information,
        string duration = "Short",
        Action? onClickAction = null)
    {
        try
        {
            if (!IsAvailable())
            {
                _logger.LogWarning("Notificações não disponíveis.");
                return;
            }

            uint iconType = type switch
            {
                NotificationType.Success => MB_ICONINFORMATION,
                NotificationType.Warning => MB_ICONWARNING,
                NotificationType.Error => MB_ICONERROR,
                _ => MB_ICONINFORMATION
            };

            string emoji = type switch
            {
                NotificationType.Success => "✅",
                NotificationType.Warning => "⚠️",
                NotificationType.Error => "❌",
                _ => "ℹ️"
            };

            string fullMessage = $"{emoji} {title}\n\n{message}";

            // Usar MessageBox como fallback
            MessageBox(IntPtr.Zero, fullMessage, "Aluka", MB_OK | iconType);

            _logger.LogDebug("Notificação enviada: {Title}", title);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao enviar notificação: {Title}", title);
        }
    }

    public bool IsAvailable()
    {
        try
        {
            return true;
        }
        catch
        {
            return false;
        }
    }
}