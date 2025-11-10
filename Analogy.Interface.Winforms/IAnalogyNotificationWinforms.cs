using Analogy.Interfaces;
using System;
using System.Drawing;

namespace Analogy.Interfaces.Winforms
{
    public interface IAnalogyNotificationWinforms : IAnalogyNotification
    {
        Image? SmallImage { get; set; }
    }
}