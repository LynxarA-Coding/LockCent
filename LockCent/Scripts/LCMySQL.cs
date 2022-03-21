using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string connStr = "server=remotemysql.com;user=BuVg5vx3v6;database=BuVg5vx3v6;password=nlbkpvJADI;";
        public void Send(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            MySqlCommand command = new MySqlCommand(commandLine, conn);
            int result = command.ExecuteNonQuery();
            conn.Close();
        }

        public User UserGet(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
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
            MySqlConnection conn = new MySqlConnection(connStr);
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
