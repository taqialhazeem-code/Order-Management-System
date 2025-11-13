using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BussinessLayer
{
    public class clsProductsBussiness
    {

        public static DataTable GetProductByID(int productId)
        {
            return _3_DataAccessLayer.clsProductsDataAccess.GetProductById(productId);
		}


		public static DataTable GetAllProducts()
        {
            return _3_DataAccessLayer.clsProductsDataAccess.GetAllProducts();
        }

        public static bool InsertProduct(string productName, decimal productPrice, decimal productPawnValue)
        {
            return _3_DataAccessLayer.clsProductsDataAccess.InsertProduct(productName, productPrice, productPawnValue);
        }

        public static bool EditProduct(int productId, string productName, decimal productPrice, decimal productPawnValue)
        {
            return _3_DataAccessLayer.clsProductsDataAccess.EditProduct(productId, productName, productPrice, productPawnValue);
        }

        public static bool DeleteProduct(int productId)
        {
            return _3_DataAccessLayer.clsProductsDataAccess.DeleteProduct(productId);
        }

		public static bool GetOrderInfo(int orderId, ref string customerName, ref string customerPhone,
	ref string deliveryLocation, ref string notes, ref DateTime orderDate, ref DateTime deliveryDate,
	ref int orderStatus, ref bool mortgageStatus, ref decimal mortgagePaid, ref decimal productsPaid,
	ref decimal totalPaid, ref decimal totalRequired, ref decimal requiredMortgage, ref decimal requiredProducts, DataTable orderDetails)
		{
			return _3_DataAccessLayer.clsOrdersDataAccess.GetOrderInfo(orderId, ref customerName, ref customerPhone,
				ref deliveryLocation, ref notes, ref orderDate, ref deliveryDate, ref orderStatus, ref mortgageStatus,
				ref mortgagePaid, ref productsPaid, ref totalPaid, ref totalRequired, ref  requiredMortgage, ref requiredProducts ,ref orderDetails);
		}

	}
}
