using System;
using System.Drawing;

namespace Analogy.Interfaces
{
    public interface IAnalogyCustomAction
    {
        Action Action { get; }
        Guid Id { get; }
        Image Image { get; }
        string Title { get; }
    }
}
