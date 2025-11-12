using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyFactory
    {
        /// <summary>
        /// Fixed Unique Guid that will be used as The Id of the Factory.
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; }
        IEnumerable<string> Contributors { get; set; }

        /// <summary>
        /// Description of the Factory e.g: "Serilog Parser for Analogy Log Viewer"
        /// </summary>
        string About { get; set; }

        /// <summary>
        /// Add Additional probing locations.
        /// </summary>
        IEnumerable<string>? AdditionalProbingLocation { get; set; }

        void RegisterNotificationCallback(INotificationReporter notificationReporter);

        Task InitializeFactory(IAnalogyFoldersAccess foldersAccess, ILogger logger);
    }
}