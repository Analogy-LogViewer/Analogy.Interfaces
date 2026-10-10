#pragma warning disable MA0046 // Keep existing event payload API for compatibility
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