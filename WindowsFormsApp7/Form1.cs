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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            int log, pass;
            log = Convert.ToInt32(textBox1.Text);
            pass = Convert.ToInt32(textBox2.Text);
            if (log == 123 && pass == 123)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Логин и/или пароль введены неверно");
            }
        }
    }
}
