using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Dovign.Logging;

public static class ServiceProviderExtensions
{
    public static IServiceProvider InitializeDovignLogging(this IServiceProvider services)
    {
        LogManager.Current.Factory = services.GetRequiredService<ILoggerFactory>();
        return services;
    }
}
