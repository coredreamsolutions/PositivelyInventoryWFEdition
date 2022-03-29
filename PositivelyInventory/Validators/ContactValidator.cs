using PositivelyInventory.Model;

namespace PositivelyInventory.Validators
{
    public class ContactValidator
    {
		public static CheckResult ValidateSave(Contact contactModel)
		{
			CheckResult checkResult = new CheckResult();

			if (string.IsNullOrWhiteSpace(contactModel.FirstName))
			{
				checkResult.AddError("You need to enter a first name.", "FirstName");
			}

			if (string.IsNullOrWhiteSpace(contactModel.MobileNumber))
			{
				checkResult.AddError("You need to enter a Mobile Number.", "MobileNumber");
			}

			return checkResult;
		}

		public static CheckResult ValidateDelete(Contact contactModel)
		{
			return CheckResult.Default;
		}
	}
}
