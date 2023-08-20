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
    public partial class Log_in : Form
    {
        DataBase dataBase = new DataBase();
        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_hide.Visible = false;
            textBox_Login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox_Login.Text = "";
            textBox_password.Text = "";
        }

        private void enter_Click(object sender, EventArgs e)
        {
            var loginuser = textBox_Login.Text;
            var passworduser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();//adapter 
            DataTable dt = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user ='{loginuser}' and password_user = '{passworduser}'";//строка запроса

            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;//инициализрование строки запроса
            adapter.Fill(dt); //вставке ответа в таблицу

            if (dt.Rows.Count == 1) //проверка на соответствие логина и пароля
            {
                var user = new CheckUser(dt.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(dt.Rows[0].ItemArray[3]));

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WorkSpace quit = new WorkSpace(user);
                this.Hide();
                quit.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Вы не вошли!", "Такого аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Reg aut = new Reg();
            aut.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_hide.Visible = false;
            pictureBox_show.Visible = true;
        }

        private void pictureBox_show_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_show.Visible = false;
            pictureBox_hide.Visible = true;
        }
    }
}
