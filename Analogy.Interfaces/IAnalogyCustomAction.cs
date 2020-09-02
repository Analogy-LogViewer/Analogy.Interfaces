using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomAction
    {
        Action Action { get; }
        Guid Id { get; }
        Image SmallImage { get; }
        Image LargeImage { get; }
        string Title { get; }
    }
}
