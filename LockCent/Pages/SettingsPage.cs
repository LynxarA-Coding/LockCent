using System;
using System.IO;
using System.Windows.Forms;

using LockCent.Properties;
using LockCent.Encryption;
using LockCent.Scripts;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class SettingsPage : Form
    {
        // Username that Settings get from other Forms
        public string Username { private get; set; }

        // Ekey that Settings get from other Forms
        public byte[] ekey { private get; set; }
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void RestoreSettings() // Restore settings when loading the Settings Page
        {
            int svtype = Convert.ToInt32(Settings.Default["SaveType"]);

            if (svtype == 1)
            {
                btnDB.Checked = true;
            }
            else
            {
                btnLocal.Checked = true;
            }

            bool notestype = Convert.ToBoolean(Settings.Default["Notes"]);

            if (notestype)
            {
                cbNotes.Checked = true;
            }
            else
            {
                cbNotes.Checked = false;
            }
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void SettingLogger(string setting) // Function that sends Discord log
        {
            DiscordLog log = new DiscordLog();

            switch (setting)
            {
                case "local":
                    log.SendLogUserLog("setting", Username, "Data storage type switched to: **'local'**");
                    break;

                case "sql":
                    log.SendLogUserLog("setting", Username, "Data storage type switched to: **'in Database'**");
                    break;

                case "eraseNotes":
                    log.SendLogUserLog("setting", Username, "Data Deletion: **Notes**");
                    break;
                case "erasePasswords":
                    log.SendLogUserLog("setting", Username, "Data Deletion: **Passwords**");
                    break;
                default:
                    log.SendLogUserLog("setting", Username, "Data passing error");
                    break;
            }
        }

        // When user clicked on local Data Type
        private void btnLocal_CheckedChanged(object sender, EventArgs e)
        {
            // Preventing double click
            btnDB.Enabled = false;
            btnLocal.Enabled = false;

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (btnLocal.Checked) // If he chose this one
            {
                // If data isn't saved locally by the settings
                if (Convert.ToInt32(Settings.Default["SaveType"]) != 0)
                {
                    Settings.Default["SaveType"] = 0; // Save the choice
                    Settings.Default.Save();

                    SettingLogger("local"); // Loging data

                    // Creating local directory
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    LCMySQL sql = new LCMySQL();
                    UserData userData = new UserData();

                    // Checking existing data in databse
                    userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                    // Transfering data from database if its already exists
                    if (userData.UserName != null)
                    {
                        // Creating password data file with data from db
                        StreamWriter sw1 = new StreamWriter(path + "/pass.json");
                        sw1.Write(userData.Passwords);
                        sw1.Close();

                        // Creating notes data file with data from db
                        StreamWriter sw2 = new StreamWriter(path + "/notes.txt");
                        sw2.WriteLine(userData.Notes);
                        sw2.Close();

                        // Deleting existing data from the db
                        sql.Send($"DELETE FROM `user_data` WHERE `username`='{Username}'");
                    }
                }
            }

            btnDB.Enabled = true;
            btnLocal.Enabled = true;
        }

        private void btnDB_CheckedChanged(object sender, EventArgs e)
        {
            btnDB.Enabled = false;
            btnLocal.Enabled = false;

            string fileNotes = " ";
            string filePass = "[]";

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (btnDB.Checked)
            {
                // If data isn't saved in the db by the settings
                if (Convert.ToInt32(Settings.Default["SaveType"]) != 1)
                {
                    Settings.Default["SaveType"] = 1; // Save the choice
                    Settings.Default.Save();

                    SettingLogger("sql"); // Logging data

                    // Checking existance of local directory
                    if (Directory.Exists(path))
                    {
                        bool notesExist = File.Exists(path + "/notes.txt"); // Do notes exist?
                        bool passExist = File.Exists(path + "/pass.json"); // Do passwords exist?

                        // If any local data exists
                        if (notesExist || passExist)
                        {
                            // If notes exist
                            if (notesExist)
                            {
                                StreamReader sr = new StreamReader(path + "/notes.txt");

                                fileNotes = "";
                                // Reading existing data into fileNotes
                                while (!sr.EndOfStream)
                                {
                                    fileNotes = fileNotes + sr.ReadLine();
                                }

                                sr.Close();
                            }

                            // If passwords exist
                            if (passExist)
                            {
                                StreamReader sr1 = new StreamReader(path + "/pass.json");

                                filePass = "";
                                // Reading existing data into filePass
                                while (!sr1.EndOfStream)
                                {
                                    filePass += sr1.ReadLine();
                                }

                                sr1.Close();
                            }
                        }

                        // Deleting existing local data
                        File.Delete(path + "/pass.json");
                        File.Delete(path + "/notes.txt");

                        // And directory
                        Directory.Delete(path);
                    }

                    // If no notes were found
                    if (fileNotes == " ")
                    {
                        // Making encrypted empty notes data
                        fileNotes = EFunctions.Encrypt(fileNotes, ekey);
                    }

                    // If no passwords were found
                    if (filePass == "[]")
                    {
                        // Making encrypted empty passwords data
                        filePass = EFunctions.Encrypt(filePass, ekey);
                    }

                    LCMySQL sql = new LCMySQL();
                    UserData userData = new UserData();

                    // Checking existing data in databse
                    userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                    // If data doesn't exist
                    if (userData.UserName == null)
                    {
                        // Creating data in the database
                        string commandLine = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{Username}','{filePass}','{fileNotes}')";
                        sql.Send(commandLine);
                    }
                    else
                    {
                        // Updating data in the database
                        string commandLine = $"UPDATE `user_data` SET `username`='{Username}',`passwords`='{filePass}',`notes`='{fileNotes}' WHERE `username`='{Username}'";
                        sql.Send(commandLine);
                    }
                }
            }

            btnDB.Enabled = true;
            btnLocal.Enabled = true;
        }

        // If Notes activation state has chenged
        private void cbNotes_CheckedChanged(object sender, EventArgs e)
        {
            // Changing settings based on the choice
            if (cbNotes.Checked)
            {
                Settings.Default["Notes"] = true;
            }
            else
            {
                Settings.Default["Notes"] = false;
            }

            Settings.Default.Save();
        }

        // Type of Timer (false - Erase Passwords, true - Erase Notes)
        bool timerType = false;
        // 5 seconds counter for timer
        int timerCount = 5;
        // Timer State Variable
        bool isTimerEnded = true;

        // If "Erase Passwords" button is pressed
        private void btnErasePass_Click(object sender, EventArgs e)
        {
            // If timer ended (button wasn't pressed to confirm any action)
            if (isTimerEnded)
            {
                // Asking for confirmation
                lblErasePasswords.Text = "Are you sure?\nPress the button again \nto confirm your action.";
                btnErasePass.Text = "CONFIRM";

                // Starting timer for confirmation
                timerType = false;
                timerConfirm.Interval = 1000;
                timerConfirm.Start();

                isTimerEnded = false;
            }
            else if (timerType == false) // If button is pressed to confirm deleting action
            {
                btnErasePass.Enabled = false;

                SettingLogger("erasePasswords"); // Logging changes
                ErasePasswords(); // Erasing Passwords

                btnErasePass.Enabled = true;
            }
        }

        // If "Erase Notes" button is pressed
        private void btnEraseNotes_Click(object sender, EventArgs e)
        {
            // If timer ended (button wasn't pressed to confirm any action)
            if (isTimerEnded)
            {
                // Asking for confirmation
                lblEraseNotes.Text = "Are you sure?\nPress the button again \nto confirm your action.";
                btnEraseNotes.Text = "CONFIRM";

                // Starting timer for confirmation
                timerType = true;
                timerConfirm.Interval = 1000;
                timerConfirm.Start();

                isTimerEnded = false;
            }
            else if (timerType == true) // If button is pressed to confirm deleting action
            {
                btnEraseNotes.Enabled = false;

                SettingLogger("eraseNotes"); // Logging changes
                EraseNotes(); // Erasing Notes

                btnEraseNotes.Enabled = true;
            }
        }

        // Timer every tick function (happens every second)
        private void timerConfirm_Tick(object sender, EventArgs e)
        {
            // Substracting amount of seconds
            timerCount -= 1;

            // If timer is over
            if (timerCount == 0)
            {
                // Resetting counter
                timerCount = 5;

                // Resetting Labels (texts)
                ResetLabels();

                // Timer is ended
                isTimerEnded = true;
                timerConfirm.Stop();
            }
        }

        // Function that resets labels (texts) for defaults
        private void ResetLabels()
        {
            lblEraseNotes.Text = "Erase all the Notes?\n(It will delete all the notes!)";
            lblErasePasswords.Text = "Erase all the Passwords?\n(It will delete all the Passwords!)";

            btnEraseNotes.Text = "ERASE NOTES";
            btnErasePass.Text = "ERASE PASSWORDS";
        }

        // Function that erases notes
        private void EraseNotes()
        {
            // If notes are stored locally
            if (Convert.ToInt32(Settings.Default["SaveType"]) == 0)
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";

                // If directory exists
                if (Directory.Exists(path)) 
                {
                    if (File.Exists(path + "/notes.txt")) // If notes exist
                    {
                        // Deleting notes
                        File.Delete(path + "/notes.txt");

                        // Sending notification that notes are deleted
                        Notificator notify = new Notificator();
                        notify.Type = "info";
                        notify.Description = "Your Notes were deleted!\nThis action is irreversible!";
                        notify.Show();
                    }
                    else
                    {
                        // Sending notification that notes don't exist in this account
                        Notificator notify = new Notificator();
                        notify.Type = "error";
                        notify.Description = "There are no notes in the chosen account!";
                        notify.Show();
                    }
                }
                else
                {
                    // Sending notification that notes don't exist in this account
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "There are no notes in the chosen account!";
                    notify.Show();
                }
            }
            else // If notes are stored in Database
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();

                // Checking for existing data
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                // If there are no records in the database
                if (userData.UserName == null)
                {
                    // Sending notification that notes don't exist in the account
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "There are no notes in the chosen account!";
                    notify.Show();
                }
                else
                {
                    string savedPasswords = userData.Passwords;

                    // Updating data in the database (erasing it)
                    string commandLine = $"UPDATE `user_data` SET `username`='{Username}',`passwords`='{savedPasswords}',`notes`='{EFunctions.Encrypt(" ", ekey)}' WHERE `username`='{Username}'";
                    sql.Send(commandLine);

                    // Sending notification that notes were deleted
                    Notificator notify = new Notificator();
                    notify.Type = "info";
                    notify.Description = "Your Notes were deleted!\nThis action is irreversible!";
                    notify.Show();
                }
            }
        }

        // Function that erases passwords
        private void ErasePasswords()
        {
            // If passwords are stored locally
            if (Convert.ToInt32(Settings.Default["SaveType"]) == 0)
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
                // If directory exists
                if (Directory.Exists(path))
                {
                    if (File.Exists(path + "/pass.json")) // If passwords exist
                    {
                        // Deleting passwords in the directory
                        File.Delete(path + "/pass.json");

                        // Sending notification that passwords were deleted
                        Notificator notify = new Notificator();
                        notify.Type = "info";
                        notify.Description = "Your Passwords were deleted!\nThis action is irreversible!";
                        notify.Show();
                    }
                    else
                    {
                        // Sending notification that there are no passwords in the account
                        Notificator notify = new Notificator();
                        notify.Type = "error";
                        notify.Description = "There are no passwords in the chosen account!";
                        notify.Show();
                    }
                }
                else
                {
                    // Sending notification that there are no passwords in the account
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "There are no passwords in the chosen account!";
                    notify.Show();
                }
            }
            else // If passwords are stored in the Database
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();

                // Checking existing data in the Database
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                // If there is no data in the db
                if (userData.UserName == null)
                {
                    // Sending notification that there are no passwords for the account
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "There are no passwords in the chosen account!";
                    notify.Show();
                }
                else
                {
                    string savedNotes = userData.Notes;

                    // Updating data in the databaase (erasing it)
                    string commandLine = $"UPDATE `user_data` SET `username`='{Username}',`passwords`='{EFunctions.Encrypt("[]", ekey)}',`notes`='{savedNotes}' WHERE `username`='{Username}'";
                    sql.Send(commandLine);

                    // Sending notification that passwords were deleted
                    Notificator notify = new Notificator();
                    notify.Type = "info";
                    notify.Description = "Your Passwords were deleted!\nThis action is irreversible!";
                    notify.Show();
                }
            }
        }
    }
}
