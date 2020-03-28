using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyDataProvidersFactory
    {
        /// <summary>
        /// the factory id which this Data providers factory belongs to
        /// </summary>
        Guid FactoryId { get; }
        string Title { get; }
        IEnumerable<IAnalogyDataProvider> DataProviders { get; }
    }
}
