using System;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;
using LockCent.Pages;

using LockCent.Encryption;
using LockCent.Scripts;
using System.Media;
using System.Text;
using System.Diagnostics;

namespace LockCent
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // When Form Loads
        private void Register_Load(object sender, EventArgs e)
        {
        }

        // When user clicks window close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closing an application
            Application.Exit();
        }

        // When user clicks "Go To Login" button 
        private void lblLogin_Click(object sender, EventArgs e)
        {
            // Showing back an instance of the Login Page
            Login login = this.Owner as Login;
            login.Show();
            this.Close();
        }

        // When user clicks "Visit Website" button
        private void btnVisit_Click(object sender, EventArgs e)
        {
            Process.Start("https://lynxdev.000webhostapp.com/useraccounts-master/registration.php");
        }
    }
}
