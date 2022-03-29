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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDrag = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.lblLogged = new System.Windows.Forms.Label();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblPasswords = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnNotes = new System.Windows.Forms.PictureBox();
            this.btnPasswords = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.pnlPage = new System.Windows.Forms.Panel();
            this.elpsPage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.animMenu1 = new Guna.UI2.WinForms.Guna2Transition();
            this.animMenu2 = new Guna.UI2.WinForms.Guna2Transition();
            this.elpsMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
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
            this.animMenu2.SetDecoration(this.pnlDrag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this.pnlDrag, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.animMenu1.SetDecoration(this.lblHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblHeader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(98, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(97, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "LockCent";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.animMenu2.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this.btnClose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(688, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.animMenu1.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.btnLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogOut.Image = global::LockCent.Properties.Resources.logout_w;
            this.btnLogOut.Location = new System.Drawing.Point(25, 366);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(40, 40);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblLogged, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblLogged, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblLogged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogged.ForeColor = System.Drawing.Color.White;
            this.lblLogged.Location = new System.Drawing.Point(99, 22);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(67, 15);
            this.lblLogged.TabIndex = 1;
            this.lblLogged.Text = "Logged As:";
            this.lblLogged.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblLogOut, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblLogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(14, 412);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(63, 20);
            this.lblLogOut.TabIndex = 1;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblUsername, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(165, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "PlaceholderUsername";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlMenu.Controls.Add(this.btnMenu);
            this.pnlMenu.Controls.Add(this.lblNotes);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.lblLogOut);
            this.pnlMenu.Controls.Add(this.lblPasswords);
            this.pnlMenu.Controls.Add(this.lblHome);
            this.pnlMenu.Controls.Add(this.lblSettings);
            this.pnlMenu.Controls.Add(this.btnNotes);
            this.pnlMenu.Controls.Add(this.btnPasswords);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.animMenu2.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMenu.Location = new System.Drawing.Point(4, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(91, 40);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.animMenu2.SetDecoration(this.btnMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this.btnMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMenu.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Image = global::LockCent.Properties.Resources.menu_w;
            this.btnMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMenu.Location = new System.Drawing.Point(30, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMenu.PressedState.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblNotes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblNotes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(21, 238);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(49, 20);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Notes";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPasswords
            // 
            this.lblPasswords.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblPasswords, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblPasswords, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblPasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswords.ForeColor = System.Drawing.Color.White;
            this.lblPasswords.Location = new System.Drawing.Point(7, 165);
            this.lblPasswords.Name = "lblPasswords";
            this.lblPasswords.Size = new System.Drawing.Size(79, 20);
            this.lblPasswords.TabIndex = 1;
            this.lblPasswords.Text = "Passwords";
            this.lblPasswords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblHome.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.White;
            this.lblHome.Location = new System.Drawing.Point(22, 92);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(50, 20);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.animMenu1.SetDecoration(this.lblSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.lblSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(14, 311);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(63, 20);
            this.lblSettings.TabIndex = 1;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnNotes
            // 
            this.animMenu1.SetDecoration(this.btnNotes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.btnNotes, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnNotes.Image = global::LockCent.Properties.Resources.notes_w;
            this.btnNotes.Location = new System.Drawing.Point(26, 195);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(40, 40);
            this.btnNotes.TabIndex = 0;
            this.btnNotes.TabStop = false;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnPasswords
            // 
            this.animMenu1.SetDecoration(this.btnPasswords, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.btnPasswords, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnPasswords.Image = global::LockCent.Properties.Resources.passwords_w;
            this.btnPasswords.Location = new System.Drawing.Point(26, 122);
            this.btnPasswords.Name = "btnPasswords";
            this.btnPasswords.Size = new System.Drawing.Size(40, 40);
            this.btnPasswords.TabIndex = 0;
            this.btnPasswords.TabStop = false;
            this.btnPasswords.Click += new System.EventHandler(this.btnPasswords_Click);
            // 
            // btnHome
            // 
            this.animMenu1.SetDecoration(this.btnHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.btnHome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHome.Image = global::LockCent.Properties.Resources.home_w;
            this.btnHome.Location = new System.Drawing.Point(27, 49);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.animMenu1.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu2.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.Image = global::LockCent.Properties.Resources.settings_w;
            this.btnSettings.Location = new System.Drawing.Point(25, 268);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pnlPage
            // 
            this.pnlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.animMenu2.SetDecoration(this.pnlPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this.pnlPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlPage.Location = new System.Drawing.Point(0, 43);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(730, 469);
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
            // animMenu1
            // 
            this.animMenu1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.animMenu1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animMenu1.DefaultAnimation = animation2;
            // 
            // animMenu2
            // 
            this.animMenu2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.animMenu2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animMenu2.DefaultAnimation = animation1;
            // 
            // elpsMenu
            // 
            this.elpsMenu.BorderRadius = 10;
            this.elpsMenu.TargetControl = this.pnlMenu;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlPage);
            this.Controls.Add(this.pnlDrag);
            this.animMenu2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.animMenu1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ImageButton btnMenu;
        private Guna.UI2.WinForms.Guna2Transition animMenu1;
        private Guna.UI2.WinForms.Guna2Transition animMenu2;
        private Guna.UI2.WinForms.Guna2Elipse elpsMenu;
    }
}