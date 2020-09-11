using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Analogy.Interfaces
{
    /// <summary>
    /// interface for logging information of data provider at the Analogy Log Viewer Ui
    /// </summary>
    public interface IAnalogyLogger
    {
        void LogEvent(string message, string source = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        void LogWarning(string message, string source = "", string memberName = "", int lineNumber = 0, string filePath = "");
        void LogDebug(string message, string source = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        void LogError(string message, string source = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        void LogCritical(string message, string source = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
        void LogException(string message, Exception ex, string source = "", [CallerMemberName] string memberName = "", [CallerLineNumber] int lineNumber = 0, [CallerFilePath] string filePath = "");
    }
}
