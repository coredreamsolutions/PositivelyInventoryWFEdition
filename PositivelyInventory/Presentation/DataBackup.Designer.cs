namespace PositivelyInventory.Presentation
{
    partial class DataBackup
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
            this.RunManualBackup = new System.Windows.Forms.Button();
            this.DataBackupFilesList = new System.Windows.Forms.ListBox();
            this.RestoreSelectedBackup = new System.Windows.Forms.Button();
            this.TestCreateDatabase = new System.Windows.Forms.Button();
            this.TestPopulateDatabase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunManualBackup
            // 
            this.RunManualBackup.Location = new System.Drawing.Point(847, 169);
            this.RunManualBackup.Name = "RunManualBackup";
            this.RunManualBackup.Size = new System.Drawing.Size(278, 51);
            this.RunManualBackup.TabIndex = 0;
            this.RunManualBackup.Text = "&Manual Backup";
            this.RunManualBackup.UseVisualStyleBackColor = true;
            this.RunManualBackup.Click += new System.EventHandler(this.RunManualBackup_Click);
            // 
            // DataBackupFilesList
            // 
            this.DataBackupFilesList.FormattingEnabled = true;
            this.DataBackupFilesList.ItemHeight = 21;
            this.DataBackupFilesList.Location = new System.Drawing.Point(12, 12);
            this.DataBackupFilesList.Name = "DataBackupFilesList";
            this.DataBackupFilesList.Size = new System.Drawing.Size(1113, 151);
            this.DataBackupFilesList.TabIndex = 1;
            // 
            // RestoreSelectedBackup
            // 
            this.RestoreSelectedBackup.Enabled = false;
            this.RestoreSelectedBackup.Location = new System.Drawing.Point(563, 169);
            this.RestoreSelectedBackup.Name = "RestoreSelectedBackup";
            this.RestoreSelectedBackup.Size = new System.Drawing.Size(278, 51);
            this.RestoreSelectedBackup.TabIndex = 2;
            this.RestoreSelectedBackup.Text = "&Restore Selected Backup";
            this.RestoreSelectedBackup.UseVisualStyleBackColor = true;
            this.RestoreSelectedBackup.Click += new System.EventHandler(this.RestoreSelectedBackup_Click);
            // 
            // TestCreateDatabase
            // 
            this.TestCreateDatabase.Location = new System.Drawing.Point(12, 171);
            this.TestCreateDatabase.Name = "TestCreateDatabase";
            this.TestCreateDatabase.Size = new System.Drawing.Size(96, 51);
            this.TestCreateDatabase.TabIndex = 3;
            this.TestCreateDatabase.Text = "Create Database";
            this.TestCreateDatabase.UseVisualStyleBackColor = true;
            this.TestCreateDatabase.Click += new System.EventHandler(this.TestCreateDatabase_Click);
            // 
            // TestPopulateDatabase
            // 
            this.TestPopulateDatabase.Location = new System.Drawing.Point(114, 169);
            this.TestPopulateDatabase.Name = "TestPopulateDatabase";
            this.TestPopulateDatabase.Size = new System.Drawing.Size(96, 51);
            this.TestPopulateDatabase.TabIndex = 4;
            this.TestPopulateDatabase.Text = "Populate Database";
            this.TestPopulateDatabase.UseVisualStyleBackColor = true;
            this.TestPopulateDatabase.Click += new System.EventHandler(this.TestPopulateDatabase_Click);
            // 
            // DataBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 234);
            this.Controls.Add(this.TestPopulateDatabase);
            this.Controls.Add(this.TestCreateDatabase);
            this.Controls.Add(this.RestoreSelectedBackup);
            this.Controls.Add(this.DataBackupFilesList);
            this.Controls.Add(this.RunManualBackup);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DataBackup";
            this.Text = "Data Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RunManualBackup;
        private ListBox DataBackupFilesList;
        private Button RestoreSelectedBackup;
        private Button TestCreateDatabase;
        private Button TestPopulateDatabase;
    }
}