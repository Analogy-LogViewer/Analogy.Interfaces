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
        object GetValueForCellColumn(IAnalogyLogMessage message, string columnName);
        List<AnalogyColumnInfo> GetColumnsInfo();
    }
    public interface IAnalogyExtensionUserControl : IAnalogyExtension
    {
        void NewMessage(IAnalogyLogMessage message);
        void NewMessages(List<IAnalogyLogMessage> messages);
        /// <summary>
        /// The Data Provider UI User Control Settings (this will be called on the UI thread)
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        void CreateUserControl(IAnalogyLogger logger);
        /// <summary>
        /// The user control to load. Must be created in the CreateUserControl method
        /// </summary>
        UserControl UserControl { get; set; }
        Task InitializeUserControl(Control hostingControl, IAnalogyLogger logger);


    }
}