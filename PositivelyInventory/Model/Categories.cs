using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivelyInventory.Model
{
    public class Categories
    {
        public long CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
