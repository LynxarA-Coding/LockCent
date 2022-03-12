using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class Notificator : Form
    {
        bool mouseDown;
        private Point offset;
        public string Text { get; set; }
        public string Type { get; set; }
        public Notificator()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notificator_Load(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();

            switch(Type)
            {
                case "error":
                    txtHeader.Text = "ERROR";
                    break;
                case "info":
                    txtHeader.Text = "INFO";
                    break;
                default:
                    txtHeader.Text = "Error | Invalid Type";
                    break;
            }

            txtMain.Text = Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
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
