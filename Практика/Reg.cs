using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика
{
    public partial class Reg : Form
    {
        DataBase dataBase = new DataBase();
        public Reg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Reg_Load(object sender, EventArgs e)
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

        private void pictureBox_hide_Click(object sender, EventArgs e)
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

        private void enter_Click(object sender, EventArgs e)
        {
            

            var login=textBox_Login.Text;
            var password=textBox_password.Text;

            if (checkUser())
            {
                return;
            }

            string QueryString = $"insert into register (login_user, password_user, is_admin) values('{login}','{password}', 0)";
            SqlCommand cmd = new SqlCommand(QueryString, dataBase.GetConnection());

            dataBase.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был успешно создан!", "Успех");
                this.Hide();
            }
            else 
            { 
                MessageBox.Show("Аккаунт не создан ("); 
            }

            dataBase.closeConnection();
        }

        private Boolean checkUser()
        {
            var logInUser = textBox_Login.Text;
            var passUser = textBox_password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string queryString = $"select id_user, login_user, password_user, is_admin from register where login_user = '{logInUser}' and password_user='{passUser}'";

            SqlCommand commande = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = commande;
            adapter.Fill(dt);

            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void textBox_Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}