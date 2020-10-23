using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
    /// <summary>
    ///     Object of this class gives you all the details about the update useful in handling the update logic yourself.
    /// </summary>
    public class DownloadInformation
    {
        /// <summary>
        /// The component title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// If new update is available then returns true otherwise false.
        /// </summary>
        public bool IsUpdateAvailable { get; set; }

        /// <summary>
        /// Download URL of the update file.
        /// </summary>
        public string DownloadURL { get; set; }

        /// <summary>
        /// URL of the webpage specifying changes in the new update.
        /// </summary>
        public string ChangelogURL { get; set; }

        /// <summary>
        /// Returns newest version of the application available to download.
        /// </summary>
        public Version LatestVersion { get; set; }

        /// <summary>
        ///     Returns version of the application currently installed on the user's PC.
        /// </summary>
        public Version InstalledVersion { get; set; }

        /// <summary>
        ///     Shows if the update is required or optional.
        /// </summary>
        public bool Mandatory { get; set; }

        /// <summary>
        ///     Defines how the Mandatory flag should work.
        /// </summary>
        public UpdateMode UpdateMode { get; set; }

        /// <summary>
        ///     Command line arguments used by Installer.
        /// </summary>
        public string InstallerArgs { get; set; }

        /// <summary>
        ///     Checksum of the update file.
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        ///     Hash algorithm that generated the checksum provided in the XML file.
        /// </summary>
        public string HashingAlgorithm { get; set; }

        public DownloadInformation(string title, bool isUpdateAvailable, string downloadUrl, string changelogUrl, Version latestVersion, Version installedVersion, bool mandatory, UpdateMode updateMode, string installerArgs, string checksum, string hashingAlgorithm)
        {
            Title = title;
            IsUpdateAvailable = isUpdateAvailable;
            DownloadURL = downloadUrl;
            ChangelogURL = changelogUrl;
            LatestVersion = latestVersion;
            InstalledVersion = installedVersion;
            Mandatory = mandatory;
            UpdateMode = updateMode;
            InstallerArgs = installerArgs;
            Checksum = checksum;
            HashingAlgorithm = hashingAlgorithm;
        }
    }
}
