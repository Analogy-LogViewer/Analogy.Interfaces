using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Data;

namespace Analogy.Interfaces
{
    public class LogMessageArgs : EventArgs
    {
        public IAnalogyLogMessage Message { get; }
        public string HostName { get; }
        public string DataSource { get; }

        public LogMessageArgs(IAnalogyLogMessage msg, string host, string dataSource)
        {
            Message = msg;
            HostName = host;
            DataSource = dataSource;
        }
    }

    public class AnalogyCellClickedEventArgs : EventArgs
    {
        public string ColumnName { get; }
        public object ColumnValue { get; }
        public IAnalogyLogMessage Message { get; }

        public AnalogyCellClickedEventArgs(string columnName, object columnValue, IAnalogyLogMessage message)
        {
            ColumnName = columnName;
            ColumnValue = columnValue;
            Message = message;
        }
    }

    public class AnalogyPageInformation
    {
        public DataTable Data { get; set; }
        public int PageNumber { get; set; }
        public int PageFirstRowIndex { get; set; }
        public int PageLastRowIndex => PageFirstRowIndex + Data.Rows.Count;

        public AnalogyPageInformation(DataTable data, int pageNumber, int pageFirstRowIndex)
        {
            Data = data;
            PageNumber = pageNumber;
            PageFirstRowIndex = pageFirstRowIndex;
        }
    }
    public class AnalogyPagingChanged : EventArgs
    {
        public AnalogyPageInformation AnalogyPage { get; set; }

        public AnalogyPagingChanged(AnalogyPageInformation analogyPage)
        {
            AnalogyPage = analogyPage;
        }
    }

    public class AnalogyDataSourceDisconnectedArgs : EventArgs
    {
        public string DisconnectedReason { get; }
        public string HostName { get; }
        public Guid DataSourceID { get; }

        public AnalogyDataSourceDisconnectedArgs(string disconnectedReason, string hostName, Guid dataSourceID)
        {
            DisconnectedReason = disconnectedReason;
            HostName = hostName;
            DataSourceID = dataSourceID;
        }
    }
    public class AnalogyLogMessageArgs : EventArgs
    {
        public IAnalogyLogMessage Message { get; }
        public string HostName { get; }
        public string DataSource { get; }
        public Guid DataSourceID { get; }

        public AnalogyLogMessageArgs(IAnalogyLogMessage msg, string host, string dataSource, Guid dataSourceID)
        {
            Message = msg;
            HostName = host;
            DataSource = dataSource;
            DataSourceID = dataSourceID;
        }
    }
    public class AnalogyLogFileProcessedArgs : EventArgs
    {
        public string LogFile { get; }
        public IEnumerable<IAnalogyLogMessage> ProcessedMessages { get; }
        public Guid DataSourceID { get; }

        public AnalogyLogFileProcessedArgs(IEnumerable<IAnalogyLogMessage> messages, string logfile, Guid dataSourceID)
        {
            ProcessedMessages = messages;
            LogFile = logfile;
            DataSourceID = dataSourceID;
        }
    }
    public class AnalogyLogMessagesArgs : EventArgs
    {
        public List<IAnalogyLogMessage> Messages { get; }
        public string HostName { get; }
        public string DataSource { get; }

        public AnalogyLogMessagesArgs(List<IAnalogyLogMessage> msgs, string host, string dataSource)
        {
            Messages = msgs;
            HostName = host;
            DataSource = dataSource;
        }
    }

    public class AnalogyStartedProcessingArgs : EventArgs
    {
        public DateTimeOffset StartTime { get; init; }
        public string Information { get; init; }

        public AnalogyStartedProcessingArgs() : this(DateTimeOffset.Now, "")
        {
        }
        public AnalogyStartedProcessingArgs(string information) : this(DateTimeOffset.Now, information)
        {
        }
        public AnalogyStartedProcessingArgs(DateTimeOffset startTime, string information)
        {
            StartTime = startTime;
            Information = information;
        }

        public override string ToString()
        {
            return $"{nameof(StartTime)}: {StartTime}, {nameof(Information)}: {Information}";
        }
    }

    public class AnalogyEndProcessingArgs : EventArgs
    {
        public DateTimeOffset StartTime { get; init; }
        public DateTimeOffset EndTime { get; init; }
        public string Information { get; init; }
        public int ProcessedMessages { get; init; }
        public AnalogyEndProcessingArgs() : this(DateTimeOffset.Now, DateTimeOffset.Now)
        {
        }
        public AnalogyEndProcessingArgs(DateTimeOffset startTime, DateTimeOffset endTime, string information = "",
            int processedMessages = 0)
        {
            StartTime = startTime;
            EndTime = endTime;
            Information = information;
            ProcessedMessages = processedMessages;
        }

        public override string ToString()
        {
            return $"{nameof(StartTime)}: {StartTime}, {nameof(EndTime)}: {EndTime}, {nameof(Information)}: {Information}, {nameof(ProcessedMessages)}: {ProcessedMessages}";
        }
    }
}