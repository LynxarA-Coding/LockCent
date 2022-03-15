namespace LockCent.Pages
{
    partial class Notificator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificator));
            this.txtHeader = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtMain = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.elpsButton = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlNotify = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.dragPanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlNotify.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHeader
            // 
            this.txtHeader.AutoSize = true;
            this.txtHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeader.ForeColor = System.Drawing.Color.White;
            this.txtHeader.Location = new System.Drawing.Point(11, 14);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(46, 21);
            this.txtHeader.TabIndex = 1;
            this.txtHeader.Text = "Error";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(362, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMain
            // 
            this.txtMain.AutoSize = true;
            this.txtMain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.ForeColor = System.Drawing.Color.White;
            this.txtMain.Location = new System.Drawing.Point(11, 67);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(96, 21);
            this.txtMain.TabIndex = 1;
            this.txtMain.Text = "Placeholder";
            // 
            // btnOK
            // 
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(109, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(180, 45);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // elpsButton
            // 
            this.elpsButton.BorderRadius = 10;
            this.elpsButton.TargetControl = this.btnOK;
            // 
            // pnlNotify
            // 
            this.pnlNotify.BorderColor = System.Drawing.Color.White;
            this.pnlNotify.BorderRadius = 18;
            this.pnlNotify.BorderThickness = 2;
            this.pnlNotify.Controls.Add(this.pnlHeader);
            this.pnlNotify.Controls.Add(this.txtMain);
            this.pnlNotify.Controls.Add(this.btnOK);
            this.pnlNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotify.Location = new System.Drawing.Point(0, 0);
            this.pnlNotify.Name = "pnlNotify";
            this.pnlNotify.ShadowDecoration.Parent = this.pnlNotify;
            this.pnlNotify.Size = new System.Drawing.Size(404, 208);
            this.pnlNotify.TabIndex = 3;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.BorderColor = System.Drawing.Color.White;
            this.pnlHeader.BorderRadius = 18;
            this.pnlHeader.BorderThickness = 2;
            this.pnlHeader.Controls.Add(this.txtHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(404, 51);
            this.pnlHeader.TabIndex = 3;
            // 
            // dragPanel
            // 
            this.dragPanel.TargetControl = this.pnlHeader;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Notificator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(404, 208);
            this.Controls.Add(this.pnlNotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notificator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificator";
            this.Load += new System.EventHandler(this.Notificator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlNotify.ResumeLayout(false);
            this.pnlNotify.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label txtMain;
        private System.Windows.Forms.Label txtHeader;
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private Guna.UI2.WinForms.Guna2Elipse elpsButton;
        private Guna.UI2.WinForms.Guna2Panel pnlNotify;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl dragPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}