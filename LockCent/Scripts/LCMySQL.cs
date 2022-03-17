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

        public User Get(string commandLine)
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
    }
}
