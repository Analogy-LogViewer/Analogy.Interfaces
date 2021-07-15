using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyOnDemandPlottingInteractor
    {
        public void ShowPlot(Guid id, AnalogyOnDemandPlottingStartupType startupType);
        public void ClosePlot(Guid id);
        public void RemoveSeriesFromPlot(Guid id, string seriesName);
        public void ClearAllData(Guid id, string seriesToClear);
    }
}
