using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Практика
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class WorkSpace : Form
    {
        private readonly CheckUser _user;

        DataBase dataBase = new DataBase();
        int selectedRow;
        public WorkSpace(CheckUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }

        private void isAdmin()
        {
            управлениеToolStripMenuItem.Enabled = _user.Is_admin;
            button_new.Enabled = _user.Is_admin;
            button_del.Enabled = _user.Is_admin;
        }
        public void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя клиента");
            dataGridView1.Columns.Add("sname", "Фамилия клиента");
            dataGridView1.Columns.Add("tname", "Отчество клиента");
            dataGridView1.Columns.Add("perc", "Доверительный коэффициент");
            dataGridView1.Columns.Add("coun", "Количество ситуаций");
            dataGridView1.Columns.Add("IsNew", string.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            
            string queryS = $"select * from company_1"; 
            SqlCommand command = new SqlCommand(queryS, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tSTextBox_user.Text = $"{_user.Login}: {_user.Status}";
            isAdmin();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >=0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_fN.Text = row.Cells[1].Value.ToString();
                textBox_sN.Text = row.Cells[2].Value.ToString();
                textBox_tN.Text = row.Cells[3].Value.ToString();
                textBox_per.Text = row.Cells[4].Value.ToString();
                textBox_count.Text = row.Cells[5].Value.ToString();
            }
        }

        private void ClearFields()
        {
            textBox_ID.Text = "";
            textBox_fN.Text = "";
            textBox_sN.Text = "";
            textBox_tN.Text = "";
            textBox_per.Text = "";
            textBox_count.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void textBox_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_new add = new Add_new();
            add.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchSttring = $"select * from company_1 where concat (id, name, sname, tname, perc, coun) like '%" +  textBox_search.Text + "%'";

            SqlCommand search = new SqlCommand(searchSttring, dataBase.GetConnection());
            dataBase.openConnection();

            SqlDataReader read = search.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
         }

        private void Update()
        {
            dataBase.openConnection();

            for(int index=0; index <dataGridView1.Rows.Count;index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;
                if(rowState ==RowState.Existed)
                {
                    continue;
                }
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from company_1 where id={id}";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fname = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var sname = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var tname = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var per = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var count = dataGridView1.Rows[index].Cells[5].Value.ToString();

                    var changeQuery = $"update company_1 set name='{fname}', sname='{sname}', tname='{tname}', perc='{per}', coun='{count}' where id='{id}'";

                    var command = new SqlCommand (changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery(); 
                }
            }
            dataBase.closeConnection();
        }

        private void Chanege()
        {
            var selectedIdOfRow = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var fname = textBox_fN.Text;
            var sname = textBox_sN.Text;
            var tname = textBox_tN.Text;
            int per;
            int count;
            if (dataGridView1.Rows[selectedIdOfRow].Cells[0].Value.ToString()!= string.Empty)
            {
                if (int.TryParse(textBox_per.Text, out per) && int.TryParse(textBox_count.Text, out count))
                {
                    dataGridView1.Rows[selectedIdOfRow].SetValues(id, fname, sname, tname, per, count);
                    dataGridView1.Rows[selectedIdOfRow].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Запись с Доверительным коэффициентом и/или Количеством ситуаций должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Chanege();
            ClearFields();
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPlus AP = new AdminPlus();
            AP.ShowDialog();
            this.Show();
        }
    }
}
