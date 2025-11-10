using Analogy.Interfaces.DataTypes;
using System;
using System.Drawing;
using System.Threading.Tasks;
namespace Analogy.Interfaces
{
    public interface IAnalogyDataProviderSettings
    {
        /// <summary>
        /// to which Analogy Factory this user setting belong to.
        /// </summary>
        Guid FactoryId { get; set; }

        /// <summary>
        /// The id of this item.
        /// </summary>
        Guid Id { get; set; }
        string Title { get; set; }
        AnalogyToolTip? ToolTip { get; set; }

        /// <summary>
        /// The Data Provider UI User Control Settings (this will be called on the UI thread)
        /// </summary>
        /// <param name="logger"></param>
        /// <returns></returns>
        void CreateUserControl(Microsoft.Extensions.Logging.ILogger logger);

        Task SaveSettingsAsync();
    }
}