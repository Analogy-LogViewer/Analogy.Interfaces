namespace Analogy.Interfaces.DataTypes
{
    public struct AnalogyColumnFilter
    {
        public string ColumnName { get; set; }
        public string FilterValue { get; set; }
        public AnalogyColumnFilterType FilterType { get; set; }
    }
}