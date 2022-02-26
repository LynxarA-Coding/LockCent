using System;
using System.Drawing;
using LockCent.Encryption;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LockCent
{
    public partial class Login : Form
    {
        bool mouseDown;
        private Point offset;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = "server=remotemysql.com;user=BuVg5vx3v6;database=BuVg5vx3v6;password=nlbkpvJADI;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string txtCommand = "SELECT * FROM `user_accounts` WHERE `username` = \"" + txtUser.Text + "\"";
            string sql = txtCommand;

            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();


            string stat = "";
            string username = "";
            string password = "";
            string ekey = "";

            while (reader.Read())
            {
                stat = reader[0].ToString();
                username = reader[1].ToString();
                password = reader[2].ToString();
                ekey = reader[3].ToString();
            }

            reader.Close();

            conn.Close();

            if (password == txtPassword.Text)
            {
                MessageBox.Show(
                "YES",
                "PASSWORD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "NO",
                "PASSWORD",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlDrag_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnlDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnlDrag_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

    }
}
