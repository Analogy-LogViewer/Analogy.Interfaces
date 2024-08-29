using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Analogy.Interfaces
{
    public class AnalogyLogMessage : IEquatable<AnalogyLogMessage>, IAnalogyLogMessage
    {
        private static readonly string CurrentProcessName = Process.GetCurrentProcess().ProcessName;
        private static readonly int CurrentProcessId = Process.GetCurrentProcess().Id;
        private AnalogyRowTextType _rawTextType;

        /// <summary>
        /// Gets/Sets date and time of arrival of log message
        /// Applicable only at server or pilot adapter
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets/Sets a unique identifier of the log message
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets/Sets the log message text
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Gets/Sets the source of the log message
        /// </summary>
        public string? Source { get; set; }

        /// <summary>
        /// Gets/Sets the method name of message generator
        /// </summary>
        public string? MethodName { get; set; }

        /// <summary>
        /// Gets/Sets the filename of message generator
        /// </summary>
        public string? FileName { get; set; }

        /// <summary>
        /// Gets/Sets the line number of message generator
        /// </summary>
        public long LineNumber { get; set; }

        /// <summary>
        /// Gets/Sets the log class of the message
        /// </summary>
        public AnalogyLogClass Class { get; set; }
        public string? MachineName { get; set; }

        /// <summary>
        /// Gets/Sets the log level of the message
        /// </summary>
        public AnalogyLogLevel Level { get; set; }

        /// <summary>
        /// Gets/Sets the module (process) name of message generator
        /// </summary>
        public string? Module { get; set; }

        /// <summary>
        /// Gets/Sets the system process ID of message generator
        /// </summary>
        public int ProcessId { get; set; }

        /// <summary>
        /// Gets/Sets the Thread ID of message generator
        /// </summary>
        public int ThreadId { get; set; }

        /// <summary>
        /// Key/Value additional information for the message
        /// </summary>
        public Dictionary<string, string>? AdditionalProperties { get; private set; }

        /// <summary>
        /// The user Name for the message
        /// </summary>
        public string? User { get; set; }
        public static Dictionary<string, AnalogyLogMessagePropertyName> LogMessagePropertyNames { get; set; }

        /// <summary>
        /// The raw message text/data before formatting
        /// </summary>
        public string RawText { get; set; }

        /// <summary>
        /// The raw message text/data type
        /// </summary>
        public AnalogyRowTextType RawTextType
        {
            get => string.IsNullOrEmpty(RawText) ? AnalogyRowTextType.None : _rawTextType;
            set => _rawTextType = value;
        }

        public void AddOrReplaceAdditionalProperty(string key, string value)
        {
            if (AdditionalProperties == null)
            {
                AdditionalProperties = new Dictionary<string, string>() { { key, value } };
            }
            else
            {
                AdditionalProperties[key] = value;
            }
        }

        public void AddOrReplaceAdditionalProperty(string key, string value, IEqualityComparer<string> comparer)
        {
            if (AdditionalProperties == null)
            {
                AdditionalProperties = new Dictionary<string, string>(comparer) { { key, value } };
            }
            else
            {
                AdditionalProperties[key] = value;
            }
        }

        static AnalogyLogMessage()
        {
            LogMessagePropertyNames = new Dictionary<string, AnalogyLogMessagePropertyName>(StringComparer.InvariantCultureIgnoreCase);
            foreach (var property in Enum.GetValues(typeof(AnalogyLogMessagePropertyName)).Cast<AnalogyLogMessagePropertyName>())
            {
                LogMessagePropertyNames.Add(property.ToString(), property);
            }
        }
        public AnalogyLogMessage()
        {
            Id = Guid.NewGuid();
            Text = string.Empty;
            Date = DateTime.Now;
            User = string.Empty;
            Module = string.Empty;
            FileName = string.Empty;
            MethodName = string.Empty;
            Source = string.Empty;
            MachineName = string.Empty;
            RawText = string.Empty;
            RawTextType = AnalogyRowTextType.None;
        }

        public AnalogyLogMessage(string text, AnalogyLogLevel level, string? source = "",
            [CallerMemberName] string? methodName = "", [CallerFilePath] string? fileName = "",
            [CallerLineNumber] int lineNumber = 0) : this(text, level, AnalogyLogClass.General, source, string.Empty,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }

        public AnalogyLogMessage(string text, AnalogyLogLevel level, AnalogyLogClass logClass, string? source,
            string? moduleOrProcessName = null, string? machineName = null, int processId = 0,
            int threadId = 0, Dictionary<string, string>? additionalInfo = null, string? user = null,
            [CallerMemberName] string? methodName = null, [CallerFilePath] string? fileName = null,
            [CallerLineNumber] int lineNumber = 0) : this()
        {
            Text = text;
            Source = source ?? string.Empty;
            MethodName = methodName ?? string.Empty;
            FileName = fileName ?? string.Empty;
            MachineName = machineName ?? string.Empty;
            LineNumber = lineNumber;
            Class = logClass;
            Level = level;
            Module = moduleOrProcessName ?? CurrentProcessName;
            ProcessId = processId != 0 ? processId : CurrentProcessId;
            AdditionalProperties = additionalInfo;
            User = user ?? string.Empty;
            ThreadId = threadId != 0 ? threadId : System.Threading.Thread.CurrentThread.ManagedThreadId;
            RawText = text;
            RawTextType = AnalogyRowTextType.Unknown;
        }
        public AnalogyLogMessage(string text, string rawText, AnalogyRowTextType rawTextType, AnalogyLogLevel level, AnalogyLogClass logClass, string? source,
            string? moduleOrProcessName = null, string? machineName = null, int processId = 0,
            int threadId = 0, Dictionary<string, string>? additionalInfo = null, string? user = null,
            [CallerMemberName] string? methodName = null, [CallerFilePath] string? fileName = null,
            [CallerLineNumber] int lineNumber = 0) : this()
        {
            Text = text;
            Source = source ?? string.Empty;
            MethodName = methodName ?? string.Empty;
            FileName = fileName ?? string.Empty;
            MachineName = machineName ?? string.Empty;
            LineNumber = lineNumber;
            Class = logClass;
            Level = level;
            Module = moduleOrProcessName ?? CurrentProcessName;
            ProcessId = processId != 0 ? processId : CurrentProcessId;
            AdditionalProperties = additionalInfo;
            User = user ?? string.Empty;
            ThreadId = threadId != 0 ? threadId : System.Threading.Thread.CurrentThread.ManagedThreadId;
            if (string.IsNullOrEmpty(rawText))
            {
                RawText = text;
                RawTextType = AnalogyRowTextType.Unknown;
            }
            else
            {
                RawText = rawText;
                RawTextType = rawTextType;
            }
        }

        public bool Equals(AnalogyLogMessage? other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            bool areEqual = Date.Equals(other.Date) && Id.Equals(other.Id) && Text == other.Text &&
                            Source == other.Source && MethodName == other.MethodName && FileName == other.FileName &&
                            LineNumber == other.LineNumber && Class == other.Class && Level == other.Level &&
                            Module == other.Module && ProcessId == other.ProcessId && ThreadId == other.ThreadId &&
                            User == other.User && MachineName == other.MachineName &&
                            RawTextType == other.RawTextType &&
                            RawText == other.RawText;
            if (!areEqual || (AdditionalProperties == null && other.AdditionalProperties != null) ||
                (AdditionalProperties != null && other.AdditionalProperties == null))
            {
                return false;
            }

            if (AdditionalProperties == null && other.AdditionalProperties == null)
            {
                return true;
            }
            if ((AdditionalProperties == null && other.AdditionalProperties != null) ||
            (AdditionalProperties != null && other.AdditionalProperties == null))
            {
                return false;
            }
            if (AdditionalProperties != null && other.AdditionalProperties != null)
            {
                return AdditionalProperties.SequenceEqual(other.AdditionalProperties);
            }

            return false;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            return obj.GetType() == this.GetType() && Equals((AnalogyLogMessage)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Date.GetHashCode();
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (Text != null ? Text.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ (Source != null ? Source.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ (MethodName != null ? MethodName.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ (FileName != null ? FileName.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ (MachineName != null ? MachineName.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ (int)LineNumber;
                hashCode = (hashCode * 397) ^ (int)Class;
                hashCode = (hashCode * 397) ^ (int)Level;
                hashCode = (hashCode * 397) ^ (Module != null ? Module.GetHashCode() : 1);
                hashCode = (hashCode * 397) ^ ProcessId;
                hashCode = (hashCode * 397) ^ ThreadId;
                hashCode = (hashCode * 397) ^ RawTextType.GetHashCode();
                hashCode = (hashCode * 397) ^ (RawText != null ? RawText.GetHashCode() : 1);
                if (AdditionalProperties is { Count: > 0 })
                {
                    foreach (var parameter in AdditionalProperties)
                    {
                        hashCode = (hashCode * 397) ^ parameter.GetHashCode();
                    }
                }
                hashCode = (hashCode * 397) ^ (User != null ? User.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Date)}: {Date}, {nameof(Level)}: {Level}, {nameof(Text)}: {Text}, {nameof(Source)}: {Source}, {nameof(Module)}: {Module}, {nameof(MethodName)}: {MethodName}, {nameof(FileName)}: {FileName}, {nameof(LineNumber)}: {LineNumber}, {nameof(Class)}: {Class}, {nameof(ProcessId)}: {ProcessId}, {nameof(ThreadId)}: {ThreadId}, {nameof(User)}: {User}, {nameof(RawText)}: {RawText}, {nameof(RawTextType)}: {RawTextType}, {nameof(AdditionalProperties)}: {(AdditionalProperties != null ? string.Join(",", AdditionalProperties) : string.Empty)}, {nameof(Id)}: {Id}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogMessage Parse(IEnumerable<(AnalogyLogMessagePropertyName PropertyName, string PropertyValue)> data)
        {
            AnalogyLogMessage m = new AnalogyLogMessage
            {
                AdditionalProperties = new Dictionary<string, string>(0),
                Date = DateTime.MinValue,
                Id = Guid.Empty,
                Module = "Unknown",
                ThreadId = -1,
                ProcessId = -1,
            };
            foreach (var (propertyName, propertyValue) in data)
            {
                switch (propertyName)
                {
                    case AnalogyLogMessagePropertyName.Date:

                        if (DateTime.TryParse(propertyValue, out DateTime time))
                        {
                            m.Date = time;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Id:

                        if (Guid.TryParse(propertyValue, out Guid id))
                        {
                            m.Id = id;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Text:
                        m.Text = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.Source:
                        m.Source = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.MethodName:
                        m.MethodName = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.FileName:
                        m.FileName = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.Module:
                        m.Module = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.MachineName:
                        m.MachineName = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.User:
                        m.User = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.LineNumber:

                        if (int.TryParse(propertyValue, out int lineNumber))
                        {
                            m.LineNumber = lineNumber;
                        }

                        continue;
                    case AnalogyLogMessagePropertyName.ProcessId:

                        if (int.TryParse(propertyValue, out int processId))
                        {
                            m.ProcessId = processId;
                        }

                        continue;
                    case AnalogyLogMessagePropertyName.ThreadId:

                        if (int.TryParse(propertyValue, out int threadId))
                        {
                            m.ThreadId = threadId;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Level:

                        if (Enum.TryParse(propertyValue, ignoreCase: true, out AnalogyLogLevel level) &&
                            Enum.IsDefined(typeof(AnalogyLogLevel), level))
                        {
                            m.Level = level;
                        }
                        else
                        {
                            m.Level = ParseLogLevelFromString(propertyValue);
                        }

                        continue;
                    case AnalogyLogMessagePropertyName.Class:

                        m.Class = Enum.TryParse(propertyValue, ignoreCase: true, out AnalogyLogClass cls) &&
                                  Enum.IsDefined(typeof(AnalogyLogClass), cls)
                            ? cls
                            : AnalogyLogClass.General;

                        continue;
                    case AnalogyLogMessagePropertyName.RawText:
                        m.RawText = string.IsNullOrEmpty(propertyValue) ? string.Empty : propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.RawTextType:
                        m.RawTextType = Enum.TryParse(propertyValue, ignoreCase: true, out AnalogyRowTextType type) &&
                                  Enum.IsDefined(typeof(AnalogyRowTextType), type)
                            ? type
                            : AnalogyRowTextType.None;
                        continue;
                    default: continue;
                }
            }

            return m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogMessage Parse(IEnumerable<(string PropertyName, string PropertyValue)> data)
        {
            var valueTuples = data.ToList();
            var dataProperties = valueTuples.Where(p => LogMessagePropertyNames.ContainsKey(p.PropertyName)).Select(s => (LogMessagePropertyNames[s.PropertyName], s.PropertyValue)).ToList();
            var m = Parse(dataProperties);
            var dataNotProperties = valueTuples.Where(p => !LogMessagePropertyNames.ContainsKey(p.PropertyName)).ToList();
            if (dataNotProperties.Count > 0)
            {
                m.AdditionalProperties = dataNotProperties.ToDictionary(p => p.PropertyName, p => p.PropertyValue);
            }

            return m;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogLevel ParseLogLevelFromString(string level)
        {
            switch (level)
            {
                case "disabled":
                case "Disabled":
                case "Off":
                case "OFF":
                case "none":
                case "None":
                case "NONE":
                    return AnalogyLogLevel.None;
                case "TCE":
                case "trc":
                case "TRC":
                case "trace":
                case "Trace":
                case "TRACE":
                    return AnalogyLogLevel.Trace;
                case "DBG":
                case "debug":
                case "Debug":
                case "DEBUG":
                case "Dbug":
                case "dbug":
                case "DebugVerbose":
                    return AnalogyLogLevel.Debug;
                case "INF":
                case "info":
                case "Info":
                case "INFO":
                case "Event":
                case "Information":
                case "information":
                case "INFORMATION":
                    return AnalogyLogLevel.Information;
                case "wrn":
                case "WRN":
                case "warn":
                case "Warn":
                case "WARN":
                case "Warning":
                case "WARNING":
                    return AnalogyLogLevel.Warning;
                case "error":
                case "Error":
                case "ERROR":
                case "ERR":
                case "Err":
                case "err":
                    return AnalogyLogLevel.Error;
                case "ftl":
                case "FTL":
                case "crit":
                case "critical":
                case "Critical":
                case "fatal":
                case "Fatal":
                case "FATAL":
                    return AnalogyLogLevel.Critical;
                case "VRB":
                case "verbose":
                case "Verbose":
                case "VERBOSE":
                case "DebugInfo":
                    return AnalogyLogLevel.Verbose;
                case "AnalogyInformation":
                case "analogy":
                case "Analogy":
                case "ANALOGY":
                    return AnalogyLogLevel.Analogy;
                default:
                    return AnalogyLogLevel.Unknown;
            }
        }
    }

    public class AnalogyInformationMessage : AnalogyLogMessage
    {
        public AnalogyInformationMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Information, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }

        public AnalogyInformationMessage(string text, string rawText, AnalogyRowTextType rawTextType, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, rawText, rawTextType, AnalogyLogLevel.Information, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
    }

    public class AnalogyErrorMessage : AnalogyLogMessage
    {
        public AnalogyErrorMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Error, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
        public AnalogyErrorMessage(string text, string rawText, AnalogyRowTextType rawTextType, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, rawText, rawTextType, AnalogyLogLevel.Error, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
    }
    public class AnalogyWarningMessage : AnalogyLogMessage
    {
        public AnalogyWarningMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Warning, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
        public AnalogyWarningMessage(string text, string rawText, AnalogyRowTextType rawTextType, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, rawText, rawTextType, AnalogyLogLevel.Warning, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
    }
    public class AnalogyDebugMessage : AnalogyLogMessage
    {
        public AnalogyDebugMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Debug, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
        public AnalogyDebugMessage(string text, string rawText, AnalogyRowTextType rawTextType, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, rawText, rawTextType, AnalogyLogLevel.Debug, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
    }
    public class AnalogyCriticalMessage : AnalogyLogMessage
    {
        public AnalogyCriticalMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Critical, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
        public AnalogyCriticalMessage(string text, string rawText, AnalogyRowTextType rawTextType, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, rawText, rawTextType, AnalogyLogLevel.Critical, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {
        }
    }
}