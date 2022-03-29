namespace LockCent.Pages
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.elpsPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblDeltePass = new System.Windows.Forms.Label();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.txtCreateValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCreateName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDelPass = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtDelName = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerNotify = new System.Windows.Forms.Timer(this.components);
            this.pnlNewPass.SuspendLayout();
            this.pnlDelPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // elpsPage
            // 
            this.elpsPage.BorderRadius = 20;
            this.elpsPage.TargetControl = this;
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.White;
            this.lblNewPass.Location = new System.Drawing.Point(12, 11);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(196, 25);
            this.lblNewPass.TabIndex = 0;
            this.lblNewPass.Text = "Create New Password";
            // 
            // lblDeltePass
            // 
            this.lblDeltePass.AutoSize = true;
            this.lblDeltePass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeltePass.ForeColor = System.Drawing.Color.White;
            this.lblDeltePass.Location = new System.Drawing.Point(12, 12);
            this.lblDeltePass.Name = "lblDeltePass";
            this.lblDeltePass.Size = new System.Drawing.Size(224, 25);
            this.lblDeltePass.TabIndex = 0;
            this.lblDeltePass.Text = "Delete Existing Password";
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Controls.Add(this.btnCreate);
            this.pnlNewPass.Controls.Add(this.txtCreateValue);
            this.pnlNewPass.Controls.Add(this.txtCreateName);
            this.pnlNewPass.Controls.Add(this.lblNewPass);
            this.pnlNewPass.Location = new System.Drawing.Point(120, 12);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(485, 215);
            this.pnlNewPass.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.BorderColor = System.Drawing.Color.White;
            this.btnCreate.BorderRadius = 6;
            this.btnCreate.BorderThickness = 2;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(17, 159);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(452, 45);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateValue
            // 
            this.txtCreateValue.BorderRadius = 6;
            this.txtCreateValue.BorderThickness = 2;
            this.txtCreateValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateValue.DefaultText = "";
            this.txtCreateValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreateValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreateValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateValue.DisabledState.Parent = this.txtCreateValue;
            this.txtCreateValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCreateValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateValue.FocusedState.Parent = this.txtCreateValue;
            this.txtCreateValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateValue.ForeColor = System.Drawing.Color.White;
            this.txtCreateValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateValue.HoverState.Parent = this.txtCreateValue;
            this.txtCreateValue.Location = new System.Drawing.Point(16, 100);
            this.txtCreateValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreateValue.Name = "txtCreateValue";
            this.txtCreateValue.PasswordChar = '\0';
            this.txtCreateValue.PlaceholderText = "Data (username, password and etc)";
            this.txtCreateValue.SelectedText = "";
            this.txtCreateValue.ShadowDecoration.Parent = this.txtCreateValue;
            this.txtCreateValue.Size = new System.Drawing.Size(453, 44);
            this.txtCreateValue.TabIndex = 2;
            this.txtCreateValue.TextChanged += new System.EventHandler(this.txtCreateValue_TextChanged);
            // 
            // txtCreateName
            // 
            this.txtCreateName.BorderRadius = 6;
            this.txtCreateName.BorderThickness = 2;
            this.txtCreateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCreateName.DefaultText = "";
            this.txtCreateName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCreateName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCreateName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateName.DisabledState.Parent = this.txtCreateName;
            this.txtCreateName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCreateName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCreateName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateName.FocusedState.Parent = this.txtCreateName;
            this.txtCreateName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateName.ForeColor = System.Drawing.Color.White;
            this.txtCreateName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCreateName.HoverState.Parent = this.txtCreateName;
            this.txtCreateName.Location = new System.Drawing.Point(16, 44);
            this.txtCreateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.PasswordChar = '\0';
            this.txtCreateName.PlaceholderText = "Website";
            this.txtCreateName.SelectedText = "";
            this.txtCreateName.ShadowDecoration.Parent = this.txtCreateName;
            this.txtCreateName.Size = new System.Drawing.Size(453, 44);
            this.txtCreateName.TabIndex = 1;
            this.txtCreateName.TextChanged += new System.EventHandler(this.txtCreateName_TextChanged);
            // 
            // pnlDelPass
            // 
            this.pnlDelPass.Controls.Add(this.btnDelete);
            this.pnlDelPass.Controls.Add(this.txtDelName);
            this.pnlDelPass.Controls.Add(this.lblDeltePass);
            this.pnlDelPass.Location = new System.Drawing.Point(120, 247);
            this.pnlDelPass.Name = "pnlDelPass";
            this.pnlDelPass.Size = new System.Drawing.Size(485, 184);
            this.pnlDelPass.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.BorderThickness = 2;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(16, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(452, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelName
            // 
            this.txtDelName.BorderRadius = 6;
            this.txtDelName.BorderThickness = 2;
            this.txtDelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDelName.DefaultText = "";
            this.txtDelName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDelName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDelName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelName.DisabledState.Parent = this.txtDelName;
            this.txtDelName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDelName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelName.FocusedState.Parent = this.txtDelName;
            this.txtDelName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelName.ForeColor = System.Drawing.Color.White;
            this.txtDelName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelName.HoverState.Parent = this.txtDelName;
            this.txtDelName.Location = new System.Drawing.Point(16, 56);
            this.txtDelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.PasswordChar = '\0';
            this.txtDelName.PlaceholderText = "Website";
            this.txtDelName.SelectedText = "";
            this.txtDelName.ShadowDecoration.Parent = this.txtDelName;
            this.txtDelName.Size = new System.Drawing.Size(453, 44);
            this.txtDelName.TabIndex = 4;
            this.txtDelName.TextChanged += new System.EventHandler(this.txtDelName_TextChanged);
            // 
            // timerNotify
            // 
            this.timerNotify.Interval = 1000;
            this.timerNotify.Tick += new System.EventHandler(this.timerNotify_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(730, 469);
            this.Controls.Add(this.pnlDelPass);
            this.Controls.Add(this.pnlNewPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.pnlDelPass.ResumeLayout(false);
            this.pnlDelPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elpsPage;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblDeltePass;
        private System.Windows.Forms.Panel pnlDelPass;
        private System.Windows.Forms.Panel pnlNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtDelName;
        private Guna.UI2.WinForms.Guna2TextBox txtCreateName;
        private Guna.UI2.WinForms.Guna2TextBox txtCreateValue;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Timer timerNotify;
    }
}