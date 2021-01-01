using System.Drawing;

namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyToolTip
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }
        /// <summary>
        /// 16x16 Image
        /// </summary>
        public Image? SmallImage { get; set; }
        /// <summary>
        /// 32x32 Image
        /// </summary>
        public Image? LargeImage { get; set; }
        public AnalogyToolTip(string title, string content, string footer, Image? smallImage, Image? largeImage)
        {
            Title = title;
            Content = content;
            Footer = footer;
            SmallImage = smallImage;
            LargeImage = largeImage;
        }
    }
}
