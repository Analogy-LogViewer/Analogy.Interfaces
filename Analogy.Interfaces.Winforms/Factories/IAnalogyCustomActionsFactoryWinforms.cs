using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.WinForms.Factories
{
    public interface IAnalogyCustomActionsFactoryWinForms : IAnalogyCustomActionsFactory
    {
        new IEnumerable<IAnalogyCustomActionWinForms> Actions { get; }
    }
}