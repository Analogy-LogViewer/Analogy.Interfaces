using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Analogy.Interfaces
{
    public interface IAnalogyExtension
    {
        Guid Id { get; set; }

        /// <summary>
        /// //Optional title to display in the ribbon bar.
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
}