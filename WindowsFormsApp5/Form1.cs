using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
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

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WordHelper("doc2.docx");
            var item = new Dictionary<string, string>
            {
                { "<COM>", textBox1.Text },
                { "<COD>", textBox2.Text },
                { "<COL>", textBox3.Text },
                { "<COZ>", textBox4.Text },
            };
            helper.Process(item);
            MessageBox.Show("Документ успешно сохранен", "Сохранено");

        }
    }
}
