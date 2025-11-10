using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.Interfaces.Winforms
{
    public interface IAnalogyExtensionUserControlWinforms : IAnalogyExtension
    {
        void NewMessage(IAnalogyLogMessage message, Guid logWindowsId);
        void NewMessages(List<IAnalogyLogMessage> messages, Guid logWindowsId);

        /// <summary>
        /// Create the user control for this specific log window
        /// </summary>
        ///  /// <param name="logWindowsId">Guid</param>
        /// <param name="logger">Microsoft.Extensions.Logging.ILogger</param>
        /// <returns>UserControl</returns>
        UserControl CreateUserControl(Guid logWindowsId, Microsoft.Extensions.Logging.ILogger logger);

        /// <summary>
        /// The user control to load for this specific log window. Must be created in the CreateUserControl method
        /// </summary>
        /// <param name="logWindowsId">Guid</param>
        /// <returns>UserControl</returns>
        UserControl GetUserControl(Guid logWindowsId);
        Task InitializeUserControl(Control hostingControl, Guid logWindowsId, Microsoft.Extensions.Logging.ILogger logger);
    }
}