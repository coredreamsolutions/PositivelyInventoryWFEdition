using Dapper;
//using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace PositivelyInventory.Data
{
    public class DataManager
    {
        public bool BackupMode = false;

        public string databaseCurrentLocation = $@"{AppDomain.CurrentDomain.BaseDirectory}\Database.pidb";
        public string databaseBackupLocation = $@"{AppDomain.CurrentDomain.BaseDirectory}\Backups\";

        public string? backupDatabasePath = string.Empty;
        public string? backupDatabaseTempPath = string.Empty;
        
        string ConnectionStringMain = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\Database.pidb";
        string ConnectionStringBackup = $@"Data Source={AppDomain.CurrentDomain.BaseDirectory}\DatabaseBackup.pidb";

        public DataManager()
        {
            //TODO
        }

        /// <summary>
        /// Check to make sure the database exists, if it does not, then
        /// alert the user and allow for a resolve. Resolve meaning allow to restore
        /// a backup database if needed.
        /// </summary>
        /// <returns></returns>
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
            // Once we have the restore file, we must copy it to the main data folder,
            // and rename it to Database.pidb.

            // Move and rename the file.
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

        /// <summary>
        /// Backup the database to a safe location.
        /// </summary>
        /// <param name="isAuto">If this is set, do this via automation.</param>
        public void BackupDatabase(bool isAuto)
        {
            if (!isAuto) // Manual
            {
                // Open the save dialog to save a copy of the database,
                // somewhere outside of the app directory.

                using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                {
                    folderBrowser.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    folderBrowser.ShowNewFolderButton = true;

                    // Append the current date and time formatted to the filename and add the extension.
                    string backupDatabaseFileName = $"Database_{DateTime.Now:yyyyMMddmmssfff}.pibk";
                    string backupDatabaseFileTemp = $"tmp_vacuum.tmp";

                    // Save the file to the location specifed.
                    if (folderBrowser.ShowDialog() == DialogResult.OK)
                    {
                        // Combine the filename with the selected path from the folder browser.
                        backupDatabasePath = Path.Combine(folderBrowser.SelectedPath, backupDatabaseFileName);

                        // Copy the current database to the new location specified in the folder browser.
                        File.Copy(databaseCurrentLocation, backupDatabasePath);

                        // Combine the backed up file to a new temp filename with the selected
                        // path fromt the folder browser, so we can vacuum (clean/reindex) the database.
                        backupDatabaseTempPath = Path.Combine(folderBrowser.SelectedPath, backupDatabaseFileTemp);

                        // Copy the backup database to a temp database.
                        File.Copy(backupDatabasePath, backupDatabaseTempPath, true);

                        // Vacuum and reindex the temp database file.
                        VacuumDatabase(backupDatabaseTempPath);

                        // Test to see if the temp database file is still valid and openable.
                        bool isValid = TestDatabaseIsValid(backupDatabaseTempPath);

                        if (true)
                        {
                            // Delete the backed up file, the non-vacuumed one.
                            File.Delete(backupDatabasePath);

                            // Rename the temp file back to the back up file.
                            File.Copy(backupDatabaseTempPath, backupDatabasePath, true);

                            // Clear all pending/idle pools so we can close the database
                            // Source: https://github.com/dotnet/efcore/issues/26369
                            SQLiteConnection.ClearAllPools();

                            // Delete the temp database filename.
                            // Status: WORKS!!!!!
                            File.Delete(backupDatabaseTempPath);

                            // Display a information dialog, letting the user know the operation was successful.
                            MessageBox.Show($@"Manual data backup has been completed, the location it is located here:
                                          {Environment.NewLine}{backupDatabasePath}", "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            //TODO
            Debug.Print("Auto is on");
        }

        /// <summary>
        /// Vacuum and reindex all the tables so the database is compacted.
        /// </summary>
        /// <param name="databaseFile">The name of the database file (backup, temp backup, or primary here).</param>
        /// <param name="trans">This can be null</param>
        public void VacuumDatabase(string databaseFile, IDbTransaction? trans = null)
        {
            //using (SQLiteConnection connection = GetConnection(databaseFile))
            using (SQLiteConnection connection = GetConnection(false))
            {
                // Open the database file you selected.
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    string sqlCommand = @"VACUUM;";

                    // Execute the VACUUM command.
                    connection.Execute(sqlCommand, trans);
                }
            }
        }

        // This is what triggers the fail, if omitted, the rest of the c
        public bool TestDatabaseIsValid(string databaseFile)
        {
            //bool result = false; Passes
            // Establish a new connection object.
            //using (SQLiteConnection connection = GetConnection(databaseFile))
            using (SQLiteConnection connection = GetConnection(false))
            {

                // Open the database file you selected.
                connection.Open();

                if (connection.State != ConnectionState.Open)
                {
                    return false;
                }
                else
                    return true;
            }
        }

        /// <summary>
        /// Create a brand new database, and populate it with tables and default data, using a valid app .sql file.
        /// </summary>
        /// <param name="databaseName">Name of the new database file.</param>
        public void CreateDatabase(string databaseName)
        {
            if (!File.Exists(databaseName))
            {
                //using (SQLiteConnection connection = GetConnection(databaseName))
                using (SQLiteConnection connection = GetConnection(false))
                {
                    connection.Open();
                }
            }
        }

        /// <summary>
        /// Populate database with tables and default data, using a valid .sql syntax file.
        /// </summary>
        /// <param name="databaseName">Name of the new database file.</param>
        /// <param name="sqlFilename">Name of the sql script file.</param>
        public void PopulateDatabase(string databaseName, string? sqlFilename = null, IDbTransaction? trans = null)
        {
            //using (SQLiteConnection connection = GetConnection(databaseName))
            using (SQLiteConnection connection = GetConnection(false))
            {
                string sqlStatement = File.ReadAllText($@"{AppDomain.CurrentDomain.BaseDirectory}\Init.sql");

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
            //using (SQLiteConnection sQLiteConnection = GetConnection(databaseCurrentLocation))
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
            //using (SQLiteConnection sQLiteConnection = GetConnection(databaseCurrentLocation))
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
