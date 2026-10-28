using Analogy.Interfaces.DataTypes;
using SkiaSharp;
using System.Drawing;

namespace Analogy.Interfaces.Drawing.DataTypes
{
    public record AnalogyToolTipWithImages(
        string Title,
        string Content,
        string Footer,
        SKImage? SmallImage,
        SKImage? LargeImage)
        : AnalogyToolTip(Title, Content, Footer)
    {
        /// <summary>
        /// 16x16 Image.
        /// </summary>
        public SKImage? SmallImage { get; set; } = SmallImage;

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        public SKImage? LargeImage { get; set; } = LargeImage;
    }
}