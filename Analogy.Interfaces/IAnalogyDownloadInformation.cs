using System;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
    public interface IAnalogyDownloadInformation
    {
        /// <summary>
        /// ID of the primary Factory it belongs to
        /// </summary>
        Guid FactoryId { get; set; }

        /// <summary>
        /// The component Title/Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// If new update is available then returns true otherwise false.
        /// </summary>
        bool IsUpdateAvailable { get; set; }

        /// <summary>
        /// Download URL of the update file.
        /// </summary>
        string? DownloadURL { get; set; }

        /// <summary>
        /// URL of the webpage specifying changes in the new update.
        /// </summary>
        string? ChangeLogURL { get; set; }

        /// <summary>
        /// Returns newest version of the application available to download.
        /// </summary>
        Version? LatestVersion { get; }
        string? LatestVersionNumber { get; set; }
        /// <summary>
        ///     Returns version of the application currently installed on the user's PC.
        /// </summary>
        Version InstalledVersion { get; }
        string InstalledVersionNumber { get; }
        /// <summary>
        ///     Shows if the update is required or optional.
        /// </summary>
        bool Mandatory { get; set; }

        /// <summary>
        ///Command line arguments used by Installer.
        /// </summary>
        string? InstallerArgs { get; set; }

        /// <summary>
        ///Checksum of the update file.
        /// </summary>
        string? Checksum { get; set; }

        /// <summary>
        ///Hash algorithm that generated the checksum.
        /// </summary>
        string? HashingAlgorithm { get; set; }

        Task<bool> CheckVersion();
    }
}