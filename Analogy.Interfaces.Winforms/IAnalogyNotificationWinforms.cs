using Analogy.Interfaces;
using System;
using System.Drawing;

namespace Analogy.Interfaces.WinForms
{
    public interface IAnalogyNotificationWinForms : IAnalogyNotification
    {
        Image? SmallImage { get; set; }
    }
}