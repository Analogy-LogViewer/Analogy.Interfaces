using System;

namespace Analogy.Interfaces.DataTypes
{
    public class AnalogyColumnInfo
    {
        public string ColumnCaption { get; }
        public string ColumnName { get; }
        public Type ColumnType { get; }

        public AnalogyColumnInfo(string columnCaption, string columnName, Type columnType)
        {
            ColumnCaption = columnCaption;
            ColumnName = columnName;
            ColumnType = columnType;
        }
    }
}
