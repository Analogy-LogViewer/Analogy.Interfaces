using Analogy.Interfaces.DataTypes;
using System.Collections.Generic;

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