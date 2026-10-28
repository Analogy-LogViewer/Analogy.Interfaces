using Analogy.Interfaces.Factories;
using SkiaSharp;
using System.Drawing;

namespace Analogy.Interfaces.Drawing.Factories
{
    public interface IAnalogyFactoryDrawing : IAnalogyFactory
    {
        /// <summary>
        /// 32x32 image for the Factory (can be null).
        /// </summary>
        SKImage? LargeImage { get; set; }

        /// <summary>
        /// 16x16 image for the Factory (can be null).
        /// </summary>
        SKImage? SmallImage { get; set; }
    }
}