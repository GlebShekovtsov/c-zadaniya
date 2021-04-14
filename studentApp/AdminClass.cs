using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace studentApp
{
    class AdminClass
    {
        DBconnection connect = new DBconnection();
        public bool insertadmin(string firstname, string lastname, string patronymic, string login, string password, string phone)
        {   
            MySqlCommand command = new MySqlCommand("INSERT INTO `admin`(`firstname`, `lastname`, `patronymic`, `login`, `password`, `phone`)" +
            " VALUES (@firstname,@lastname,@patronymic,@login,@password,@phone);", connect.getconnection);
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("phone", MySqlDbType.VarChar).Value = phone;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }

        }
        public DataTable getAdminList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin`", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}

