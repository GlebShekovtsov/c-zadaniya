using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            Graphics g = CreateGraphics();
            Rectangle smallRectangle = button1.ClientRectangle;
            smallRectangle.Inflate(-3, -3);
            gp.AddEllipse(smallRectangle);
            button1.Region = new Region(gp);
            g.DrawEllipse(new Pen(Color.Gray, 2),
            button1.Left + 1,
            button1.Top + 1,
            button1.Width - 3,
            button1.Height - 3);
            g.Dispose();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            label1.Text = String.Format("Текущее значение:{0}", trackBar1.Value);
            int x =Convert.ToInt32(trackBar1.Value);
            int y = 500 * x;
            textBox1.Text = Convert.ToString(y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                int x, y;
                x = Convert.ToInt32(textBox3.Text);
                if (x > 10)
                {
                    MessageBox.Show("Нельзя заказать больше 10 страниц");
                }
                else
                {
                    y = x * 1200 + x * 2700;
                    textBox2.Text = Convert.ToString(y);
                }
            }
           else if (checkBox2.Checked == true)
            {
                int x, y;
                x = Convert.ToInt32(textBox3.Text);
                if (x > 10)
                {
                    MessageBox.Show("Нельзя заказать больше 10 страниц");
                }
                else
                {
                    y = x * 1200 + x * 2200;
                    textBox2.Text = Convert.ToString(y);
                }

            }
            else if (checkBox3.Checked == true)
            {
                int x, y;
                x = Convert.ToInt32(textBox3.Text);
                if (x > 10)
                {
                    MessageBox.Show("Нельзя заказать больше 10 страниц");
                }
                else
                {
                    y = x * 1200 + x * 4500;
                    textBox2.Text = Convert.ToString(y);
                }
            }
            else if (checkBox4.Checked == true)
            {
                int x, y;
                x = Convert.ToInt32(textBox3.Text);
                if (x > 10)
                {
                    MessageBox.Show("Нельзя заказать больше 10 страниц");
                }
                else
                {
                    y = x * 1200 + x * 1500;
                    textBox2.Text = Convert.ToString(y);
                }
            }
            else
            {
                MessageBox.Show("Значения пусты");
            }

        }

    }

}
