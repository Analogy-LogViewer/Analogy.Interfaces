namespace Analogy.Interfaces
{
    public interface IAnalogyPlottingInteractor
    {
        public void SetDefaultWindow(int numberOfPointsInWindow);
        public void SetXAxisType(AnalogyPlottingPointXAxisDataType xAxisDataType);
    }
}