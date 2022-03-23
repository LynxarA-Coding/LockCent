using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

using LockCent.Encryption;
using LockCent.Properties;
using DiscordRPC;
using DiscordRPC.Logging;
using LockCent.Scripts;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class Main : Form
    {
        bool mouseDown;
        private Point offset;

        public string email;
        public string username;
        public string password;
        public byte[] ekey;


        public DiscordRpcClient client;
        bool discordInitialized = false;

        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DiscordLog log = new DiscordLog();
            log.SendLogUserLog("logout", username, "");

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

        private void FileChecker()
        {
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);
            if (saveType == 0)
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                if (!Directory.Exists(path + $"/{username}"))
                {
                    Directory.CreateDirectory(path + $"/{username}");
                }

                path = path + $"/{username}";

                if (!File.Exists(path + "/pass.json"))
                {
                    StreamWriter sw1 = new StreamWriter(path + "/pass.json");
                    string standart = EFunctions.Encrypt("[]", ekey);
                    sw1.Write(standart);
                    sw1.Close();
                }

                if (!File.Exists(path + "/notes.txt"))
                {
                    StreamWriter sw2 = new StreamWriter(path + "/notes.txt");
                    sw2.Close();
                }
            }
        }

        // Loaded
        private void Main_Load(object sender, EventArgs e)
        {
            discordInitialized = true;
            client = new DiscordRpcClient("951572520681738311");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            while (!discordInitialized)
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

            FileChecker();

            loadPage(new HomePage());
            lblHeader.Text = "LockCent | Home";

            lblUsername.Text = username;
        }

        // Form Opener
        public void loadPage(object Form)
        {
            if (this.pnlPage.Controls.Count > 0)
                this.pnlPage.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlPage.Controls.Add(f);
            this.pnlPage.Tag = f;
            f.Show();
        }

        // Home
        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage page = new HomePage();
            loadPage(page);
            
            lblHeader.Text = "LockCent | Home";
        }

        // Passwords
        private void btnPasswords_Click(object sender, EventArgs e)
        {
            FileChecker();

            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            if (saveType == 0)
            {
                string jsonfile = "";
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}/pass.json";
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    jsonfile += sr.ReadLine();
                }
                sr.Close();

                var result = JsonConvert.DeserializeObject<List<Passwords>>(EFunctions.Decrypt(jsonfile, ekey));
                string[] names = new string[result.Count];
                string[] values = new string[result.Count];

                for (int i = 0; i < result.Count; i++)
                {
                    names[i] = result[i].Name;
                    values[i] = result[i].Password;
                }

                PasswordsPage page = new PasswordsPage();
                page.GivenPassNames = names;
                page.GivenPassValues = values;

                loadPage(page);
            }
            else
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                if (userData.UserName == null)
                {
                    string[] names = new string[0];
                    string[] values = new string[0];

                    PasswordsPage page = new PasswordsPage();
                    page.GivenPassNames = names;
                    page.GivenPassValues = values;

                    loadPage(page);
                }
                else
                {
                    string decPasswords = EFunctions.Decrypt(userData.Passwords, ekey);
                    var result = JsonConvert.DeserializeObject<List<Passwords>>(decPasswords);

                    string[] names = new string[result.Count];
                    string[] values = new string[result.Count];

                    for (int i = 0; i < result.Count; i++)
                    {
                        names[i] = result[i].Name;
                        values[i] = result[i].Password;
                    }

                    PasswordsPage page = new PasswordsPage();
                    page.GivenPassNames = names;
                    page.GivenPassValues = values;

                    loadPage(page);
                }
            }

            lblHeader.Text = "LockCent | Passwords";
        }

        // Notes
        private void btnNotes_Click(object sender, EventArgs e)
        {
            FileChecker();

            NotesPage page = new NotesPage();
            page.ekey = ekey;
            page.username = username;
            loadPage(page);

            lblHeader.Text = "LockCent | Notes";
        }

        // Settings 
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsPage page = new SettingsPage();
            page.Username = username;
            page.ekey = ekey;
            loadPage(page);

            lblHeader.Text = "LockCent | Settings";
        }

        // LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DiscordLog log = new DiscordLog();
            log.SendLogUserLog("logout", username, "");

            username = "";
            password = "";
            ekey = null;

            Register reg = new Register();
            Login lgn = new Login();

            if (this.Owner.GetType() == reg.GetType())
            {
                Register reg2 = this.Owner as Register;
                reg2.Show();
                this.Close();
            }
            else
            {
                Login lgn2 = this.Owner as Login;
                lgn.Show();
                this.Close();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
