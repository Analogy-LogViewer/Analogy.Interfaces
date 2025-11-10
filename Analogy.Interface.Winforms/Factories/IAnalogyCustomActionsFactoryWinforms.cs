using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Winforms.Factories
{
    public interface IAnalogyCustomActionsFactoryWinforms : IAnalogyCustomActionsFactory
    {
        new IEnumerable<IAnalogyCustomActionWinforms> Actions { get; }
    }
}