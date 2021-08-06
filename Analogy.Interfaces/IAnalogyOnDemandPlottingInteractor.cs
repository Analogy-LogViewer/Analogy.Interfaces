using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyOnDemandPlottingInteractor
    {
        public void ShowPlot(Guid id,string plotTitle, AnalogyOnDemandPlottingStartupType startupType);
        public void ClosePlot(Guid id);
        public void AddSeriesToPlot(Guid id, string seriesName);
        public void RemoveSeriesFromPlot(Guid id, string seriesName);
        public void ClearSeriesData(Guid id, string seriesNameToClear);
        public void ClearAllData(Guid id);
        public void SetDefaultWindow(int numberOfPointsInWindow);

    }
}
