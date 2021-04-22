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

namespace WindowsFormsApp12
{
    public partial class Login : Form
    {
        SuperUser su = new SuperUser();
        AdminClass admin = new AdminClass();
        UserClass userClass = new UserClass();
        public Login()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                string login = textBox_login.Text;
                string password = textBox_password.Text;
                MySqlCommand rolecheck = new MySqlCommand("SELECT * FROM `admin` WHERE `role`=@role");
                DataTable table = su.getSuperUserLogout(new MySqlCommand("SELECT * FROM `superuser` WHERE `login`= '" + login + "' AND `password`= '" + password + "' "));
                if (table.Rows.Count > 0)
                {
                    SuperUserMenu sumenu = new SuperUserMenu();
                    this.Hide();
                    sumenu.Show();
                }
                else
                {
                    MessageBox.Show("Неправильно введен логин и/или пароль", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            
        }

        private void textBox_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        //public void AdminRole()
        //{
        //    string login = textBox_login.Text; ;

        //    MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=airlines");
        //    string sql = "SELECT role FROM admin  WHERE `login` = @lg;";


        //    connect.Open();

        //    MySqlParameter nameParam = new MySqlParameter("@lg", login);

        //    MySqlCommand command = new MySqlCommand(sql, connect);
        //    command.Parameters.Add(nameParam);

        //    string Form_Role = command.ExecuteScalar().ToString();

        //    switch (Form_Role)
        //    {
        //        case "admin":

        //            SuperUserMenu sumenu = new SuperUserMenu();
        //            sumenu.Show();
        //            this.Hide();
        //            break;
        //    }
        //    connect.Close();
        //}

    }



}
   
