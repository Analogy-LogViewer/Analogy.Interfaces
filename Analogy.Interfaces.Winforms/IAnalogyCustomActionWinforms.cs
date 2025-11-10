using Analogy.Interfaces.Winforms.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.Winforms
{
    public interface IAnalogyCustomActionWinforms : IAnalogyCustomAction
    {
        /// <summary>
        /// 16x16 Image.
        /// </summary>
        Image? SmallImage { get; set; }

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        Image? LargeImage { get; set; }

        new AnalogyToolTipWinforms? ToolTip { get; set; }
    }
}