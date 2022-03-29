using Dapper;
using PositivelyInventory.Model;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace PositivelyInventory.Data
{
    public class ProductRepository
    {
        DataManager dataManager = new DataManager();

        public List<Categories> GetCategories()
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                return connection.Query<Categories>(@"SELECT * FROM Categories;").ToList();
            }
        }

        public async void GetProductByCategory()
        {
            using (SQLiteConnection? connection = dataManager.GetConnection(false))
            {
                var sqlQuery = @"SELECT ProductId, ProductName, P.CategoryId, CategoryName 
                                 FROM Products P 
                                 INNER JOIN Categories C on P.CategoryId = C.CategoryId";

                var products = await connection.QueryAsync<Product, Category, Product>(sqlQuery, (p, c) => {
                    p.Category = c;
                    return p;
                },

                splitOn: "CategoryId");
                products.ToList().ForEach(p => 
                Debug.Print($"Product: {p.ProductName}, Category: {p.Category.CategoryName}"));
 
            }
        }

        public void SaveCategory(Categories categories, IDbTransaction? trans = null)
        {
            using (SQLiteConnection connection = dataManager.GetConnection(false))
            {
                if (categories.CategoryId == 0L)
                {
                    categories.CategoryId = connection.Query<long>(
                        @"INSERT INTO Categories (CategoryName) 
                          VALUES (@CategoryName); 
                          SELECT last_insert_rowid()", 
                        categories, trans, true, null, null).FirstOrDefault<long>();
                }
            }
        }
    }
}
