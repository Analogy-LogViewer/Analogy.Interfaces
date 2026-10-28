using SkiaSharp;

namespace Analogy.Interfaces.Drawing
{
    public interface IAnalogyCustomActionDrawing : IAnalogyCustomAction, IAnalogyCustomActionImages
    {
        /// <summary>
        /// 16x16 Image.
        /// </summary>
        SKImage? SmallImage { get; set; }

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        SKImage? LargeImage { get; set; }
    }
}