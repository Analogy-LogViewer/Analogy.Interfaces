using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.WinForms.Factories
{
    public interface IAnalogyCustomUserControlsFactoryWinForms
    {
        /// <summary>
        /// the factory id which this actions providers factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyCustomUserControlWinForms> UserControls { get; }
    }
}