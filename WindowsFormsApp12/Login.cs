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
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Пожалуйста заполните все поля", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string login = textBox_login.Text;
                string password = textBox_password.Text;
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
    }
}
