using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        public Form activeForm = null;
        private void OpenInsertUser(Form OpenInsertUser)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = OpenInsertUser;
            OpenInsertUser.TopLevel = false;
            OpenInsertUser.FormBorderStyle = FormBorderStyle.None;
            OpenInsertUser.Dock = DockStyle.Fill;
            panel_main.Controls.Add(OpenInsertUser);
            panel_main.Tag = OpenInsertUser;
            OpenInsertUser.BringToFront();
            OpenInsertUser.Show();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenInsertUser(new InsertUser());
        }
        private void DeleteUser(Form DeleteUser)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = DeleteUser;
            DeleteUser.TopLevel = false;
            DeleteUser.FormBorderStyle = FormBorderStyle.None;
            DeleteUser.Dock = DockStyle.Fill;
            panel_main.Controls.Add(DeleteUser);
            panel_main.Tag = DeleteUser;
            DeleteUser.BringToFront();
            DeleteUser.Show();
        }

        private void удалитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser(new DeleteUser());
        }
        private void ViewUser(Form ViewUser)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ViewUser;
            ViewUser.TopLevel = false;
            ViewUser.FormBorderStyle = FormBorderStyle.None;
            ViewUser.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ViewUser);
            panel_main.Tag = ViewUser;
            ViewUser.BringToFront();
            ViewUser.Show();
        }

        private void списокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser(new UserView());
        }
        private void InsertTicket (Form InsertTicket)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = InsertTicket;
            InsertTicket.TopLevel = false;
            InsertTicket.FormBorderStyle = FormBorderStyle.None;
            InsertTicket.Dock = DockStyle.Fill;
            panel_main.Controls.Add(InsertTicket);
            panel_main.Tag = InsertTicket;
            InsertTicket.BringToFront();
            InsertTicket.Show();
        }
        private void добавитьБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertTicket(new InsertTicket());
        }
        private void DeleteTicket(Form DeleteTicket)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = DeleteTicket;
            DeleteTicket.TopLevel = false;
            DeleteTicket.FormBorderStyle = FormBorderStyle.None;
            DeleteTicket.Dock = DockStyle.Fill;
            panel_main.Controls.Add(DeleteTicket);
            panel_main.Tag = DeleteTicket;
            DeleteTicket.BringToFront();
            DeleteTicket.Show();
        }
        private void удалитьБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteTicket(new DeleteTicket());
        }
        private void TicketView(Form TicketView)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = TicketView;
            TicketView.TopLevel = false;
            TicketView.FormBorderStyle = FormBorderStyle.None;
            TicketView.Dock = DockStyle.Fill;
            panel_main.Controls.Add(TicketView);
            panel_main.Tag = TicketView;
            TicketView.BringToFront();
            TicketView.Show();

        }

        private void списокБилетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketView(new TicketView());
        }
    }
}
