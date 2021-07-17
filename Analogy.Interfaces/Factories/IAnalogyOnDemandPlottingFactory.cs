using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyOnDemandPlottingFactory
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<IAnalogyOnDemandPlotting> OnDemandPlottingGenerator { get; set; }
        public event EventHandler<IAnalogyOnDemandPlotting> OnAddedOnDemandPlottingGenerator;
        public event EventHandler<IAnalogyOnDemandPlotting> OnRemovedOnDemandPlottingGenerator;
    }
}
