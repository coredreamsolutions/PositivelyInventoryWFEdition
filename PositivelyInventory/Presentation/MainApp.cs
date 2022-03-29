using PositivelyInventory;
using PositivelyInventory.Data;
using PositivelyInventory.Model;


namespace PositivelyInventory.Presentation
{
    public partial class MainApp : Form
    {
        DataManager dataManager = new DataManager();
        SettingsRepository settingsRepository = new SettingsRepository();
        ContactsRepository contactsRepository = new ContactsRepository();

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

        private void MenuStripEditSettings_Click(object sender, EventArgs e)
        {
            Setting setting = settingsRepository.GetSettings();

            using (SettingsView settingsView = new SettingsView(setting))
                settingsView.ShowDialog();
        }

        private void MenuStripEditContacts_Click(object sender, EventArgs e)
        {
            List<Contacts> contact = contactsRepository.GetContacts();
            using (ContactsView contactsView = new ContactsView(contact))
            {
                contactsView.Owner= this;
                contactsView.ShowDialog();
            }
          
        }
    }
}
