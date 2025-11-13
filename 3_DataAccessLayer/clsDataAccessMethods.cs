using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace _3_DataAccessLayer
{
	public class clsDataAccessMethods
	{
		private static string _connectionString;

		public static string ConnectionString
		{
			get
			{
				if (string.IsNullOrEmpty(_connectionString))
				{
					// Path to your Desktop connection file
					string filePath = Path.Combine(
						Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
						"ConnectionString.txt"
					);

					if (!File.Exists(filePath))
						throw new FileNotFoundException("Connection string file not found: " + filePath);

					_connectionString = File.ReadAllText(filePath).Trim();
				}

				return _connectionString;
			}
		}
	}
}
