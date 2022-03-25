using System;
using System.IO;
using LockCent.Scripts;
using LockCent.Properties;
using LockCent.Encryption;
using System.Windows.Forms;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class NotesPage : Form
    {
        // Username that Form gets from other Forms
        public string username { get; set; }
        // Ekey that Form gets from other Forms
        public byte[] ekey { get; set; }
        public NotesPage()
        {
            InitializeComponent();
        }

        // When Notes Page is loaded
        private void NotesPage_Load(object sender, EventArgs e)
        {
            // Checking if notes are available
            bool notesSettings = Convert.ToBoolean(Settings.Default["Notes"]);
            // Checking where user stores data
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If notes are enabled
            if (notesSettings)
            {
                // Placing default text in the Placeholder
                txtNotes.PlaceholderText = "Start to write your text here. Don't forget to Save!";

                // Anti-DoubleClick
                btnSave.Enabled = true;
                txtNotes.ReadOnly = false;

                // If user stores data in the DB
                if (saveType == 1)
                { 
                    LCMySQL sql = new LCMySQL();
                    UserData data = new UserData();

                    // Checking existing data in the DB
                    data = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                    // If there is any data of this user in the DB
                    if (data.UserName != null)
                    {
                        // Putting data from DB to the Text Box
                        txtNotes.Text = EFunctions.Decrypt(data.Notes, ekey);
                    }
                }
                else // If data is stored locally
                { 
                    string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";

                    // If saving directory exists
                    if (Directory.Exists(path))
                    {
                        path += "/notes.txt";
                        StreamReader sr = new StreamReader(path);

                        string encodedResult = "";

                        // Copying saved data
                        while (!sr.EndOfStream)
                        {
                            encodedResult = encodedResult + sr.ReadLine();
                        }
                        sr.Close();

                        // Putting data from local directory to the Text Box
                        txtNotes.Text = EFunctions.Decrypt(encodedResult, ekey);
                    }
                    else
                    {
                        // No data found, notifying user
                        txtNotes.PlaceholderText = "Wrong User. Switch to the user that owns these Notes...\n Or delete Notes File in Settings.";
                    }
                }
            }
            else // If notes are not enabled
            { 
                // Notifying user
                txtNotes.PlaceholderText = "Enable Notes function in the Settings Page!";

                // Disabling controls of the text
                btnSave.Enabled = false;
                txtNotes.ReadOnly = true;
            }
        }

        // When user clicks "Save" button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Storing encripted text that user is trying to save
            string eresult = EFunctions.Encrypt(txtNotes.Text, ekey);
            // Checking wher user stores notes
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If user stores notes in the DB
            if (saveType == 1)
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();
                
                // Checking existing data in the DB
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");
                
                // If data about user doen't exist
                if (userData.UserName == null)
                {
                    // Creating new data with new notes
                    string commandLine = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{username}','{EFunctions.Encrypt("[]", ekey)}','{eresult}')";
                    sql.Send(commandLine);
                }
                else
                {
                    // Updating existing data with new notes
                    string commandLine = $"UPDATE `user_data` SET `username`='{username}',`passwords`='{userData.Passwords}',`notes`='{eresult}' WHERE `username`='{username}'";
                    sql.Send(commandLine);
                }
            }
            else // If user stores data locally
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";

                // If directory doesn't exist
                if (!Directory.Exists(path))
                {
                    // Notifying user that there are no notes
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "Wrong user. Use Erase Data or \nLogin to Data Owner account";
                    notify.Show();
                }
                else // If directory exists
                {
                    // Deleting previous notes
                    File.Delete(path + "/notes.txt");

                    // Creating new notes file with updated data
                    StreamWriter sw = new StreamWriter(path + "/notes.txt");
                    sw.WriteLine(eresult);
                    sw.Close();
                }
            }
        }
    }
}
