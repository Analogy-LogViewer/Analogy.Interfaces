using System;

namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyPlottingPointData
    {
        /// <summary>
        /// Series Name.
        /// </summary>
        public string Name { get; set; }
        public double Value { get; set; }
        public DateTimeOffset DateTime { get; }
        public double XAxisValue { get; }
        public AnalogyPlottingPointXAxisDataType XAxisDataType { get; }

        public AnalogyPlottingPointData(string name, double value, DateTimeOffset dateTime, double xAxisValue, AnalogyPlottingPointXAxisDataType xAxisDataType)
        {
            Name = name;
            Value = value;
            DateTime = dateTime;
            XAxisValue = xAxisValue;
            XAxisDataType = xAxisDataType;
        }
        public AnalogyPlottingPointData(string name, double value, DateTimeOffset dateTime)
        {
            Name = name;
            Value = value;
            DateTime = dateTime;
            XAxisDataType = AnalogyPlottingPointXAxisDataType.DateTime;
        }

        public AnalogyPlottingPointData(string name, double value, double xAxisValue)
        {
            Name = name;
            Value = value;
            XAxisValue = xAxisValue;
            XAxisDataType = AnalogyPlottingPointXAxisDataType.Numerical;
        }
    }
}