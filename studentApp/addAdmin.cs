using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentApp
{
    public partial class addAdmin : Form
    {
        AdminClass admin = new AdminClass();
        public addAdmin()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_fname.Text == "") || (textBox_lname.Text == "") || (textBox_patronymic.Text == "") || (textBox_login.Text == "") || (textBox_password.Text =="") || (textBox_phone.Text ==""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_patronymic.Clear();
            textBox_login.Clear();
            textBox_password.Clear();
            textBox_phone.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string firstname = textBox_fname.Text;
            string lastname = textBox_lname.Text;
            string patronymic = textBox_patronymic.Text;
            string login = textBox_login.Text;
            string password = textBox_password.Text;
            string phone = textBox_phone.Text;
            if (verify())
            {
                try
                {
                    if (admin.insertadmin(firstname, lastname, patronymic, login, password, phone))
                    {
                        MessageBox.Show("Новые данные успешно добавлены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
