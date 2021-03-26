using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyCustomUserControlsFactory
    {        /// <summary>
             /// the factory id which this actions providers factory belongs to
             /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyCustomUserControl> Actions { get; }
    }
}
