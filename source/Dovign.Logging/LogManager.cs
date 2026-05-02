using Microsoft.Extensions.Logging;

namespace Dovign.Logging;

public class LogManager
{
    private static readonly Lazy<LogManager> Instance = new(() => new LogManager());
    private static readonly Lazy<NoLogger> NoLoggerInstance = new(() => new NoLogger());
    
    internal static LogManager Current => Instance.Value;
    internal ILoggerFactory? Factory { get; set; }

    private LogManager()
    {
    }
    
    public static ILogger GetLogger<T>() => (ILogger?)Current.Factory?.CreateLogger<T>() ?? NoLoggerInstance.Value;
    public static ILogger GetLogger(Type type) => Current.Factory?.CreateLogger(type) ?? NoLoggerInstance.Value;
    public static ILogger GetLogger(string loggerName) => Current.Factory?.CreateLogger(loggerName) ?? NoLoggerInstance.Value;
}
