namespace LockCent.Pages
{
    partial class SettingsPage
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
            this.lblDataText = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnDB = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnLocal = new Guna.UI2.WinForms.Guna2RadioButton();
            this.elpsData = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.cbNotes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlErase = new System.Windows.Forms.Panel();
            this.btnErasePass = new Guna.UI2.WinForms.Guna2Button();
            this.btnEraseNotes = new Guna.UI2.WinForms.Guna2Button();
            this.lblErasePasswords = new System.Windows.Forms.Label();
            this.lblEraseNotes = new System.Windows.Forms.Label();
            this.elpsNotes = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsErase = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsErBtnNotes = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsErBtnPass = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timerConfirm = new System.Windows.Forms.Timer(this.components);
            this.pnlData.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.pnlErase.SuspendLayout();
            this.SuspendLayout();
            // 
            // elpsPage
            // 
            this.elpsPage.BorderRadius = 20;
            this.elpsPage.TargetControl = this;
            // 
            // lblDataText
            // 
            this.lblDataText.AutoSize = true;
            this.lblDataText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataText.ForeColor = System.Drawing.Color.White;
            this.lblDataText.Location = new System.Drawing.Point(19, 14);
            this.lblDataText.Name = "lblDataText";
            this.lblDataText.Size = new System.Drawing.Size(152, 21);
            this.lblDataText.TabIndex = 1;
            this.lblDataText.Text = "Data Save Location:";
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlData.Controls.Add(this.btnDB);
            this.pnlData.Controls.Add(this.btnLocal);
            this.pnlData.Controls.Add(this.lblDataText);
            this.pnlData.Location = new System.Drawing.Point(71, 52);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(323, 161);
            this.pnlData.TabIndex = 2;
            // 
            // btnDB
            // 
            this.btnDB.AutoSize = true;
            this.btnDB.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnDB.CheckedState.BorderThickness = 0;
            this.btnDB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDB.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnDB.CheckedState.InnerOffset = -4;
            this.btnDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDB.ForeColor = System.Drawing.Color.White;
            this.btnDB.Location = new System.Drawing.Point(23, 91);
            this.btnDB.Name = "btnDB";
            this.btnDB.Size = new System.Drawing.Size(147, 25);
            this.btnDB.TabIndex = 2;
            this.btnDB.Text = "In the DataBase";
            this.btnDB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnDB.UncheckedState.BorderThickness = 2;
            this.btnDB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnDB.UseVisualStyleBackColor = true;
            this.btnDB.CheckedChanged += new System.EventHandler(this.btnDB_CheckedChanged);
            // 
            // btnLocal
            // 
            this.btnLocal.AutoSize = true;
            this.btnLocal.Checked = true;
            this.btnLocal.CheckedState.BorderColor = System.Drawing.Color.White;
            this.btnLocal.CheckedState.BorderThickness = 0;
            this.btnLocal.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLocal.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnLocal.CheckedState.InnerOffset = -4;
            this.btnLocal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.Location = new System.Drawing.Point(23, 62);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(82, 25);
            this.btnLocal.TabIndex = 1;
            this.btnLocal.TabStop = true;
            this.btnLocal.Text = "Locally";
            this.btnLocal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnLocal.UncheckedState.BorderThickness = 2;
            this.btnLocal.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLocal.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.CheckedChanged += new System.EventHandler(this.btnLocal_CheckedChanged);
            // 
            // elpsData
            // 
            this.elpsData.BorderRadius = 10;
            this.elpsData.TargetControl = this.pnlData;
            // 
            // pnlNotes
            // 
            this.pnlNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlNotes.Controls.Add(this.cbNotes);
            this.pnlNotes.Controls.Add(this.lblNotes);
            this.pnlNotes.Location = new System.Drawing.Point(71, 239);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(323, 161);
            this.pnlNotes.TabIndex = 2;
            // 
            // cbNotes
            // 
            this.cbNotes.AutoSize = true;
            this.cbNotes.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotes.CheckedState.BorderRadius = 2;
            this.cbNotes.CheckedState.BorderThickness = 0;
            this.cbNotes.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNotes.ForeColor = System.Drawing.Color.White;
            this.cbNotes.Location = new System.Drawing.Point(72, 84);
            this.cbNotes.Name = "cbNotes";
            this.cbNotes.Size = new System.Drawing.Size(184, 25);
            this.cbNotes.TabIndex = 2;
            this.cbNotes.Text = "Activate Notes Page?";
            this.cbNotes.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbNotes.UncheckedState.BorderRadius = 2;
            this.cbNotes.UncheckedState.BorderThickness = 0;
            this.cbNotes.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbNotes.UseVisualStyleBackColor = true;
            this.cbNotes.CheckedChanged += new System.EventHandler(this.cbNotes_CheckedChanged);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(106, 47);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(106, 21);
            this.lblNotes.TabIndex = 1;
            this.lblNotes.Text = "Enable Notes";
            // 
            // pnlErase
            // 
            this.pnlErase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlErase.Controls.Add(this.btnErasePass);
            this.pnlErase.Controls.Add(this.btnEraseNotes);
            this.pnlErase.Controls.Add(this.lblErasePasswords);
            this.pnlErase.Controls.Add(this.lblEraseNotes);
            this.pnlErase.Location = new System.Drawing.Point(415, 52);
            this.pnlErase.Name = "pnlErase";
            this.pnlErase.Size = new System.Drawing.Size(242, 348);
            this.pnlErase.TabIndex = 2;
            // 
            // btnErasePass
            // 
            this.btnErasePass.CheckedState.Parent = this.btnErasePass;
            this.btnErasePass.CustomImages.Parent = this.btnErasePass;
            this.btnErasePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnErasePass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErasePass.ForeColor = System.Drawing.Color.White;
            this.btnErasePass.HoverState.Parent = this.btnErasePass;
            this.btnErasePass.Location = new System.Drawing.Point(5, 196);
            this.btnErasePass.Name = "btnErasePass";
            this.btnErasePass.ShadowDecoration.Parent = this.btnErasePass;
            this.btnErasePass.Size = new System.Drawing.Size(232, 40);
            this.btnErasePass.TabIndex = 2;
            this.btnErasePass.Text = "ERASE PASSWORDS";
            this.btnErasePass.Click += new System.EventHandler(this.btnErasePass_Click);
            // 
            // btnEraseNotes
            // 
            this.btnEraseNotes.CheckedState.Parent = this.btnEraseNotes;
            this.btnEraseNotes.CustomImages.Parent = this.btnEraseNotes;
            this.btnEraseNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEraseNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEraseNotes.ForeColor = System.Drawing.Color.White;
            this.btnEraseNotes.HoverState.Parent = this.btnEraseNotes;
            this.btnEraseNotes.Location = new System.Drawing.Point(5, 78);
            this.btnEraseNotes.Name = "btnEraseNotes";
            this.btnEraseNotes.ShadowDecoration.Parent = this.btnEraseNotes;
            this.btnEraseNotes.Size = new System.Drawing.Size(232, 40);
            this.btnEraseNotes.TabIndex = 2;
            this.btnEraseNotes.Text = "ERASE NOTES";
            this.btnEraseNotes.Click += new System.EventHandler(this.btnEraseNotes_Click);
            // 
            // lblErasePasswords
            // 
            this.lblErasePasswords.AutoSize = true;
            this.lblErasePasswords.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErasePasswords.ForeColor = System.Drawing.Color.White;
            this.lblErasePasswords.Location = new System.Drawing.Point(3, 130);
            this.lblErasePasswords.Name = "lblErasePasswords";
            this.lblErasePasswords.Size = new System.Drawing.Size(243, 42);
            this.lblErasePasswords.TabIndex = 1;
            this.lblErasePasswords.Text = "Erase all the Passwords?\r\n(It will delete all the Passwords!)";
            // 
            // lblEraseNotes
            // 
            this.lblEraseNotes.AutoSize = true;
            this.lblEraseNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEraseNotes.ForeColor = System.Drawing.Color.White;
            this.lblEraseNotes.Location = new System.Drawing.Point(11, 14);
            this.lblEraseNotes.Name = "lblEraseNotes";
            this.lblEraseNotes.Size = new System.Drawing.Size(208, 42);
            this.lblEraseNotes.TabIndex = 1;
            this.lblEraseNotes.Text = "Erase all the Notes?\r\n(It will delete all the notes!)";
            // 
            // elpsNotes
            // 
            this.elpsNotes.BorderRadius = 10;
            this.elpsNotes.TargetControl = this.pnlNotes;
            // 
            // elpsErase
            // 
            this.elpsErase.BorderRadius = 10;
            this.elpsErase.TargetControl = this.pnlErase;
            // 
            // elpsErBtnNotes
            // 
            this.elpsErBtnNotes.BorderRadius = 10;
            this.elpsErBtnNotes.TargetControl = this.btnEraseNotes;
            // 
            // elpsErBtnPass
            // 
            this.elpsErBtnPass.BorderRadius = 10;
            this.elpsErBtnPass.TargetControl = this.btnErasePass;
            // 
            // timerConfirm
            // 
            this.timerConfirm.Tick += new System.EventHandler(this.timerConfirm_Tick);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(730, 469);
            this.Controls.Add(this.pnlErase);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.pnlData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPage";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlNotes.ResumeLayout(false);
            this.pnlNotes.PerformLayout();
            this.pnlErase.ResumeLayout(false);
            this.pnlErase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elpsPage;
        private System.Windows.Forms.Label lblDataText;
        private System.Windows.Forms.Panel pnlData;
        private Guna.UI2.WinForms.Guna2Elipse elpsData;
        private System.Windows.Forms.Panel pnlNotes;
        private Guna.UI2.WinForms.Guna2CheckBox cbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel pnlErase;
        private System.Windows.Forms.Label lblEraseNotes;
        private Guna.UI2.WinForms.Guna2Elipse elpsNotes;
        private Guna.UI2.WinForms.Guna2Elipse elpsErase;
        private Guna.UI2.WinForms.Guna2Button btnEraseNotes;
        private Guna.UI2.WinForms.Guna2Elipse elpsErBtnNotes;
        private System.Windows.Forms.Label lblErasePasswords;
        private Guna.UI2.WinForms.Guna2Button btnErasePass;
        private Guna.UI2.WinForms.Guna2Elipse elpsErBtnPass;
        private Guna.UI2.WinForms.Guna2RadioButton btnLocal;
        private Guna.UI2.WinForms.Guna2RadioButton btnDB;
        private System.Windows.Forms.Timer timerConfirm;
    }
}