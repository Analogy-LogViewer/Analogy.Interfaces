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
        Dictionary<AnalogyLogMessagePropertyName, List<string>> Maps { get; set; }
        void Configure(List<string> supportedFilesExtension, Dictionary<AnalogyLogMessagePropertyName, List<string>> maps);
        void AddMap(AnalogyLogMessagePropertyName key, string value);
        bool CanOpenFile(string fileName);
        bool CanOpenFiles(IEnumerable<string> fileNames);
        AnalogyLogMessagePropertyName? GetAnalogyPropertyName(string value);
    }
}
