namespace PositivelyInventory.Model
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }

}
