using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace LockCent.Pages
{
    /*
     LockCent @2022
     by LynxarA
    */
    public partial class PasswordsPage : Form
    {
        // Passed Password Names from other Form
        public string[] GivenPassNames { get; set; }

        // Passed Password Values from other Form
        public string[] GivenPassValues { get; set; }

        string json = "[";

        // Local variables for Lists of Passwords' names and values
        private List<string> PassName = new List<string>();
        private List<string> PassValue = new List<string>();

        // Current page number
        private int PageNum = 0;

        // Total page amount
        private int PageTotal;

        /*
         Current Page Variables:
        */

        // Button Names for a page
        private string[] BNames = { "", "", "", "" };

        // Button Values for a page
        private string[] BValues = {"", "", "" , ""};

        public PasswordsPage()
        {
            InitializeComponent();
        }

        // When form is loaded
        private void PasswordsPage_Load(object sender, EventArgs e)
        {
            // If there are any passwords
            if (GivenPassNames.Length > 0 && GivenPassValues.Length > 0)
            {
                // Adding data (names and values of the buttons) to the whole storage
                for (int i = 0; i < GivenPassNames.Length; i++)
                {
                    PassName.Add(GivenPassNames[i]);
                    PassValue.Add(GivenPassValues[i]);
                }

                // Calculating amount of pages based on data size
                PageTotal = GivenPassNames.Length / 4;

                // If there are extra passwords (password amount is not divisible by 4 without remainder)
                if (GivenPassNames.Length % 4 > 0)
                {
                    // Add extra page because it was not added to the Page Amount due to a formula
                    PageTotal++;

                    // Changing names for non-existing passwords on the page (when there are less than 4 on the last page)
                    for (int i = 0; i < 4 - (GivenPassNames.Length % 4); i++)
                    {
                        PassName.Add("NO PASS");
                        PassValue.Add("NO PASS");
                    }
                }

                // Setting choice to the first page
                PageNum = 0;
                PageChanged(0);
            }
            else // If there are no passwords
            {
                // Changing amount of pages to 0 (1 page with no passwords)
                PageTotal = 1;

                // Adding 4 empty passwords
                for (int i = 0; i < 4; i++)
                {
                    PassName.Add("NO PASS");
                    PassValue.Add("NO PASS");
                }

                // Setting choice to the first page
                PageNum = 0;
                PageChanged(0);
            }
        }

        // Function that updates How Buttons look and what data they contain
        private void UpdateButtonVisual()
        {
            // Changing Button Text based on data of the page
            btnFirstPass.Text = BNames[0];
            btnSecondPass.Text = BNames[1];
            btnThirdPass.Text = BNames[2];
            btnFourthPass.Text = BNames[3];

            // If page is not last
            if (PageNum < PageTotal - 1)
            {
                // Changing next page button text
                btnNextPage.Text = $"Page {PageNum + 1} >";
                
                // Changing Next Button visibility to true
                btnNextPage.Enabled = true;
                btnNextPage.Visible = true;
            }
            else // If page is last
            {
                // Changing next page button text
                btnNextPage.Text = "No Page Further";

                // Changing Next Button Visibility to false
                btnNextPage.Enabled = false;
                btnNextPage.Visible = false;
            }
            
            // If Page is not first
            if (PageNum > 0)
            {
                // Changing previous page button text
                btnPreviousPage.Text = $"< Page {PageNum - 1}";

                // Changing Previous Button Visibility to true
                btnPreviousPage.Enabled = true;
                btnPreviousPage.Visible = true;
            }
            else // If Page is first
            {
                // Changing previous page button text
                btnPreviousPage.Text = "No Page Back";

                // Changing Previous Button Visibility to false
                btnPreviousPage.Enabled = false;
                btnPreviousPage.Visible = false;
            }
        }

        // Function that changes Page data when user changes the page
        private void PageChanged(int page)
        {
            // Putting values for the first button
            BNames[0] = PassName[page * 4];
            BValues[0] = PassValue[page * 4];

            // Putting values for the second button
            BNames[1] = PassName[(page * 4) + 1];
            BValues[1] = PassValue[(page * 4) + 1];

            // Putting values for the third button
            BNames[2] = PassName[(page * 4) + 2];
            BValues[2] = PassValue[(page * 4) + 2];

            // Putting values for the fourth button
            BNames[3] = PassName[(page * 4) + 3];
            BValues[3] = PassValue[(page * 4) + 3];

            // Updating buttons' visuals and data
            UpdateButtonVisual();
        }

        // When Next Page button is clicked
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            // If page is not last
            if (PageNum < PageTotal - 1)
            {
                // Changing page
                PageNum++;
                PageChanged(PageNum);
            }
        }

        // When Previous Page button is clicked
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            // If page is not first
            if (PageNum > 0)
            {
                // Changing page
                PageNum--;
                PageChanged(PageNum);
            }
        }

        // When First Password button is clicked
        private void btnFirstPass_Click(object sender, EventArgs e)
        {
            // Reveal password data to user
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[0]} data is: \n{BValues[0]}";
            notify.Show();
        }

        // When Second Password button is clicked
        private void btnSecondPass_Click(object sender, EventArgs e)
        {
            // Reveal password data to user
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[1]} data is: \n{BValues[1]}";
            notify.Show();
        }

        // When Third Password button is clicked
        private void btnThirdPass_Click(object sender, EventArgs e)
        {
            // Reveal password data to user
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[2]} data is: \n{BValues[2]}";
            notify.Show();
        }

        // When Fourth Password button is clicked
        private void btnFourthPass_Click(object sender, EventArgs e)
        {
            // Reveal password data to user
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[3]} data is: \n{BValues[3]}";
            notify.Show();
        }
    }
}
