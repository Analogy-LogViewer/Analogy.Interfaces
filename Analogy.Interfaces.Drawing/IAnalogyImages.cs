#pragma warning disable MA0048 // File name must match type name
#pragma warning disable SA1649 // File name must match first type name
using SkiaSharp;
using System;
using System.Drawing;

namespace Analogy.Interfaces.Drawing
{
    public interface IAnalogyCustomActionImages
    {
        SKImage? GetCustomActionSmallImage();
        SKImage? GetCustomActionLargeImage();
        SKImage? GetCustomActionToolTipSmallImage();
        SKImage? GetCustomActionToolTipLargeImage();
    }
    public interface IAnalogyCustomActionsFactoryImages
    {
        SKImage? GetCustomActionSmallImage(Guid componentId);
        SKImage? GetCustomActionLargeImage(Guid componentId);
        SKImage? GetCustomActionToolTipSmallImage(Guid componentId);
        SKImage? GetCustomActionToolTipLargeImage(Guid componentId);
    }
    public interface IAnalogyDataProviderSettingsImages
    {
        SKImage? GetDataProviderSettingsSmallImage();
        SKImage? GetDataProviderSettingsLargeImage();
        SKImage? GetDataProviderSettingsToolTipSmallImage();
        SKImage? GetDataProviderSettingsToolTipLargeImage();
    }
    public interface IAnalogyDataProviderImages
    {
        SKImage? GetDataProviderSmallImage();
        SKImage? GetDataProviderLargeImage();
        SKImage? GetDataProviderToolTipSmallImage();
        SKImage? GetDataProviderToolTipLargeImage();
    }

    public interface IAnalogyDataProvidersFactoryImages
    {
        SKImage? GetDataFactorySmallImage(Guid componentId);
        SKImage? GetDataFactoryLargeImage(Guid componentId);
    }
    public interface IAnalogyStreamingDataProviderImages
    {
        SKImage GetStreamingConnectedLargeImage();
        SKImage GetStreamingConnectedSmallImage();
        SKImage GetStreamingDisconnectedLargeImage();
        SKImage GetStreamingDisconnectedSmallImage();
    }

    public interface IAnalogyImages
    {
        SKImage GetLargeBookmarksImage(Guid analogyComponentId);
        SKImage GetSmallBookmarksImage(Guid analogyComponentId);
        SKImage GetLargeOpenFileImage(Guid analogyComponentId);
        SKImage GetSmallOpenFileImage(Guid analogyComponentId);
        SKImage GetLargeOpenFolderImage(Guid analogyComponentId);
        SKImage GetSmallOpenFolderImage(Guid analogyComponentId);
        SKImage GetLargeRecentFoldersImage(Guid analogyComponentId);
        SKImage GetSmallRecentFoldersImage(Guid analogyComponentId);
        SKImage GetLargeFilePoolingImage(Guid analogyComponentId);
        SKImage GetSmallFilePoolingImage(Guid analogyComponentId);
        SKImage GetLargeRecentFilesImage(Guid analogyComponentId);
        SKImage GetSmallRecentFilesImage(Guid analogyComponentId);
        SKImage GetLargeKnownLocationsImage(Guid analogyComponentId);
        SKImage GetSmallKnownLocationsImage(Guid analogyComponentId);
        SKImage GetLargeSearchImage(Guid analogyComponentId);
        SKImage GetSmallSearchImage(Guid analogyComponentId);
        SKImage GetLargeCombineLogsImage(Guid analogyComponentId);
        SKImage GetSmallCombineLogsImage(Guid analogyComponentId);
        SKImage GetLargeCompareLogsImage(Guid analogyComponentId);
        SKImage GetSmallCompareLogsImage(Guid analogyComponentId);
    }
}