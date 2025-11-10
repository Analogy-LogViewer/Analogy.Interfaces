using Microsoft.Extensions.Logging;
using System;

namespace Analogy.Interfaces.Helpers
{
    public class EmptyAnalogyLogger : Microsoft.Extensions.Logging.ILogger
    {
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public void LogInformation(string message, string source = "", string memberName = "", int lineNumber = 0,
            string filePath = "")
        {
        }

        public void LogWarning(string message, string source = "", string memberName = "", int lineNumber = 0, string filePath = "")
        {
        }

        public void LogDebug(string message, string source = "", string memberName = "", int lineNumber = 0, string filePath = "")
        {
        }

        public void LogError(string message, string source = "", string memberName = "", int lineNumber = 0, string filePath = "")
        {
        }

        public void LogCritical(string message, string source = "", string memberName = "", int lineNumber = 0, string filePath = "")
        {
        }

        public void LogException(string message, Exception ex, string source = "", string memberName = "", int lineNumber = 0,
            string filePath = "")
        {
        }
    }
}