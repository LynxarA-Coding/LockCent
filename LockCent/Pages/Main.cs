using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class Main : Form
    {
        bool mouseDown;
        private Point offset;

        public DiscordRpcClient client;
        bool discordInitialized = false;

        public Main()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Login lgn = this.Owner as Login;
            lgn.Show();
            this.Close();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            discordInitialized = true;
            client = new DiscordRpcClient("951572520681738311");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            while(!discordInitialized)
            {

            }

            if (discordInitialized)
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = "",
                    State = "securing passwords...",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = "lockcent_w512",
                        LargeImageText = "",
                        SmallImageKey = ""
                    }
                });
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }
    }
}
