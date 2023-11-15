using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyExtensionsFactory
    {
        /// <summary>
        /// the factory id which this Extensions factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyExtension> Extensions { get; }
    }
}