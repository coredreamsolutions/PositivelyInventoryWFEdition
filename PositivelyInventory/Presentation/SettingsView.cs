using PositivelyInventory.Data;
using PositivelyInventory.Model;
using PositivelyInventory.Validators;

namespace PositivelyInventory.Presentation
{
    public partial class SettingsView : Form
    {
        SettingsRepository settingsRepository = new SettingsRepository();
        public Setting SettingModel { get; set; }
        public SettingsView(Setting setting)
        {
            InitializeComponent();
            SettingModel = setting ?? throw new ArgumentNullException("setting");

            BindModel(setting);

        }

        public void BindModel(Setting setting)
        {
            DataBackupPath.DataBindings.Add("Text", setting, "DatabaseBackupPath", true, DataSourceUpdateMode.OnPropertyChanged);
            ShowBrandingCheck.DataBindings.Add("Checked", setting, "ShowStoreBranding", true, DataSourceUpdateMode.OnPropertyChanged);         
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            SaveSettingsView();
        }

        public void SaveSettingsView()
        {
            CheckResult checkResult = SettingValidator.ValidateSave(SettingModel);
            if (checkResult.Failed)
            {
                MessageBox.Show(checkResult.Items[0].Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            settingsRepository.UpdateSettings(SettingModel);
            Close();
            Setting setting = settingsRepository.GetSettings();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = setting;
        }

        private void BrowseBackupPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                folderBrowser.ShowNewFolderButton = true;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    DataBackupPath.Text = folderBrowser.SelectedPath;
                }
            }
        }
    }
}
