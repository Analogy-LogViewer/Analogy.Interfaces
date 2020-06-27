namespace Analogy.Interfaces
{

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
        Disabled,
        Trace,
        Verbose,
        Debug,
        Event,
        Warning,
        Error,
        Critical,
        AnalogyInformation
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
}
