using System;

namespace Analogy.Interfaces
{
    public interface IAnalogyOnDemandPlottingInteractor
    {
        public void ShowPlot(Guid plotId, string plotTitle, AnalogyOnDemandPlottingStartupType startupType);
        public void ClosePlot(Guid plotId);
        public void AddSeriesToPlot(Guid plotId, string seriesName);
        public void RemoveSeriesFromPlot(Guid plotId, string seriesName);
        public void ClearSeriesData(Guid plotId, string seriesNameToClear);
        public void ClearAllData(Guid plotId);
        public void SetDefaultWindow(Guid plotId, int numberOfPointsInWindow);
    }
}