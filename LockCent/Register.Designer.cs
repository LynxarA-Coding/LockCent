namespace LockCent
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.pnlDrag = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnVisit = new Guna.UI2.WinForms.Guna2Button();
            this.elpsVisit = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrag.Controls.Add(this.lblTitle);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.ShadowDecoration.Parent = this.pnlDrag;
            this.pnlDrag.Size = new System.Drawing.Size(730, 40);
            this.pnlDrag.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(13, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "REGISTER";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(690, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 25;
            this.elpsMain.TargetControl = this;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(13, 482);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(193, 21);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = "I already have an account";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(607, 483);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(116, 19);
            this.lblCopyright.TabIndex = 13;
            this.lblCopyright.Text = "LockCent @2022";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(153, 189);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(445, 37);
            this.lblText.TabIndex = 14;
            this.lblText.Text = "Create an Account on our WebSite:";
            // 
            // btnVisit
            // 
            this.btnVisit.CheckedState.Parent = this.btnVisit;
            this.btnVisit.CustomImages.Parent = this.btnVisit;
            this.btnVisit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnVisit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.ForeColor = System.Drawing.Color.White;
            this.btnVisit.HoverState.Parent = this.btnVisit;
            this.btnVisit.Location = new System.Drawing.Point(156, 247);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.ShadowDecoration.Parent = this.btnVisit;
            this.btnVisit.Size = new System.Drawing.Size(438, 58);
            this.btnVisit.TabIndex = 15;
            this.btnVisit.Text = "VISIT OUR WEBSITE";
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // elpsVisit
            // 
            this.elpsVisit.BorderRadius = 15;
            this.elpsVisit.TargetControl = this.btnVisit;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlDrag;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(730, 512);
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlDrag);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockCent | Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlDrag;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2Button btnVisit;
        private Guna.UI2.WinForms.Guna2Elipse elpsVisit;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
    }
}