namespace PositivelyInventory.Validators
{
    public class CheckResult
    {
        public static readonly CheckResult Default = new CheckResult();

        public bool Failed => Items.Any((CheckItem i) => i.IsError);

        public List<CheckItem> Items { get; set; }

        public CheckResult()
        {
            Items = new List<CheckItem>();
        }
        public void AddError(string message, string property)
        {
            Items.Add(new CheckItem(true, message, property));
        }
        public void AddWarning(string message, string property)
        {
            Items.Add(new CheckItem(false, message, property));
        }
    }
}
