namespace PositivelyInventory.Model
{
	public class Mail
	{
		public long MailId { get; set; }

		public string HostName { get; set; }

		public long HostPort { get; set; }

		public string SenderName { get; set; }

		public string AddressTo { get; set; }

		public string UserName { get; set; }

		public string UserPassword { get; set; }

		public string DefaultSubject { get; set; }

		public string DefaultMessage { get; set; }
	}
}
