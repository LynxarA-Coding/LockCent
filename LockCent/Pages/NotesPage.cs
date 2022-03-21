using System;
using System.IO;
using LockCent.Scripts;
using LockCent.Properties;
using LockCent.Encryption;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class NotesPage : Form
    {
        public string username { get; set; }
        public byte[] ekey { get; set; }
        public NotesPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eresult = EFunctions.Encrypt(txtNotes.Text, ekey);
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            if (saveType == 1)
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");
                
                if (userData.UserName == null)
                {
                    string commandLine = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{username}','{EFunctions.Encrypt("[]", ekey)}','{EFunctions.Encrypt(txtNotes.Text, ekey)}')";
                    sql.Send(commandLine);
                }
                else
                {
                    string commandLine = $"UPDATE `user_data` SET `username`='{username}',`passwords`='{userData.Passwords}',`notes`='{EFunctions.Encrypt(txtNotes.Text, ekey)}' WHERE `username`='{username}'";
                    sql.Send(commandLine);
                }
            }
            else
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";

                if (!Directory.Exists(path))
                {
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "Wrong user. Use Erase Data or \nLogin to Data Owner account";
                    notify.Show();
                }
                else
                {
                    File.Delete(path + "/notes.txt");

                    StreamWriter sw = new StreamWriter(path + "/notes.txt");
                    sw.WriteLine(eresult);
                    sw.Close();
                }
            }
            
        }

        private void NotesPage_Load(object sender, EventArgs e)
        {
            bool notesSettings = Convert.ToBoolean(Settings.Default["Notes"]);
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            if (notesSettings)
            {
                txtNotes.PlaceholderText = "Start to write your text here. Don't forget to Save!";

                btnSave.Enabled = true;
                txtNotes.ReadOnly = false;

                if (saveType == 1)
                { // MySQL
                    LCMySQL sql = new LCMySQL();
                    UserData data = new UserData();
                    data = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                    if (data.UserName != null)
                    {
                        txtNotes.Text = EFunctions.Decrypt(data.Notes, ekey);
                    }
                }
                else
                { // Raw
                    string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";
                    if (Directory.Exists(path))
                    {
                        path += "/notes.txt";
                        StreamReader sr = new StreamReader(path);

                        string encodedResult = "";
                        while (!sr.EndOfStream)
                        {
                            encodedResult += sr.ReadLine();
                        }
                        sr.Close();

                        txtNotes.Text = EFunctions.Decrypt(encodedResult, ekey);
                    }
                    else
                    {
                        txtNotes.PlaceholderText = "Wrong User. Switch to the user that owns these Notes...\n Or delete Notes File in Settings.";
                    }
                }
                
            }
            else
            {
                txtNotes.PlaceholderText = "Enable Notes function in the Settings Page!";

                btnSave.Enabled = false;
                txtNotes.ReadOnly = true;
            }
        }
    }
}
