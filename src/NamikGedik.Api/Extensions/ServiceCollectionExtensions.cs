using Microsoft.Extensions.Options;
using NamikGedik.Api.Configuration;
using NamikGedik.Application.Contracts;
using NamikGedik.Infrastructure.Data;
using NamikGedik.Infrastructure.Services;

namespace NamikGedik.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<DatabaseOptions>(configuration.GetSection(DatabaseOptions.SectionName));
        services.Configure<AuthOptions>(configuration.GetSection(AuthOptions.SectionName));

        services.AddSingleton(sp =>
        {
            var options = sp.GetRequiredService<IOptions<DatabaseOptions>>().Value;
            return new SqlConnectionSettings
            {
                Host = options.Host,
                Port = options.Port,
                Database = options.Name,
                UserName = options.User,
                Password = options.Password
            };
        });

        services.AddSingleton<SqlConnectionFactory>();
        services.AddScoped<IAdminAuthService, AdminAuthService>();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddScoped<ICommentModerationService, CommentModerationService>();

        return services;
    }
}
