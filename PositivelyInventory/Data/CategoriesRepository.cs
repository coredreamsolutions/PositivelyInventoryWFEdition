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
                return connection.Query<Category>(@"SELECT * FROM Categories;").ToList();
            }
        }
    }


}
