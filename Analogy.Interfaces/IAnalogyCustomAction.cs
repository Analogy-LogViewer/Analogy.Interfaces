using Analogy.Interfaces.DataTypes;
using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomAction
    {
        Action Action { get; }
        Guid Id { get; set; }
        string Title { get; set; }
        AnalogyCustomActionType Type { get; }
        AnalogyToolTip? ToolTip { get; set; }
    }
}