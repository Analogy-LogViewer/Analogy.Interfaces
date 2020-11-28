using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.Interfaces
{
    public interface IAnalogyExtension
    {
        Guid Id { get; set; }
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string Title { get; set; }
        Guid TargetComponentId { get; set; }
        string Author { get; set; }
        string AuthorMail { get; set; }
        List<string> AdditionalContributors { get; }
        string Description { get; set; }
    }

    public interface IAnalogyExtensionInPlace : IAnalogyExtension
    {

        void CellClicked(object sender, AnalogyCellClickedEventArgs args);
        object GetValueForCellColumn(AnalogyLogMessage message, string columnName);
        List<AnalogyColumnInfo> GetColumnsInfo();
    }
    public interface IAnalogyExtensionUserControl : IAnalogyExtension
    {
        void NewMessage(AnalogyLogMessage message);
        void NewMessages(List<AnalogyLogMessage> messages);
        /// <summary>
        /// The user control to load
        /// </summary>
        UserControl UserControl { get; set; }
        Task InitUserControl { get; set; }
    }
}