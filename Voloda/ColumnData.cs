using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voloda
{
    public class LineData
    {
        public List<ColumnData> columns_data = new List<ColumnData>();
    }

    public class ColumnData
    {
        public string column_name;
        public string data;
        public string type;

        public ColumnData(string column_name, string data, string type)
        {
            this.column_name = column_name;
            this.data = data;
            this.type = type;
        }
    }
}
