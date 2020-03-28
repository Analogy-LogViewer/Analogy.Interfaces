using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyCustomActionsFactory
    {
        /// <summary>
        /// the factory id which this actions providers factory belongs to
        /// </summary>
        Guid FactoryId { get; }
        string Title { get; }
        IEnumerable<IAnalogyCustomAction> Actions { get; }
    }
}
