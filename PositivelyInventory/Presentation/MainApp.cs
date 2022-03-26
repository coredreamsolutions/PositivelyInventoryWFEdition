using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PositivelyInventory.Data;

namespace PositivelyInventory.Presentation
{
    public partial class MainApp : Form
    {
        DataManager dataManager = new DataManager();
        public MainApp()
        {
            InitializeComponent();

            // Check database on application load.
            dataManager.CheckDatabase();

        }

        private void MenuStripToolsBackupData_Click(object sender, EventArgs e)
        {
            using (DataBackup backupDatabase = new DataBackup())
                backupDatabase.ShowDialog();
        }

        
    }
}
