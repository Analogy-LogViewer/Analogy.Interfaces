using System;
using System.ComponentModel;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomActionImages
    {
        Image? GetCustomActionSmallImage(Guid componentId);
        Image? GetCustomActionLargeImage(Guid componentId);
        Image? GetCustomActionToolTipSmallImage(Guid componentId);
        Image? GetCustomActionToolTipLargeImage(Guid componentId);
    }
    public interface IAnalogyDataProviderSettingsImages
    {
        Image? GetDataProviderSettingsSmallImage();
        Image? GetDataProviderSettingsLargeImage();
        Image? GetDataProviderSettingsToolTipSmallImage();
        Image? GetDataProviderSettingsToolTipLargeImage();
    }
    public interface IAnalogyDataProviderImages
    {
        Image? GetDataProviderSmallImage();
        Image? GetDataProviderLargeImage();
        Image? GetDataProviderToolTipSmallImage();
        Image? GetDataProviderToolTipLargeImage();
    }
    public interface IAnalogyDataFactoryImages
    {
        Image? GetDataFactorySmallImage(Guid componentId);
        Image? GetDataFacoryLargeImage(Guid componentId);
    }
    public interface IAnalogyStreamingDataProviderImages
    {
        Image GetStreamingConnectedLargeImage();
        Image GetStreamingConnectedSmallImage();
        Image GetStreamingDisconnectedLargeImage();
        Image GetStreamingDisconnectedSmallImage();
    }

    public interface IAnalogyImages
    {
        Image GetLargeBookmarksImage(Guid analogyComponentId);
        Image GetSmallBookmarksImage(Guid analogyComponentId);
        Image GetLargeOpenFileImage(Guid analogyComponentId);
        Image GetSmallOpenFileImage(Guid analogyComponentId);
        Image GetLargeOpenFolderImage(Guid analogyComponentId);
        Image GetSmallOpenFolderImage(Guid analogyComponentId);
        Image GetLargeRecentFoldersImage(Guid analogyComponentId);
        Image GetSmallRecentFoldersImage(Guid analogyComponentId);
        Image GetLargeFilePoolingImage(Guid analogyComponentId);
        Image GetSmallFilePoolingImage(Guid analogyComponentId);
        Image GetLargeRecentFilesImage(Guid analogyComponentId);
        Image GetSmallRecentFilesImage(Guid analogyComponentId);
        Image GetLargeKnownLocationsImage(Guid analogyComponentId);
        Image GetSmallKnownLocationsImage(Guid analogyComponentId);
        Image GetLargeSearchImage(Guid analogyComponentId);
        Image GetSmallSearchImage(Guid analogyComponentId);
        Image GetLargeCombineLogsImage(Guid analogyComponentId);
        Image GetSmallCombineLogsImage(Guid analogyComponentId);
        Image GetLargeCompareLogsImage(Guid analogyComponentId);
        Image GetSmallCompareLogsImage(Guid analogyComponentId);
    }
}