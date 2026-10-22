using Aluka.Application.Services;
using Aluka.Application.Validators;
using Aluka.Domain.Interfaces;
using Aluka.Infrastructure.Data;
using Aluka.Infrastructure.Data.Repositories;
using Aluka.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aluka.Infrastructure.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var dbPath = Path.Combine(AppContext.BaseDirectory, "aluka.db");
        var connectionString = $"Data Source={dbPath}";

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IApplicationRepository, ApplicationRepository>();
        services.AddScoped<IRuleRepository, RuleRepository>();
        services.AddScoped<IHistoryRepository, HistoryRepository>();

        services.AddScoped<IAppScanner, RegistryScanner>();
        services.AddScoped<WindowsProcessManager>();

        // =========================================================
        // NOTIFICAÇÕES: Usar a implementação da Infrastructure
        // =========================================================
        services.AddScoped<IToastNotificationSender, WindowsToastSender>();
        services.AddScoped<INotificationService, NotificationService>();

        services.AddHostedService<BackgroundScheduler>();

        return services;
    }

    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddScoped<IAppService, AppService>();
        services.AddScoped<IRuleService, RuleService>();
        services.AddScoped<IHistoryService, HistoryService>();

        services.AddScoped<CreateRuleDTOValidator>();
        services.AddScoped<UpdateRuleDTOValidator>();

        services.AddAutoMapper(typeof(Application.Mappings.ApplicationProfile).Assembly);

        return services;
    }
}