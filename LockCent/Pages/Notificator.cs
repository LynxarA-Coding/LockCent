using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class Notificator : Form
    {
        public string Description { get; set; }
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
                    this.Text = "LockCent | ERROR";
                    txtHeader.Text = "ERROR";
                    break;
                case "info":
                    this.Text = "LockCent | INFO";
                    txtHeader.Text = "INFO";
                    break;
                default:
                    this.Text = "LockCent | INVALID";
                    txtHeader.Text = "Error | Invalid Type";
                    break;
            }

            txtMain.Text = Description;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
