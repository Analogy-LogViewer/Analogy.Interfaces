using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
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
       Image GetRealTimeConnectedLargeImage(Guid analogyComponentId);
       Image GetRealTimeConnectedSmallImage(Guid analogyComponentId);
       Image GetRealTimeDisconnectedLargeImage(Guid analogyComponentId);
       Image GetRealTimeDisconnectedSmallImage(Guid analogyComponentId);
    }
}
