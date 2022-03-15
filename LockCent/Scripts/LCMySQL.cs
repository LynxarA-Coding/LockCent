using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LockCent.Scripts
{
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

        public string[] Get(string commandLine)
        {
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();

            string sql = commandLine;

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();

            string dbusername = "";
            string dbpassword = "";
            string dbekey = "";

            while (reader.Read())
            {
                dbusername = reader[0].ToString();
                dbpassword = reader[1].ToString();
                dbekey = reader[2].ToString();
            }

            reader.Close();

            conn.Close();

            string[] result = new string[3];
            result[0] = dbusername;
            result[1] = dbpassword;
            result[2] = dbekey;

            return result;
        }
    }
}
