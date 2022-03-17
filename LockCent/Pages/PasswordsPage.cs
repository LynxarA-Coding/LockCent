using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockCent.Pages
{
    public partial class PasswordsPage : Form
    {
        public string[] GivenPassNames { get; set; }

        public string[] GivenPassValues { get; set; }

        private List<string> PassName = new List<string>();
        private List<string> PassValue = new List<string>();

        private int PageNum = 0;
        private int PageTotal;

        private string[] BNames = new string[4] { "", "", "", "" };

        private string[] BValues = new string[4] {"", "", "" , ""};
        public PasswordsPage()
        {
            InitializeComponent();
        }

        private void UpdateButtonVisual()
        {
            btnFirstPass.Text = BNames[0];
            btnSecondPass.Text = BNames[1];
            btnThirdPass.Text = BNames[2];
            btnFourthPass.Text = BNames[3];

            if (PageNum < PageTotal - 1)
            {
                btnNextPage.Text = $"Page {PageNum + 1} >";
                btnNextPage.Enabled = true;
                btnNextPage.Visible = true;
            }
            else
            {
                btnNextPage.Text = "No Page Further";
                btnNextPage.Enabled = false;
                btnNextPage.Visible = false;
            }
            
            if (PageNum > 0)
            {
                btnPreviousPage.Text = $"< Page {PageNum - 1}";
                btnPreviousPage.Enabled = true;
                btnPreviousPage.Visible = true;
            }
            else
            {
                btnPreviousPage.Text = "No Page Back";
                btnPreviousPage.Enabled = false;
                btnPreviousPage.Visible = false;
            }
        }

        private void PageChanged(int page)
        {
            BNames[0] = PassName[page * 4];
            BValues[0] = PassValue[page * 4];

            BNames[1] = PassName[page * 4 + 1];
            BValues[1] = PassValue[page * 4 + 1];

            BNames[2] = PassName[page * 4 + 2];
            BValues[2] = PassValue[page * 4 + 2];

            BNames[3] = PassName[page * 4 + 3];
            BValues[3] = PassValue[page * 4 + 3];

            UpdateButtonVisual();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (PageNum < PageTotal - 1)
            {
                PageNum++;
                PageChanged(PageNum);
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (PageNum > 0)
            {
                PageNum--;
                PageChanged(PageNum);
            }
        }

        private void PasswordsPage_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < GivenPassNames.Length; i++)
            {
                PassName.Add(GivenPassNames[i]);
                PassValue.Add(GivenPassValues[i]);
            }

            PageTotal = GivenPassNames.Length / 4;

            if (GivenPassNames.Length % 4 > 0)
            {
                PageTotal++;

                for (int i = 0; i < 4 - GivenPassNames.Length % 4; i++)
                {
                    PassName.Add("NO PASS");
                    PassValue.Add("NO PASS");
                }
            }

            PageNum = 0;
            PageChanged(0);
        }

        private void btnFirstPass_Click(object sender, EventArgs e)
        {
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[0]} password is: \n{BValues[0]}";
            notify.Show();
        }

        private void btnSecondPass_Click(object sender, EventArgs e)
        {
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[1]} password is: \n{BValues[1]}";
            notify.Show();
        }

        private void btnThirdPass_Click(object sender, EventArgs e)
        {
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[2]} password is: \n{BValues[2]}";
            notify.Show();
        }

        private void btnFourthPass_Click(object sender, EventArgs e)
        {
            Notificator notify = new Notificator();
            notify.Type = "info";
            notify.Description = $"{BNames[3]} password is: \n{BValues[3]}";
            notify.Show();
        }
    }
}
