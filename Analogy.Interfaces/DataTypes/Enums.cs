using System;

namespace Analogy.Interfaces
{
    public enum AnalogyCustomActionType
    {
        BelongsToProvider,
        Global,
    }
    /// <summary>
    /// LogClass identifies the class of a log event.
    /// </summary>
    public enum AnalogyLogClass
    {
        /// <summary>
        /// Most log events
        /// </summary>
        General,

        /// <summary>
        /// Security logs (audit trails)
        /// </summary>
        Security,

        /// <summary>
        /// Hazard issues
        /// </summary>
        Hazard,
        //
        // Summary:
        //Protected Health Information
        PHI
    }
    /// <summary>
    /// LogLevel enumerates the possible logging levels.
    /// </summary>
    public enum AnalogyLogLevel
    {
        Unknown,
        Trace,
        Verbose,
        Debug,
        Information,
        Warning,
        Error,
        Critical,
        Analogy,
        None
    }

    public enum AnalogChangeLogType
    {
        None,
        Bug,
        Feature,
        Improvement
    }

    public enum AnalogyLogMessagePropertyName
    {
        Date,
        Id,
        Text,
        Category,
        Source,
        Module,
        MethodName,
        FileName,
        User,
        LineNumber,
        ProcessId,
        ThreadId,
        Level,
        Class,
        MachineName
    }

    [Flags()]
    public enum AnalogyExtensionType
    {
        None = 0,
        InPlace = 1,
        UserControl = 2
    }

    public enum AnalogyDataSourceType
    {
        RealTimeDataSource,
        OfflineDataSource,

    }
}
