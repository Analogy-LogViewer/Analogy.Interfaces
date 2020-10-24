using System;
using System.Diagnostics;
using System.Reflection;

namespace Analogy.Interfaces.DataTypes
{

    /// <summary>
    ///     Object of this class gives you all the details about the update useful in handling the update logic yourself.
    /// </summary>
    [Serializable]
    public class AnalogyDownloadInformation : IAnalogyDownloadInformation
    {
        /// <summary>
        /// ID of the primary Factory it belongs to
        /// </summary>
        public Guid PrimaryFactoryId { get; set; }
        /// <summary>
        /// The component title/name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// If new update is available then returns true otherwise false.
        /// </summary>
        public bool IsUpdateAvailable { get; set; }

        /// <summary>
        /// Download URL of the update file.
        /// </summary>
        public string? DownloadURL { get; set; }

        /// <summary>
        /// URL of the webpage specifying changes in the new update.
        /// </summary>
        public string? ChangeLogURL { get; set; }

        public string? LatestVersionNumber { get; set; }
        /// <summary>
        /// Returns newest version of the application available to download.
        /// </summary>
        public Version? LatestVersion
        {
            get
            {
                if (LatestVersionNumber == null)
                    return null;
                try
                {
                    return new Version(LatestVersionNumber);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        private string? _installedVersionNumber;
        public virtual string InstalledVersionNumber
        {
            get
            {
                if (_installedVersionNumber!=null)
                {
                    return _installedVersionNumber;
                }
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                _installedVersionNumber = fvi.FileVersion;
                return _installedVersionNumber;
            }

        }

        /// <summary>
        ///     Returns version of the application currently installed on the user's PC.
        /// </summary>
        public virtual Version InstalledVersion
        {
            get
            {
                try
                {
                    return new Version(InstalledVersionNumber);
                }
                catch (Exception)
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                    _installedVersionNumber = fvi.FileVersion;
                    return new Version(fvi.FileVersion);
                }
            }
        }

        /// <summary>
        ///     Shows if the update is required or optional.
        /// </summary>
        public bool Mandatory { get; set; }

        /// <summary>
        ///Command line arguments used by Installer.
        /// </summary>
        public string? InstallerArgs { get; set; }

        /// <summary>
        ///Checksum of the update file.
        /// </summary>
        public string? Checksum { get; set; }

        /// <summary>
        ///Hash algorithm that generated the checksum.
        /// </summary>
        public string? HashingAlgorithm { get; set; }

        public AnalogyDownloadInformation(Guid primaryFactoryId, string title)
        {
            Name = title;
            PrimaryFactoryId = primaryFactoryId;
        }
        public AnalogyDownloadInformation(Guid primaryFactoryId,string title, bool isUpdateAvailable, string? downloadUrl, string? changeLogUrl, string? latestVersionNumber, string? installedVersionNumber, bool mandatory, string? installerArgs, string? checksum, string? hashingAlgorithm):this(primaryFactoryId,title)
        {
            Name = title;
            IsUpdateAvailable = isUpdateAvailable;
            DownloadURL = downloadUrl;
            ChangeLogURL = changeLogUrl;
            LatestVersionNumber = latestVersionNumber;
            _installedVersionNumber = installedVersionNumber;
            Mandatory = mandatory;
            InstallerArgs = installerArgs;
            Checksum = checksum;
            HashingAlgorithm = hashingAlgorithm;
        }
    }
}
