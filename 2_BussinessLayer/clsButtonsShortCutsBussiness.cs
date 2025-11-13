using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BussinessLayer
{
	public class clsButtonsShortCutsBussiness
	{

		public static void DeleteButtonShortcut(string buttonName)
		{
			try
			{
				_3_DataAccessLayer.clsButtonsShortCutsDataAccess.DeleteButtonShortcut(buttonName);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error in DeleteButtonShortcut: {e.Message}");
			}
		}

		public static void SaveButtonShortcut(string buttonName, int ProductID, string productName)
		{
			try
			{
				_3_DataAccessLayer.clsButtonsShortCutsDataAccess.SaveButtonShortcut(buttonName, ProductID, productName);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error in SaveButtonShortcut: {e.Message}");
			}
		}

		public static DataTable GetAllButtonsShortCuts()
		{
			try
			{
				return _3_DataAccessLayer.clsButtonsShortCutsDataAccess.GetAllButtonsShortCuts();
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error in GetAllButtonsShortCuts: {e.Message}");
				return new DataTable(); // Return an empty DataTable in case of error
			}
		}

	}
}
