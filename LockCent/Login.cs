using System;
using System.Drawing;
using LockCent.Pages;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using LockCent.Scripts;
using LockCent.Encryption;
using System.Media;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace LockCent
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Login : Form
    {
        // Text Length Value (maximum)
        private readonly int textLength = 20;

        public Login()
        {
            InitializeComponent();
        }

        // Function that centers text boxes and a button to center
        private void DesignCorrector()
        {
            txtUser.Location = new Point((this.Width / 2) - (txtUser.Width / 2), txtUser.Location.Y);
            txtPassword.Location = new Point((this.Width / 2) - (txtPassword.Width / 2), txtPassword.Location.Y);

            btnLogin.Location = new Point((this.Width / 2) - (btnLogin.Width / 2), btnLogin.Location.Y);
        }

        // When Form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            // Centering the elements
            DesignCorrector();
        }

        // Function that checkes Text based on the rules
        private bool TextControl(string text)
        {
            // If text is empty
            if (text.Length == 0)
            {
                // text was not validated
                return false;
            }

            // For Each symbol in text
            foreach (char a in text)
            {
                // It is not number or a letter
                if (a < '0' || (a > '9' && a < 'A') || (a > 'Z' && a < 'a') || a > 'z')
                {
                    // text was not validated
                    return false;
                }
            }

            // If no if's returned false - text is validated
            return true;
        }

        // When user presses login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Anti-double click
            btnLogin.Enabled = false;

            // If username and password passed the validation
            if (TextControl(txtUser.Text) && TextControl(txtPassword.Text))
            {
                LCMySQL sql = new LCMySQL();

                // Checking existing data in the database of users
                string txtCommand = "SELECT * FROM `user_accounts` WHERE `username` = \"" + txtUser.Text + "\"";

                User user = sql.UserGet(txtCommand);

                // If user exists and password matches
                if (user.Ekey != null && user.Password == EFunctions.Encrypt(txtPassword.Text, user.Ekey))
                {
                    // Logging user log in
                    DiscordLog log = new DiscordLog();
                    log.SendLogUserLog("login", txtUser.Text, "");

                    // Creating a new instance of the Main Form
                    Main mn = new Main(){ Owner = this };

                    // Passing user data to the Form
                    mn.email = user.Email;
                    mn.username = user.UserName;
                    mn.password = user.Password;
                    mn.ekey = user.Ekey;

                    // Showing a configured Form
                    mn.Show();

                    // Removing user input from the page
                    txtUser.Text = "";
                    txtPassword.Text = "";

                    // Hiding Login Page
                    this.Hide();
                }
                else // If user does not exist or password was incorrect
                {
                    // Sending user error
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "Username or password are incorrect!";
                    notify.Show();
                }

                btnLogin.Enabled = true;
            }
            else // If text fields were not validated
            {
                // Sending text error
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "Login or Password include incorrect symbols!";
                notify.Show();

                btnLogin.Enabled = true;
            }
        }

        // When user clicks register button
        private void lblRegister_Click(object sender, EventArgs e)
        {
            // Creating a new instance of a Register Page
            Register rgstr = new Register() { Owner = this };
            rgstr.Show();

            // Removing user input from the page
            txtUser.Text = "";
            txtPassword.Text = "";

            // Hiding this page
            this.Hide();
        }

        // If user changes text in the username field
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            // If user exceeds a length of text
            if (txtUser.Text.Length > textLength)
            {
                // Removing any extra symbol
                txtUser.Text = txtUser.Text.Substring(0, textLength);
                txtUser.SelectionStart = txtUser.Text.Length;
                txtUser.SelectionLength = 0;

                // Playing Windows Error Sound
                SystemSounds.Exclamation.Play();
            }
        }

        // If user changes text in the password field
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // If user exceeds a length of text
            if (txtPassword.Text.Length > textLength)
            {
                // Removing any extra symbol
                txtPassword.Text = txtPassword.Text.Substring(0, textLength);
                txtPassword.SelectionStart = txtPassword.Text.Length;
                txtPassword.SelectionLength = 0;

                // Playing Windows Error Sound
                SystemSounds.Exclamation.Play();
            }
        }

        // When user clicks a window close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closing program
            Application.Exit();
        }
    }
}
