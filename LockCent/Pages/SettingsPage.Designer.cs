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
            this.FolderSelector = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lblSQL = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDataText = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.elpsData = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlNotes = new System.Windows.Forms.Panel();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cbNotes = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnlData.SuspendLayout();
            this.pnlNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // elpsPage
            // 
            this.elpsPage.BorderRadius = 20;
            this.elpsPage.TargetControl = this;
            // 
            // FolderSelector
            // 
            this.FolderSelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.FolderSelector.HoverState.Parent = this.FolderSelector;
            this.FolderSelector.LargeChange = 1;
            this.FolderSelector.Location = new System.Drawing.Point(9, 105);
            this.FolderSelector.Maximum = 1;
            this.FolderSelector.MouseWheelBarPartitions = 1;
            this.FolderSelector.Name = "FolderSelector";
            this.FolderSelector.Size = new System.Drawing.Size(300, 23);
            this.FolderSelector.TabIndex = 0;
            this.FolderSelector.ThumbColor = System.Drawing.Color.White;
            this.FolderSelector.Value = 0;
            this.FolderSelector.ValueChanged += new System.EventHandler(this.FolderSelector_ValueChanged);
            // 
            // lblSQL
            // 
            this.lblSQL.AutoSize = true;
            this.lblSQL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQL.ForeColor = System.Drawing.Color.White;
            this.lblSQL.Location = new System.Drawing.Point(186, 65);
            this.lblSQL.Name = "lblSQL";
            this.lblSQL.Size = new System.Drawing.Size(123, 21);
            this.lblSQL.TabIndex = 1;
            this.lblSQL.Text = "In the DataBase";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.White;
            this.lblLocal.Location = new System.Drawing.Point(5, 65);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(60, 21);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Locally";
            // 
            // lblDataText
            // 
            this.lblDataText.AutoSize = true;
            this.lblDataText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataText.ForeColor = System.Drawing.Color.White;
            this.lblDataText.Location = new System.Drawing.Point(5, 14);
            this.lblDataText.Name = "lblDataText";
            this.lblDataText.Size = new System.Drawing.Size(115, 21);
            this.lblDataText.TabIndex = 1;
            this.lblDataText.Text = "Save Location:";
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlData.Controls.Add(this.FolderSelector);
            this.pnlData.Controls.Add(this.lblDataText);
            this.pnlData.Controls.Add(this.lblLocal);
            this.pnlData.Controls.Add(this.lblSQL);
            this.pnlData.Location = new System.Drawing.Point(22, 24);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(323, 161);
            this.pnlData.TabIndex = 2;
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
            this.pnlNotes.Location = new System.Drawing.Point(22, 213);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(323, 161);
            this.pnlNotes.TabIndex = 2;
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
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(620, 450);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elpsPage;
        private Guna.UI2.WinForms.Guna2TrackBar FolderSelector;
        private System.Windows.Forms.Label lblSQL;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDataText;
        private System.Windows.Forms.Panel pnlData;
        private Guna.UI2.WinForms.Guna2Elipse elpsData;
        private System.Windows.Forms.Panel pnlNotes;
        private Guna.UI2.WinForms.Guna2CheckBox cbNotes;
        private System.Windows.Forms.Label lblNotes;
    }
}