using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyOnDemandPlottingFactory
    {
        Guid Id { get; set; }
        string Title { get; set; }
        List<IAnalogyOnDemandPlotting> OnDemandPlottingGenerators { get; set; }
        event EventHandler<IAnalogyOnDemandPlotting> OnAddedOnDemandPlottingGenerator;
        event EventHandler<IAnalogyOnDemandPlotting> OnRemovedOnDemandPlottingGenerator;
    }
}