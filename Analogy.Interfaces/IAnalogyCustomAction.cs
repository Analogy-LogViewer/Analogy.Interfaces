using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomAction
    {
        Action Action { get; }
        Guid Id { get; set; }
        Image SmallImage { get; set; }
        Image LargeImage { get; set; }
        string Title { get; set; }
    }
}
