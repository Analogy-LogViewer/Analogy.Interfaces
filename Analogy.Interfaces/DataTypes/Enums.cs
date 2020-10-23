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
    /// <summary>
    ///     Enum representing the effect of Mandatory flag.
    /// </summary>
    public enum UpdateMode
    {
        /// <summary>
        /// In this mode, it ignores Remind Later and Skip values set previously and hide both buttons.
        /// </summary>
        Normal,

        /// <summary>
        /// In this mode, it won't show close button in addition to Normal mode behaviour.
        /// </summary>
        Forced,

        /// <summary>
        /// In this mode, it will start downloading and applying update without showing standard update dialog in addition to Forced mode behaviour.
        /// </summary>
        ForcedDownload
    }
}
