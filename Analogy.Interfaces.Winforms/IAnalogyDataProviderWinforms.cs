using Analogy.Interfaces.DataTypes;
using Analogy.Interfaces.WinForms.DataTypes;
using System.Drawing;

namespace Analogy.Interfaces.WinForms
{
    public interface IAnalogyDataProviderWinForms : IAnalogyDataProvider
    {
        /// <summary>
        /// get the colors to use in the data grid of Analogy.
        /// </summary>
        (Color BackgroundColor, Color ForegroundColor) GetColorForMessage(IAnalogyLogMessage logMessage);
        new AnalogyToolTipWinForms? ToolTip { get; set; }
    }

    public interface IAnalogyRealTimeDataProviderWinForms : IAnalogyDataProviderWinForms, IAnalogyRealTimeDataProvider
    {
        Image? ConnectedLargeImage { get; set; }
        Image? ConnectedSmallImage { get; set; }
        Image? DisconnectedLargeImage { get; set; }
        Image? DisconnectedSmallImage { get; set; }
        new IAnalogyOfflineDataProviderWinForms? FileOperationsHandler { get; }
    }

    public interface IAnalogyOfflineDataProviderWinForms : IAnalogyDataProviderWinForms, IAnalogyOfflineDataProvider
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

    public interface IAnalogySingleFileDataProviderWinForms : IAnalogyDataProviderWinForms, IAnalogySingleFileDataProvider
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
    public interface IAnalogySingleDataProviderWinForms : IAnalogyDataProviderWinForms, IAnalogySingleDataProvider
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

    public interface IAnalogyProviderSidePagingProviderWinForms : IAnalogyDataProviderWinForms, IAnalogyProviderSidePagingProvider
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