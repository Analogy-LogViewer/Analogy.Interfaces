using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Analogy.Interfaces
{
    public class AnalogyProgressReport
    {
        public string Prefix { get; set; }
        public int Processed { get; set; }
        public int Total { get; set; }
        public string FinishedProcessing { get; set; }
        public AnalogyProgressReport(string prefix, int processed, int total, string finishedProcessing) => (Prefix, Processed, Total, FinishedProcessing) = (prefix, processed, total, finishedProcessing);
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
    public class AnalogyColumnInfo
    {
        public string ColumnCaption { get; }
        public string ColumnName { get; }
        public Type ColumnType { get; }

        public AnalogyColumnInfo(string columnCaption, string columnName, Type columnType)
        {
            ColumnCaption = columnCaption;
            ColumnName = columnName;
            ColumnType = columnType;
        }
    }



    /// <summary>
    /// Class representing Log message
    /// </summary>
    [Serializable]
    [XmlRoot("AnalogyLogMessage")]

    public class AnalogyLogMessage : IEquatable<AnalogyLogMessage>, IAnalogyLogMessage
    {

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

        public int ThreadId { get; set; }

        /// <summary>
        /// Additional information that will be presented as new columns in the UI
        /// </summary>
        [XmlIgnore]
        public Dictionary<string, string> AdditionalInformation { get; set; }

        public string User { get; set; }

        private static string _currentProcessName = Process.GetCurrentProcess().ProcessName;
        private static int _currentProcessId = Process.GetCurrentProcess().Id;
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

        public AnalogyLogMessage(string text, AnalogyLogLevel level, string source = null,
            [CallerMemberName] string methodName = null, [CallerFilePath] string fileName = null,
            [CallerLineNumber] int lineNumber = 0) : this(text, level, AnalogyLogClass.General, source, string.Empty,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {

        }

        public AnalogyLogMessage(string text, AnalogyLogLevel level, AnalogyLogClass logClass, string source, string category = null, string moduleOrProcessName = null, string machineName = null, int processId = 0, int threadId = 0, Dictionary<string,string> additionalInfo = null, string user = null, [CallerMemberName] string methodName = null, [CallerFilePath] string fileName = null, [CallerLineNumber] int lineNumber = 0) : this()
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
            Module = moduleOrProcessName ?? _currentProcessName;
            ProcessId = processId != 0 ? processId : _currentProcessId;
            AdditionalInformation = additionalInfo;
            User = user ?? string.Empty;
            ThreadId = threadId != 0 ? threadId : System.Threading.Thread.CurrentThread.ManagedThreadId;
        }

        public bool Equals(AnalogyLogMessage other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            bool areEqual = Date.Equals(other.Date) && Id.Equals(other.Id) && Text == other.Text &&
                            Category == other.Category &&
                            Source == other.Source && MethodName == other.MethodName && FileName == other.FileName &&
                            LineNumber == other.LineNumber && Class == other.Class && Level == other.Level &&
                            Module == other.Module && ProcessId == other.ProcessId && ThreadId == other.ThreadId &&
                            User == other.User && MachineName == other.MachineName;
            if (!areEqual ||
                AdditionalInformation == null && other.AdditionalInformation != null ||
                AdditionalInformation != null && other.AdditionalInformation == null)
                return false;
            if (AdditionalInformation == null && other.AdditionalInformation == null)
                return true;
            return AdditionalInformation.SequenceEqual(other.AdditionalInformation);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
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
                                m.Date = time;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.Id:
                        {
                            if (Guid.TryParse(propertyValue, out Guid id))
                                m.Id = id;
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
                                m.LineNumber = num;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.ProcessId:
                        {
                            if (int.TryParse(propertyValue, out int num))
                                m.ProcessId = num;
                        }
                        continue;
                    case AnalogyLogMessagePropertyName.ThreadId:
                        {
                            if (int.TryParse(propertyValue, out int num))
                                m.ThreadId = num;
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
                                    case "OFF":
                                        m.Level = AnalogyLogLevel.Disabled;
                                        break;
                                    case "TRACE":
                                        m.Level = AnalogyLogLevel.Trace;
                                        break;
                                    case "DEBUG":
                                        m.Level = AnalogyLogLevel.Debug;
                                        break;
                                    case "INFO":
                                        m.Level = AnalogyLogLevel.Event;
                                        break;
                                    case "WARN":
                                        m.Level = AnalogyLogLevel.Warning;
                                        break;
                                    case "ERROR":
                                        m.Level = AnalogyLogLevel.Error;
                                        break;
                                    case "FATAL":
                                        m.Level = AnalogyLogLevel.Critical;
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
    }

    public class AnalogyEventMessage : AnalogyLogMessage
    {
        public AnalogyEventMessage(string text, string source = null,
            [CallerMemberName] string methodName = null, [CallerFilePath] string fileName = null,
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Event, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {

        }
    }

    public class AnalogyErrorMessage : AnalogyLogMessage
    {
        public AnalogyErrorMessage(string text, string source = null,
            [CallerMemberName] string methodName = null, [CallerFilePath] string fileName = null,
            [CallerLineNumber] int lineNumber = 0) : base(text, AnalogyLogLevel.Error, AnalogyLogClass.General, source,
            methodName: methodName, fileName: fileName, lineNumber: lineNumber)
        {

        }
    }
}
