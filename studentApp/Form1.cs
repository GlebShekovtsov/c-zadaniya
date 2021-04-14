using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentApp
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }
        public Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm !=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(childForm);
            panel_mane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void viewTableForm(Form viewform)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = viewform;
            viewform.TopLevel = false;
            viewform.FormBorderStyle = FormBorderStyle.None;
            viewform.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(viewform);
            panel_mane.Tag = viewform;
            viewform.BringToFront();
            viewform.Show();
        }
        private void openTeacherForm(Form teacherForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = teacherForm;
            teacherForm.TopLevel = false;
            teacherForm.FormBorderStyle = FormBorderStyle.None;
            teacherForm.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(teacherForm);
            panel_mane.Tag = teacherForm;
            teacherForm.BringToFront();
            teacherForm.Show();
        }
        private void viewTableForm1(Form viewsteacher)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = viewsteacher;
            viewsteacher.TopLevel = false;
            viewsteacher.FormBorderStyle = FormBorderStyle.None;
            viewsteacher.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(viewsteacher);
            panel_mane.Tag = viewsteacher;
            viewsteacher.BringToFront();
            viewsteacher.Show();
        }
        private void openAdminForm(Form addAdmin)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = addAdmin;
            addAdmin.TopLevel = false;
            addAdmin.FormBorderStyle = FormBorderStyle.None;
            addAdmin.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(addAdmin);
            panel_mane.Tag = addAdmin;
            addAdmin.BringToFront();
            addAdmin.Show();
        }
        private void viewTableForm2(Form viewadmin)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = viewadmin;
            viewadmin.TopLevel = false;
            viewadmin.FormBorderStyle = FormBorderStyle.None;
            viewadmin.Dock = DockStyle.Fill;
            panel_mane.Controls.Add(viewadmin);
            panel_mane.Tag = viewadmin;
            viewadmin.BringToFront();
            viewadmin.Show();
        }
        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new addStudent());
        }

        private void списокСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTableForm(new views());
        }

        private void добавитьПреподавателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openTeacherForm(new addTeacher());
        }

        private void списокПреподавателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTableForm1(new viewsteacher());
        }

        private void добавитьАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openAdminForm(new addAdmin());
        }

        private void просмотретьСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTableForm2(new viewsadmin());
        }
    }
}
