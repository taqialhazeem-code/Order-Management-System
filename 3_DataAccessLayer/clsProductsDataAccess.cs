using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _3_DataAccessLayer
{
    public class clsProductsDataAccess
    {
        private static string ConnectionString = clsDataAccessMethods.ConnectionString;


        public static DataTable GetProductById(int productId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductsTable WHERE [معرف المنتج] = @ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception as needed
                throw;
            }
            return dt;
		}

		public static DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductsTable", con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception as needed
                throw;
            }
            return dt;
        }

        public static bool InsertProduct(string productName, decimal productPrice, decimal productPawnValue)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    string query = @"INSERT INTO [dbo].[ProductsTable]
                         ([اسم المنتج], [سعر المنتج], [قيمه رهن المنتج])
                         VALUES (@ProductName, @ProductPrice, @ProductPawnValue)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                        cmd.Parameters.AddWithValue("@ProductPawnValue", productPawnValue);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception as needed
                throw;
            }
        }

        public static bool EditProduct(int productId, string productName, decimal productPrice, decimal productPawnValue)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    string query = @"UPDATE [dbo].[ProductsTable]
                         SET [اسم المنتج] = @ProductName,
                             [سعر المنتج] = @ProductPrice,
                             [قيمه رهن المنتج] = @ProductPawnValue
                         WHERE [معرف المنتج] = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
                        cmd.Parameters.AddWithValue("@ProductPawnValue", productPawnValue);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception as needed
                throw;
            }
        }

        public static bool DeleteProduct(int productId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    string query = @"DELETE FROM [dbo].[ProductsTable]
                         WHERE [معرف المنتج] = @ProductID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productId);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception as needed
                throw;
            }
        }
    }
}
