using System;
using System.Data;
using System.Data.SqlClient;

namespace _3_DataAccessLayer
{
	public class clsOrdersDataAccess
	{
		private static string ConnectionString = clsDataAccessMethods.ConnectionString;

		public static int GettMaxOrderID()
		{
			int identityValue = 0;
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = "SELECT ISNULL(IDENT_CURRENT('OrdersTable'), 0)";
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						con.Open();
						identityValue = Convert.ToInt32(cmd.ExecuteScalar());
					}
				}
			}
			catch (Exception ex)
			{
				// Consider logging the exception here as needed.
				Console.WriteLine($"Error fetching identity value: {ex.Message}");
			}
			return identityValue;
		}

		public static bool InsertOrder(string customerName, string customerPhone, string deliveryLocation,
	string notes, DateTime orderDate, DateTime deliveryDate, int orderStatus, bool mortgageStatus,
	decimal mortgagePaid, decimal productsPaid, decimal totalPaid, decimal totalRequired,
	decimal requiredMortgage, decimal requiredProducts)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
                INSERT INTO [dbo].[OrdersTable]
                ([اسم العميل], [رقم هاتف العميل], [مكان التوصيل], [ملاحظات], 
                 [تاريخ الطلب], [تاريخ تسليم الطلب], [حاله الطلب], [حاله الرهن],
                 [قيمه الرهن المطلوب], [قيمه المدفوع للرهن], [قيمه المنتجات المطلوبه], 
                 [قيمه المدفوع للمنتجات], [قيمه المبلغ المدفوع الكلي], [قيمه المبلغ المطلوب])
                VALUES 
                (@CustomerName, @CustomerPhone, @DeliveryLocation, @Notes,
                 @OrderDate, @DeliveryDate, @OrderStatus, @MortgageStatus,
                 @RequiredMortgage, @MortgagePaid, @RequiredProducts, 
                 @ProductsPaid, @TotalPaid, @TotalRequired)";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@CustomerName", customerName);
						cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
						cmd.Parameters.AddWithValue("@DeliveryLocation", deliveryLocation);
						cmd.Parameters.AddWithValue("@Notes", notes);
						cmd.Parameters.AddWithValue("@OrderDate", orderDate);
						cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
						cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
						cmd.Parameters.AddWithValue("@MortgageStatus", mortgageStatus);
						cmd.Parameters.AddWithValue("@RequiredMortgage", requiredMortgage);
						cmd.Parameters.AddWithValue("@MortgagePaid", mortgagePaid);
						cmd.Parameters.AddWithValue("@RequiredProducts", requiredProducts);
						cmd.Parameters.AddWithValue("@ProductsPaid", productsPaid);
						cmd.Parameters.AddWithValue("@TotalPaid", totalPaid);
						cmd.Parameters.AddWithValue("@TotalRequired", totalRequired);

						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error inserting order: {ex.Message}");
				return false;
			}
		}


		public static bool UpdateOrder(int orderId, string customerName, string customerPhone, string deliveryLocation,
	string notes, DateTime orderDate, DateTime deliveryDate, int orderStatus, bool mortgageStatus,
	decimal mortgagePaid, decimal productsPaid, decimal totalPaid, decimal totalRequired,
	decimal requiredMortgage, decimal requiredProducts)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
            UPDATE [dbo].[OrdersTable]
            SET [اسم العميل] = @CustomerName,
                [رقم هاتف العميل] = @CustomerPhone,
                [مكان التوصيل] = @DeliveryLocation,
                [ملاحظات] = @Notes,
                [تاريخ الطلب] = @OrderDate,
                [تاريخ تسليم الطلب] = @DeliveryDate,
                [حاله الطلب] = @OrderStatus,
                [حاله الرهن] = @MortgageStatus,
                [قيمه الرهن المطلوب] = @RequiredMortgage,
                [قيمه المدفوع للرهن] = @MortgagePaid,
                [قيمه المنتجات المطلوبه] = @RequiredProducts,
                [قيمه المدفوع للمنتجات] = @ProductsPaid,
                [قيمه المبلغ المدفوع الكلي] = @TotalPaid,
                [قيمه المبلغ المطلوب] = @TotalRequired
            WHERE [معرف الطلب] = @OrderId";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);
						cmd.Parameters.AddWithValue("@CustomerName", customerName);
						cmd.Parameters.AddWithValue("@CustomerPhone", customerPhone);
						cmd.Parameters.AddWithValue("@DeliveryLocation", deliveryLocation);
						cmd.Parameters.AddWithValue("@Notes", notes);
						cmd.Parameters.AddWithValue("@OrderDate", orderDate);
						cmd.Parameters.AddWithValue("@DeliveryDate", deliveryDate);
						cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
						cmd.Parameters.AddWithValue("@MortgageStatus", mortgageStatus);
						cmd.Parameters.AddWithValue("@RequiredMortgage", requiredMortgage);
						cmd.Parameters.AddWithValue("@MortgagePaid", mortgagePaid);
						cmd.Parameters.AddWithValue("@RequiredProducts", requiredProducts);
						cmd.Parameters.AddWithValue("@ProductsPaid", productsPaid);
						cmd.Parameters.AddWithValue("@TotalPaid", totalPaid);
						cmd.Parameters.AddWithValue("@TotalRequired", totalRequired);

						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error updating order: {ex.Message}");
				return false;
			}
		}


		public static bool DeleteOrder(int orderId)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"DELETE FROM [dbo].[OrdersTable] WHERE [معرف الطلب] = @OrderId";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);

						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error deleting order: {ex.Message}");
				return false;
			}
		}



		public static bool InsertOrderDetail(int orderId, int productId, string productName,
			decimal productPrice, decimal mortgageValue, int quantity, decimal unitPrice)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
						INSERT INTO [dbo].[OrderDetailsTable]
						([رقم الطلب], [رقم المنتج], [اسم المنتج], [سعر المنتج], 
						 [قيمه الرهن], [الكميه], [سعر الوحده])
						VALUES 
						(@OrderId, @ProductId, @ProductName, @ProductPrice,
						 @MortgageValue, @Quantity, @UnitPrice)";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);
						cmd.Parameters.AddWithValue("@ProductId", productId);
						cmd.Parameters.AddWithValue("@ProductName", productName);
						cmd.Parameters.AddWithValue("@ProductPrice", productPrice);
						cmd.Parameters.AddWithValue("@MortgageValue", mortgageValue);
						cmd.Parameters.AddWithValue("@Quantity", quantity);
						cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error inserting order detail: {ex.Message}");
				return false;
			}
		}


		public static bool DeleteAllOrderDetails(int orderId)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"DELETE FROM [dbo].[OrderDetailsTable] WHERE [رقم الطلب] = @OrderId";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);

						con.Open();
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error deleting all order details for order: {ex.Message}");
				return false;
			}
		}

		public static bool DeleteCompleteOrder(int orderId)
		{
			try
			{
				bool areOrderDetailsDeleted = DeleteAllOrderDetails(orderId);

				bool isOrderDeleted = DeleteOrder(orderId);



				if (isOrderDeleted && areOrderDetailsDeleted)
				{
					return true;
				}
				else
				{
					Console.WriteLine("Failed to delete order or its details.");
					return false;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error deleting complete order: {ex.Message}");
				return false;
			}
		}

		public static DataTable GetAllOrders()
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
            SELECT
                t.[معرف الطلب],
                t.[اسم العميل],
                t.[رقم هاتف العميل],
                t.[مكان التوصيل],
                t.[ملاحظات],
                t.[تاريخ الطلب],
                t.[تاريخ تسليم الطلب],
                CASE t.[حاله الطلب]
                    WHEN 0 THEN N'قيد التسليم'
                    WHEN 1 THEN N'مكتمل'
                    WHEN 2 THEN N'ملغي'
                    ELSE N'غير معروف'
                END AS [حاله الطلب],
                t.[حاله الرهن],
                t.[قيمه الرهن المطلوب],
                t.[قيمه المدفوع للرهن],
                t.[قيمه المنتجات المطلوبه],
                t.[قيمه المدفوع للمنتجات],
                t.[قيمه المبلغ المدفوع الكلي],
                t.[قيمه المبلغ المطلوب]
            FROM [dbo].[OrdersTable] AS t;";
					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						con.Open();
						new SqlDataAdapter(cmd).Fill(dt);
					}
				}
			}
			catch (Exception ex)
			{
				// Consider logging the exception here as needed.
				Console.WriteLine($"Error fetching orders: {ex.Message}");
			}
			return dt;
		}

		public static bool GetOrderInfo(int orderId, ref string customerName, ref string customerPhone,
			ref string deliveryLocation, ref string notes, ref DateTime orderDate, ref DateTime deliveryDate,
			ref int orderStatus, ref bool mortgageStatus, ref decimal mortgagePaid, ref decimal productsPaid,
			ref decimal totalPaid, ref decimal totalRequired, ref decimal requiredMortgage, ref decimal requiredProducts,
			ref DataTable orderDetails)
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					con.Open();
					
					// Get order header information
					const string orderSQL = @"
            SELECT [اسم العميل], [رقم هاتف العميل], [مكان التوصيل], [ملاحظات],
                   [تاريخ الطلب], [تاريخ تسليم الطلب], [حاله الطلب], [حاله الرهن],
                   [قيمه الرهن المطلوب], [قيمه المدفوع للرهن], [قيمه المنتجات المطلوبه],
                   [قيمه المدفوع للمنتجات], [قيمه المبلغ المدفوع الكلي], [قيمه المبلغ المطلوب]
            FROM [dbo].[OrdersTable] 
            WHERE [معرف الطلب] = @OrderId";

					using (SqlCommand cmd = new SqlCommand(orderSQL, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);
						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							if (reader.Read())
							{
								customerName = reader["اسم العميل"].ToString();
								customerPhone = reader["رقم هاتف العميل"].ToString();
								deliveryLocation = reader["مكان التوصيل"].ToString();
								notes = reader["ملاحظات"].ToString();
								orderDate = Convert.ToDateTime(reader["تاريخ الطلب"]);
								deliveryDate = Convert.ToDateTime(reader["تاريخ تسليم الطلب"]);
								orderStatus = Convert.ToInt32(reader["حاله الطلب"]);
								mortgageStatus = Convert.ToBoolean(reader["حاله الرهن"]);

								// Note the correct column names from database
								requiredMortgage = Convert.ToDecimal(reader["قيمه الرهن المطلوب"]);
								mortgagePaid = Convert.ToDecimal(reader["قيمه المدفوع للرهن"]);
								requiredProducts = Convert.ToDecimal(reader["قيمه المنتجات المطلوبه"]);
								productsPaid = Convert.ToDecimal(reader["قيمه المدفوع للمنتجات"]);
								totalPaid = Convert.ToDecimal(reader["قيمه المبلغ المدفوع الكلي"]);
								totalRequired = Convert.ToDecimal(reader["قيمه المبلغ المطلوب"]);
							}
							else
							{
								return false; // Order not found
							}
						}
					}

					// Get order details
					orderDetails = GetOrderDetails(orderId);

					if (orderDetails == null)
					{
						return false;
					}

					return true; // Successfully retrieved order info
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error getting order info: {ex.Message}");
				return false;
			}
		}

		public static DataTable GetOrderDetails(int orderId)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
                SELECT *
                FROM [dbo].[OrderDetailsTable] 
                WHERE [رقم الطلب] = @OrderId
               ";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@OrderId", orderId);
						con.Open();
						new SqlDataAdapter(cmd).Fill(dt);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error getting order details: {ex.Message}");
			}
			return dt;
		}


		public static bool DeleteAllOrders()
		{
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					con.Open();

					// Delete from child table
					using (SqlCommand cmd = new SqlCommand("DELETE FROM OrderDetailsTable;", con))
					{
						cmd.ExecuteNonQuery();
					}

					// Reset identity for child table
					using (SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT ('OrderDetailsTable', RESEED, 0);", con))
					{
						cmd.ExecuteNonQuery();
					}

					// Delete from parent table
					using (SqlCommand cmd = new SqlCommand("DELETE FROM OrdersTable;", con))
					{
						cmd.ExecuteNonQuery();
					}

					// Reset identity for parent table
					using (SqlCommand cmd = new SqlCommand("DBCC CHECKIDENT ('OrdersTable', RESEED, 0);", con))
					{
						cmd.ExecuteNonQuery();
					}

					return true; // if all commands executed without exception
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error deleting all orders: {ex.Message}");
				return false;
			}
		}


		public static DataTable GetProductQuantitiesByDateRange(DateTime fromDate, DateTime toDate)
		{
			DataTable dt = new DataTable();
			try
			{
				using (SqlConnection con = new SqlConnection(ConnectionString))
				{
					const string sql = @"
                SELECT 
                    [رقم المنتج],
                    [اسم المنتج],
                    SUM(الكميه) AS اجمالي_الكميه
                FROM 
                    OrderDetailsTable
                WHERE 
                    [رقم الطلب] IN (
                        SELECT [معرف الطلب] 
                        FROM OrdersTable 
                        WHERE [حاله الطلب] = 0 
                        AND [تاريخ تسليم الطلب] BETWEEN @FromDate AND @ToDate
                    )
                GROUP BY 
                    [رقم المنتج], [اسم المنتج];";

					using (SqlCommand cmd = new SqlCommand(sql, con))
					{
						cmd.Parameters.AddWithValue("@FromDate", fromDate);
						cmd.Parameters.AddWithValue("@ToDate", toDate);

						con.Open();
						new SqlDataAdapter(cmd).Fill(dt);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching product quantities by date range: {ex.Message}");
			}
			return dt;
		}


	}
}
