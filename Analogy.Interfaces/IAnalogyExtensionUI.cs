using System;
using System.Windows.Forms;

namespace Analogy.Interfaces
{
    interface IAnalogyExtensionUI
    {
        /// <summary>
        /// ID of the ExtensionUI
        /// </summary>
        Guid Id { get; }
        /// <summary>
        /// ID of the Extension
        /// </summary>
        Guid ExtensionId { get; }
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string OptionalTitle { get; }
        /// <summary>
        /// The user control to show
        /// </summary>
        UserControl UserControl { get; }
    }
}

