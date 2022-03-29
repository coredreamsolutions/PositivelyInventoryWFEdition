using PositivelyInventory.Model;

namespace PositivelyInventory.Validators
{
    public class CategoryValidator
    {
		public static CheckResult ValidateSave(Category categoryModel)
		{
			CheckResult checkResult = new CheckResult();

			if (string.IsNullOrWhiteSpace(categoryModel.CategoryName))
			{
				checkResult.AddError("You need to enter a category name.", "CategoryName");
			}

			return checkResult;
		}

		public static CheckResult ValidateDelete(Category categoryModel)
		{
			return CheckResult.Default;
		}
	}
}
