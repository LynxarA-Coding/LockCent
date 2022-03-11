using System;
using System.Windows.Forms;

using LockCent.Properties;

namespace LockCent.Pages
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void RestoreSettings()
        {
            int svtype = Convert.ToInt32(Settings.Default["SaveType"]);

            if (svtype == 1)
            {
                FolderSelector.Value = 1;
            }
            else
            {
                FolderSelector.Value = 0;
            }
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void FolderSelector_ValueChanged(object sender, EventArgs e)
        {
            if (FolderSelector.Value == 0)
            {
                Settings.Default["SaveType"] = 0;
                Settings.Default.Save();
            }
            else
            {
                FolderSelector.Value = 0;
                MessageBox.Show("DataBase option is Not Done yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
