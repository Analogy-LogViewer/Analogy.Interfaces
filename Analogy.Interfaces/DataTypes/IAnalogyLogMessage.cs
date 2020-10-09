using System;
using System.Collections.Generic;

namespace Analogy.Interfaces
{
    public interface IAnalogyLogMessage
    {
        /// <summary>
        /// Gets/Sets date and time of arrival of log message
        /// Applicable only at server or pilot adapter
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Gets/Sets a unique identifier of the log message
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// Gets/Sets the log message text
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Gets/Sets the category of the log message
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Gets/Sets the source of the log message
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// Gets/Sets the method name of message generator
        /// </summary>
        string MethodName { get; set; }

        /// <summary>
        /// Gets/Sets the filename of message generator
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Gets/Sets the line number of message generator
        /// </summary>
        int LineNumber { get; set; }

        /// <summary>
        /// Gets/Sets the log class of the message
        /// </summary>
        AnalogyLogClass Class { get; set; }

        /// <summary>
        /// Gets/Sets the log level of the message
        /// </summary>
        AnalogyLogLevel Level { get; set; }

        /// <summary>
        /// Gets/Sets the module (process) name of message
        /// </summary>
        string Module { get; set; }
        /// <summary>
        /// Gets/Sets the Machine Name of message
        /// </summary>
        string MachineName { get; set; }

        /// <summary>
        /// Gets/Sets the system process ID of message
        /// </summary>
        int ProcessId { get; set; }

        int ThreadId { get; set; }

        /// <summary>
        /// Additional information that will be presented as new columns in the UI
        /// </summary>
        Dictionary<string, string> AdditionalInformation { get; set; }
        string User { get; set; }
    }
}
