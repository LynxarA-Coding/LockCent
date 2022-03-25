using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LockCent.Encryption;
using MySql.Data.MySqlClient;

namespace LockCent.Scripts
{
    class User
    {
        public string Email { get; set; }
        public string UserName { get; set; }   
        public string Password { get; set; }
        public byte[] Ekey { get; set; }
    }

    class UserData
    {
        public string UserName { get; set; }
        public string Passwords { get; set; }
        public string Notes { get; set; }
    }
    class LCMySQL
    {
        // The key
        private readonly byte[] _key = { 0x12, 0x56, 0x14, 0x71, 0x0, 0x21, 0x9, 0x17, 0x66, 0x33, 0x56, 0x34, 0x10, 0x13, 0x11, 0x71 };
        
        // DB connection string
        private readonly string connStr = "zHeXUI0/LKpGgeb00H+XT7YmYx6/w8OQuMRPJ7j3VLcD+q9pwU6rDx3psONJQU5MTtTimZBkj6LRBWDY4LzQt1Sfpg/ZKbd3s92SahEnx7g=";
        public void Send(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(EFunctions.Decrypt(connStr, _key));
            conn.Open();

            MySqlCommand command = new MySqlCommand(commandLine, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public User UserGet(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(EFunctions.Decrypt(connStr, _key));
            conn.Open();

            string sql = commandLine;

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            User user = new User();

            while (reader.Read())
            {
                user.Email = reader[0].ToString();
                user.UserName = reader[1].ToString();
                user.Password = reader[2].ToString();
                user.Ekey = (byte[])reader[3];
            }

            reader.Close();

            conn.Close();

            return user;
        }

        public UserData DataGet(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(EFunctions.Decrypt(connStr, _key));
            conn.Open();

            string sql = commandLine;

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            UserData data = new UserData();

            while (reader.Read())
            {
                data.UserName = reader[0].ToString();
                data.Passwords = reader[1].ToString();
                data.Notes = reader[2].ToString();
            }

            reader.Close();

            conn.Close();

            return data;
        }
    }
}
