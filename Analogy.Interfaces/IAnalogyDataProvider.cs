using System;
using System.Collections.Generic;
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
        Guid ID { get; }
        /// <summary>
        /// call to initialize to provider
        /// </summary>
        Task InitializeDataProviderAsync(IAnalogyLogger logger);
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string OptionalTitle { get; }
        /// <summary>
        /// called when the message is open in Analogy in full view mode (detailed view). Should not throw exception
        /// </summary>
        /// <param name="message"></param>
        void MessageOpened(AnalogyLogMessage message);

    }

    public interface IAnalogyRealTimeDataProvider : IAnalogyDataProvider
    {
        event EventHandler<AnalogyDataSourceDisconnectedArgs> OnDisconnected;
        event EventHandler<AnalogyLogMessageArgs> OnMessageReady;
        event EventHandler<AnalogyLogMessagesArgs> OnManyMessagesReady;
        /// <summary>
        /// Handler for save/read logs for the online source.
        /// </summary>
        IAnalogyOfflineDataProvider FileOperationsHandler { get; }
        Task<bool> CanStartReceiving();
        void StartReceiving();
        void StopReceiving();
        bool IsConnected { get; }
    }

    public interface IAnalogyOfflineDataProvider : IAnalogyDataProvider
    {
        bool DisableFilePoolingOption { get; }
        bool CanSaveToLogFile { get; }
        string FileOpenDialogFilters { get; }
        string FileSaveDialogFilters { get; }
        IEnumerable<string> SupportFormats { get; }
        string InitialFolderFullPath { get; }

        Task<IEnumerable<AnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler);
        IEnumerable<FileInfo> GetSupportedFiles(DirectoryInfo dirInfo, bool recursiveLoad);
        Task SaveAsync(List<AnalogyLogMessage> messages, string fileName);
        bool CanOpenFile(string fileName);
        bool CanOpenAllFiles(IEnumerable<string> fileNames);
    }

    public interface IAnalogySingleFileDataProvider : IAnalogyDataProvider
    {
        bool DisableFilePoolingOption { get; }
        /// <summary>
        /// Full path of the file to open
        /// </summary>
        string FileNamePath { get; }
        Task<IEnumerable<AnalogyLogMessage>> ProcessFile(CancellationToken token, ILogMessageCreatedHandler messagesHandler);
    }
}
