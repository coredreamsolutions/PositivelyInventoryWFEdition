using Dapper;
using PositivelyInventory.Model;
using System.Data;
using System.Data.SQLite;

namespace PositivelyInventory.Data
{
    public class SettingsRepository
    {
        readonly DataManager dataManager = new DataManager();

        public Setting? GetSettings()
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                return connection.Query<Setting>("SELECT * FROM Settings;").FirstOrDefault();
            }
        }

        public void UpdateSettings(Setting settingModel, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                string sqlStatement = @"UPDATE Settings SET ShowStoreBranding = @ShowStoreBranding, DatabaseBackupPath = @DatabaseBackupPath WHERE Id = 1;";
                connection.Execute(sqlStatement, settingModel);
            }
        }
    }
}
