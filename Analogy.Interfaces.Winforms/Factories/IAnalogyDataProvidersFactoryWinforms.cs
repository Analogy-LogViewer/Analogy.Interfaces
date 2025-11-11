using Analogy.Interfaces.Factories;
using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.WinForms.Factories
{
    public interface IAnalogyDataProvidersFactoryWinForms: IAnalogyDataProvidersFactory
    {
       new IEnumerable<IAnalogyDataProviderWinForms> DataProviders { get; }
    }
}