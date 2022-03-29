using Dapper;
using System.Data;
using System.Data.SQLite;

namespace PositivelyInventory.Data
{
    public class DataManager
    {
        public bool BackupMode = false;

        public string databaseCurrentLocation = $@"{AppDomain.CurrentDomain.BaseDirectory}\Database.pidb";
        public string databaseBackupLocation = $@"{AppDomain.CurrentDomain.BaseDirectory}\Backups\";

        public string? backupDatabasePath;
        public string? backupDatabaseTempPath;
        
        string ConnectionStringMain = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\Database.pidb";
        string ConnectionStringBackup = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\DatabaseBackup.pidb";

        public bool CheckDatabase()
        {
            if (!File.Exists(databaseCurrentLocation))
            {
                var result = MessageBox.Show(
                    "The database is missing. Do you want to restore from a backup? To create a new database, click No.",
                    "Database Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.Yes)
                {
                    RestoreDatabase();
                } else
                {
                    CreateDatabase(databaseCurrentLocation);
                    Thread.Sleep(1000);
                    PopulateDatabase(databaseCurrentLocation);
                }
            }

            return true;

        }

        public void RestoreBackup(string selectedBackup)
        {
            File.Move(selectedBackup,
                $@"{AppDomain.CurrentDomain.BaseDirectory}\Database.pidb");

            MessageBox.Show(@"The database has been successfully restored. The app will
                    now restart for the data to be useable.", "Data Restore Succeeded", MessageBoxButtons.OK);

        }

        public static void RestoreDatabase()
        {
            // Launch the open file dialog.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Positively Inventory Backup (*.pibk)|*.pibk";
            openFileDialog.Title = "Select Database to Restore From";
            openFileDialog.ShowDialog();

            if (!openFileDialog.CheckFileExists)
            {
                MessageBox.Show("N");

            }
        }

        public void BackupDatabase(bool isAuto)
        {
            if (!isAuto) 
            {
                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                {
                    folderBrowser.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    folderBrowser.ShowNewFolderButton = true;

                    string backupDatabaseFileName = $"Database_{DateTime.Now:yyyyMMddmmssfff}.pibk";
                    string backupDatabaseFileTemp = $"tmp_vacuum.tmp";

                    // Save the file to the location specifed.
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        backupDatabasePath = Path.Combine(folderBrowser.SelectedPath, backupDatabaseFileName);

                        File.Copy(databaseCurrentLocation, backupDatabasePath);

                        backupDatabaseTempPath = Path.Combine(folderBrowser.SelectedPath, backupDatabaseFileTemp);

                        File.Copy(backupDatabasePath, backupDatabaseTempPath, true);

                        VacuumDatabase(backupDatabaseTempPath);

                        bool isValid = TestDatabaseIsValid(backupDatabaseTempPath);

                        if (true)
                        {
                            File.Delete(backupDatabasePath);
                            File.Copy(backupDatabaseTempPath, backupDatabasePath, true);

                            SQLiteConnection.ClearAllPools();

                            File.Delete(backupDatabaseTempPath);

                            MessageBox.Show($@"Manual data backup has been completed, the location it is located here:
                                          {Environment.NewLine}{backupDatabasePath}", "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        public void VacuumDatabase(string databaseFile, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = GetConnection(false))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string sqlCommand = @"VACUUM;";

                    connection.Execute(sqlCommand, trans);
                }
            }
        }
        public bool TestDatabaseIsValid(string databaseFile)
        {
            using (SQLiteConnection connection = GetConnection(false))
            {
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        public void CreateDatabase(string databaseName)
        {
            if (!File.Exists(databaseName))
            {
                using (SQLiteConnection connection = GetConnection(false))
                {
                    connection.Open();
                }
            }
        }

        public void PopulateDatabase(string databaseName, string? sqlFilename = null, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = GetConnection(false))
            {
                var sqlStatement = File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\Init.sql");
                connection.Execute(sqlStatement, trans);
            }
        }

        public SQLiteConnection GetConnection(bool isBackupMode)
        {
            if (!isBackupMode)
            {
                return new SQLiteConnection(ConnectionStringMain);
            }
            else { 
                return new SQLiteConnection(ConnectionStringBackup);
            }
        }

        public DataTable Select(string sql, params SQLiteParameter[] param)
        {
            using (SQLiteConnection connection = GetConnection(false))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(command))
                    {
                        command.Parameters.AddRange(param);
                        connection.Open();
                        DataTable dataTable = new DataTable("data");
                        sQLiteDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataSet SelectTwo(string sql, params SQLiteParameter[] param)
        {
            using (SQLiteConnection connection = GetConnection(false))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(command))
                    {
                        command.Parameters.AddRange(param);
                        connection.Open();
                        DataSet dataSet = new DataSet("data");
                        sQLiteDataAdapter.Fill(dataSet);
                        return dataSet;
                    }
                }
            }
        }
    }
}
