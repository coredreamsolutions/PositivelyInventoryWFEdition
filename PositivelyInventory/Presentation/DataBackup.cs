using PositivelyInventory.Data;
using System.Diagnostics;

namespace PositivelyInventory.Presentation
{
    public partial class DataBackup : Form
    {
        DataManager dataManager = new DataManager();

        public DataBackup()
        {
            InitializeComponent();

            ScanBackupFiles();            
        }

        private void RunManualBackup_Click(object sender, EventArgs e)
        {
            dataManager.BackupDatabase(false);
        }

        public void ScanBackupFiles()
        {
            string[] backupFiles =
                   Directory.GetFiles($@"{AppDomain.CurrentDomain.BaseDirectory}\Backups\","*.pibk");

            foreach (string backupFile in backupFiles)
            {
                DataBackupFilesList.Items.Add(backupFile);
                DataBackupFilesList.Update();
            }

            if (DataBackupFilesList.Items.Count > 0)
                RestoreSelectedBackup.Enabled = true;
        }

        private void RestoreSelectedBackup_Click(object sender, EventArgs e)
        {
            dataManager.RestoreBackup(DataBackupFilesList.Text);
        }

       
    }
}
