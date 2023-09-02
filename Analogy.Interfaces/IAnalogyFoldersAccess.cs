using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
