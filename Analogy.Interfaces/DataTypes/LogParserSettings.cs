﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Analogy.Interfaces.DataTypes
{
    [Serializable]
    public class LogParserSettings : ILogParserSettings
    {
        public string Directory { get; set; }
        public List<string> SupportedFilesExtensions { get; set; }
        public bool IsConfigured { get; set; }
        public Dictionary<AnalogyLogMessagePropertyName, List<string>> Maps { get; set; }
        public LogParserSettings()
        {
            IsConfigured = false;
            Maps = new Dictionary<AnalogyLogMessagePropertyName, List<string>>();
            foreach (var items in AnalogyLogMessage.LogMessagePropertyNames)
            {
                Maps[items.Value] = new List<string> { items.Key };
            }
            SupportedFilesExtensions = new List<string>();
            Directory = string.Empty;
        }

        public void Configure(List<string> supportedFilesExtension, Dictionary<AnalogyLogMessagePropertyName, List<string>> maps)
        {
            SupportedFilesExtensions = supportedFilesExtension;
            Maps = maps ?? new Dictionary<AnalogyLogMessagePropertyName, List<string>>();
            IsConfigured = true;
        }

        public void AddMap(AnalogyLogMessagePropertyName key, string value)
        {
            if (Maps.ContainsKey(key))
            {
                Maps[key] ??= new List<string>();

                if (!Maps[key].Contains(value))
                {
                    Maps[key].Add(value);
                }
            }
            else
            {
                Maps[key] = new List<string> { value };
            }
        }

        public void DeleteMap(AnalogyLogMessagePropertyName key, string value)
        {
#if NET
            if (Maps.TryGetValue(key, out var val))
            {
                if (val == null)
                {
                    Maps[key] = new List<string>();
                }
                Maps[key].Remove(value);
            }
#else
            if (Maps.ContainsKey(key))
            {
                if (Maps[key] == null)
                {
                    Maps[key] = new List<string>();
                }
                Maps[key].Remove(value);
            }
#endif
        }

        public bool CanOpenFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return false;
            }
            return SupportedFilesExtensions.Any(s => s.EndsWith(Path.GetExtension(fileName), StringComparison.InvariantCultureIgnoreCase));
        }

        public bool CanOpenFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);

        public AnalogyLogMessagePropertyName? GetAnalogyPropertyName(string value)
        {
            foreach (var item in Maps)
            {
                if (item.Value.Contains(value))
                {
                    return item.Key;
                }
            }

            return null;
        }
    }
}