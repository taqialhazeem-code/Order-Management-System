using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_EnhancedManagingOrdersSystem._Managing_Products;
using _1_EnhancedManagingOrdersSystem.Utilties.CustomDateTimePicker;
using _1_EnhancedManagingOrdersSystem.Utilties.Keyboard_And_Numpad.KeyBoard;
using _1_EnhancedManagingOrdersSystem.Utilties.PrintMethods;
using _2_BussinessLayer;

namespace _1_EnhancedManagingOrdersSystem.frmManagingOrderDetails
{
	public partial class frmManagingOrderDetails : Form
	{

		/// <summary>
		/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// </summary>


		Button CurrentButton;
		int OrderToUpdate = -1;

		private void InitializeButtonsClicks()
        {
			button1.Click += AllButtons_Click;
			button2.Click += AllButtons_Click;
			button3.Click += AllButtons_Click;
			button4.Click += AllButtons_Click;
			button5.Click += AllButtons_Click;
			button6.Click += AllButtons_Click;
			button7.Click += AllButtons_Click;
			button8.Click += AllButtons_Click;
			button9.Click += AllButtons_Click;
			button10.Click += AllButtons_Click;
			button11.Click += AllButtons_Click;
			button12.Click += AllButtons_Click;

            // Use MouseEnter instead of Enter
            button1.MouseEnter += SaveCurrentButton;
            button2.MouseEnter += SaveCurrentButton;
            button3.MouseEnter += SaveCurrentButton;
            button4.MouseEnter += SaveCurrentButton;
            button5.MouseEnter += SaveCurrentButton;
            button6.MouseEnter += SaveCurrentButton;
            button7.MouseEnter += SaveCurrentButton;
            button8.MouseEnter += SaveCurrentButton;
            button9.MouseEnter += SaveCurrentButton;
            button10.MouseEnter += SaveCurrentButton;
            button11.MouseEnter += SaveCurrentButton;
            button12.MouseEnter += SaveCurrentButton;

			



			for (int i = 0; i < 12; i++)
            {
                Button button = (Button)this.Controls["button" + (i + 1)];

                button.Text = "";


			}


		}

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public frmManagingOrderDetails(int OrderToUpdate = -1)
		{
			InitializeComponent();

			
            InitializeButtonsClicks();

            if (OrderToUpdate != -1)
            {

                txtOrderID.Text = OrderToUpdate.ToString();

				this.OrderToUpdate = OrderToUpdate;

				btnAddNewOrderOrUpdateOrderAndPrint.Text = "تحديث الطلب مع طباعه";
				btnAddNewOrderOrUpdateOrder.Text = "تحديث الطلب";

			}
            else
            {

				txtOrderID.Text = (clsOrdersBussiness.GetMaxOrderID() + 1).ToString();
                btnAddNewOrderOrUpdateOrderAndPrint.Text = "إضافة طلب مع طباعه";
				btnAddNewOrderOrUpdateOrder.Text = "إضافة طلب";


			}


              
            

		}

		/// <summary>
		/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// </summary>

        private void LoadAllButtonsShortCuts()
        {
            try
            {
                // Get all button shortcuts from database
                DataTable dt = _2_BussinessLayer.clsButtonsShortCutsBussiness.GetAllButtonsShortCuts();

                foreach (DataRow row in dt.Rows)
                {
                    string btnName = row["ButtonName"].ToString(); // This contains the button name from database
                    if (int.TryParse(row["ProductID"].ToString(), out int productId))
                    {
                        // Find all buttons on the form
                        Button[] buttons = { button1, button2, button3, button4, button5, button6, 
                                           button7, button8, button9, button10, button11, button12 };
                        
                        // Find the button that matches the Name property
                        Button btn = buttons.FirstOrDefault(b => b.Name == btnName);
                        if (btn != null)
                        {
                            // Save the product id into the button's Tag property
                            btn.Tag = productId;
                            // Update the button text with the product name
                            btn.Text = row["ProductName"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or log exception appropriately
                MessageBox.Show("Error loading button shortcuts: " + ex.Message);
            }
		}

		private void LoadCustomizationIntodgvOrderDetails()
		{
			var g = dgvOrderDetails;

			g.AutoGenerateColumns = false;
			g.Columns.Clear();

			// Right-to-left and read-only
			g.RightToLeft = RightToLeft.Yes;
			g.ReadOnly = true;
			g.EditMode = DataGridViewEditMode.EditProgrammatically;
			g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			g.MultiSelect = false;

			// Lock everything down
			g.AllowUserToAddRows = false;
			g.AllowUserToDeleteRows = false;
			g.AllowUserToOrderColumns = false;
			g.AllowUserToResizeRows = false;
			g.AllowUserToResizeColumns = false;
			g.RowTemplate.Resizable = DataGridViewTriState.False;
			g.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			g.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

			// Bigger row + header
			g.RowTemplate.Height = 60;   // Row height
			g.ColumnHeadersHeight = 70;  // Header height
			g.RowHeadersWidth = 80;      // Make row header wider

			// Center text
			g.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


			// Example: make font bigger and use an Arabic-friendly font
			g.DefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Regular);

			// Also update column headers
			g.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

			// Optional: Right-to-Left support for Arabic layout
			g.RightToLeft = RightToLeft.Yes;

			g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


			// Columns
			g.Columns.Add("InvoiceId", "معرف الفاتوره");
			g.Columns.Add("OrderId", "رقم الطلب");
			g.Columns.Add("ProductId", "رقم المنتج");
			g.Columns.Add("ProductName", "اسم المنتج");
			g.Columns.Add("ProductPrice", "سعر المنتج");
			g.Columns.Add("MortgageValue", "قيمه الرهن");
			g.Columns.Add("Quantity", "الكميه");
			g.Columns.Add("UnitPrice", "سعر الوحده");

			// Hide the ones you don’t want the user to see
			g.Columns["InvoiceId"].Visible = false;
			g.Columns["OrderId"].Visible = false;
			g.Columns["ProductId"].Visible = false;
		}

		private void ForceAllRowsHeight()
		{
			foreach (DataGridViewRow row in dgvOrderDetails.Rows)
			{
				if (!row.IsNewRow) // Don't set height for the "new row" if AllowUserToAddRows is true
				{
					row.Height = 60;
				}
			}
		}

		private void LoadCustomizationIntoDateTimePicker()
    {
         // Set the format to display the date in a specific way
         dtpOrderDate.Format = DateTimePickerFormat.Custom;
         dtpOrderDate.CustomFormat = "yyyy-MM-dd hh:mm tt"; // Example format
         dtpOrderDate.RightToLeft = RightToLeft.Yes; // Right-to-left layout

	}


		private void LoadDeffaltValuesIntoControls()
		{
			try
			{
				if (OrderToUpdate == -1)
				{
					chkTheMortgageIsReturned.Checked = false;
					rdOnDelivery.Checked = true; // Default to "On Delivery"

					UpdatePriceList();

				}
				else
				{
					// Declare variables for order information
					string customerName = "";
					string customerPhone = "";
					string deliveryLocation = "";
					string notes = "";
					DateTime orderDate = DateTime.MinValue;
					DateTime deliveryDate = DateTime.MinValue;
					int orderStatus = 0;
					bool mortgageStatus = false;
					decimal mortgagePaid = 0;
					decimal productsPaid = 0;
					decimal totalPaid = 0;
					decimal totalRequired = 0;
					decimal requiredMortgage = 0;  // New variable
					decimal requiredProducts = 0;   // New variable
					DataTable orderDetails = null;

					// Get order information from database
					bool orderFound = clsOrdersBussiness.GetOrderInfo(OrderToUpdate,
						ref customerName, ref customerPhone, ref deliveryLocation, ref notes,
						ref orderDate, ref deliveryDate, ref orderStatus, ref mortgageStatus,
						ref mortgagePaid, ref productsPaid, ref totalPaid, ref totalRequired,
						ref requiredMortgage, ref requiredProducts, ref orderDetails);

					if (orderFound)
					{
						// Load order header information into controls
						txtCustomerName.Text = customerName;
						txtCustomerPhoneNumber.Text = customerPhone;
						txtDeliveryLocation.Text = deliveryLocation;
						txtNotes.Text = notes;
						dtpOrderDate.Value = orderDate;
						dtpOrderDate.Value = deliveryDate;

						// Set order status radio buttons
						switch (orderStatus)
						{
							case 0: // تحت التوصيل (On Delivery)
								rdOnDelivery.Checked = true;
								break;
							case 1: // مكتمل (Complete)
								rdComplete.Checked = true;
								break;
							case 2: // ملغي (Cancelled)
								rdCancel.Checked = true;
								break;
							default:
								rdOnDelivery.Checked = true;
								break;
						}

						// Set mortgage status
						chkTheMortgageIsReturned.Checked = mortgageStatus;

						// Load financial information into textboxes
						txtPaidAmountForMortgage.Text = mortgagePaid.ToString();
						txtAmountPaidForProducts.Text = productsPaid.ToString();

						// You may want to display these values in additional textboxes if needed
						// txtRequiredMortgage.Text = requiredMortgage.ToString();
						// txtRequiredProducts.Text = requiredProducts.ToString();

						// Load order details into DataGridView
						if (orderDetails != null && orderDetails.Rows.Count > 0)
						{
							dgvOrderDetails.Rows.Clear();

							foreach (DataRow row in orderDetails.Rows)
							{
								DataGridViewRow dgvRow = new DataGridViewRow();
								dgvRow.CreateCells(dgvOrderDetails);
								dgvRow.Height = 60; // Set row height

								// Map database columns to DataGridView columns
								dgvRow.Cells[0].Value = row["معرف الفاتوره"];    // InvoiceId
								dgvRow.Cells[1].Value = row["رقم الطلب"];           // OrderId
								dgvRow.Cells[2].Value = row["رقم المنتج"];          // ProductId
								dgvRow.Cells[3].Value = row["اسم المنتج"];          // ProductName
								dgvRow.Cells[4].Value = row["سعر المنتج"];          // ProductPrice
								dgvRow.Cells[5].Value = row["قيمه الرهن"];          // MortgageValue
								dgvRow.Cells[6].Value = row["الكميه"];             // Quantity
								dgvRow.Cells[7].Value = row["سعر الوحده"];         // UnitPrice

								dgvOrderDetails.Rows.Add(dgvRow);
							}

							ForceAllRowsHeight(); // Ensure all rows have correct height
						}

						UpdatePriceList();
					}
					else
					{
						MessageBox.Show("Order not found in database.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						this.Close(); // Close form if order not found
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading default values into controls: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		

		private void AddProductIntoDgvOrderDetails(int ProductID)
		{
			try
			{
				DataTable dt = clsProductsBussiness.GetProductByID(ProductID);

				if (dt.Rows.Count > 0)
				{
					DataRow productRow = dt.Rows[0];

					// Extract product information from the database row
					string productName = productRow["اسم المنتج"].ToString();
					decimal productPrice = Convert.ToDecimal(productRow["سعر المنتج"]);
					decimal mortgageValue = Convert.ToDecimal(productRow["قيمه رهن المنتج"]);

					// Generate unique IDs (you might want to implement proper ID generation later)
					int invoiceId = dgvOrderDetails.Rows.Count + 1;
					int orderId ; // This should come from your order form
                    int.TryParse(txtOrderID.Text, out orderId);
					int quantity = 1; // Default quantity
					decimal unitPrice = (productPrice+mortgageValue) * quantity;

					// Check if product already exists in the grid
					bool productExists = false;
					foreach (DataGridViewRow existingRow in dgvOrderDetails.Rows)
					{
						if (existingRow.Cells["ProductId"].Value != null &&
							Convert.ToInt32(existingRow.Cells["ProductId"].Value) == ProductID)
						{
							// Product exists, increase quantity
							int currentQuantity = Convert.ToInt32(existingRow.Cells["Quantity"].Value);
							existingRow.Cells["Quantity"].Value = currentQuantity + 1;
							existingRow.Cells["UnitPrice"].Value = (productPrice + mortgageValue) * (currentQuantity + 1);
							productExists = true;
							break;
						}
					}

					// If product doesn't exist, add new row
					if (!productExists)
					{
						DataGridViewRow row = new DataGridViewRow();
						row.CreateCells(dgvOrderDetails);
						
						// *** IMPORTANT: Set the row height explicitly ***
						row.Height = 60; // Match the RowTemplate.Height

						row.Cells[0].Value = invoiceId;        // معرف الفاتوره
						row.Cells[1].Value = orderId;          // رقم الطلب
						row.Cells[2].Value = ProductID;        // رقم المنتج
						row.Cells[3].Value = productName;      // اسم المنتج
						row.Cells[4].Value = productPrice;     // سعر المنتج
						row.Cells[5].Value = mortgageValue;    // قيمه الرهن
						row.Cells[6].Value = quantity;         // الكميه
						row.Cells[7].Value = unitPrice;        // سعر الوحده

						dgvOrderDetails.Rows.Add(row);
						ForceAllRowsHeight(); // This will ensure all rows have the correct height

						// Optional: Scroll to the newly added row
						if (dgvOrderDetails.Rows.Count > 0)
						{
							dgvOrderDetails.FirstDisplayedScrollingRowIndex = dgvOrderDetails.Rows.Count - 1;
						}
					}
				}
				else
				{
					MessageBox.Show("Product not found in database.", "منتج غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding product to order details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void DeleteProductFromdgvOrderDetails()
        {

            try
            {

				if (dgvOrderDetails.CurrentRow != null)
				{
					dgvOrderDetails.Rows.Remove(dgvOrderDetails.CurrentRow);
				}



			}
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product from order details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}

        private void DeleteAllProductsFromdgvOrderDetails()
        {
            try
            {

               dgvOrderDetails.Rows.Clear(); // Clear all rows from the DataGridView


			}
			catch (Exception ex)
            {
                MessageBox.Show("Error deleting all products from order details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

		private int GetRadioStatus()
		{
			if (rdOnDelivery.Checked)
			{
				return 0; // تحت التوصيل
			}
			else if (rdComplete.Checked)
			{
				return 1; // مكتمل
			}
			else if (rdCancel.Checked)
			{
				return 2; // ملغي
			}
			else
			{
				return -1; // Invalid status
			}
		}


		private decimal CalculateTotalMortgageRequired()
		{
			try
			{
				decimal totalMortgageRequired = 0;

				if (dgvOrderDetails.Rows.Count == 0)
					return totalMortgageRequired;

				foreach (DataGridViewRow row in dgvOrderDetails.Rows)
				{
					if (row.Cells["MortgageValue"].Value != null && row.Cells["Quantity"].Value != null)
					{
						decimal mortgageValue = Convert.ToDecimal(row.Cells["MortgageValue"].Value);
						int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
						totalMortgageRequired += mortgageValue * quantity;
					}
				}
				return totalMortgageRequired;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating total mortgage required: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
		}

		private decimal CalculateTotalProductsRequired()
		{
			try
			{
				decimal totalProductsRequired = 0;

				if(dgvOrderDetails.Rows.Count==0)
					return totalProductsRequired;

				foreach (DataGridViewRow row in dgvOrderDetails.Rows)
				{
					if (row.Cells["ProductPrice"].Value != null && row.Cells["Quantity"].Value != null)
					{
						decimal productPrice = Convert.ToDecimal(row.Cells["ProductPrice"].Value);
						int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
						totalProductsRequired += productPrice * quantity;
					}
				}
				return totalProductsRequired;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error calculating total products required: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
		}

		private DataTable LoadOrderDetailFromDgvOrderDetails()
		{
			try
			{
				DataTable dt = new DataTable();

				// Define columns to match the structure used when loading data
				dt.Columns.Add("معرف تفاصيل الطلب", typeof(int));
				dt.Columns.Add("رقم الطلب", typeof(int));
				dt.Columns.Add("رقم المنتج", typeof(int));
				dt.Columns.Add("اسم المنتج", typeof(string));
				dt.Columns.Add("سعر المنتج", typeof(decimal));
				dt.Columns.Add("قيمه الرهن", typeof(decimal));
				dt.Columns.Add("الكميه", typeof(int));
				dt.Columns.Add("سعر الوحده", typeof(decimal));

				// Loop through the DataGridView rows and populate the DataTable
				foreach (DataGridViewRow dgvRow in dgvOrderDetails.Rows)
				{
					DataRow row = dt.NewRow();

					// Map DataGridView cells to DataTable columns
					row["معرف تفاصيل الطلب"] = Convert.ToInt32(dgvRow.Cells["InvoiceId"].Value);
					row["رقم الطلب"] = Convert.ToInt32(dgvRow.Cells["OrderId"].Value);
					row["رقم المنتج"] = Convert.ToInt32(dgvRow.Cells["ProductId"].Value);
					row["اسم المنتج"] = dgvRow.Cells["ProductName"].Value.ToString();
					row["سعر المنتج"] = Convert.ToDecimal(dgvRow.Cells["ProductPrice"].Value);
					row["قيمه الرهن"] = Convert.ToDecimal(dgvRow.Cells["MortgageValue"].Value);
					row["الكميه"] = Convert.ToInt32(dgvRow.Cells["Quantity"].Value);
					row["سعر الوحده"] = Convert.ToDecimal(dgvRow.Cells["UnitPrice"].Value);

					dt.Rows.Add(row);
				}

				return dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting order details from DataGridView: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null; // Return null to indicate failure
			}
		}


		private void AddNewOrder()
		{
			try
			{
				if (dgvOrderDetails.Rows.Count == 0)
				{
					MessageBox.Show("يجب إضافة منتجات للطلب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Get values from form controls
				string customerName = txtCustomerName.Text.Trim();
				string customerPhone = txtCustomerPhoneNumber.Text.Trim();
				string deliveryLocation = txtDeliveryLocation.Text.Trim();
				string notes = txtNotes.Text.Trim();
				DateTime orderDate = DateTime.Now;
				DateTime deliveryDate = dtpOrderDate.Value; // Using same DateTimePicker for both dates
				int orderStatus = GetRadioStatus();
				bool mortgageStatus = chkTheMortgageIsReturned.Checked;

				// Calculate financial totals from DataGridView
				decimal totalProductsPaid = 0;
				decimal totalMortgagePaid = 0;
				decimal totalPaid = 0;
				decimal totalRequired = 0;
				decimal requiredMortgage = 0;
				decimal requiredProducts = 0;

				// Set default values for text fields
				customerName = string.IsNullOrEmpty(customerName) ? "غير معروف" : customerName;
				customerPhone = string.IsNullOrEmpty(customerPhone) ? "غير معروف" : customerPhone;
				deliveryLocation = string.IsNullOrEmpty(deliveryLocation) ? "غير معروف" : deliveryLocation;
				notes = string.IsNullOrEmpty(notes) ? "لا يوجد ملاحظات" : notes;

				// Parse paid amounts from text fields
				decimal.TryParse(txtPaidAmountForMortgage.Text.Trim(), out totalMortgagePaid);
				decimal.TryParse(txtAmountPaidForProducts.Text.Trim(), out totalProductsPaid);

				// Calculate required amounts
				requiredMortgage = CalculateTotalMortgageRequired();
				requiredProducts = CalculateTotalProductsRequired();

				totalPaid = totalProductsPaid + totalMortgagePaid;
				totalRequired = requiredMortgage + requiredProducts;

				DataTable orderDetails = LoadOrderDetailFromDgvOrderDetails();

				// Insert order with new required values
				bool orderInserted = clsOrdersBussiness.InsertOrder(
					customerName, customerPhone, deliveryLocation, notes,
					orderDate, deliveryDate, orderStatus, mortgageStatus,
					totalMortgagePaid, totalProductsPaid, totalPaid, totalRequired,
					requiredMortgage, requiredProducts);

				if (!orderInserted)
				{
					MessageBox.Show("فشل في إضافة الطلب إلى قاعدة البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				int newOrderId = clsOrdersBussiness.GetMaxOrderID();

				// Insert order details
				foreach (DataGridViewRow row in dgvOrderDetails.Rows)
				{
					if (row.Cells["ProductId"].Value != null)
					{
						int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
						string productName = row.Cells["ProductName"].Value?.ToString() ?? "";
						decimal productPrice = Convert.ToDecimal(row.Cells["ProductPrice"].Value ?? 0);
						decimal mortgageValue = Convert.ToDecimal(row.Cells["MortgageValue"].Value ?? 0);
						int quantity = Convert.ToInt32(row.Cells["Quantity"].Value ?? 1);
						decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value ?? 0);

						bool detailInserted = clsOrdersBussiness.InsertOrderDetail(
							newOrderId, productId, productName, productPrice,
							mortgageValue, quantity, unitPrice);

						if (!detailInserted)
						{
							MessageBox.Show("فشل في إضافة تفاصيل الطلب", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
				}

				
				this.Close(); // Close the form after successful addition

			}
			catch (Exception ex)
			{
				MessageBox.Show("خطأ في إضافة الطلب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateOrder()
		{
			try
			{
				if (OrderToUpdate == -1)
				{
					MessageBox.Show("لا يوجد طلب محدد للتحديث", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				if (dgvOrderDetails.Rows.Count == 0)
				{
					MessageBox.Show("يجب إضافة منتجات للطلب", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// Get values from form controls
				string customerName = txtCustomerName.Text.Trim();
				string customerPhone = txtCustomerPhoneNumber.Text.Trim();
				string deliveryLocation = txtDeliveryLocation.Text.Trim();
				string notes = txtNotes.Text.Trim();
				DateTime orderDate = DateTime.Now;
				DateTime deliveryDate = dtpOrderDate.Value;
				int orderStatus = GetRadioStatus();
				bool mortgageStatus = chkTheMortgageIsReturned.Checked;

				// Calculate financial totals
				decimal totalProductsPaid = 0;
				decimal totalMortgagePaid = 0;
				decimal.TryParse(txtPaidAmountForMortgage.Text.Trim(), out totalMortgagePaid);
				decimal.TryParse(txtAmountPaidForProducts.Text.Trim(), out totalProductsPaid);

				// Set default values for text fields
				customerName = string.IsNullOrEmpty(customerName) ? "غير معروف" : customerName;
				customerPhone = string.IsNullOrEmpty(customerPhone) ? "غير معروف" : customerPhone;
				deliveryLocation = string.IsNullOrEmpty(deliveryLocation) ? "غير معروف" : deliveryLocation;
				notes = string.IsNullOrEmpty(notes) ? "لا يوجد ملاحظات" : notes;

				// Calculate required amounts
				decimal requiredMortgage = CalculateTotalMortgageRequired();
				decimal requiredProducts = CalculateTotalProductsRequired();

				decimal totalPaid = totalProductsPaid + totalMortgagePaid;
				decimal totalRequired = requiredMortgage + requiredProducts;

				// Update the order header with new required values
				bool orderUpdated = clsOrdersBussiness.UpdateOrder(
					OrderToUpdate, customerName, customerPhone, deliveryLocation, notes,
					orderDate, deliveryDate, orderStatus, mortgageStatus,
					totalMortgagePaid, totalProductsPaid, totalPaid, totalRequired,
					requiredMortgage, requiredProducts);

				if (!orderUpdated)
				{
					MessageBox.Show("فشل في تحديث الطلب في قاعدة البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Delete existing order details first
				bool detailsDeleted = clsOrdersBussiness.DeleteAllOrderDetails(OrderToUpdate);
				if (!detailsDeleted)
				{
					MessageBox.Show("فشل في حذف تفاصيل الطلب السابقة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Insert updated order details
				bool allDetailsInserted = true;
				foreach (DataGridViewRow row in dgvOrderDetails.Rows)
				{
					if (row.Cells["ProductId"].Value != null)
					{
						int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
						string productName = row.Cells["ProductName"].Value?.ToString() ?? "";
						decimal productPrice = Convert.ToDecimal(row.Cells["ProductPrice"].Value ?? 0);
						decimal mortgageValue = Convert.ToDecimal(row.Cells["MortgageValue"].Value ?? 0);
						int quantity = Convert.ToInt32(row.Cells["Quantity"].Value ?? 1);
						decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value ?? 0);

						bool detailInserted = clsOrdersBussiness.InsertOrderDetail(
							OrderToUpdate, productId, productName, productPrice,
							mortgageValue, quantity, unitPrice);

						if (!detailInserted)
						{
							allDetailsInserted = false;
							break;
						}
					}
				}

				if (!allDetailsInserted)
				{
					MessageBox.Show("تم تحديث الطلب ولكن فشل في إضافة بعض تفاصيل المنتجات", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					this.Close(); // Close the form after successful update
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("خطأ في تحديث الطلب: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AddAndUpdateOrder()
		{
			try
			{
				if (OrderToUpdate != -1)
				{
					UpdateOrder();
					
				}
				else
				{
					AddNewOrder();
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding/updating order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdatePriceList()
		{

			try
			{ 
			
				decimal PriceForMprtgage = CalculateTotalMortgageRequired();

				decimal PriceForProducts = CalculateTotalProductsRequired();

				decimal TotalPrice = PriceForMprtgage + PriceForProducts;

				txtPriceForMortage.Text = PriceForMprtgage.ToString();
				txtPriceForProducts.Text = PriceForProducts.ToString();
				txtTotalPrice.Text = TotalPrice.ToString();

			}

			catch(Exception ex)
			{
				throw;
				
			}
		
		}

		private void LoadData()
		{



			LoadCustomizationIntodgvOrderDetails();
			LoadCustomizationIntoDateTimePicker();
			LoadAllButtonsShortCuts();
			LoadDeffaltValuesIntoControls();



		}


		/// <summary>
		/// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// </summary>

		private void frmManagingOrderDetails_Load(object sender, EventArgs e)
		{

            LoadData();

		}

		private void AllButtons_Click(object sender, EventArgs e)
		{

            try
            {

				int ProductID = 0;
				if (CurrentButton != null && CurrentButton.Tag != null)
				{
					// Get the ProductID from the button's Tag property
					ProductID = Convert.ToInt32(CurrentButton.Tag);
				}
				
				// Add the product to the DataGridView
				AddProductIntoDgvOrderDetails(ProductID);

				UpdatePriceList(); // Update the price list after adding the product



			}
            catch (Exception ex)
            {
                MessageBox.Show("Error handling button click: " + ex.Message);
			}



		}

        private void SaveCurrentButton(object sender, EventArgs e)
        {
           

            CurrentButton = (Button)sender; // Cast sender to Button


		}

		private void اضافهاختصارToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                if (CurrentButton == null)
                {
                    MessageBox.Show("No button selected to add shortcut.");
                    return;
                }

                if (CurrentButton.Tag != null)
                {
                    MessageBox.Show("This button already has a shortcut assigned.");
                    return;
				}

				frmManagingProducts frm = new frmManagingProducts(true); // Pass true to indicate this is for adding shortcuts

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frm.SelectedProductId > 0 && !string.IsNullOrEmpty(frm.SelectedProductName))
                    {
                        string CurrentButtonName = CurrentButton.Name; // Use Name instead of Text

                        clsButtonsShortCutsBussiness.SaveButtonShortcut(CurrentButtonName, frm.SelectedProductId, frm.SelectedProductName);

                        LoadAllButtonsShortCuts(); // Reload the shortcuts to reflect the change
                       
                    }
                    else
                    {
                        MessageBox.Show("No valid product was selected.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving button shortcut: " + ex.Message);
            }
		}

		private void حذفاختصارToolStripMenuItem_Click(object sender, EventArgs e)
		{

            try
            {

                if (CurrentButton != null)
                {
                    string buttonName = CurrentButton.Name;
                    _2_BussinessLayer.clsButtonsShortCutsBussiness.DeleteButtonShortcut(buttonName);
                    CurrentButton.Tag = null; // Clear the Tag property
                    CurrentButton.Text = "";
                    LoadAllButtonsShortCuts(); // Reload the shortcuts to reflect the change
					MessageBox.Show("Button shortcut deleted successfully.");
                }
                else
                {
                    MessageBox.Show("No button selected to delete shortcut.");
				}


			}
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting button shortcut: " + ex.Message);

            }
        
        }

		private void brnDeleteSelectedProduct_Click(object sender, EventArgs e)
		{

            DeleteProductFromdgvOrderDetails();

			UpdatePriceList(); // Update the price list after deleting the product

		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{

            DeleteAllProductsFromdgvOrderDetails();

			UpdatePriceList(); // Update the price list after deleting all products
		}



		private void btnAddNewOrderOrUpdateOrderAndPrint_Click(object sender, EventArgs e)
		{

			try
			{
				AddAndUpdateOrder();


				int OrderID;

				int.TryParse(txtOrderID.Text, out OrderID);

				Utilties.PrintMethods.clsPrintMethods.PrintOrderDetailsOn80mmThermalPrinter(OrderID);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error handling button click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnAddNewOrderOrUpdateOrder_Click_1(object sender, EventArgs e)
		{
			try
			{
				AddAndUpdateOrder();


				int OrderID;

				int.TryParse(txtOrderID.Text, out OrderID);

				

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error handling button click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void frmManagingOrderDetails_MouseClick(object sender, MouseEventArgs e)
		{
			try
			{
				var TextBox = sender as TextBox;


				if (TextBox == txtCustomerPhoneNumber)
				{

					Numpad numpad = new Numpad(txtCustomerPhoneNumber.Text);
					numpad.ShowDialog();

					TextBox.Text = numpad.NumpadValue;

					return;
				}

				frmKeyboard keyboardForm = new frmKeyboard(TextBox.Text);
				keyboardForm.ShowDialog();

				TextBox.Text = keyboardForm._text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error handling mouse click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtPaidAmountForMortgage_MouseClick(object sender, MouseEventArgs e)
		{


			TextBox TextBox = sender as TextBox;

			Numpad numpad = new Numpad(TextBox.Text);
			numpad.ShowDialog();
			if (decimal.TryParse(numpad.NumpadValue, out decimal result))
			{
				TextBox.Text = result.ToString();
			}
			

		}

		private void dtpOrderDate_MouseDown(object sender, MouseEventArgs e)
		{
			frmCustomDateTimePicker frm = new frmCustomDateTimePicker();
			frm.ShowDialog();
			dtpOrderDate.Value = frm.SelectedDateTime;
		}

		private void btnFastPaid_Click(object sender, EventArgs e)
		{


			txtAmountPaidForProducts.Text = txtPriceForProducts.Text;
		
			txtPaidAmountForMortgage.Text = txtPriceForMortage.Text;

		}

		
	}
}









