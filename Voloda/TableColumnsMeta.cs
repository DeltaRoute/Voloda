using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Voloda
{
    public class TableColumnsMeta
    {
        public string table_name;
        public List<ColumnMeta> columns = new List<ColumnMeta>();

        public TableColumnsMeta(string _table_name, string _column_name, string _data_type)
        {
            table_name = _table_name;
            columns.Add(new ColumnMeta(_column_name, _data_type));
        }
    }

    public class ColumnMeta
    {
        public string column_name;
        public string data_type;

        public ColumnMeta(string _column_name, string _data_type)
        {
            column_name = _column_name;
            data_type = _data_type; 
        }
    }
}
