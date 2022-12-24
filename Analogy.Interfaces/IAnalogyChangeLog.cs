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
        DateTime Date { get; }

        Uri? IssueUri { get; }
    }

    public class AnalogyChangeLog: IAnalogyChangeLog
    {
        public string ChangeInformation { get; }
        public AnalogChangeLogType ChangeLogType { get; }
        public string Name { get; }
        public DateTime Date { get; }
        public Uri? IssueUri { get; }
        public AnalogyChangeLog(string changeInformation, AnalogChangeLogType changeLogType, string name, DateTime date)
        {
            ChangeInformation = changeInformation;
            ChangeLogType = changeLogType;
            Name = name;
            Date = date;
        }

        public AnalogyChangeLog(string changeInformation, AnalogChangeLogType changeLogType, string name, DateTime date, Uri? issueUri)
        {
            ChangeInformation = changeInformation;
            ChangeLogType = changeLogType;
            Name = name;
            Date = date;
            IssueUri = issueUri;
        }
    }
}
