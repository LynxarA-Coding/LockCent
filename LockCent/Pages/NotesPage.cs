using System;
using System.IO;
using LockCent.Properties;
using LockCent.Encryption;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class NotesPage : Form
    {
        public string username { get; set; }
        public string ekey { get; set; }
        public NotesPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eresult = EFunctions.Encrypt(txtNotes.Text, ekey);

            string settingsUsername = EFunctions.Decrypt(Convert.ToString(Settings.Default["Username"]), "LockCentEncrUsername");

            if (settingsUsername != username)
            {
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "Wrong user. Use Erase Data or \nLogin to Data Owner account";
                notify.Show();
            }
            else
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent";
                File.Delete(path + "/notes.txt");

                StreamWriter sw = new StreamWriter(path + "/notes.txt");
                sw.WriteLine(eresult);
                sw.Close();
            }
        }

        private void NotesPage_Load(object sender, EventArgs e)
        {
            bool notesSettings = Convert.ToBoolean(Settings.Default["Notes"]);

            if (notesSettings)
            {
                txtNotes.PlaceholderText = "Start to write your text here. Don't forget to Save!";

                btnSave.Enabled = true;
                txtNotes.ReadOnly = false;

                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/notes.txt";
                StreamReader sr = new StreamReader(path);

                string encodedResult = "";
                while(!sr.EndOfStream)
                {
                    encodedResult += sr.ReadLine();
                }
                sr.Close();

                if (username == EFunctions.Decrypt(Convert.ToString(Settings.Default["Username"]), "LockCentEncrUsername"))
                {
                    if (encodedResult != "")
                    {
                        txtNotes.Text = EFunctions.Decrypt(encodedResult, ekey);
                    }
                }
                else
                {
                    txtNotes.PlaceholderText = "Wrong User. Switch to the user that owns these Notes...\n Or delete Notes File in Settings.";
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
