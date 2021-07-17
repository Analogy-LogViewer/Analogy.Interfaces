using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyOnDemandPlottingFactory
    {
        Guid Id { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyOnDemandPlotting> OnDemandPlottingGenerators { get; set; }
        event EventHandler<IAnalogyOnDemandPlotting> OnAddedOnDemandPlottingGenerator;
        event EventHandler<IAnalogyOnDemandPlotting> OnRemovedOnDemandPlottingGenerator;
    }
}
