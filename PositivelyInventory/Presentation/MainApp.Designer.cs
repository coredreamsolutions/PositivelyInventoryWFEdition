namespace PositivelyInventory.Presentation
{
    partial class MainApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEditSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEditContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripEditCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripToolDatabaseManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutPositivelyInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripFile,
            this.MenuStripEdit,
            this.MenuStripView,
            this.MenuStripTools,
            this.MenuStripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStripFile
            // 
            this.MenuStripFile.Name = "MenuStripFile";
            this.MenuStripFile.Size = new System.Drawing.Size(37, 20);
            this.MenuStripFile.Text = "&File";
            // 
            // MenuStripEdit
            // 
            this.MenuStripEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripEditSettings,
            this.MenuStripEditContacts,
            this.MenuStripEditCategories});
            this.MenuStripEdit.Name = "MenuStripEdit";
            this.MenuStripEdit.Size = new System.Drawing.Size(39, 20);
            this.MenuStripEdit.Text = "&Edit";
            // 
            // MenuStripEditSettings
            // 
            this.MenuStripEditSettings.Name = "MenuStripEditSettings";
            this.MenuStripEditSettings.Size = new System.Drawing.Size(180, 22);
            this.MenuStripEditSettings.Text = "Settings";
            this.MenuStripEditSettings.Click += new System.EventHandler(this.MenuStripEditSettings_Click);
            // 
            // MenuStripEditContacts
            // 
            this.MenuStripEditContacts.Name = "MenuStripEditContacts";
            this.MenuStripEditContacts.Size = new System.Drawing.Size(180, 22);
            this.MenuStripEditContacts.Text = "&Contacts";
            this.MenuStripEditContacts.Click += new System.EventHandler(this.MenuStripEditContacts_Click);
            // 
            // MenuStripEditCategories
            // 
            this.MenuStripEditCategories.Name = "MenuStripEditCategories";
            this.MenuStripEditCategories.Size = new System.Drawing.Size(180, 22);
            this.MenuStripEditCategories.Text = "Categories";
            this.MenuStripEditCategories.Click += new System.EventHandler(this.MenuStripEditCategories_Click);
            // 
            // MenuStripView
            // 
            this.MenuStripView.Name = "MenuStripView";
            this.MenuStripView.Size = new System.Drawing.Size(44, 20);
            this.MenuStripView.Text = "&View";
            // 
            // MenuStripTools
            // 
            this.MenuStripTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStripToolDatabaseManager});
            this.MenuStripTools.Name = "MenuStripTools";
            this.MenuStripTools.Size = new System.Drawing.Size(46, 20);
            this.MenuStripTools.Text = "&Tools";
            // 
            // MenuStripToolDatabaseManager
            // 
            this.MenuStripToolDatabaseManager.Name = "MenuStripToolDatabaseManager";
            this.MenuStripToolDatabaseManager.Size = new System.Drawing.Size(172, 22);
            this.MenuStripToolDatabaseManager.Text = "Database Manager";
            this.MenuStripToolDatabaseManager.Click += new System.EventHandler(this.MenuStripToolsBackupData_Click);
            // 
            // MenuStripHelp
            // 
            this.MenuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutPositivelyInventoryToolStripMenuItem});
            this.MenuStripHelp.Name = "MenuStripHelp";
            this.MenuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuStripHelp.Text = "&Help";
            // 
            // aboutPositivelyInventoryToolStripMenuItem
            // 
            this.aboutPositivelyInventoryToolStripMenuItem.Name = "aboutPositivelyInventoryToolStripMenuItem";
            this.aboutPositivelyInventoryToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.aboutPositivelyInventoryToolStripMenuItem.Text = "&About Positively Inventory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Positively Inventory Lite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuStripFile;
        private ToolStripMenuItem MenuStripEdit;
        private ToolStripMenuItem MenuStripView;
        private ToolStripMenuItem MenuStripTools;
        private ToolStripMenuItem MenuStripToolDatabaseManager;
        private ToolStripMenuItem MenuStripHelp;
        private ToolStripMenuItem aboutPositivelyInventoryToolStripMenuItem;
        private ToolStripMenuItem MenuStripEditSettings;
        private ToolStripMenuItem MenuStripEditContacts;
        private Button button1;
        private ToolStripMenuItem MenuStripEditCategories;
    }
}