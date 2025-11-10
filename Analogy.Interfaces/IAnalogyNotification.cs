using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyNotification
    {
        /// <summary>
        /// ID of the primary Factory it belongs to
        /// </summary>
        Guid PrimaryFactoryId { get; set; }
        string Title { get; set; }
        string Message { get; set; }
        AnalogyLogLevel Level { get; set; }
        int DurationSeconds { get; set; }
        Action? ActionOnClick { get; set; }
    }
}