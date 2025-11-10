using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyChangeLog
    {
        /// <summary>
        /// Information about this change.
        /// </summary>
        string ChangeInformation { get; }

        /// <summary>
        /// Change type.
        /// </summary>
        AnalogChangeLogType ChangeLogType { get; }

        /// <summary>
        /// The person who did this commit/fix/change.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Time of the commit.
        /// </summary>
        DateTime Date { get; }

        Uri? IssueUri { get; }
        string Version { get; }
    }

    public class AnalogyChangeLog(
        string changeInformation,
        AnalogChangeLogType changeLogType,
        string name,
        DateTime date,
        Uri? issueUri,
        string version)
        : IAnalogyChangeLog
    {
        public string ChangeInformation { get; } = changeInformation;
        public AnalogChangeLogType ChangeLogType { get; } = changeLogType;
        public string Name { get; } = name;
        public DateTime Date { get; } = date;
        public Uri? IssueUri { get; } = issueUri;
        public string Version { get; } = version;

        public AnalogyChangeLog(string changeInformation, AnalogChangeLogType changeLogType, string name, DateTime date, string? version) : this(changeInformation, changeLogType, name, date, null, version ?? "")
        {
        }
    }
}