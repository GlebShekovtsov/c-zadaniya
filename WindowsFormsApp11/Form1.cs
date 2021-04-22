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
        static int partition<T>(T[] m, int a, int b)
        where T : IComparable<T>
        {
            int i = a;
            for (int j = a; j <= b; j++)         // просматриваем с a по b
            {
                if (m[j].CompareTo(m[b]) <= 0)  // если элемент m[j] не превосходит m[b],
                {
                    T t = m[i];                  // меняем местами m[j] и m[a], m[a+1], m[a+2] и так далее...
                    m[i] = m[j];                 // то есть переносим элементы меньшие m[b] в начало,
                    m[j] = t;                    // а затем и сам m[b] «сверху»
                    i++;                         // таким образом последний обмен: m[b] и m[i], после чего i++
                }
            }
            return i - 1;                        // в индексе i хранится <новая позиция элемента m[b]> + 1
        }

        static void quicksort<T>(T[] m, int a, int b) where T : IComparable<T>// a - начало подмножества, b - конец
        {                                        // для первого вызова: a = 0, b = <элементов в массиве> - 1
            if (a >= b) return;
            int c = partition(m, a, b);
            quicksort(m, a, c - 1);
            quicksort(m, c + 1, b);
        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void GnomeSort(int[] inArray)
        {
            int i = 1;
            int j = 2;
            while (i < inArray.Length)
            {
                if (inArray[i - 1] < inArray[i])
                {
                    i = j;
                    j += 1;
                }
                else
                {
                    Swap(inArray, i - 1, i);
                    i -= 1;
                    if (i == 0)
                    {
                        i = j;
                        j += 1;
                    }
                }
            }
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

            if (checkBox1.Checked)//Метод Выбора
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
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
                    else if (comboBox1.SelectedIndex == 1)
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
                            temp = mas[min];
                            mas[min] = mas[i];
                            mas[i] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
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
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
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
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
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
                            temp = mas[min];
                            mas[min] = mas[i];
                            mas[i] = temp;
                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
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

                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
            }
            else if (checkBox2.Checked)//Метод пузырька
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        int temp;
                        for (int i = 0; i < mas.Length; i++)
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

                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
            }
            else if (checkBox3.Checked)//Метод включения
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }
                        for (int i = 0; i < mas.Length; i++)
                        {
                            textBox4.Text += " " + Convert.ToString(mas[i]);
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),
                        Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        int temp;
                        for (int i = 1; i < mas.Length; i++)
                        {
                            temp = mas[i];
                            int j;
                            for (j = i - 1; j >= 0 && mas[j] > temp; j--)
                                mas[j + 1] = mas[j];
                            mas[j + 1] = temp;
                        }


                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }

                }
            }
            else if (checkBox4.Checked)
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        quicksort<double>(mas, 0, mas.Length - 1);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        quicksort<double>(mas, 0, mas.Length - 1);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text),Convert.ToInt32(textBox6.Text)};
                        quicksort<double>(mas, 0, mas.Length - 1);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        quicksort<double>(mas, 0, mas.Length - 1);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        quicksort<double>(mas, 0, mas.Length - 1);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        double[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) };
                        quicksort<double>(mas, 0, mas.Length - 1);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
            }
            else if (checkBox5.Checked)
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }
                            
                        }
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                        
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox5.Text) };
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }

                        }
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }

                        }
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }

                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text)};
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }

                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text)};
                        double gap = mas.Length;
                        bool swaps = true;
                        while (gap > 1 || swaps)
                        {
                            gap /= 1.247330950103979;
                            if (gap < 1) { gap = 1; }
                            int i = 0;
                            swaps = false;
                            while (i + gap < mas.Length)
                            {
                                int igap = i + (int)gap;
                                if (mas[i] > mas[igap])
                                {
                                    int swap = mas[i];
                                    mas[i] = mas[igap];
                                    mas[igap] = swap;
                                    swaps = true;
                                }
                                i++;
                            }

                        }
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
            }
            else if (checkBox6.Checked)
            {
                if (comboBox2.SelectedIndex == 0)//Сортировка по возрастанию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        GnomeSort(mas);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }

                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        GnomeSort(mas);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) };
                        GnomeSort(mas);
                        foreach (int i in mas)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
                else if (comboBox2.SelectedIndex == 1)//Сортировка по убыванию
                {
                    if (comboBox1.SelectedIndex == 0)
                    {

                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) };
                        GnomeSort(mas);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 1)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text) };
                        GnomeSort(mas);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        int[] mas = { Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text) };
                        GnomeSort(mas);
                        var ordered = from i in mas
                                      orderby i descending
                                      select i;
                        foreach (int i in ordered)
                        {
                            textBox4.Text += " " + i;
                        }
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)//Заполнение рандомными значениями
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            Random rng = new Random();
            for (int i = 1; i<= 1; i++)
            {
              
                if (comboBox1.SelectedIndex ==0)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex ==1)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                    textBox5.Text += (rng.Next(100000)).ToString() + " ";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    textBox1.Text += (rng.Next(100000)).ToString() + " ";
                    textBox2.Text += (rng.Next(100000)).ToString() + " ";
                    textBox3.Text += (rng.Next(100000)).ToString() + " ";
                    textBox5.Text += (rng.Next(100000)).ToString() + " ";
                    textBox6.Text += (rng.Next(100000)).ToString() + " ";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//Костыльное добавление текстбоксов
        {

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
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
