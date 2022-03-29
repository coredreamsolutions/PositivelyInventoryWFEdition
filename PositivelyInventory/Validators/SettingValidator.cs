using PositivelyInventory.Model;

namespace PositivelyInventory.Validators
{
    public  class SettingValidator
    {
		public static CheckResult ValidateSave(Setting settingModel)
		{
			CheckResult checkResult = new CheckResult();
			if (string.IsNullOrWhiteSpace(settingModel.DatabaseBackupPath))
			{
				checkResult.AddError("You need to enter a valid path.", "DatabaseBackupPath");
			}
		
			return checkResult;
		}

		public static CheckResult ValidateDelete(Setting settingModel)
		{
			return CheckResult.Default;
		}
	}
}
