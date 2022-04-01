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
        ProductRepository productRepository = new ProductRepository();
        CategoriesRepository categoriesRepository = new CategoriesRepository();
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
            Setting? setting = settingsRepository.GetSettings();

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

        private void MenuStripEditCategories_Click(object sender, EventArgs e)
        {
            Category categoryNew = new Category();
            List<Category> categoryList = categoriesRepository.GetCategories(); // Shows 3
            
            using (CategoriesView categoriesView = new CategoriesView(categoryList, categoryNew))
            {
                categoriesView.Owner = this;
                categoriesView.ShowDialog();
            }
        }

        // TEST ONLY
        private void button1_Click(object sender, EventArgs e)
        {
            productRepository.GetProductByCategory();
        }

        
    }
}
