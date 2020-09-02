using System;
using System.Collections.Generic;

namespace Analogy.Interfaces
{
    public interface IAnalogyExtension
    {
        Guid Id { get; }
        Guid TargetProviderId { get; }
        string Author { get; }
        string AuthorMail { get; }
        List<string> AdditionalContributors { get; }
        string Title { get; }
        string Description { get; }
        AnalogyExtensionType ExtensionType { get; }

        void CellClicked(object sender, AnalogyCellClickedEventArgs args);
        object GetValueForCellColumn(AnalogyLogMessage message, string columnName);
        List<AnalogyColumnInfo> GetColumnsInfo();
        void NewMessage(AnalogyLogMessage message);
        void NewMessages(List<AnalogyLogMessage> messages);
    }
}
