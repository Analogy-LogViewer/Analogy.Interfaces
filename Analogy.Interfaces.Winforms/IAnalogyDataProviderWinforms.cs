using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.WinForms.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.WinForms
{
    public interface IAnalogyRealTimeDataProviderWinForms : IAnalogyRealTimeDataProvider, IAnalogyStreamingDataProviderImages
    {
        Image? ConnectedLargeImage { get; set; }
        Image? ConnectedSmallImage { get; set; }
        Image? DisconnectedLargeImage { get; set; }
        Image? DisconnectedSmallImage { get; set; }
    }

    public interface IAnalogyOfflineDataProviderWinForms : IAnalogyOfflineDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        Image? SmallImage { get; set; }
    }

    public interface IAnalogySingleFileDataProviderWinForms : IAnalogySingleFileDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        Image? SmallImage { get; set; }
    }
    public interface IAnalogySingleDataProviderWinForms : IAnalogySingleDataProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        Image? SmallImage { get; set; }
    }

    public interface IAnalogyProviderSidePagingProviderWinForms : IAnalogyProviderSidePagingProvider, IAnalogyDataProviderImages
    {
        /// <summary>
        /// Optional 32x32 Image (or null).
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null).
        /// </summary>
        Image? SmallImage { get; set; }
    }
}