using Microsoft.Extensions.Logging;
using System;

namespace Analogy.Interfaces.WinForms.Helpers
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
    }
}