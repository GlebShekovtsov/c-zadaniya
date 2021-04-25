using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLinesBD
{
    public partial class Login : Form
    {
        SuperUserClass su = new SuperUserClass();
        AdminClass admin = new AdminClass();
        UserClass userClass = new UserClass();
        public Login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=airlines");
            string CommandText = "SELECT Count(*) FROM users WHERE login = '" + textBox_login.Text + "' AND password = '" + textBox_password.Text + "' LIMIT 1";
            MySqlCommand myCommand = new MySqlCommand(CommandText, connect);
            connect.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                userRole();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void userRole()
        {
        
            MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=airlines");
            string login = textBox_login.Text;
            string sql = "SELECT role FROM users WHERE `login` = @lg";


            connect.Open();

            MySqlParameter nameParam = new MySqlParameter("@lg", login);

            MySqlCommand command = new MySqlCommand(sql, connect);
            command.Parameters.Add(nameParam);

            string Form_Role = command.ExecuteScalar().ToString();

            switch (Form_Role)
            {
                case "admin":
                    AdminMenu adminmenu = new AdminMenu();
                    this.Hide();
                    adminmenu.Show();


                    break;
                case "user":


                case "superuser":
                    SuperUserMenu sumenu = new SuperUserMenu();
                    this.Hide();
                    sumenu.Show();
                    break;
            }
            connect.Close();
        }

        private void textBox_login_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox_password_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}