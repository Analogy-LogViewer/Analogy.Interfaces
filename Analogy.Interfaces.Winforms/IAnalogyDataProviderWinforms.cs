using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.Winforms.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.Winforms
{
    public interface IAnalogyDataProviderWinforms : IAnalogyDataProvider
    {
        /// <summary>
        /// get the colors to use in the data grid of Analogy.
        /// </summary>
        (Color BackgroundColor, Color ForegroundColor) GetColorForMessage(IAnalogyLogMessage logMessage);
        new AnalogyToolTipWinforms? ToolTip { get; set; }
    }

    public interface IAnalogyRealTimeDataProviderWinforms : IAnalogyDataProviderWinforms, IAnalogyRealTimeDataProvider
    {
        Image? ConnectedLargeImage { get; set; }
        Image? ConnectedSmallImage { get; set; }
        Image? DisconnectedLargeImage { get; set; }
        Image? DisconnectedSmallImage { get; set; }
        new IAnalogyOfflineDataProviderWinforms? FileOperationsHandler { get; }
    }

    public interface IAnalogyOfflineDataProviderWinforms : IAnalogyDataProviderWinforms, IAnalogyOfflineDataProvider
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

    public interface IAnalogySingleFileDataProviderWinforms : IAnalogyDataProviderWinforms, IAnalogySingleFileDataProvider
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
    public interface IAnalogySingleDataProviderWinforms : IAnalogyDataProviderWinforms, IAnalogySingleDataProvider
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

    public interface IAnalogyProviderSidePagingProviderWinforms : IAnalogyDataProviderWinforms, IAnalogyProviderSidePagingProvider
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