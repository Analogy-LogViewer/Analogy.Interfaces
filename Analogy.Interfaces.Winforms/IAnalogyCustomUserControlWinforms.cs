using Analogy.Interfaces.WinForms.DataTypes;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.Interfaces.WinForms
{
    public interface IAnalogyCustomUserControlWinForms
    {
        UserControl UserControl { get; }
        Guid Id { get; set; }

        /// <summary>
        /// 16x16 Image.
        /// </summary>
        Image? SmallImage { get; set; }

        /// <summary>
        /// 32x32 Image.
        /// </summary>
        Image? LargeImage { get; set; }
        string Title { get; set; }
        AnalogyToolTipWithImages? ToolTip { get; set; }
        Task InitializeUserControl(Control hostingControl, Microsoft.Extensions.Logging.ILogger logger);
        Task UserControlRemoved();
    }
}