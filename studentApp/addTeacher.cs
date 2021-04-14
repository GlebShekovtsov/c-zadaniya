using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentApp
{
    public partial class addTeacher : Form
    {
        TeacherClass teacher = new TeacherClass();
        public addTeacher()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if((textBox_fname.Text=="") || (textBox_lname.Text=="") || (textBox_adress.Text=="") || (textBox_phone.Text=="") || (pictureBox1.Image==null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_moreImg_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Расширения(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {
            string firstname = textBox_fname.Text;
            string lastname = textBox_lname.Text;
            string adress = textBox_adress.Text;
            string phone = textBox_phone.Text;
            if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] photo = ms.ToArray();
                    if (teacher.insertteacher(firstname, lastname, adress, phone, photo))
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

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_phone.Clear();
            textBox_adress.Clear();
            pictureBox1.Image = null;
        }
    }
}