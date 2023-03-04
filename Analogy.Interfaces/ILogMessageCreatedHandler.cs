using System;
using System.Collections.Generic;
using Analogy.Interfaces.DataTypes;
using static Analogy.Interfaces.AnalogyLogMessagesArgs;

namespace Analogy.Interfaces
{
    public interface ILogMessageCreatedHandler
    { 
        bool ForceNoFileCaching { get; set; }
        bool DoNotAddToRecentHistory { get; set; }
        void AppendMessage(IAnalogyLogMessage message, string dataSource);
        void AppendMessages(List<IAnalogyLogMessage> messages, string dataSource);
        void ReportFileReadProgress(AnalogyFileReadProgress progress);
    }
}
