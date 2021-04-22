using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp12
{
    public partial class InsertUser : Form
    {
        UserClass user = new UserClass();
        public InsertUser()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_fname.Text == "") || (textBox_lname.Text == "") || (textBox_patronymic.Text == "") || (textBox_login.Text == "") || (textBox_password.Text == "") || (textBox_phone.Text == "" || pictureBox1.Image == null))
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
            textBox_login.Clear();
            textBox_patronymic.Clear();
            textBox_password.Clear();
            textBox_phone.Clear();
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Расширения(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string role = textBox_role.Text;
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
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] image = ms.ToArray();
                    if (user.insertuser(role, firstname, lastname, patronymic, login, password, phone, image))
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_login.Clear();
            textBox_patronymic.Clear();
            textBox_password.Clear();
            textBox_phone.Clear();
            pictureBox1.Image = null;
        }
    }
}
