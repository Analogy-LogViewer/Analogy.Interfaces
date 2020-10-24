using System;
using System.Collections.Generic;
using System.Drawing;
using Analogy.Interfaces.DataTypes;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyFactory
    {
        event EventHandler<IAnalogyNotification>? RaiseNotification;
        /// <summary>
        /// Fixed Unique Guid that will be used as The Id of the Factory 
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; }
        /// <summary>
        /// 32x32 image for the Factory (can be null)
        /// </summary>
        Image? LargeImage { get; set; }
        /// <summary>
        /// 16x16 image for the Factory (can be null)
        /// </summary>
        Image? SmallImage { get; set; }
        IEnumerable<string> Contributors { get; set; }
        /// <summary>
        /// Description of the Factory e.g: "Serilog Parser for Analogy Log Viewer"
        /// </summary>
        string About { get; set; }
    }

}
