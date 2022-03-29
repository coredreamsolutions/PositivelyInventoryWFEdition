namespace PositivelyInventory.Validators
{
    public class CheckItem
    {
		public bool IsError { get; set; }

		public string Message { get; set; }

		public string Property { get; set; }

		public CheckItem(bool isError, string msg, string prop)
		{
			IsError = isError;
			Message = msg;
			Property = prop;
		}
	}
}
