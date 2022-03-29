using Dapper;
using PositivelyInventory.Model;
using System.Data;
using System.Data.SQLite;

namespace PositivelyInventory.Data
{
    public class ContactsRepository
    {
        DataManager dataManager = new DataManager();

        public List<Contacts> GetContacts()
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                return connection.Query<Contacts>(@"SELECT * FROM Contacts;").ToList();
            }       
        }

        public void SaveContact(Contact contact, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                if (contact.ContactId == 0L)
                {
                       contact.ContactId = connection.Query<long>(
                           @"INSERT INTO Contacts (FirstName, LastName, Email, MobileNumber, OfficeNumber) " +
                           "VALUES (@FirstName, @LastName, @Email, @MobileNumber, @OfficeNumber); " + //
                           "SELECT last_insert_rowid()", contact, trans, true, null, null).FirstOrDefault<long>();
                    //ToDo: use parameterized queries: https://stackoverflow.com/questions/22776756/parameterized-queries-in-sqlite3-using-question-marks
                }
            }
        }
    }
}
