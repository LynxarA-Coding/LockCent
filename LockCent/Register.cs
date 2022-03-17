using System;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;
using LockCent.Pages;

using LockCent.Encryption;
using LockCent.Scripts;
using System.Media;
using System.Text;

namespace LockCent
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Register : Form
    {
        bool mouseDown;
        private Point offset;

        private int textLength = 20;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            

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

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = this.Owner as Login;
            login.Show();
            this.Close();
        }
    }
}
