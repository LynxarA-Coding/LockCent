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
        // User data variables
        public string email { private get; set; }
        public string username { private get; set; }
        public string password { private get; set; }
        public byte[] ekey { private get; set; }

        // Creating discord client for Rich Presence
        private DiscordRpcClient client;
        bool discordInitialized;

        public Main()
        {
            InitializeComponent();
        }

        // When Main Page is loaded
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

            HomePage page = new HomePage();
            page.username = username;
            page.ekey = ekey;
            loadPage(page);

            lblHeader.Text = "LockCent | Home";

            lblUsername.Text = username;
        }

        // If user clicks on Window Close Button
        private void btnClose_Click(object sender, EventArgs e)
        {
            // Sending logout logs
            DiscordLog log = new DiscordLog();
            log.SendLogUserLog("logout", username, "");

            // Exiting the app
            Application.Exit();
        }

        // Functions for checking Local Storage file existence
        private void FileChecker()
        {
            // Checking user's storage type
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If user saves data locally
            if (saveType == 0)
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent";

                // If Directory does not exist
                if (!Directory.Exists(path))
                {
                    // Creating a new directory
                    Directory.CreateDirectory(path);
                }

                // If directory of the USER does not exist
                if (!Directory.Exists(path + $"/{username}"))
                {
                    // Creating a new directory
                    Directory.CreateDirectory(path + $"/{username}");
                }

                path = path + $"/{username}";

                // If passwords file does not exist
                if (!File.Exists(path + "/pass.json"))
                {
                    // Creating a new empty password file
                    StreamWriter sw1 = new StreamWriter(path + "/pass.json");
                    string standart = EFunctions.Encrypt("[]", ekey);
                    sw1.Write(standart);
                    sw1.Close();
                }

                // If notes file does not exist
                if (!File.Exists(path + "/notes.txt"))
                {
                    // Creating a new empty notes file
                    StreamWriter sw2 = new StreamWriter(path + "/notes.txt");
                    sw2.Close();
                }
            }
        }

        // Function that opens a new Page (Form) inside a panel 
        public void loadPage(object Form)
        {
            // Removing previous one
            if (this.pnlPage.Controls.Count > 0)
            {
                this.pnlPage.Controls.RemoveAt(0);
            }

            // Changing Form properties
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlPage.Controls.Add(f);
            this.pnlPage.Tag = f;
            f.Show();
        }

        // When Home Page button is clicked
        private void btnHome_Click(object sender, EventArgs e)
        {
            // Creating a new instance of a page
            HomePage page = new HomePage();
            page.username = username;
            page.ekey = ekey;
            loadPage(page);
            
            // Changing header to the page name
            lblHeader.Text = "LockCent | Home";
        }

        // When Passwords Page button is clicked
        private void btnPasswords_Click(object sender, EventArgs e)
        {
            // Checking file existence 
            FileChecker();

            // Checking where user stores data
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If data is stored locally
            if (saveType == 0)
            {
                string jsonfile = "";
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}/pass.json";

                // Reading a json file
                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    jsonfile = jsonfile + sr.ReadLine();
                }
                sr.Close();

                // Converting result into a List<>
                var result = JsonConvert.DeserializeObject<List<Passwords>>(EFunctions.Decrypt(jsonfile, ekey));

                // Creating arrays to pass the data
                string[] names = new string[result.Count];
                string[] values = new string[result.Count];

                // Dilling arrays with data
                for (int i = 0; i < result.Count; i++)
                {
                    names[i] = result[i].Name;
                    values[i] = result[i].Password;
                }

                // Opening a Passwords Page
                PasswordsPage page = new PasswordsPage();
                
                // Passing Passwords names data to the page
                page.GivenPassNames = names;

                // Passing Passwords' data (username/password) to the page
                page.GivenPassValues = values;

                // Opening a configured page
                loadPage(page);
            }
            else // If data is stored in the DB
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();

                // Checking existing data in the DB
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                // If data doesn't exist
                if (userData.UserName == null)
                {
                    // Making empty arrays of data
                    string[] names = new string[0];
                    string[] values = new string[0];

                    PasswordsPage page = new PasswordsPage();

                    // Passing empty Passwords' names and data to the page
                    page.GivenPassNames = names;
                    page.GivenPassValues = values;

                    // Loading page
                    loadPage(page);
                }
                else // If data exists
                {
                    // Decrypting password data
                    string decPasswords = EFunctions.Decrypt(userData.Passwords, ekey);

                    // Converting json-styled data into List<>
                    var result = JsonConvert.DeserializeObject<List<Passwords>>(decPasswords);

                    // Creating arrays for Password Names and Data
                    string[] names = new string[result.Count];
                    string[] values = new string[result.Count];

                    // Filling arrays with data from a List<>
                    for (int i = 0; i < result.Count; i++)
                    {
                        names[i] = result[i].Name;
                        values[i] = result[i].Password;
                    }

                    // Creating a new instance of a page and passing arrays of names and data to it
                    PasswordsPage page = new PasswordsPage();
                    page.GivenPassNames = names;
                    page.GivenPassValues = values;

                    // Loading a configured page
                    loadPage(page);
                }
            }

            // Changing window header to the opened page
            lblHeader.Text = "LockCent | Passwords";
        }

        // When Notes page is clicked
        private void btnNotes_Click(object sender, EventArgs e)
        {
            // Checking file existence
            FileChecker();

            // Creating a new instance of a page
            NotesPage page = new NotesPage();

            // Passing user Ekey to the page
            page.ekey = ekey;

            // Passing user's Username to the page
            page.username = username;

            // Loading configured page
            loadPage(page);

            // Changing window header to the opened page
            lblHeader.Text = "LockCent | Notes";
        }

        // When Settings Page button is clicked
        private void btnSettings_Click(object sender, EventArgs e)
        {
            // Creating a new instance of a page
            SettingsPage page = new SettingsPage();
            
            // Passing user's username to the page
            page.Username = username;

            // Passing user's Ekey to the page
            page.ekey = ekey;

            // Loading a configured page
            loadPage(page);

            // Changing window header to the opened page
            lblHeader.Text = "LockCent | Settings";
        }

        // When Menu Button is clicked
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Height == 40)
            {
                pnlMenu.Visible = false;

                pnlMenu.Height = 436;
                animMenu1.ShowSync(pnlMenu);
            }
            else
            {
                pnlMenu.Visible = false;

                pnlMenu.Height = 40;
                animMenu2.ShowSync(pnlMenu);
            }
        }

        // When LogOut button is clicked
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Logging user's quitting to the discord
            DiscordLog log = new DiscordLog();
            log.SendLogUserLog("logout", username, "");

            // Erasing user data
            email = "";
            username = "";
            password = "";
            ekey = null;

            // Creating a new instance of a login page
            Login lgn = new Login();

            // If this Form was opened from login page
            if (this.Owner.GetType() == lgn.GetType())
            {
                // Opening an existing instance of a login page
                Login lgn2 = this.Owner as Login;
                lgn2.Show();

                // Closing this Form
                this.Close();
            }
        }

        // When Form is closing
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Shutting down Discord Client
            client.Dispose();
        }
    }
}
