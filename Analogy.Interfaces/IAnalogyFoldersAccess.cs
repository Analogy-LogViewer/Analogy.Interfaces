using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyFoldersAccess
    {
        event EventHandler RootFolderChanged;
        string WriteableRootFolder { get; }
        string ConfigurationsFolder { get; }
        string GetConfigurationFilePath(string configFile);
        bool TryGetConfigurationFilePathFromAnyValidLocation(string configFile, out string finalLocation);
    }
}