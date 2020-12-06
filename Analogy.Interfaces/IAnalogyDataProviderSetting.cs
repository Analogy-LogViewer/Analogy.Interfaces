using Analogy.Interfaces.DataTypes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.Interfaces
{
    public interface IAnalogyDataProviderSettings
    {
        /// <summary>
        /// to which Analogy Factory this user setting belong t0
        /// </summary>
        Guid FactoryId { get; set; }
        /// <summary>
        /// The id of this item
        /// </summary>
        Guid Id { get; set; }
        string Title { get; set; }
        UserControl DataProviderSettings { get; }
        /// <summary>
        /// 16x16 icon to show in the Analogy UI
        /// </summary>
        Image? SmallImage { get; set; }
        /// <summary>
        /// 32x32 icon to show in the Analogy UI
        /// </summary>
        Image? LargeImage { get; set; }
        AnalogyToolTip? ToolTip { get; set; }
        Task SaveSettingsAsync();
    }


}
