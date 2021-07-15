using System;

namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyPlottingPointData
    {
        /// <summary>
        /// Series Name
        /// </summary>
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTime DateTime { get; }

        public AnalogyPlottingPointData(string name, double value, DateTime dateTime)
        {
            Name = name;
            Value = value;
            DateTime = dateTime;
        }
    }
}

