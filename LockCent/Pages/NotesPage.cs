using System;
using System.IO;
using LockCent.Properties;
using LockCent.Encryption;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class NotesPage : Form
    {

        public string ekey { get; set; }
        public NotesPage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string eresult = EFunctions.Encrypt(txtNotes.Text, ekey);

            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent";
            File.Delete(path + "/notes.txt");

            StreamWriter sw = new StreamWriter(path + "/notes.txt");
            sw.WriteLine(eresult);
            sw.Close();
        }

        private void NotesPage_Load(object sender, EventArgs e)
        {
            bool notesSettings = Convert.ToBoolean(Settings.Default["Notes"]);

            if (notesSettings)
            {
                txtNotes.PlaceholderText = "Start to write your text here. Don't forget to Save!";

                btnSave.Enabled = true;
                txtNotes.ReadOnly = false;
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
