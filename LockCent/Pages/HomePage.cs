using LockCent.Encryption;
using LockCent.Properties;
using LockCent.Scripts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class HomePage : Form
    {
        // Username variable from other Forms
        public string username { get; set; }

        //Ekey variable from other forms
        public byte[] ekey { get; set; }

        private readonly int stringLength = 25;

        // Local list of Passwords
        private List<Passwords> passwords { get; set; }

        // Timer
        private int timerCounter;
        private int timerType;

        public HomePage()
        {
            InitializeComponent();
        }

        // When Form loads
        private void HomePage_Load(object sender, EventArgs e)
        {
            // Checking where user stores data
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If data is stored locally
            if (saveType == 0)
            {
                string jsonfile = "[]";
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";

                // If pass file exists
                if (!File.Exists(path + "/pass.json"))
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    StreamWriter sw = new StreamWriter(path + "/pass.json");
                    sw.Write(EFunctions.Encrypt(jsonfile, ekey));
                    sw.Close();
                }
                jsonfile = "";

                // Reading a json file
                StreamReader sr = new StreamReader(path + "/pass.json");
                while (!sr.EndOfStream)
                {
                    jsonfile = jsonfile + sr.ReadLine();
                }
                sr.Close();

                // Converting result into a Password List<>
                passwords = JsonConvert.DeserializeObject<List<Passwords>>(EFunctions.Decrypt(jsonfile, ekey));
            }
            else // If data is stored in the DB
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();

                // Checking existing data in the DB
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                string jsonfile;
                // If data doesn't exist
                if (userData.UserName == null)
                {
                    jsonfile = "[]";

                    passwords = JsonConvert.DeserializeObject<List<Passwords>>(jsonfile);
                }
                else // If data exists
                {
                    // Storing Passwords data locally
                    jsonfile = userData.Passwords;

                    // Converting data from text to List<>
                    passwords = JsonConvert.DeserializeObject<List<Passwords>>(EFunctions.Decrypt(jsonfile, ekey));
                }
            }
        }

        // Function that validates text
        private bool TextChecker(string text)
        {
            // If text is empty
            if (text.Length == 0)
            {
                // Text was not validated
                return false;
            }

            // For each symbol in text
            foreach (char s in text)
            {
                // If it doen not meet the criteria
                if ((s < '0' && s != ',' && s != '.') || (s > '9' && s < 'A') || (s > 'Z' && s != '_' && s < 'a') || (s > 'z'))
                {
                    // Text is not validated
                    return false;
                }
            }

            // Text is validated
            return true;
        }

        // function to save passwords
        private void PasswordSaver()
        {
            // Checking storage saving type
            int saveType = Convert.ToInt32(Settings.Default["SaveType"]);

            // If data is stored locally
            if (saveType == 0)
            {
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/LockCent/{username}";
                
                // If File exists
                if (File.Exists(path + "/pass.json"))
                {
                    // Create empty json
                    string jsonFile = "";

                    // Fill Json with data
                    jsonFile = JsonConvert.SerializeObject(passwords);

                    // Delete existing password file
                    File.Delete(path + "/pass.json");

                    // Create a new password file with new encrypted data
                    StreamWriter sw = new StreamWriter(path + "/pass.json");
                    sw.WriteLine(EFunctions.Encrypt(jsonFile, ekey));
                    sw.Close();
                }
                else // If file does not exist
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    // Creating empty Json
                    string jsonFile = "";

                    // Filling Json with data
                    jsonFile = JsonConvert.SerializeObject(passwords);

                    // Saving encrypted Json to local storage
                    StreamWriter sw = new StreamWriter(path + "/pass.json");
                    sw.Write(EFunctions.Encrypt(jsonFile, ekey));
                    sw.Close();
                }
            }
            else // If data is stored in the DB
            {
                LCMySQL sql = new LCMySQL();
                UserData userData = new UserData();

                // Checking existing data in the DB
                userData = sql.DataGet($"SELECT * FROM `user_data` WHERE `username`='{username}'");

                // creating a Json full of encrypted data
                string jsonFile = EFunctions.Encrypt(JsonConvert.SerializeObject(passwords), ekey);

                // If data exists in the database
                if (userData.UserName != null)
                {
                    // Updating existing data set
                    string commandLine = $"UPDATE `user_data` SET `username`='{username}',`passwords`='{jsonFile}',`notes`='{userData.Notes}' WHERE `username`='{username}'";
                    sql.Send(commandLine);
                }
                else // If data does not exist in the DB
                {
                    // Creating new data with new passwords
                    string commandLine = $"INSERT INTO `user_data`(`username`, `passwords`, `notes`) VALUES ('{username}','{jsonFile}','{EFunctions.Encrypt(" ", ekey)}')";
                    sql.Send(commandLine);
                }
            }
        }

        // When user clicks on Create Password button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Anti double-click
            btnCreate.Enabled = false;

            if (TextChecker(txtCreateName.Text) && TextChecker(txtCreateValue.Text))
            {
                // Creating a new instance of password
                Passwords tempPass = new Passwords();

                // filling password with data
                tempPass.Name = txtCreateName.Text;
                tempPass.Password = txtCreateValue.Text;

                bool isPasswordExist = false;

                // For each password in the list of passwords
                foreach (Passwords pass in passwords)
                {
                    // If name or value matches
                    if (pass.Name.ToLower() == txtCreateName.Text.ToLower())
                    {
                        // Password exists
                        isPasswordExist = true;
                    }
                }

                // If password is already present
                if (isPasswordExist || passwords.Contains(tempPass))
                {
                    // Notifying user about their mistake
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "The password you typed already exists!";
                    notify.Show();
                }
                else // If there is no such password
                {
                    // Add a new password
                    passwords.Add(tempPass);

                    // Save data
                    PasswordSaver();

                    txtCreateName.Text = "";
                    txtCreateName.PlaceholderText = "Password was successfully created";
                    txtCreateValue.Text = "";
                    txtCreateValue.PlaceholderText = "";

                    // Start norification timer
                    timerCounter = 3;
                    timerType = 1;
                    txtCreateName.Enabled = false;
                    txtCreateValue.Enabled = false;
                    btnCreate.Enabled = false;
                    btnCreate.Visible = false;
                    timerNotify.Start();
                }
            }
            else // If text does not meet the criteria
            {
                // Notify the user of their mistake
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "The fields have incorrect symbols or length";
                notify.Show();
            }

            btnCreate.Enabled = true;
        }

        // When user clicks on Delete Password button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Anti double-click
            btnDelete.Enabled = false;

            // Creating a new instance of password
            Passwords tempPass = new Passwords();

            if (TextChecker(txtDelName.Text))
            {
                bool isPasswordExist = false;

                foreach (Passwords pass in passwords)
                {
                    // If name matches
                    if (pass.Name.ToLower() == txtDelName.Text.ToLower())
                    {
                        // Password exists
                        isPasswordExist = true;

                        // Make a copy of it
                        tempPass = pass;
                    }
                }

                // If password exists
                if (isPasswordExist)
                {
                    // Remove found password
                    passwords.Remove(tempPass);

                    // Save data
                    PasswordSaver();

                    txtDelName.Text = "";
                    txtDelName.PlaceholderText = "Password was successfully deleted";

                    // Start norification timer
                    timerCounter = 3;
                    timerType = 2;
                    txtDelName.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDelete.Visible = false;
                    timerNotify.Start();
                }
                else // If password does not exist
                {
                    // Notify the user of their mistake
                    Notificator notify = new Notificator();
                    notify.Type = "error";
                    notify.Description = "The pasword does not exist!\n(maybe name was typed incorrectly)";
                    notify.Show();
                }
            }
            else // If text does not meet the criteria
            {
                // Notify the user of their mistake
                Notificator notify = new Notificator();
                notify.Type = "error";
                notify.Description = "The fields have incorrect symbols or length";
                notify.Show();
            }

            btnDelete.Enabled = true;
        }

        private void txtCreateName_TextChanged(object sender, EventArgs e)
        {
            // If text in Name is longer than constant
            if (txtCreateName.Text.Length > stringLength)
            {
                // Delete last symbol(s)
                txtCreateName.Text = txtCreateName.Text.Substring(0, stringLength);
            }
        }

        private void txtCreateValue_TextChanged(object sender, EventArgs e)
        {
            // If text in Value is longer than constant
            if (txtCreateValue.Text.Length > stringLength)
            {
                // Delete last symbol(s)
                txtCreateValue.Text = txtCreateValue.Text.Substring(0, stringLength);
            }
        }

        private void txtDelName_TextChanged(object sender, EventArgs e)
        {
            // If text in Del Pass Name is longer than constant
            if (txtDelName.Text.Length > stringLength)
            {
                // Delete last symbol(s)
                txtDelName.Text = txtDelName.Text.Substring(0, stringLength);
            }
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            timerCounter = timerCounter - 1;

            if (timerCounter == 0)
            {
                if (timerType == 1)
                {
                    txtCreateName.PlaceholderText = "Website";
                    txtCreateValue.PlaceholderText = "Data (username, password and etc)";
                    txtCreateName.Enabled = true;
                    txtCreateValue.Enabled = true;

                    btnCreate.Enabled = true;
                    btnCreate.Visible = true;
                }
                else
                {
                    txtDelName.PlaceholderText = "Website";
                    txtDelName.Enabled = true;

                    btnDelete.Enabled = true;
                    btnDelete.Visible = true;
                }
            }
        }
    }
}
