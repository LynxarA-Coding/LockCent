using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Notificator : Form
    {
        // Text description that Notifications get from other Forms
        public string Description { get; set; }
        // Notification type that Notifications get from other Forms ("error" - Error type, "info" - Info type)
        public string Type { get; set; }
        public Notificator()
        {
            InitializeComponent();
        }

        // If window close button is pressed
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }

        // When Notifications appear
        private void Notificator_Load(object sender, EventArgs e)
        {
            // Play Windows Error sound
            SystemSounds.Exclamation.Play();

            /*
             this.Text = Windows Label display when hovering with mouse
             txtHeader.Text = Header of the window
            */
            switch(Type)
            {
                // IF Notification Type is "Error"
                case "error":
                    this.Text = "LockCent | ERROR";
                    txtHeader.Text = "ERROR";
                    break;
                // IF Notification Type is "Error"
                case "info":
                    this.Text = "LockCent | INFO";
                    txtHeader.Text = "INFO";
                    break;
                // IF Notification Type is "Error"
                default:
                    this.Text = "LockCent | INVALID";
                    txtHeader.Text = "Error | Invalid Type";
                    break;
            }

            txtMain.Text = Description;
        }

        // If OK button is clicked
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
