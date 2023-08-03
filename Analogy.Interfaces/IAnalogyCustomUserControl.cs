using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.Interfaces.DataTypes;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomUserControl
    {
        UserControl UserControl { get; }
        Guid Id { get; set; }
        /// <summary>
        /// 16x16 Image
        /// </summary>
        Image? SmallImage { get; set; }
        /// <summary>
        /// 32x32 Image
        /// </summary>
        Image? LargeImage { get; set; }
        string Title { get; set; }
        AnalogyToolTip? ToolTip { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingControl">The Forms that holds the User Control</param>
        /// <param name="logger">The Analogy Log Viewer logger</param>
        /// <returns></returns>
        Task InitializeUserControl(Control hostingControl, Microsoft.Extensions.Logging.ILogger logger);
        Task UserControlRemoved();
    }
}