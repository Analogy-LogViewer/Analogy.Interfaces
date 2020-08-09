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
        public Dictionary<AnalogyLogMessagePropertyName, List<string>> Maps { get; set; }
        public int ValidItemsCount { get; set; }

        // public string AsJson() => JsonConvert.SerializeObject(this);
        //  public static LogParserSettings FromJson(string json) => JsonConvert.DeserializeObject<LogParserSettings>(json);
        public LogParserSettings()
        {
            IsConfigured = false;
            Layout = string.Empty;
            Splitter = string.Empty;
            Maps = new Dictionary<AnalogyLogMessagePropertyName, List<string>>();
            foreach (var items in AnalogyLogMessage.AnalogyLogMessagePropertyNames)
            {
                Maps[items.Value]=new List<string>{items.Key};
            }
            SupportedFilesExtensions = new List<string>();
        }

        public void Configure(string layout, string splitter, List<string> supportedFilesExtension, Dictionary<AnalogyLogMessagePropertyName, List<string>> maps)
        {
            Layout = layout;
            Splitter = splitter;
            SupportedFilesExtensions = supportedFilesExtension;
            Maps = maps ?? new Dictionary<AnalogyLogMessagePropertyName, List<string>>();
            IsConfigured = true;
            ValidItemsCount = Layout.Split(splitter.Split(), StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public void AddMap(AnalogyLogMessagePropertyName key, string value)
        {
            if (Maps.ContainsKey(key))
            {
                if (Maps[key] == null)
                    Maps[key] = new List<string>();
                if (!Maps[key].Contains(value))
                    Maps[key].Add(value);
            }
            else
            {
                Maps[key] = new List<string> { value };
            }
        }


        public bool CanOpenFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return false;
            return SupportedFilesExtensions.Any(s => s.EndsWith(Path.GetExtension(fileName), StringComparison.InvariantCultureIgnoreCase));
        }

        public bool CanOpenFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);

        public AnalogyLogMessagePropertyName? GetAnalogyPropertyName(string value)
        {
            foreach (var item in Maps)
            {
                if (item.Value.Contains(value))
                    return item.Key;
            }

            return null;
        }

    }
}
