using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Dovign.Logging;

public static class ServiceProviderExtensions
{
    public static IServiceProvider InitializeLogging(this IServiceProvider services)
    {
        LogManager.Current.Factory = services.GetRequiredService<ILoggerFactory>();
        return services;
    }
}