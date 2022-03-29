// SimpleInv.ExtentionMethods
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public static class ExtentionMethods
{
	public static List<T> GetChecked<T>(this CheckedListBox box)
	{
		IEnumerable<int> enumerable = box.CheckedIndices.Cast<int>();
		List<T> list = new List<T>();
		List<T> list2 = (List<T>)box.Tag;
		foreach (int item in enumerable)
		{
			list.Add(list2[item]);
		}
		return list;
	}

	public static void TryShowPopup(this Form form, string property)
	{
		Control[] array = form.Controls.Find(property, true);
		if (array != null && array.Length > 0)
		{
			if (array[0] is ComboBox)
			{
				ComboBox comboBox = array[0] as ComboBox;
				comboBox.DroppedDown = true;
			}
			else
			{
				Control control = array[0];
				control.Select();
			}
		}
	}

	public static DateTime ToEndDay(this DateTime date)
	{
		return date.Date.AddSeconds(86399.0);
	}

	public static object GetRow(this DataGridView grid, int rowIndex)
	{
		if (rowIndex < 0 || grid.Rows.Count <= 0)
		{
			return null;
		}
		return grid.Rows[rowIndex].DataBoundItem;
	}

	public static T GetRow<T>(this DataGridView grid, int rowIndex) where T : class
	{
		if (rowIndex < 0 || grid.Rows.Count <= 0)
		{
			return null;
		}
		return (T)grid.Rows[rowIndex].DataBoundItem;
	}

	public static void SetDataSource<T>(this CheckedListBox box, List<T> dataSource)
	{
		box.Tag = dataSource;
		dataSource.ForEach(delegate (T d)
		{
			box.Items.Add(d);
		});
	}
}
