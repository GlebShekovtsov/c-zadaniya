﻿using System;
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
    public partial class DeleteAdmin : Form
    {
        AdminClass admin = new AdminClass();
        public DeleteAdmin()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if (textBox_ID.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = textBox_ID.Text;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить администратора?", "Удаление пользователя", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (verify())
                {
                    try
                    {
                        if (admin.deleteadmin(ID))
                        {
                            MessageBox.Show("Запись удалена");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
