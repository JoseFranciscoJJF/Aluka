using Aluka.Domain.Enums;
using Aluka.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Aluka.Application.Services;

/// <summary>
/// Serviço de notificações do Aluka.
/// Gerencia o envio de notificações Toast com controlo de cooldown.
/// </summary>
public class NotificationService : INotificationService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IToastNotificationSender _toastSender;
    private readonly IConfiguration _configuration;
    private readonly ILogger<NotificationService> _logger;

    private readonly bool _globalEnabled;
    private readonly int _cooldownMinutes;
    private readonly int _defaultDelaySeconds;

    public NotificationService(
        IUnitOfWork unitOfWork,
        IToastNotificationSender toastSender,
        IConfiguration configuration,
        ILogger<NotificationService> logger)
    {
        _unitOfWork = unitOfWork;
        _toastSender = toastSender;
        _configuration = configuration;
        _logger = logger;

        // =========================================================
        // CORREÇÃO: Usar GetSection e converter manualmente
        // =========================================================
        var section = _configuration.GetSection("Notifications");
        
        _globalEnabled = bool.TryParse(section["Enabled"], out var enabled) ? enabled : true;
        _cooldownMinutes = int.TryParse(section["CooldownMinutes"], out var cooldown) ? cooldown : 60;
        _defaultDelaySeconds = int.TryParse(section["DefaultDelaySeconds"], out var delay) ? delay : 0;
    }

    public async Task<bool> SendSuccessNotificationAsync(int ruleId, string appName, string action)
    {
        try
        {
            if (!IsGloballyEnabled())
            {
                _logger.LogDebug("Notificações globalmente desativadas.");
                return false;
            }

            if (!await CanNotifyAsync(ruleId))
            {
                _logger.LogDebug("Regra {RuleId} não pode notificar.", ruleId);
                return false;
            }

            var rule = await _unitOfWork.Rules.GetByIdAsync(ruleId);
            if (rule == null)
            {
                _logger.LogWarning("Regra {RuleId} não encontrada.", ruleId);
                return false;
            }

            var message = GetNotificationMessage(appName, action, true);
            var duracao = rule.ObterDuracaoNotificacao();
            var atraso = rule.AtrasoNotificacaoSegundos ?? _defaultDelaySeconds;

            if (atraso > 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(atraso));
            }

            _toastSender.SendToast(
                title: $"Aluka - {action}",
                message: message,
                type: NotificationType.Success,
                duration: duracao);

            rule.RegistrarNotificacao();
            await _unitOfWork.Rules.UpdateAsync(rule);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Notificação de sucesso enviada para regra {RuleId}: {AppName}", ruleId, appName);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao enviar notificação de sucesso para regra {RuleId}", ruleId);
            return false;
        }
    }

    public async Task<bool> SendErrorNotificationAsync(int ruleId, string appName, string errorMessage)
    {
        try
        {
            if (!IsGloballyEnabled())
            {
                _logger.LogDebug("Notificações globalmente desativadas.");
                return false;
            }

            if (!await CanNotifyAsync(ruleId))
            {
                _logger.LogDebug("Regra {RuleId} não pode notificar.", ruleId);
                return false;
            }

            var rule = await _unitOfWork.Rules.GetByIdAsync(ruleId);
            if (rule == null)
            {
                _logger.LogWarning("Regra {RuleId} não encontrada.", ruleId);
                return false;
            }

            var message = GetNotificationMessage(appName, "execução", false);
            message = $"{message}\nErro: {errorMessage}";

            var duracao = rule.ObterDuracaoNotificacao();
            var atraso = rule.AtrasoNotificacaoSegundos ?? _defaultDelaySeconds;

            if (atraso > 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(atraso));
            }

            _toastSender.SendToast(
                title: "Aluka - Erro",
                message: message,
                type: NotificationType.Error,
                duration: duracao);

            rule.RegistrarNotificacao();
            await _unitOfWork.Rules.UpdateAsync(rule);
            await _unitOfWork.CompleteAsync();

            _logger.LogInformation("Notificação de erro enviada para regra {RuleId}: {AppName}", ruleId, appName);
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao enviar notificação de erro para regra {RuleId}", ruleId);
            return false;
        }
    }

    public bool IsGloballyEnabled()
    {
        return _globalEnabled && _toastSender.IsAvailable();
    }

    public async Task<bool> CanNotifyAsync(int ruleId)
    {
        try
        {
            var rule = await _unitOfWork.Rules.GetByIdAsync(ruleId);
            return rule?.PodeNotificar() ?? false;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao verificar permissão de notificação para regra {RuleId}", ruleId);
            return false;
        }
    }

    public string GetNotificationMessage(string appName, string action, bool isSuccess)
    {
        return isSuccess
            ? $"✅ {appName} foi {action.ToLower()} com sucesso."
            : $"❌ Falha ao {action.ToLower()} {appName}.";
    }
}