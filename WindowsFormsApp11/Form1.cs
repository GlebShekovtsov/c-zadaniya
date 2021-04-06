using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //int a, b, c, pk;
                //a = Convert.ToInt32(textBox1.Text);
                //b = Convert.ToInt32(textBox2.Text);
                //c = Convert.ToInt32(textBox3.Text);
                //if (a>b)
                //{
                //    pk = a;
                //    a = b;
                //    b = pk;
                //}
                //else
                //{
                //    pk = b;
                //}
                //if (pk <= c)
                //{
                //    textBox4.Text = Convert.ToString($"{a},{b},{c}");
                //}
                //else 
                //{
                //if (c <=a)
                //    {
                //        textBox4.Text = Convert.ToString($"{c},{a},{b}");
                //    }
                //else
                //    {
                //        textBox4.Text = Convert.ToString($"{a},{c},{b}");
                //    }
                //}
               
                int[] mas = {Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                int temp;
                for (int i = 0; i < mas.Length-1; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < mas.Length; i++)
                {
                    textBox4.Text +=" " + Convert.ToString(mas[i]);
                }


            }
            else if (checkBox2.Checked)
            {
                //int a, b, c, pk;
                //a = Convert.ToInt32(textBox1.Text);
                //b = Convert.ToInt32(textBox2.Text);
                //c = Convert.ToInt32(textBox3.Text);
                //if (a < b)
                //{
                //    pk = a;
                //    a = b;
                //    b = pk;
                //}
                //else
                //{
                //    pk = b;
                //}
                //if (pk >= c)
                //{
                //    textBox4.Text = Convert.ToString($"{a},{b},{c}");
                //}
                //else
                //{
                //    if (c >= a)
                //    {
                //        textBox4.Text = Convert.ToString($"{c},{a},{b}");
                //    }
                //    else
                //    {
                //        textBox4.Text = Convert.ToString($"{a},{c},{b}");
                //    }
                //}


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            for (int i = 1; i<= 1; i++)
            {
                textBox1.Text += (rng.Next(100000)).ToString() + " ";
                textBox2.Text += (rng.Next(100000)).ToString() + " ";
                textBox3.Text += (rng.Next(100000)).ToString() + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
