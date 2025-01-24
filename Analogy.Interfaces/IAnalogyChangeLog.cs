using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyChangeLog
    {
        /// <summary>
        /// Information about this change
        /// </summary>
        string ChangeInformation { get; }

        /// <summary>
        /// Change type
        /// </summary>
        AnalogChangeLogType ChangeLogType { get; }

        /// <summary>
        /// The person who did this commit/fix/change
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Time of the commit
        /// </summary>
        DateTimeOffset Date { get; }

        Uri? IssueUri { get; }
        string Version { get; }
    }

    public class AnalogyChangeLog : IAnalogyChangeLog
    {
        public string ChangeInformation { get; }
        public AnalogChangeLogType ChangeLogType { get; }
        public string Name { get; }
        public DateTimeOffset Date { get; }
        public Uri? IssueUri { get; }
        public string Version { get; }
        public AnalogyChangeLog(string changeInformation, AnalogChangeLogType changeLogType, string name, DateTimeOffset date, string? version)
        {
            ChangeInformation = changeInformation;
            ChangeLogType = changeLogType;
            Name = name;
            Date = date;
            Version = version ?? "";
        }

        public AnalogyChangeLog(string changeInformation, AnalogChangeLogType changeLogType, string name, DateTimeOffset date, Uri? issueUri, string version)
        {
            ChangeInformation = changeInformation;
            ChangeLogType = changeLogType;
            Name = name;
            Date = date;
            IssueUri = issueUri;
            Version = version;
        }
    }
}