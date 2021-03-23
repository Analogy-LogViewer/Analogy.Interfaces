using System.Collections.Generic;
using Analogy.Interfaces.DataTypes;

namespace Analogy.Interfaces
{
    public interface ILogMessageCreatedHandler
    {
        bool ForceNoFileCaching { get; set; }
        bool DoNotAddToRecentHistory { get; set; }
        void AppendMessage(AnalogyLogMessage message, string dataSource);
        void AppendMessages(List<AnalogyLogMessage> messages, string dataSource);
        void ReportFileReadProgress(AnalogyFileReadProgress progress);
    }
}
