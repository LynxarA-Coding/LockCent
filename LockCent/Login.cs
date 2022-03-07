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

        private void DesignCorrector()
        {
            txtUser.Location = new Point(this.Width / 2 - txtUser.Width / 2, txtUser.Location.Y);
            txtPassword.Location = new Point(this.Width / 2 - txtPassword.Width / 2, txtPassword.Location.Y);

            btnLogin.Location = new Point(this.Width / 2 - btnLogin.Width / 2, btnLogin.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DesignCorrector();
        }

        private bool TextControl(string text)
        {
            foreach(char a in text)
            {
                if (a < '0' || (a > '9' && a < 'A') || (a > 'Z' && a < 'a') || a > 'z')
                {
                    return false;
                }
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            if (TextControl(txtUser.Text) && TextControl(txtPassword.Text))
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
                    lblError.Visible = true;
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "User found in the DB!";
                }
                else
                {
                    lblError.Visible = true;
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "No such user in the DB!";
                }

                btnLogin.Enabled = true;
            }
            else
            {
                lblError.Visible = true;
                lblError.ForeColor = Color.Red;
                lblError.Text = "Login or Password include incorrect symbols!";
                lblError.Location = new Point(this.Width / 2 - lblError.Width / 2, lblError.Location.Y);

                btnLogin.Enabled = true;
            }
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register rgstr = new Register();
            rgstr.Show();
            this.Hide();
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
