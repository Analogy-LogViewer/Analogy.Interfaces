using Analogy.Interfaces.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.WinForms.DataTypes
{
    public record AnalogyToolTipWinForms(
        string Title,
        string Content,
        string Footer,
        Image? SmallImage,
        Image? LargeImage)
        : AnalogyToolTip(Title, Content, Footer)
    {
        /// <summary>
        /// 16x16 Image.
        /// </summary>
        public Image? SmallImage { get; set; } = SmallImage;

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        public Image? LargeImage { get; set; } = LargeImage;
    }
}