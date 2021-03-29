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

namespace WindowsFormsApp8
{

    public partial class Form1 : Form
    {
        public static string text1, text2;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
        }
    }


}
