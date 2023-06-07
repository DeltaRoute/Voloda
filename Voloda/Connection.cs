using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Voloda
{
    internal class Connection
    {
        SqlConnection SqlCon = new SqlConnection(@"Server=LAPTOP-5R28I66H\SQLEXPRESS;Database=course_work;Trusted_Connection=True;");
        List<TableColumnsMeta> Meta = new List<TableColumnsMeta>();
        public void openConnection()
        {
            SqlCon.Open();
        }

        public void CloseConnection()
        {
            SqlCon.Close();
        }

        public List<String> GetTableNames()
        {
            List<String> res_list = new List<String>();
            foreach (TableColumnsMeta table_column in Meta) {
                res_list.Add(table_column.table_name);
            }
            return res_list;
        }

        public List<String> GetTableColumns(string table_name)
        {
            List<String> res_list = new List<String>();
            foreach (TableColumnsMeta table_column in Meta)
            {
                if (table_name == table_column.table_name)
                    foreach (ColumnMeta Collumn in table_column.columns)
                        res_list.Add(Collumn.column_name);
            }
            return res_list;
        }

        public List<LineData> SelectTableData(string table, List<string> column_names)
        {
            string command_text = CreateSQLCommand(table, column_names);
            SqlCommand command = new SqlCommand(command_text, SqlCon);
            SqlDataReader reader = command.ExecuteReader();
            List<LineData> table_data = new List<LineData>();
            if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        LineData line_data = new LineData();
                        for (int column_number = 0; column_number < column_names.Count; column_number++)
                        {
                            string column_name = reader.GetName(column_number).ToString();
                            string column_data = reader.GetValue(column_number).ToString();
                            string column_type = reader.GetDataTypeName(column_number).ToString();
                            line_data.columns_data.Add(new ColumnData(column_name, column_data, column_type));                 
                        }
                    table_data.Add(line_data);
                }
            }
            reader.Close();
            return table_data;
        }

        string CreateSQLCommand(string table_name, List<string> column_names) {
            string command_names = "";
            foreach (string collumn in column_names) {
                command_names += "[" + collumn + "],";
            }
            if (command_names.Length>0)
                command_names = command_names.Substring(0, command_names.Length-1);
            return "SELECT " + command_names + " FROM [" + table_name+"]";
        }

        public List<TableColumnsMeta> GetMetaFromSQL()
        {
            string command_text = "SELECT [TABLE_NAME],[COLUMN_NAME],[DATA_TYPE] FROM INFORMATION_SCHEMA.COLUMNS";
            SqlCommand command = new SqlCommand(command_text, SqlCon);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    object table_name = reader.GetValue(0);
                    object column_name = reader.GetValue(1);
                    object data_type = reader.GetValue(2);
                    bool has_table_name = false;
                    foreach (TableColumnsMeta TableMeta in Meta){
                        if (TableMeta.table_name == table_name.ToString()){
                            TableMeta.columns.Add(new ColumnMeta(column_name.ToString(), data_type.ToString()));
                            has_table_name = true;
                        }   
                    }
                    if (!has_table_name)
                    {
                        Meta.Add(new TableColumnsMeta(table_name.ToString(), column_name.ToString(), data_type.ToString()));
                    }
                    object value_column0 = reader.GetValue(0);
                    object value_column1 = reader.GetValue(1);
                    object value_column2 = reader.GetValue(2);
                }
            }
            reader.Close();
            return Meta;
        }
    }
}
