namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyPlottingPointData
    {

        public string Name { get; set; }
        public double Value { get; set; }

        public AnalogyPlottingPointData(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}

