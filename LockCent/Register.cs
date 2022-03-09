using System;
using System.Drawing;
using System.Windows.Forms;
using LockCent.Pages;
using MySql.Data.MySqlClient;

namespace LockCent
{
    public partial class Register : Form
    {
        bool mouseDown;
        private Point offset;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtUser.Location = new Point(this.Width / 2 - txtUser.Width / 2, txtUser.Location.Y);
            txtPass1.Location = new Point(this.Width / 2 - txtPass1.Width / 2, txtPass1.Location.Y);
            txtPass2.Location = new Point(this.Width / 2 - txtPass2.Width / 2, txtPass2.Location.Y);

            btnRegister.Location = new Point(this.Width / 2 - btnRegister.Width / 2, btnRegister.Location.Y);
            lblError.Location = new Point(this.Width / 2 - lblError.Width / 2, lblError.Location.Y);
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login lgn = this.Owner as Login;
            lgn.Show();
            this.Close();
        }

        private bool TextControl(string text)
        {
            if (text.Length == 0)
            {
                return false;
            }

            foreach (char a in text)
            {
                if (a < '0' || (a > '9' && a < 'A') || (a > 'Z' && a < 'a') || a > 'z')
                {
                    return false;
                }
            }

            return true;
        }

        private string TextGenerator(int length)
        {
            var rnd = new Random();
            string AllowedLetters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string result = "";

            for (int i = 0; i < length; i++)
            {
                result += AllowedLetters[rnd.Next(0, AllowedLetters.Length)];
            }

            return result;
        }

        private bool UserChecker(string username, string password)
        {

            string connStr = "server=remotemysql.com;user=BuVg5vx3v6;database=BuVg5vx3v6;password=nlbkpvJADI;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string txtCommand = "SELECT * FROM `user_accounts` WHERE `username` = \"" + username + "\"";
            string sql = txtCommand;

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

            if (username == dbusername)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;

            if (TextControl(txtUser.Text) && TextControl(txtPass1.Text) && TextControl(txtPass2.Text) && (txtPass1.Text == txtPass2.Text))
            {
                string username = txtUser.Text;
                string password = txtPass1.Text;
                string key = TextGenerator(24);

                if (UserChecker(username, password))
                {
                    string connStr = "server=remotemysql.com;user=BuVg5vx3v6;database=BuVg5vx3v6;password=nlbkpvJADI;";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();

                    string editedCom = "INSERT INTO `user_accounts`(`username`, `password`, `ekey`) VALUES ('" + username + "','" + password + "','" + key + "')";
                    MySqlCommand command = new MySqlCommand(editedCom, conn);
                    int result = command.ExecuteNonQuery();
                    conn.Close();

                    Main mn = new Main() { Owner = this };
                    mn.Show();

                    txtUser.Text = "";
                    txtPass1.Text = "";
                    txtPass2.Text = "";

                    this.Close();
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "User already registered!";
                    lblError.Location = new Point(this.Width / 2 - lblError.Width / 2, lblError.Location.Y);
                }

                

                btnRegister.Enabled = true;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "Login or Password include incorrect symbols!";
                lblError.Location = new Point(this.Width / 2 - lblError.Width / 2, lblError.Location.Y);

                btnRegister.Enabled = true;
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

        private void lblError_TextChanged(object sender, EventArgs e)
        {
            lblError.Location = new Point(this.Width / 2 - lblError.Width / 2, lblError.Location.Y);
        }

        
    }
}
