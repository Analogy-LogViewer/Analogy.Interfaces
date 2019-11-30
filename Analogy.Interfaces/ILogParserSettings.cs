using System;
using System.Collections.Generic;
using System.Text;

namespace Analogy.Interfaces
{
    public interface ILogParserSettings
    {
        /// <summary>
        /// The initial location of the log files.
        /// </summary>
        string Directory { get; set; }
        List<string> SupportedFilesExtensions { get; set; }
        bool IsConfigured { get; set; }
        string Splitter { get; set; }
        string Layout { get; set; }
        Dictionary<int, AnalogyLogMessagePropertyName> Maps { get; set; }
        int ValidItemsCount { get; set; }
        string AsJson();
        void Configure(string layout, string splitter, List<string> supportedFilesExtension, Dictionary<int, AnalogyLogMessagePropertyName> maps);
        void AddMap(int index, AnalogyLogMessagePropertyName name);
        bool CanOpenFile(string fileName);
        bool CanOpenFiles(IEnumerable<string> fileNames);
    }
}
