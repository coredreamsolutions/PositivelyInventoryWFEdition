namespace PositivelyInventory.Model
{
	public class Inventory
	{
		public long InvId { get; set; }

		public string? CategoryName { get; set; }

		public string? DescriptionName { get; set; }

		public long QtyNeeded { get; set; }

		public long QtyLeftOver { get; set; }
	}
}
