using System;
using System.Windows.Forms;

namespace Analogy.Interfaces
{
    interface IAnalogyExtensionUI
    {
        /// <summary>
        /// ID of the ExtensionUI
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// ID of the Extension
        /// </summary>
        Guid ExtensionId { get; set; }
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string OptionalTitle { get; set; }
        /// <summary>
        /// The user control to show
        /// </summary>
        UserControl UserControl { get; set; }
    }
}

