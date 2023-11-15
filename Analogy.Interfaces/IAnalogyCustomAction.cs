using Analogy.Interfaces.DataTypes;
using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomAction
    {
        Action Action { get; }
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
        AnalogyCustomActionType Type { get; }
        AnalogyToolTip? ToolTip { get; set; }
    }
}