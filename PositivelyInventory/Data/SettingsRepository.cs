using Dapper;
using PositivelyInventory;
using PositivelyInventory.Model;
using System.Linq;
using System.Data.SQLite;
using System.Data;


namespace PositivelyInventory.Data
{
    public class SettingsRepository
    {
        readonly DataManager dataManager = new DataManager();

        public Setting GetSettings()
        {
            //using (SQLiteConnection connection = DataManager.GetConnection($@"{AppDomain.CurrentDomain.BaseDirectory}\Database.pidb"))
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                return connection.Query<Setting>("SELECT * FROM Settings;").FirstOrDefault();
            }
        }

        public void UpdateSettings(Setting settingModel, IDbTransaction trans = null)
        {
            //using (SQLiteConnection connection = DataManager.GetConnection($@"{AppDomain.CurrentDomain.BaseDirectory}\Database.pidb"))
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                // Do not need WHERE since it is only 1 record.
                string sqlStatement = @"UPDATE Settings SET ShowStoreBranding = @ShowStoreBranding, DatabaseBackupPath = @DatabaseBackupPath WHERE Id = 1;";
                connection.Execute(sqlStatement, settingModel);
            }
        }
    }
}
