using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyDataProvider
    {
        /// <summary>
        /// ID of the data provider.
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// One time call to initialize the provider during startup or before first time use.
        /// </summary>
        Task InitializeDataProvider(Microsoft.Extensions.Logging.ILogger logger);

        /// <summary>
        /// //Optional title to display in the ribbon bar.
        /// </summary>
        string? OptionalTitle { get; set; }

        /// <summary>
        /// called when the message is open in Analogy in full view mode (detailed view). Should not throw exception
        /// </summary>
        void MessageOpened(IAnalogyLogMessage message);

        /// <summary>
        /// called when the message is selected/focused in Analogy list view. Should not throw exception
        /// </summary>
        void MessageSelected(IAnalogyLogMessage message);

        /// <summary>
        /// indicate that the data provider will supply coloring logic per row/message
        /// </summary>
        bool UseCustomColors { get; set; }

        /// <summary>
        /// get the colors to use in the data grid of Analogy
        /// </summary>
        (Color BackgroundColor, Color ForegroundColor) GetColorForMessage(IAnalogyLogMessage logMessage);

        /// <summary>
        /// When implemented, return replacement titles/headers for the data grid
        /// OriginalHeader options are:
        /// DataProvider,Date,Text,Source,Level,Class,Category,User,Module,Audit,ProcessID,ThreadID
        /// </summary>
        /// <returns></returns>
        IEnumerable<(string OriginalHeader, string ReplacementHeader)> GetReplacementHeaders();

        /// <summary>
        /// When implemented, return list of Default columns to hide in  he UI
        /// </summary>
        /// <returns></returns>
        IEnumerable<AnalogyLogMessagePropertyName> HideExistingColumns();

        /// <summary>
        /// list of column fields to hide (may by properties in the Additional Properties dictionary of the Message)
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> HideAdditionalColumns();

        AnalogyToolTip? ToolTip { get; set; }
    }

    public interface IAnalogyRealTimeDataProvider : IAnalogyDataProvider
    {
        event EventHandler<AnalogyDataSourceDisconnectedArgs> OnDisconnected;
        event EventHandler<AnalogyLogMessageArgs> OnMessageReady;
        event EventHandler<AnalogyLogMessagesArgs> OnManyMessagesReady;

        /// <summary>
        /// Handler for save/read logs for the online source.
        /// </summary>
        IAnalogyOfflineDataProvider? FileOperationsHandler { get; }
        Task<bool> CanStartReceiving();

        /// <summary>
        /// start receiving. called when the hosting window/tab is opening 
        /// </summary>
        /// <returns></returns>
        Task StartReceiving();

        /// <summary>
        /// pause/stop receiving. called when the hosting window/tab is closed 
        /// </summary>
        /// <returns></returns>
        Task StopReceiving();

        /// <summary>
        /// called before application exits
        /// </summary>
        /// <returns></returns>
        Task ShutDown();
        Image? ConnectedLargeImage { get; set; }
        Image? ConnectedSmallImage { get; set; }
        Image? DisconnectedLargeImage { get; set; }
        Image? DisconnectedSmallImage { get; set; }
    }

    public interface IAnalogyOfflineDataProvider : IAnalogyDataProvider
    {
        event EventHandler<AnalogyStartedProcessingArgs> ProcessingStarted;
        event EventHandler<AnalogyEndProcessingArgs> ProcessingFinished;

        /// <summary>
        /// Optional 32x32 Image (or null)
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null)
        /// </summary>
        Image? SmallImage { get; set; }
        bool DisableFilePoolingOption { get; }
        bool CanSaveToLogFile { get; }
        string FileOpenDialogFilters { get; }
        string? FileSaveDialogFilters { get; }
        IEnumerable<string> SupportFormats { get; }
        string? InitialFolderFullPath { get; }
        Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler);
        IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad);
        Task SaveAsync(List<IAnalogyLogMessage> messages, string fileName);
        bool CanOpenFile(string fileName);
        bool CanOpenAllFiles(IEnumerable<string> fileNames);
    }

    public interface IAnalogySingleFileDataProvider : IAnalogyDataProvider
    {
        event EventHandler<AnalogyStartedProcessingArgs> ProcessingStarted;
        event EventHandler<AnalogyEndProcessingArgs> ProcessingFinished;

        /// <summary>
        /// Optional 32x32 Image (or null)
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null)
        /// </summary>
        Image? SmallImage { get; set; }
        bool DisableFilePoolingOption { get; }

        /// <summary>
        /// Full path of the file to open
        /// </summary>
        string FileNamePath { get; set; }
        Task<IEnumerable<IAnalogyLogMessage>> Process(CancellationToken token, ILogMessageCreatedHandler messagesHandler);
    }
    public interface IAnalogySingleDataProvider : IAnalogyDataProvider
    {
        /// <summary>
        /// Optional 32x32 Image (or null)
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null)
        /// </summary>
        Image? SmallImage { get; set; }
        Task<IEnumerable<IAnalogyLogMessage>> Execute(CancellationToken token, ILogMessageCreatedHandler messagesHandler);
    }

    public interface IAnalogyProviderSidePagingProvider : IAnalogyDataProvider
    {
        /// <summary>
        /// Optional 32x32 Image (or null)
        /// </summary>
        Image? LargeImage { get; set; }

        /// <summary>
        /// Optional 16x16 Image (or null)
        /// </summary>
        Image? SmallImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageNumber">The page number</param>
        /// <param name="pageCount">Number of messages per page</param>
        /// <param name="filterCriteria">The filter criteria</param>
        /// <param name="token">CancellationToken</param>
        /// <param name="messagesHandler">messagesHandler</param>
        /// <returns>The filtered messages</returns>
        Task<IEnumerable<IAnalogyLogMessage>> FetchMessages(int pageNumber, int pageCount, FilterCriteria filterCriteria, CancellationToken token, ILogMessageCreatedHandler messagesHandler);
        Task ShutdownAsync(Microsoft.Extensions.Logging.ILogger logger);
    }
}