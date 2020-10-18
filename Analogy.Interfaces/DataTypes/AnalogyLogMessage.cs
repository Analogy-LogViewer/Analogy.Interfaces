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
        public string Text { get; set; }

        /// <summary>
        /// Gets/Sets the category of the log message
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets/Sets the source of the log message
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Gets/Sets the method name of message generator
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets/Sets the filename of message generator
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets/Sets the line number of message generator
        /// </summary>
        public int LineNumber { get; set; }

        /// <summary>
        /// Gets/Sets the log class of the message
        /// </summary>
        public AnalogyLogClass Class { get; set; }
        public string MachineName { get; set; }
        /// <summary>
        /// Gets/Sets the log level of the message
        /// </summary>
        public AnalogyLogLevel Level { get; set; }

        /// <summary>
        /// Gets/Sets the module (process) name of message generator
        /// </summary>
        public string Module { get; set; }

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
        public Dictionary<string, string>? AdditionalInformation { get; set; }
        /// <summary>
        /// The user Name for the message
        /// </summary>
        public string User { get; set; }


        public static Dictionary<string, AnalogyLogMessagePropertyName> LogMessagePropertyNames { get; set; }

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
            Category = string.Empty;
            MachineName = string.Empty;
        }

        public AnalogyLogMessage(string text, AnalogyLogLevel level, string? source = "",
            [CallerMemberName] string? methodName = "", [CallerFilePath] string? fileName = "",
            [CallerLineNumber] int lineNumber = 0) : this(text, level, AnalogyLogClass.General, source, string.Empty,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {

        }

        public AnalogyLogMessage(string text, AnalogyLogLevel level, AnalogyLogClass logClass, string? source, string? category = null, string? moduleOrProcessName = null, string? machineName = null, int processId = 0, int threadId = 0, Dictionary<string, string>? additionalInfo = null, string? user = null, [CallerMemberName] string? methodName = null, [CallerFilePath] string? fileName = null, [CallerLineNumber] int lineNumber = 0) : this()
        {
            Text = text;
            Category = category ?? string.Empty;
            Source = source ?? string.Empty;
            MethodName = methodName ?? string.Empty;
            FileName = fileName ?? string.Empty;
            MachineName = machineName ?? string.Empty;
            LineNumber = lineNumber;
            Class = logClass;
            Level = level;
            Module = moduleOrProcessName ?? CurrentProcessName;
            ProcessId = processId != 0 ? processId : CurrentProcessId;
            AdditionalInformation = additionalInfo;
            User = user ?? string.Empty;
            ThreadId = threadId != 0 ? threadId : System.Threading.Thread.CurrentThread.ManagedThreadId;
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
                            Category == other.Category &&
                            Source == other.Source && MethodName == other.MethodName && FileName == other.FileName &&
                            LineNumber == other.LineNumber && Class == other.Class && Level == other.Level &&
                            Module == other.Module && ProcessId == other.ProcessId && ThreadId == other.ThreadId &&
                            User == other.User && MachineName == other.MachineName;
            if (!areEqual || AdditionalInformation == null && other.AdditionalInformation != null ||
                AdditionalInformation != null && other.AdditionalInformation == null)
            {
                return false;
            }

            if (AdditionalInformation == null && other.AdditionalInformation == null)
            {
                return true;
            }
            if (AdditionalInformation == null && other.AdditionalInformation != null ||
            AdditionalInformation != null && other.AdditionalInformation == null)
            {
                return false;
            }
            return AdditionalInformation.SequenceEqual(other.AdditionalInformation);
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
                hashCode = (hashCode * 397) ^ (Text != null ? Text.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Category != null ? Category.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Source != null ? Source.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MethodName != null ? MethodName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (FileName != null ? FileName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (MachineName != null ? MachineName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ LineNumber;
                hashCode = (hashCode * 397) ^ (int)Class;
                hashCode = (hashCode * 397) ^ (int)Level;
                hashCode = (hashCode * 397) ^ (Module != null ? Module.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ ProcessId;
                hashCode = (hashCode * 397) ^ ThreadId;
                if (AdditionalInformation != null && AdditionalInformation.Any())
                {
                    foreach (var parameter in AdditionalInformation)
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
            return $"{nameof(Date)}: {Date}, {nameof(Level)}: {Level}, {nameof(Text)}: {Text}, {nameof(Source)}: {Source}, {nameof(Module)}: {Module}, {nameof(MethodName)}: {MethodName}, {nameof(Category)}: {Category}, {nameof(FileName)}: {FileName}, {nameof(LineNumber)}: {LineNumber}, {nameof(Class)}: {Class}, {nameof(ProcessId)}: {ProcessId}, {nameof(ThreadId)}: {ThreadId}, {nameof(User)}: {User}, {nameof(AdditionalInformation)}: {(AdditionalInformation != null ? string.Join(",", AdditionalInformation) : string.Empty)}, {nameof(Id)}: {Id}";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogMessage Parse(IEnumerable<(AnalogyLogMessagePropertyName PropertyName, string propertyValue)> data)
        {
            AnalogyLogMessage m = new AnalogyLogMessage
            {
                AdditionalInformation = new Dictionary<string, string>(0),
                Date = DateTime.MinValue,
                Id = Guid.Empty,
                Module = "Unknown",
                ThreadId = -1,
                ProcessId = -1
            };
            foreach (var (propertyName, propertyValue) in data)
            {
                switch (propertyName)
                {
                    case AnalogyLogMessagePropertyName.Date:
                        {
                            if (DateTime.TryParse(propertyValue, out DateTime time))
                            {
                                m.Date = time;
                            }
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Id:
                        {
                            if (Guid.TryParse(propertyValue, out Guid id))
                            {
                                m.Id = id;
                            }
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Text:
                        m.Text = propertyValue;
                        continue;
                    case AnalogyLogMessagePropertyName.Category:
                        m.Category = propertyValue;
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
                        {
                            if (int.TryParse(propertyValue, out int num))
                            {
                                m.LineNumber = num;
                            }
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.ProcessId:
                        {
                            if (int.TryParse(propertyValue, out int num))
                            {
                                m.ProcessId = num;
                            }
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.ThreadId:
                        {
                            if (int.TryParse(propertyValue, out int num))
                            {
                                m.ThreadId = num;
                            }
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Level:
                        {
                            if (Enum.TryParse(propertyValue, true, out AnalogyLogLevel level) &&
                                Enum.IsDefined(typeof(AnalogyLogLevel), level))
                            {
                                m.Level = level;
                            }
                            else
                            {
                                switch (propertyValue)
                                {
                                    case "Disabled":
                                    case "Off":
                                    case "OFF":
                                    case "None":
                                    case "NONE":
                                        m.Level = AnalogyLogLevel.None;
                                        break;
                                    case "TCE":
                                    case "TRC":
                                    case "Trace":
                                    case "TRACE":
                                        m.Level = AnalogyLogLevel.Trace;
                                        break;
                                    case "DBG":
                                    case "Debug":
                                    case "DEBUG":
                                    case "DebugVerbose":
                                        m.Level = AnalogyLogLevel.Debug;
                                        break;
                                    case "INF":
                                    case "Info":
                                    case "INFO":
                                    case "Event":
                                    case "Information":
                                    case "information":
                                    case "INFORMATION":
                                        m.Level = AnalogyLogLevel.Information;
                                        break;
                                    case "WRN":
                                    case "Warn":
                                    case "WARN":
                                    case "Warning":
                                    case "WARNING":
                                        m.Level = AnalogyLogLevel.Warning;
                                        break;
                                    case "Error":
                                    case "ERROR":
                                    case "ERR":
                                    case "Err":
                                        m.Level = AnalogyLogLevel.Error;
                                        break;
                                    case "FTL":
                                    case "Critical":
                                    case "Fatal":
                                    case "FATAL":
                                        m.Level = AnalogyLogLevel.Critical;
                                        break;
                                    case "Verbose":
                                    case "VERBOSE":
                                    case "DebugInfo":
                                        m.Level = AnalogyLogLevel.Verbose;
                                        break;
                                    case "AnalogyInformation":
                                    case "Analogy":
                                        m.Level = AnalogyLogLevel.Analogy;
                                        break;
                                    default:
                                        m.Level = AnalogyLogLevel.Unknown;
                                        break;
                                }

                            }

                            continue;
                        }
                    case AnalogyLogMessagePropertyName.Class:
                        {
                            m.Class = Enum.TryParse(propertyValue, true, out AnalogyLogClass cls) &&
                                      Enum.IsDefined(typeof(AnalogyLogClass), cls)
                                ? cls
                                : AnalogyLogClass.General;
                        }
                        continue;
                    default: continue;
                }
            }

            return m;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AnalogyLogMessage Parse(IEnumerable<(string PropertyName, string propertyValue)> data)
        {
            var valueTuples = data.ToList();
            var dataProperties = valueTuples.Where(p => LogMessagePropertyNames.ContainsKey(p.PropertyName)).Select(s => (LogMessagePropertyNames[s.PropertyName], s.propertyValue)).ToList();
            var m = Parse(dataProperties);
            var dataNotProperties = valueTuples.Where(p => !LogMessagePropertyNames.ContainsKey(p.PropertyName)).ToList();
            if (dataNotProperties.Any())
            {
                m.AdditionalInformation = dataNotProperties.ToDictionary(p => p.PropertyName, p => p.propertyValue);
            }

            return m;
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
    }

    public class AnalogyErrorMessage : AnalogyLogMessage
    {
        public AnalogyErrorMessage(string text, string source = "",
            [CallerMemberName] string methodName = "", [CallerFilePath] string fileName = "",
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Error, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {

        }
    }
}
