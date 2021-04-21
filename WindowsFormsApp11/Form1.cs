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
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
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
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) ||
            (!string.IsNullOrEmpty(textBox1.Text) && e.KeyChar == ','))
            {
                return;
            }

            e.Handled = true;
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
            textBox4.Text = null;
            if (checkBox1.Checked)//По Возрастанию
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
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
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
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
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
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
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
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
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text)};
                    int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
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
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
            }
            else if (checkBox2.Checked)//По убыванию
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length + 1; i++)
                    {
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (mas[i] < mas[j])
                            {
                                temp = mas[i];
                                mas[i] = mas[j];
                                mas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), };
                    int temp;
                    for (int i = 0; i < mas.Length + 1; i++)
                    {
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (mas[i] < mas[j])
                            {
                                temp = mas[i];
                                mas[i] = mas[j];
                                mas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length + 1; i++)
                    {
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (mas[i] < mas[j])
                            {
                                temp = mas[i];
                                mas[i] = mas[j];
                                mas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text) };
                    int temp;
                    for (int i = 0; i < mas.Length + 1; i++)
                    {
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (mas[i] < mas[j])
                            {
                                temp = mas[i];
                                mas[i] = mas[j];
                                mas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        textBox4.Text += Convert.ToString(mas[i]);
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                    int temp;
                    for (int i = 0; i < mas.Length + 1; i++)
                    {
                        for (int j = i + 1; j < mas.Length; j++)
                        {
                            if (mas[i] < mas[j])
                            {
                                temp = mas[i];
                                mas[i] = mas[j];
                                mas[j] = temp;
                            }
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        textBox4.Text += " " + Convert.ToString(mas[i]);
                    }
                }
                else if (checkBox3.Checked)//Метод Выбора
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length - 1; i++)
                        {
                            int min = i;
                            for (int j = i + 1; j < mas.Length; j++)
                            {
                                if (mas[j] < mas[min])
                                {
                                    min = j;
                                }
                            }
                            temp = mas[i];
                            mas[i] = mas[min];
                            mas[min] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                  
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), };
                        int temp;
                        for (int i = 0; i < mas.Length - 1; i++)
                        {
                            int min = i;
                            for (int j = i + 1; j < mas.Length; j++)
                            {
                                if (mas[j] < mas[min])
                                {
                                    min = j;
                                }
                            }
                            temp = mas[i];
                            mas[i] = mas[min];
                            mas[min] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length - 1; i++)
                        {
                            int min = i;
                            for (int j = i + 1; j < mas.Length; j++)
                            {
                                if (mas[j] < mas[min])
                                {
                                    min = j;
                                }
                            }
                            temp = mas[min];
                            mas[min] = mas[i];
                            mas[i] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length - 1; i++)
                        {
                            int min = i;
                            for (int j = i + 1; j < mas.Length; j++)
                            {
                                if (mas[j] < mas[min])
                                {
                                    min = j;
                                }
                            }
                            temp = mas[i];
                            mas[i] = mas[min];
                            mas[min] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text = " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 4)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        int temp;
                        for (int i = 0; i < mas.Length - 1; i++)
                        {
                            int min = i;
                            for (int j = i + 1; j < mas.Length; j++)
                            {
                                if (mas[j] < mas[min])
                                {
                                    min = j;
                                }
                            }
                            temp = mas[i];
                            mas[i] = mas[min];
                            mas[min] = temp;
                        }
                        
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                }

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            Random rng = new Random();
            for (int i = 1; i<= 1; i++)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex ==2)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex ==3)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                    textBox5.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                    textBox5.Text += (rng.Next(100000)).ToString() + " ";
                    textBox6.Text += (rng.Next(100000)).ToString() + " ";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
        }
    }
}
