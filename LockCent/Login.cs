using System;
using System.Drawing;
using LockCent.Pages;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using LockCent.Scripts;
using LockCent.Encryption;
using System.Media;
using System.Text;

namespace LockCent
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Login : Form
    {
        bool mouseDown;
        private Point offset;

        private int textLength = 20;

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;

            if (TextControl(txtUser.Text) && TextControl(txtPassword.Text))
            {
                LCMySQL sql = new LCMySQL();
                string txtCommand = "SELECT * FROM `user_accounts` WHERE `username` = \"" + txtUser.Text + "\"";

                User user = sql.Get(txtCommand);

                if (user.Ekey != null && user.Password == EFunctions.Encrypt(txtPassword.Text, user.Ekey))
                {

                    Main mn = new Main(){ Owner = this };

                    mn.email = user.Email;
                    mn.username = user.UserName;
                    mn.password = user.Password;
                    mn.ekey = user.Ekey;

                    mn.Show();

                    txtUser.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                }
                else
                {
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "Username or password are incorrect!";
                    notify.Show();
                }

                btnLogin.Enabled = true;
            }
            else
            {
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "Login or Password include incorrect symbols!";
                notify.Show();

                btnLogin.Enabled = true;
            }
            
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register rgstr = new Register() { Owner = this };
            rgstr.Show();

            txtUser.Text = "";
            txtPassword.Text = "";

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

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > textLength)
            {
                txtUser.Text = txtUser.Text.Substring(0, textLength);
                txtUser.SelectionStart = txtUser.Text.Length;
                txtUser.SelectionLength = 0;

                SystemSounds.Exclamation.Play();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > textLength)
            {
                txtPassword.Text = txtPassword.Text.Substring(0, textLength);
                txtPassword.SelectionStart = txtPassword.Text.Length;
                txtPassword.SelectionLength = 0;

                SystemSounds.Exclamation.Play();
            }
        }
    }
}
