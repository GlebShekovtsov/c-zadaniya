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
        private const string Format = "dd+7-";

        public Form2()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void просмотретьЦеныБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                int x;
                x = 45000;
                textBox1.Text = Convert.ToString(x);
            }
            else if (checkBox2.Checked == true)
            {
                int x;
                x = 34000;
                textBox1.Text = Convert.ToString(x);
            }
            else if (checkBox3.Checked == true)
            {
                int x;
                x = 53450;
                textBox1.Text = Convert.ToString(x);
            }
            else if (checkBox4.Checked == true)
            {
                int x;
                x = 46730;
                textBox1.Text = Convert.ToString(x);
            }
        }
    }
}
