using Microsoft.Extensions.Logging;

namespace ZiggyRafiq.CodeExample04.InversionOfControl
{
    public class ExampleLogger : ILogger
    {
        private readonly ILogger _logger;

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return _logger.BeginScope(state);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _logger.IsEnabled(logLevel);
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            _logger.Log(logLevel, eventId, state, exception, formatter);
        }

        public void LogInfo(string message) 
        { 
            _logger.LogInformation(message);
            
        }
    }
}
