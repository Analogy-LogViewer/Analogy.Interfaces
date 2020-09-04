using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyDataProvidersFactory
    {
        /// <summary>
        /// the factory id which this Data providers factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyDataProvider> DataProviders { get; }
    }
}
