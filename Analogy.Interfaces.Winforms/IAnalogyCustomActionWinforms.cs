using Analogy.Interfaces.WinForms.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.WinForms
{
    public interface IAnalogyCustomActionWinForms : IAnalogyCustomAction
    {
        /// <summary>
        /// 16x16 Image.
        /// </summary>
        Image? SmallImage { get; set; }

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        Image? LargeImage { get; set; }

        new AnalogyToolTipWinForms? ToolTip { get; set; }
    }
}