using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
        }

        private void просмотретьЦеныБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                int x;
                x = 55564;
                if (checkBox5.Checked == true)
                {
                    int z, y;
                    z = Convert.ToInt32(richTextBox1.Text);
                    if (z<=0)
                    {
                        MessageBox.Show("Введите число пассажиров");
                    }
                    else if (z > 4)
                    {
                        MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                    }
                    else
                    {
                        y = x * z+5000;
                        if (checkBox6.Checked == true)
                        {
                            int d;
                            d = y + 15000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else if (checkBox7.Checked == true)
                        {
                            int d;
                            d = y + 25000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else if (checkBox8.Checked == true)
                        {
                            int d;
                            d = y + 40000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else
                        {
                            textBox1.Text = Convert.ToString($"{y} рублей");
                        }
                   
                    }

                }
                else
                {
                    int y,z;
                    z = Convert.ToInt32(richTextBox1.Text);
                    if (z > 4)
                    {
                        MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                    }
                    else  if (z <=0)
                    {
                        MessageBox.Show("Введите число пассажиров");
                    }
                    else
                    {
                        y = x * z;
                        textBox1.Text = Convert.ToString($"{y} рублей");
                    }
                }
                textBox4.Text = Convert.ToString("Рейс в Прагу");
               if (checkBox5.Checked==true)
                {
                    textBox3.Text = Convert.ToString("Есть");
                }    
               else 
                {
                    textBox3.Text = Convert.ToString("Нет");
                }
               if (checkBox6.Checked==true)
                {
                    textBox5.Text = Convert.ToString("Трехзвездочный");
                }
               else if (checkBox7.Checked==true)
                {
                    textBox5.Text = Convert.ToString("Четырехзвездочный");
                }
               else if (checkBox8.Checked==true)
                {
                    textBox5.Text = Convert.ToString("Пятизвездочный");
                }
            }
            else if (checkBox2.Checked == true)
            {
                int x;
                x = 34439;
                if (checkBox5.Checked == true)
                {
                    int z, y;
                    z = Convert.ToInt32(richTextBox1.Text);
                    if (z <= 0)
                    {
                        MessageBox.Show("Введите число пассажиров");
                    }
                    else if (z > 4)
                    {
                        MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                    }
                    else
                    {
                        y = x * z + 5000;
                        if (checkBox6.Checked == true)
                        {
                            int d;
                            d = y + 15000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else if (checkBox7.Checked == true)
                        {
                            int d;
                            d = y + 25000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else if (checkBox8.Checked == true)
                        {
                            int d;
                            d = y + 40000;
                            textBox1.Text = Convert.ToString($"{d} рублей");
                        }
                        else
                        {
                            textBox1.Text = Convert.ToString($"{y} рублей");
                        }
                    }

                }
                else
                {
                    int y, z;
                    z = Convert.ToInt32(richTextBox1.Text);
                    if (z > 4)
                    {
                        MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                    }
                    else if (z <= 0)
                    {
                        MessageBox.Show("Введите число пассажиров");
                    }
                    else
                    {
                        y = x * z;
                        textBox1.Text = Convert.ToString($"{y} рублей");
                    }
                   
                }
                textBox4.Text = Convert.ToString("Рейс в Анкару");
                if (checkBox5.Checked == true)
                {
                    textBox3.Text = Convert.ToString("Есть");
                }
                else
                {
                    textBox3.Text = Convert.ToString("Нет");
                }
                if (checkBox6.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Трехзвездочный");
                }
                else if (checkBox7.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Четырехзвездочный");
                }
                else if (checkBox8.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Пятизвездочный");
                }
            }
            else if (checkBox3.Checked == true)
            {

                {
                    int x;
                    x = 41354;
                    if (checkBox5.Checked == true)
                    {
                        int z, y;
                        z = Convert.ToInt32(richTextBox1.Text);
                        if (z <= 0)
                        {
                            MessageBox.Show("Введите число пассажиров");
                        }
                        else if (z > 4)
                        {
                            MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                        }
                        else
                        {
                            y = x * z + 5000;
                            if (checkBox6.Checked == true)
                            {
                                int d;
                                d = y + 15000;
                                textBox1.Text = Convert.ToString($"{d} рублей");
                            }
                            else if (checkBox7.Checked == true)
                            {
                                int d;
                                d = y + 25000;
                                textBox1.Text = Convert.ToString($"{d} рублей");
                            }
                            else if (checkBox8.Checked == true)
                            {
                                int d;
                                d = y + 40000;
                                textBox1.Text = Convert.ToString($"{d} рублей");
                            }
                            else
                            {
                                textBox1.Text = Convert.ToString($"{y} рублей");
                            }
                        }

                    }
                    else
                    {
                        int y, z;
                        z = Convert.ToInt32(richTextBox1.Text);
                        if (z > 4)
                        {
                            MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                        }
                        else if (z <= 0)
                        {
                            MessageBox.Show("Введите число пассажиров");
                        }
                        else
                        {
                            y = x * z;
                            textBox1.Text = Convert.ToString($"{y} рублей");
                        }
                    }
                }
                textBox4.Text = Convert.ToString("Рейс в Берлин");
                if (checkBox5.Checked == true)
                {
                    textBox3.Text = Convert.ToString("Есть");
                }
                else
                {
                    textBox3.Text = Convert.ToString("Нет");
                }
                if (checkBox6.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Трехзвездочный");
                }
                else if (checkBox7.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Четырехзвездочный");
                }
                else if (checkBox8.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Пятизвездочный");
                }
            }
            else if (checkBox4.Checked == true)
            {

                {

                    {
                        int x;
                        x = 49682;
                        if (checkBox5.Checked == true)
                        {
                            int z, y;
                            z = Convert.ToInt32(richTextBox1.Text);
                            if (z <= 0)
                            {
                                MessageBox.Show("Введите число пассажиров");
                            }
                            else if (z > 4)
                            {
                                MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                            }
                            else
                            {
                                y = x * z + 5000;
                                if (checkBox6.Checked == true)
                                {
                                    int d;
                                    d = y + 15000;
                                    textBox1.Text = Convert.ToString($"{d} рублей");
                                }
                                else if (checkBox7.Checked == true)
                                {
                                    int d;
                                    d = y + 25000;
                                    textBox1.Text = Convert.ToString($"{d} рублей");
                                }
                                else if (checkBox8.Checked == true)
                                {
                                    int d;
                                    d = y + 40000;
                                    textBox1.Text = Convert.ToString($"{d} рублей");
                                }
                                else
                                {
                                    textBox1.Text = Convert.ToString($"{y} рублей");
                                }
                            }

                        }
                        else
                        {
                            int y, z;
                            z = Convert.ToInt32(richTextBox1.Text);
                            if (z > 4)
                            {
                                MessageBox.Show("Нельзя перевезти больше 4 пассажиров");
                            }
                            else if (z <= 0)
                            {
                                MessageBox.Show("Введите число пассажиров");
                            }
                            else
                            {
                                y = x * z;
                                textBox1.Text = Convert.ToString($"{y} рублей");
                            }
                        }
                    }
                }
                textBox4.Text = Convert.ToString("Рейс в Париж");
                if (checkBox5.Checked == true)
                {
                    textBox3.Text = Convert.ToString("Есть");
                }
                else
                {
                    textBox3.Text = Convert.ToString("Нет");
                }
                if (checkBox6.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Трехзвездочный");
                }
                else if (checkBox7.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Четырехзвездочный");
                }
                else if (checkBox8.Checked == true)
                {
                    textBox5.Text = Convert.ToString("Пятизвездочный");
                }
            }
            else
            {
                MessageBox.Show("Выберите рейс");
            }
            var helper = new WordHelper("check.docx");
            var item = new Dictionary<string, string>
            {
                {"<AAA>", textBox2.Text},
                {"<AAB>", textBox4.Text},
                {"<AAC>", richTextBox1.Text},
                {"<AAD>", textBox3.Text},
                {"<AAE>", textBox5.Text },
                {"<AAF>", Convert.ToString(dateTimePicker1.Value)},
                {"<AAG>", Convert.ToString(dateTimePicker2.Value)},
                {"<AAQ>", textBox1.Text},
            };
            helper.Process(item);
            MessageBox.Show("Чек успешно сохранен", "Сохранено");
        }
    }
}
