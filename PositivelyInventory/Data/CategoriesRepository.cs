using Dapper;
using PositivelyInventory.Model;
using System.Data;
using System.Data.SQLite;

namespace PositivelyInventory.Data
{
    public class CategoriesRepository
    {
        DataManager dataManager = new DataManager();

        public List<Category> GetCategories()
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                return connection.Query<Category>(@"SELECT * FROM Categories ORDER BY CategoryName;").ToList();
            }
        }

        public void SaveCategory(Category category, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                if (category.CategoryId == 0L)
                {
                    category.CategoryId = connection.Query<long>(
                        @"INSERT INTO Categories (CategoryName) 
                          VALUES (@CategoryName); 
                          SELECT last_insert_rowid()",
                        category, trans, true, null, null).FirstOrDefault<long>();
                }
            }
        }

    }
}
