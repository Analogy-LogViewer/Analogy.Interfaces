using System;
using System.Collections.Generic;
using System.Text;

namespace Analogy.Interfaces
{
    /// <summary>
    /// interface for logging information of data provider at the Analogy Log Viewer Ui
    /// </summary>
    public interface IAnalogyLogger
    {
        void LogEvent(string source, string message, string memberName = "", int lineNumber = 0, string filePath = "");
        void LogWarning(string source, string message, string memberName = "", int lineNumber = 0,string filePath = "");

        void LogDebug(string source, string message, string memberName = "", int lineNumber = 0, string filePath = "");

        void LogError(string source, string message, string memberName = "", int lineNumber = 0, string filePath = "");

        void LogCritical(string source, string message, string memberName = "", int lineNumber = 0,string filePath = "");

        void LogException(Exception ex, string source, string message, string memberName = "", int lineNumber = 0,string filePath = "");
    }
}
