using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using System;
using System.Drawing;

namespace Analogy.Interfaces.Winforms.DataTypes
{
    public class AnalogyNotificationWinforms : AnalogyNotification, IAnalogyNotificationWinforms
    {
        public Image? SmallImage { get; set; }
        public AnalogyNotificationWinforms(Guid primaryFactoryId, string title, string message) : base(primaryFactoryId, title, message)
        {
        }
        public AnalogyNotificationWinforms(Guid primaryFactoryId, string title, string message, AnalogyLogLevel level, Image? smallImage, int durationSeconds, Action? actionOnClick) : base(primaryFactoryId, title, message, level, durationSeconds, actionOnClick)
        {
            Level = level;
            SmallImage = smallImage;
            DurationSeconds = durationSeconds;
            ActionOnClick = actionOnClick;
        }
    }
}