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

namespace Практика
{
    public partial class Add_new : Form
    {
        DataBase dataBase = new DataBase();
        public Add_new()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_new_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var fname = textBox_fN.Text;
            var sname = textBox_sN.Text;
            var tname = textBox_tN.Text;
            int per;
            int count;
            
            if(int.TryParse(textBox_per.Text, out per) && int.TryParse(textBox_count.Text, out count))
            {
                var addQuery = $"insert into company_1 (name, sname, tname, perc, coun) values ('{fname}', '{sname}', '{tname}', '{per}', '{count}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Запись с Доверительным коэффициентом и/или Количеством ситуаций должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
