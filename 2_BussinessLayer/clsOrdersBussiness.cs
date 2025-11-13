using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _3_DataAccessLayer;

namespace _2_BussinessLayer
{
	public class clsOrdersBussiness
	{

		public static int GetMaxOrderID()
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.GettMaxOrderID();
		}
		public static DataTable GetAllOrders()
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.GetAllOrders();
		}

		public static bool InsertOrder(string customerName, string customerPhone, string deliveryLocation,
	string notes, DateTime orderDate, DateTime deliveryDate, int orderStatus, bool mortgageStatus,
	decimal mortgagePaid, decimal productsPaid, decimal totalPaid, decimal totalRequired,
	decimal requiredMortgage, decimal requiredProducts)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.InsertOrder(customerName, customerPhone, deliveryLocation,
				notes, orderDate, deliveryDate, orderStatus, mortgageStatus, 
				mortgagePaid, productsPaid, totalPaid, totalRequired,
				requiredMortgage, requiredProducts);
		}

		public static bool UpdateOrder(int orderId, string customerName, string customerPhone, string deliveryLocation,
			string notes, DateTime orderDate, DateTime deliveryDate, int orderStatus, bool mortgageStatus,
			decimal mortgagePaid, decimal productsPaid, decimal totalPaid, decimal totalRequired,
			decimal requiredMortgage, decimal requiredProducts)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.UpdateOrder(orderId, customerName, customerPhone, deliveryLocation,
				notes, orderDate, deliveryDate, orderStatus, mortgageStatus, 
				mortgagePaid, productsPaid, totalPaid, totalRequired,
				requiredMortgage, requiredProducts);
		}

		public static bool DeleteOrder(int orderId)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.DeleteOrder(orderId);
		}

		public static bool InsertOrderDetail(int orderId, int productId, string productName,
			decimal productPrice, decimal mortgageValue, int quantity, decimal unitPrice)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.InsertOrderDetail(orderId, productId, productName,
				productPrice, mortgageValue, quantity, unitPrice);
		}

		public static bool DeleteAllOrderDetails(int orderId)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.DeleteAllOrderDetails(orderId);
		}

		public static bool DeleteCompleteOrder(int orderId)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.DeleteCompleteOrder(orderId);
		}

		public static bool GetOrderInfo(int orderId, ref string customerName, ref string customerPhone,
			ref string deliveryLocation, ref string notes, ref DateTime orderDate, ref DateTime deliveryDate,
			ref int orderStatus, ref bool mortgageStatus, ref decimal mortgagePaid, ref decimal productsPaid,
			ref decimal totalPaid, ref decimal totalRequired, ref decimal requiredMortgage, ref decimal requiredProducts, 
			ref DataTable orderDetails)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.GetOrderInfo(orderId, ref customerName, ref customerPhone,
				ref deliveryLocation, ref notes, ref orderDate, ref deliveryDate, ref orderStatus, ref mortgageStatus,
				ref mortgagePaid, ref productsPaid, ref totalPaid, ref totalRequired, 
				ref requiredMortgage, ref requiredProducts, ref orderDetails);
		}

		public static bool DeleteCompleteOrderDetails(int orderId)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.DeleteCompleteOrder(orderId);
		}


		public static bool DeleteAllOrders()
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.DeleteAllOrders();
		}

		public static DataTable GetProductQuantitiesByDateRange(DateTime startDate, DateTime endDate)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.GetProductQuantitiesByDateRange(startDate, endDate);
		}

	}
}
