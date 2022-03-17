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
            this.pnlDelPass = new System.Windows.Forms.Panel();
            this.txtDelName = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlNewPass.Controls.Add(this.lblNewPass);
            this.pnlNewPass.Location = new System.Drawing.Point(28, 12);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(485, 200);
            this.pnlNewPass.TabIndex = 1;
            // 
            // pnlDelPass
            // 
            this.pnlDelPass.Controls.Add(this.txtDelName);
            this.pnlDelPass.Controls.Add(this.lblDeltePass);
            this.pnlDelPass.Location = new System.Drawing.Point(28, 231);
            this.pnlDelPass.Name = "pnlDelPass";
            this.pnlDelPass.Size = new System.Drawing.Size(485, 200);
            this.pnlDelPass.TabIndex = 2;
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
            this.txtDelName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDelName.HoverState.Parent = this.txtDelName;
            this.txtDelName.Location = new System.Drawing.Point(17, 70);
            this.txtDelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDelName.Name = "txtDelName";
            this.txtDelName.PasswordChar = '\0';
            this.txtDelName.PlaceholderText = "";
            this.txtDelName.SelectedText = "";
            this.txtDelName.ShadowDecoration.Parent = this.txtDelName;
            this.txtDelName.Size = new System.Drawing.Size(453, 44);
            this.txtDelName.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(620, 450);
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
    }
}