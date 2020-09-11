using System;
using System.Collections.Generic;
using Analogy.Interfaces.DataTypes;

namespace Analogy.Interfaces
{
    public interface IAnalogyExtension
    {
        Guid Id { get; set; }
        Guid TargetProviderId { get; set; }
        string Author { get; set; }
        string AuthorMail { get; set; }
        List<string> AdditionalContributors { get; }
        string Title { get; set; }
        string Description { get; set; }
        AnalogyExtensionType ExtensionType { get; }

        void CellClicked(object sender, AnalogyCellClickedEventArgs args);
        object GetValueForCellColumn(AnalogyLogMessage message, string columnName);
        List<AnalogyColumnInfo> GetColumnsInfo();
        void NewMessage(AnalogyLogMessage message);
        void NewMessages(List<AnalogyLogMessage> messages);
    }
}
