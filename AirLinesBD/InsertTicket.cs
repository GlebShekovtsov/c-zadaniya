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

namespace AirLinesBD
{
    public partial class InsertTicket : Form
    {
        TicketClass ticket = new TicketClass();
        public InsertTicket()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((textBox_name.Text == "") || (textBox_price.Text == "") || (textBox_discount.Text == "") || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clear_Click_1(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_price.Clear();
            textBox_discount.Clear();
            pictureBox1.Image = null;
        }

        private void button_save_Click_1(object sender, EventArgs e)
        {

            string name = textBox_name.Text;
            string price = textBox_price.Text;
            string discount = textBox_discount.Text;
            if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] image = ms.ToArray();
                    if (ticket.insertticket(name, Convert.ToString(price), Convert.ToString(discount), image))
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Расширения(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
