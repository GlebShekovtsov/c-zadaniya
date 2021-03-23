using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("doc.docx");
            var items = new Dictionary<string, string>
            {
                { "<ORG>", textBox1.Text },
                { "<DIR>", textBox2.Text },
            };
            helper.Process(items);
        }
    }
}
