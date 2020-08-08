using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Analogy.Interfaces.DataTypes
{
    [Serializable]
    public class LogParserSettings : ILogParserSettings
    {
        public string Directory { get; set; }
        public List<string> SupportedFilesExtensions { get; set; }
        public bool IsConfigured { get; set; }
        public string Splitter { get; set; }
        public string Layout { get; set; }
        public Dictionary<string, AnalogyLogMessagePropertyName> Maps { get; set; }
        public int ValidItemsCount { get; set; }

        // public string AsJson() => JsonConvert.SerializeObject(this);
        //  public static LogParserSettings FromJson(string json) => JsonConvert.DeserializeObject<LogParserSettings>(json);
        public LogParserSettings()
        {
            IsConfigured = false;
            Layout = string.Empty;
            Splitter = string.Empty;
            Maps = new Dictionary<string, AnalogyLogMessagePropertyName>(StringComparer.InvariantCultureIgnoreCase);
            SupportedFilesExtensions = new List<string>();
        }

        public void Configure(string layout, string splitter, List<string> supportedFilesExtension, Dictionary<string, AnalogyLogMessagePropertyName> maps)
        {
            Layout = layout;
            Splitter = splitter;
            SupportedFilesExtensions = supportedFilesExtension;
            Maps = maps ?? new Dictionary<string, AnalogyLogMessagePropertyName>(StringComparer.InvariantCultureIgnoreCase);
            IsConfigured = true;
            ValidItemsCount = Layout.Split(splitter.Split(), StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public void AddMap(string key, AnalogyLogMessagePropertyName name) => Maps[key] = name;

        public bool CanOpenFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return false;
            return SupportedFilesExtensions.Any(s => s.EndsWith(Path.GetExtension(fileName), StringComparison.InvariantCultureIgnoreCase));
        }

        public bool CanOpenFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);

        public AnalogyLogMessagePropertyName? GetAnalogyPropertyName(string key)
        => Maps.ContainsKey(key) ? Maps[key] : (AnalogyLogMessagePropertyName?)null;

    }
}
