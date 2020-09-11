using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
