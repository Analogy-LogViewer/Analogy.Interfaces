using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
   public interface IAnalogyExtensionsFactory
    {
        /// <summary>
        /// the factory id which this Extensions factory belongs to
        /// </summary>
        Guid FactoryId { get; }
        string Title { get; }
        IEnumerable<IAnalogyExtension> Extensions { get; }
    }
}
