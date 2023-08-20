using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class AdminPlus : Form
    {
        DataBase dataBase = new DataBase();
        public AdminPlus()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "ID");
            dataGridView1.Columns.Add("login_user", "Логин");
            dataGridView1.Columns.Add("password_user", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            dataGridView1.Columns.Add(checkColumn);
        }

        private void ReadSingleRows(IDataRecord record) 
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from register;";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(reader);
            }

            reader.Close();

            dataBase.closeConnection();
        }

        private void AdminPlus_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            for (int index =0; index<dataGridView1.Rows.Count;index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isadmin = dataGridView1.Rows[index].Cells[3].Value.ToString();
                var changeQuery = $"update register set is_admin ='{isadmin}' where id_user='{id}'";
                var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();

            RefreshDataGrid();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"delete from register where id_user = {id}";

            var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            
            dataBase.closeConnection();

            RefreshDataGrid();
        }
    }
}
