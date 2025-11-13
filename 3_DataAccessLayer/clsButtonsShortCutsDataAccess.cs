using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _3_DataAccessLayer
{
	public class clsButtonsShortCutsDataAccess
	{

		private static string ConnectionString = clsDataAccessMethods.ConnectionString;


		public static void DeleteButtonShortcut(string buttonName)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					string query = "DELETE FROM [dbo].[ButtonsShortCutsTable] WHERE [ButtonName] = @ButtonName";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@ButtonName", buttonName);
						con.Open();
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error deleting button shortcut: {e.Message}");
			}
		}

		public static void SaveButtonShortcut(string buttonName, int ProductID, string productName)
		{

			try
			{

				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					string query = @"
                INSERT INTO [dbo].[ButtonsShortCutsTable] ([ButtonName], [ProductID], [ProductName])
                VALUES (@ButtonName, @ProductID, @ProductName)";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						cmd.Parameters.AddWithValue("@ButtonName", buttonName);
						cmd.Parameters.AddWithValue("@ProductID", ProductID);
						cmd.Parameters.AddWithValue("@ProductName", productName);

						con.Open();
						cmd.ExecuteNonQuery();
					}
				}

			}
			catch (Exception e)
			
			{
			
				Console.WriteLine($"Error saving button shortcut: {e.Message}");

			}

		}


		public static DataTable GetAllButtonsShortCuts()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					string query = "SELECT * FROM [dbo].[ButtonsShortCutsTable]";
					using (SqlCommand cmd = new SqlCommand(query, con))
					{
						con.Open();
						new SqlDataAdapter(cmd).Fill(dt);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching button shortcuts: {ex.Message}");
			}
			return dt;
		}

	}
}
