using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces.DataTypes
{
   public class AnalogyNotification: IAnalogyNotification
    {
        public Guid PrimaryFactoryId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public AnalogyLogLevel Level { get; set; }
        public Image? SmallImage { get; set; }
        public int DurationSeconds { get; set; }
        public Action? ActionOnClick { get; set; }

        public AnalogyNotification(Guid primaryFactoryId, string title, string message)
        {
            PrimaryFactoryId = primaryFactoryId;
            Title = title;
            Message = message;
            Level = AnalogyLogLevel.Information;
        }
        public AnalogyNotification(Guid primaryFactoryId, string title, string message, AnalogyLogLevel level, Image? smallImage, int durationSeconds, Action? actionOnClick):this(primaryFactoryId,title,message)
        {
            Level = level;
            SmallImage = smallImage;
            DurationSeconds = durationSeconds;
            ActionOnClick = actionOnClick;
        }
    }
}
