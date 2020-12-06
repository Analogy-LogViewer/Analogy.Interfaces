namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyToolTip
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public AnalogyToolTip(string title, string content, string footer)
        {
            Title = title;
            Content = content;
            Footer = footer;
        }
    }
}
