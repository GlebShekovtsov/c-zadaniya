using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLinesBD
{
    public partial class AdminView : Form
    {
        AdminClass admin = new AdminClass();
        public AdminView()
        {
            InitializeComponent();
        }
        public void showTable()
        {
            dataGridView1.DataSource = admin.getAdminList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView1.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void AdminView_Load_1(object sender, EventArgs e)
        {
            showTable();
        }
    }
}

