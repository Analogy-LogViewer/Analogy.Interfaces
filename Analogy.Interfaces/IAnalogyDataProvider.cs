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
        /// ID of the data provider
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// call to initialize to provider
        /// </summary>
        Task InitializeDataProviderAsync(IAnalogyLogger logger);
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string? OptionalTitle { get; set; }
        /// <summary>
        /// called when the message is open in Analogy in full view mode (detailed view). Should not throw exception
        /// </summary>
        /// <param name="message"></param>
        void MessageOpened(AnalogyLogMessage message);
        /// <summary>
        /// indicate that the data provider will supply coloring logic per row/message
        /// if true the 
        /// </summary>
        bool UseCustomColors { get; set; }
        /// <summary>
        /// get the colors to use in the data grid of Analogy
        /// </summary>
        /// <param name="logMessage"></param>
        /// <returns></returns>
        (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage);
        /// <summary>
        /// if implemented, return replacement titles/headers for the data grid
        /// OriginalHeader options are:
        /// DataProvider,Date,Text,Source,Level,Class,Category,User,Module,Audit,ProcessID,ThreadID
        /// </summary>
        /// <returns></returns>
        IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders();
        /// <summary>
        /// list of column fields to hide
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> HideColumns();

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
        Task StartReceiving();
        Image? ConnectedLargeImage { get; set; }
        Image? ConnectedSmallImage { get; set; }
        Image? DisconnectedLargeImage { get; set; }
        Image? DisconnectedSmallImage { get; set; }
        Task StopReceiving();
    }

    public interface IAnalogyOfflineDataProvider : IAnalogyDataProvider
    {
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
        Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler);
        IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad);
        Task SaveAsync(List<AnalogyLogMessage> messages, string fileName);
        bool CanOpenFile(string fileName);
        bool CanOpenAllFiles(IEnumerable<string> fileNames);
    }

    public interface IAnalogySingleFileDataProvider : IAnalogyDataProvider
    {
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
        Task<IEnumerable<AnalogyLogMessage>> Process(CancellationToken token, ILogMessageCreatedHandler messagesHandler);
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
        Task<IEnumerable<AnalogyLogMessage>> Execute(CancellationToken token, ILogMessageCreatedHandler messagesHandler);
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
        Task<IEnumerable<AnalogyLogMessage>> FetchMessages(FilterCriteria filterCriteria, CancellationToken token, ILogMessageCreatedHandler messagesHandler);
        Task ShutdownAsync(IAnalogyLogger logger);

    }
}
