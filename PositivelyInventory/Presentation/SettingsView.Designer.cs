namespace PositivelyInventory.Presentation
{
    partial class SettingsView
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
            this.SaveSettings = new System.Windows.Forms.Button();
            this.DataBackupPathHeader = new System.Windows.Forms.Label();
            this.DataBackupPath = new System.Windows.Forms.TextBox();
            this.BrowseBackupPath = new System.Windows.Forms.Button();
            this.ShowBrandingCheck = new System.Windows.Forms.CheckBox();
            this.CancelModal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(341, 152);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(97, 33);
            this.SaveSettings.TabIndex = 0;
            this.SaveSettings.Text = "&Save";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // DataBackupPathHeader
            // 
            this.DataBackupPathHeader.AutoSize = true;
            this.DataBackupPathHeader.Location = new System.Drawing.Point(12, 9);
            this.DataBackupPathHeader.Name = "DataBackupPathHeader";
            this.DataBackupPathHeader.Size = new System.Drawing.Size(130, 21);
            this.DataBackupPathHeader.TabIndex = 1;
            this.DataBackupPathHeader.Text = "Data Backup Path";
            // 
            // DataBackupPath
            // 
            this.DataBackupPath.Enabled = false;
            this.DataBackupPath.Location = new System.Drawing.Point(17, 33);
            this.DataBackupPath.Name = "DataBackupPath";
            this.DataBackupPath.Size = new System.Drawing.Size(443, 29);
            this.DataBackupPath.TabIndex = 2;
            // 
            // BrowseBackupPath
            // 
            this.BrowseBackupPath.Location = new System.Drawing.Point(466, 33);
            this.BrowseBackupPath.Name = "BrowseBackupPath";
            this.BrowseBackupPath.Size = new System.Drawing.Size(75, 29);
            this.BrowseBackupPath.TabIndex = 3;
            this.BrowseBackupPath.Text = "...";
            this.BrowseBackupPath.UseVisualStyleBackColor = true;
            this.BrowseBackupPath.Click += new System.EventHandler(this.BrowseBackupPath_Click);
            // 
            // ShowBrandingCheck
            // 
            this.ShowBrandingCheck.AutoSize = true;
            this.ShowBrandingCheck.Location = new System.Drawing.Point(17, 87);
            this.ShowBrandingCheck.Name = "ShowBrandingCheck";
            this.ShowBrandingCheck.Size = new System.Drawing.Size(175, 25);
            this.ShowBrandingCheck.TabIndex = 4;
            this.ShowBrandingCheck.Text = "Show Store Branding";
            this.ShowBrandingCheck.UseVisualStyleBackColor = true;
            // 
            // CancelModal
            // 
            this.CancelModal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelModal.Location = new System.Drawing.Point(444, 152);
            this.CancelModal.Name = "CancelModal";
            this.CancelModal.Size = new System.Drawing.Size(97, 33);
            this.CancelModal.TabIndex = 5;
            this.CancelModal.Text = "C&ancel";
            this.CancelModal.UseVisualStyleBackColor = true;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 197);
            this.Controls.Add(this.CancelModal);
            this.Controls.Add(this.ShowBrandingCheck);
            this.Controls.Add(this.BrowseBackupPath);
            this.Controls.Add(this.DataBackupPath);
            this.Controls.Add(this.DataBackupPathHeader);
            this.Controls.Add(this.SaveSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsView";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveSettings;
        private Label DataBackupPathHeader;
        private TextBox DataBackupPath;
        private Button BrowseBackupPath;
        private CheckBox ShowBrandingCheck;
        private Button CancelModal;
    }
}