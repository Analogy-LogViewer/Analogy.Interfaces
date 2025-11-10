using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Winforms.Factories
{
    public interface IAnalogyCustomUserControlsFactoryWinforms
    {
        /// <summary>
        /// the factory id which this actions providers factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        new IEnumerable<IAnalogyCustomUserControlWinforms> UserControls { get; }
    }
}