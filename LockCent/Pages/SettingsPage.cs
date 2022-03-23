using System;
using System.IO;
using System.Windows.Forms;

using LockCent.Properties;
using LockCent.Encryption;
using LockCent.Scripts;

namespace LockCent.Pages
{
    public partial class SettingsPage : Form
    {
        public string Username { private get; set; }
        public byte[] ekey { private get; set; }
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void RestoreSettings()
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

        private void SettingChanged(string setting)
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
                default:

                    break;
            }
        }

        private void btnLocal_CheckedChanged(object sender, EventArgs e)
        {
            btnDB.Enabled = false;
            btnLocal.Enabled = false;

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (btnLocal.Checked)
            {
                if (Convert.ToInt32(Settings.Default["SaveType"]) != 0)
                {
                    Settings.Default["SaveType"] = 0;
                    Settings.Default.Save();

                    SettingChanged("local");

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    LCMySQL sql = new LCMySQL();
                    UserData userData = new UserData();

                    userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                    if (userData.UserName != null)
                    {
                        StreamWriter sw1 = new StreamWriter(path + "/pass.json");
                        sw1.Write(userData.Passwords);
                        sw1.Close();

                        StreamWriter sw2 = new StreamWriter(path + "/notes.txt");
                        sw2.WriteLine(userData.Notes);
                        sw2.Close();

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

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (btnDB.Checked)
            {
                if (Convert.ToInt32(Settings.Default["SaveType"]) != 1)
                {
                    Settings.Default["SaveType"] = 1;
                    Settings.Default.Save();

                    SettingChanged("sql");

                    if (Directory.Exists(path))
                    {
                        bool notesE = File.Exists(path + "/notes.txt");
                        bool passE = File.Exists(path + "/pass.json");

                        if (notesE || passE)
                        {
                            string fileNotes = "";
                            string filePass = "";

                            if (notesE)
                            {
                                StreamReader sr = new StreamReader(path + "/notes.txt");

                                while (!sr.EndOfStream)
                                {
                                    fileNotes += sr.ReadLine();
                                }

                                sr.Close();
                            }

                            if (passE)
                            {
                                StreamReader sr1 = new StreamReader(path + "/pass.json");

                                while (!sr1.EndOfStream)
                                {
                                    filePass += sr1.ReadLine();
                                }

                                sr1.Close();
                            }

                            if (fileNotes == "")
                            {
                                fileNotes = EFunctions.Encrypt(" ", ekey);
                            }

                            if (filePass == "")
                            {
                                filePass = EFunctions.Encrypt("[]", ekey);
                            }

                            LCMySQL sql = new LCMySQL();
                            UserData userData = new UserData();

                            userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                            if (userData.UserName == null)
                            {
                                string commandLine = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{Username}','{filePass}','{fileNotes}')";
                                sql.Send(commandLine);
                            }
                            else
                            {
                                string commandLine = $"UPDATE `user_data` SET `username`='{Username}',`passwords`='{filePass}',`notes`='{fileNotes}' WHERE `username`='{Username}'";
                                sql.Send(commandLine);
                            }
                        }

                        File.Delete(path + "/pass.json");
                        File.Delete(path + "/notes.txt");

                        Directory.Delete(path);
                    }
                    else
                    {
                        LCMySQL sql = new LCMySQL();
                        UserData userData = new UserData();

                        userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`= '{Username}'");

                        if (userData.UserName == null)
                        {
                            string command = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{Username}','{EFunctions.Encrypt("[]", ekey)}','{EFunctions.Encrypt(" ", ekey)}')";
                            sql.Send(command);
                        }
                    }
                }
            }

            btnDB.Enabled = true;
            btnLocal.Enabled = true;
        }

        private void cbNotes_CheckedChanged(object sender, EventArgs e)
        {
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

        private void btnErasePass_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (Directory.Exists(path))
            {
                File.Delete(path + "/pass.json");
                Notificator notify = new Notificator();
                notify.Type = "info";
                notify.Description = "Your Passwords were deleted!\nThis action is irreversible!";
                notify.Show();
            }
            else
            {
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "There are no passwords in the chosen account!";
                notify.Show();
            }
        }

        private void btnEraseNotes_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{Username}";
            if (Directory.Exists(path))
            {
                if (File.Exists(path + "/notes.txt"))
                {
                    File.Delete(path + "/notes.txt");

                    Notificator notify = new Notificator();
                    notify.Type = "info";
                    notify.Description = "Your Notes were deleted!\nThis action is irreversible!";
                    notify.Show();
                }
                else
                {
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "There are no notes in the chosen account!";
                    notify.Show();
                }
                
            }
            else
            {
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "There are no notes in the chosen account!";
                notify.Show();
            }
        }

    }
}
