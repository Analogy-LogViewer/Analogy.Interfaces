using Analogy.Interfaces.Winforms.DataTypes;
using System.Drawing;
using System.Windows.Forms;

namespace Analogy.Interfaces.Winforms
{
    public interface IAnalogyDataProviderSettingsWinforms : IAnalogyDataProviderSettings
    {
        /// <summary>
        /// The user control to load. Must be created in the CreateUserControl method
        /// </summary>
        UserControl DataProviderSettings { get; }

        /// <summary>
        /// 16x16 icon to show in the Analogy UI.
        /// </summary>
        Image? SmallImage { get; set; }

        /// <summary>
        /// 32x32 icon to show in the Analogy UI.
        /// </summary>
        Image? LargeImage { get; set; }
        new AnalogyToolTipWinforms? ToolTip { get; set; }
    }
}