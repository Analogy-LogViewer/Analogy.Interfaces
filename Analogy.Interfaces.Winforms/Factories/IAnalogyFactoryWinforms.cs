using Analogy.Interfaces.Factories;
using System.Drawing;

namespace Analogy.Interfaces.WinForms.Factories
{
    public interface IAnalogyFactoryWinForms : IAnalogyFactory
    {
        /// <summary>
        /// 32x32 image for the Factory (can be null).
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// 16x16 image for the Factory (can be null).
        /// </summary>
        Image? SmallImage { get; set; }
    }
}