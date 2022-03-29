namespace PositivelyInventory.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public long ProductNumber { get; set; }
        public string? ProductName { get; set; }
        public Category? Category { get; set; }
    }
}
