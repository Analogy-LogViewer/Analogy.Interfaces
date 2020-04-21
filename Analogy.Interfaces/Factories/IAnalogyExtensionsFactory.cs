using System;
using System.Collections.Generic;
using System.Text;

namespace Analogy.Interfaces.Factories
{
    interface IAnalogyExtensionsFactory
    {        /// <summary>
        /// the factory id which this Extensions factory belongs to
        /// </summary>
        Guid FactoryId { get; }
        string Title { get; }
        IEnumerable<IAnalogyExtension> DataProviders { get; }
    }
}
