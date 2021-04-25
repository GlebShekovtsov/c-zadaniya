﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AirLinesBD
{
    class AdminClass
    {
        DBconnection connect = new DBconnection();
        public bool insertadmin(string role, string firstname, string lastname, string patronymic, string login, string password, string phone, byte[] image)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`role`,`firstname`, `lastname`, `patronymic`, `login`, `password`, `phone`,`image`)" +
            " VALUES (@role,@firstname,@lastname,@patronymic,@login,@password,@phone,@image);", connect.getconnection);
            command.Parameters.Add("@role", MySqlDbType.VarChar).Value = role;
            command.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = firstname;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
            command.Parameters.Add("patronymic", MySqlDbType.VarChar).Value = patronymic;
            command.Parameters.Add("login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("password", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("image", MySqlDbType.LongBlob).Value = image;
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
        public bool deleteadmin(string id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE id = @id;", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `role`='admin'",connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAdminLogout(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
