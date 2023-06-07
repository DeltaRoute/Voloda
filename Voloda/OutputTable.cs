using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voloda
{
    public partial class Form1 : Form
    {
        Connection con = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.openConnection();
            con.GetMetaFromSQL();
            table_name_cbox.Items.AddRange(con.GetTableNames().ToArray());
        }

        private void get_gata_from_sql_btn_Click(object sender, EventArgs e)
        {
            List<string> selecteg_columns = new List<string>();
            foreach (ListViewItem list_view_item in column_name_lview.Items)
                if (list_view_item.Checked)
                    selecteg_columns.Add(list_view_item.Text);
            string table_name = table_name_cbox.SelectedItem.ToString();
            List<LineData> data = con.SelectTableData(table_name, selecteg_columns);

            data_dgv.Columns.Clear();
            data_dgv.Rows.Clear();
            foreach (string column in selecteg_columns) {
                data_dgv.Columns.Add(column, column);
                data_dgv.Rows[0].Cells[data_dgv.ColumnCount - 1].Value = data[0].columns_data[data_dgv.ColumnCount - 1].type;
            }
        }

        private void table_name_cbox_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(table_name_cbox.SelectedItem);
            column_name_lview.Items.Clear();
            ListViewItem list_view_item = new ListViewItem(); ;
            foreach (string column_name in con.GetTableColumns(table_name_cbox.SelectedItem.ToString()))
            {
                list_view_item = new ListViewItem();
                list_view_item.Text = column_name;
                column_name_lview.Items.Add(list_view_item);
            }
        }

        private void table_name_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
