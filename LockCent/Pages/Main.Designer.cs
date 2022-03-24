namespace LockCent.Pages
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDrag = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblLogged = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPasswords = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.btnNotes = new System.Windows.Forms.PictureBox();
            this.btnPasswords = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.elpsPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 25;
            this.elpsMain.TargetControl = this;
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrag.Controls.Add(this.lblHeader);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Controls.Add(this.lblLogged);
            this.pnlDrag.Controls.Add(this.lblUsername);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.ShadowDecoration.Parent = this.pnlDrag;
            this.pnlDrag.Size = new System.Drawing.Size(730, 40);
            this.pnlDrag.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(12, 1);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(97, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "LockCent";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(691, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogged.ForeColor = System.Drawing.Color.White;
            this.lblLogged.Location = new System.Drawing.Point(13, 23);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(67, 15);
            this.lblLogged.TabIndex = 1;
            this.lblLogged.Text = "Logged As:";
            this.lblLogged.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(79, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "PlaceholderUsername";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.lblNotes);
            this.pnlMenu.Controls.Add(this.lblPasswords);
            this.pnlMenu.Controls.Add(this.lblHome);
            this.pnlMenu.Controls.Add(this.lblSettings);
            this.pnlMenu.Controls.Add(this.lblLogOut);
            this.pnlMenu.Controls.Add(this.btnNotes);
            this.pnlMenu.Controls.Add(this.btnPasswords);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(91, 472);
            this.pnlMenu.TabIndex = 3;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(21, 210);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 20);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.lblPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswords.ForeColor = System.Drawing.Color.White;
            this.lblPasswords.Location = new System.Drawing.Point(7, 137);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(79, 20);
            this.lblPasswords.TabIndex = 1;
            this.lblPasswords.Text = "Passwords";
            this.lblPasswords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(22, 64);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(50, 20);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(14, 283);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(63, 20);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(15, 446);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(63, 20);
            this.lblLogOut.TabIndex = 1;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNotes
            // 
            this.btnNotes.Image = ((System.Drawing.Image)(resources.GetObject("btnNotes.Image")));
            this.btnNotes.Location = new System.Drawing.Point(26, 167);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(40, 40);
            this.btnNotes.TabIndex = 0;
            this.btnNotes.TabStop = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnPasswords
            // 
            this.btnPasswords.Image = ((System.Drawing.Image)(resources.GetObject("btnPasswords.Image")));
            this.btnPasswords.Location = new System.Drawing.Point(26, 94);
            this.btnPasswords.Name = "btnPasswords";
            this.btnPasswords.Size = new System.Drawing.Size(40, 40);
            this.btnPasswords.TabIndex = 0;
            this.btnPasswords.TabStop = false;
            this.btnPasswords.Click += new System.EventHandler(this.btnPasswords_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(27, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(25, 240);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(27, 403);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(40, 40);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlPage.Location = new System.Drawing.Point(98, 48);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(628, 459);
            this.pnlPage.TabIndex = 4;
            // 
            // elpsPage
            // 
            this.elpsPage.BorderRadius = 20;
            this.elpsPage.TargetControl = this.pnlPage;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlDrag;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDrag);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockCent | Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private Guna.UI2.WinForms.Guna2Panel pnlDrag;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.Panel pnlPage;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label lblPasswords;
        private System.Windows.Forms.PictureBox btnPasswords;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.PictureBox btnNotes;
        private Guna.UI2.WinForms.Guna2Elipse elpsPage;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}