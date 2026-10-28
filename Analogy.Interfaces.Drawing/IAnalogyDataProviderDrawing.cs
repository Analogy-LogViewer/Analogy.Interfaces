#pragma warning disable MA0048 // File name must match type name
#pragma warning disable SA1649 // File name must match type name
using SkiaSharp;
using System.Drawing;

namespace Analogy.Interfaces.Drawing
{
    public interface IAnalogyRealTimeDataProviderDrawing : IAnalogyRealTimeDataProvider, IAnalogyStreamingDataProviderImages
    {
        SKImage? ConnectedLargeImage { get; set; }
        SKImage? ConnectedSmallImage { get; set; }
        SKImage? DisconnectedLargeImage { get; set; }
        SKImage? DisconnectedSmallImage { get; set; }
    }

    public interface IAnalogyOfflineDataProviderDrawing : IAnalogyOfflineDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        SKImage? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        SKImage? SmallImage { get; set; }
    }

    public interface IAnalogySingleFileDataProviderDrawing : IAnalogySingleFileDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        SKImage? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        SKImage? SmallImage { get; set; }
    }
    public interface IAnalogySingleDataProviderDrawing : IAnalogySingleDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        SKImage? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        SKImage? SmallImage { get; set; }
    }

    public interface IAnalogyProviderSidePagingProviderDrawing : IAnalogyProviderSidePagingProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        SKImage? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        SKImage? SmallImage { get; set; }
    }
}