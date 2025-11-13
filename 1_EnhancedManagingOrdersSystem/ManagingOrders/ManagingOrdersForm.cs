using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_EnhancedManagingOrdersSystem.Utilties.Keyboard_And_Numpad.KeyBoard;
using _1_EnhancedManagingOrdersSystem.Utilties.PrintMethods;
using _2_BussinessLayer;

namespace _1_EnhancedManagingOrdersSystem.ManagingOrders
{
	public partial class ManagingOrdersForm : Form
	{
		public ManagingOrdersForm()
		{
			InitializeComponent();

			// Wire up event handlers for automatic filtering
			cmbOrderBy.SelectedIndexChanged += (s, e) => ApplyFilters();
			cmbShowBy.SelectedIndexChanged += (s, e) => ApplyFilters();
			cmbSearchBy.SelectedIndexChanged += (s, e) => ApplyFilters();
			txtSearchBy.TextChanged += (s, e) => ApplyFilters();
			rdASC.CheckedChanged += (s, e) => ApplyFilters();
			rdDESC.CheckedChanged += (s, e) => ApplyFilters();
		}

		/// <summary>
		/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// </summary>

		private DataView dvOrders;



		private void UpdateLabelOrdersCount()
		{
			if (dvOrders != null)
			{
				lblOrdersCount.Text = $"عدد الطلبات: {dvOrders.Count}";
			}
			else
			{
				lblOrdersCount.Text = "عدد الطلبات: 0";
			}
		}

		private void LoadDataIntoComboBoxes()
		{
			try
			{
				// Load Order By options (for sorting)
				cmbOrderBy.Items.Clear();
				cmbOrderBy.Items.Add("معرف الطلب");
				cmbOrderBy.Items.Add("اسم العميل");
				cmbOrderBy.Items.Add("تاريخ الطلب");
				cmbOrderBy.Items.Add("تاريخ تسليم الطلب");
				cmbOrderBy.Items.Add("حاله الطلب");
				cmbOrderBy.Items.Add("قيمه المبلغ المطلوب");
				cmbOrderBy.SelectedIndex = 0; // Default selection
				cmbOrderBy.RightToLeft = RightToLeft.Yes; // Right-to-left layout for Arabic
				cmbOrderBy.DropDownStyle = ComboBoxStyle.DropDownList; // Make it a dropdown list

				// Load Show By options (for filtering display)
				cmbShowBy.Items.Clear();
				cmbShowBy.Items.Add("جميع الطلبات");
				cmbShowBy.Items.Add("قيد التسليم");
				cmbShowBy.Items.Add("مكتمل");
				cmbShowBy.Items.Add("ملغي");
				cmbShowBy.Items.Add("الرهن مُسترد");
				cmbShowBy.Items.Add("الرهن غير مُسترد");
				cmbShowBy.Items.Add("طلبات غير مسددة بالكامل للمنتجات");
				cmbShowBy.Items.Add("طلبات غير مسددة بالكامل للرهن");// NEW OPTION: Orders not fully paid
				cmbShowBy.Items.Add("طلبات غير مسددة بالكامل");
				cmbShowBy.SelectedIndex = 0; // Default to show all orders
				cmbShowBy.RightToLeft = RightToLeft.Yes; // Right-to-left layout for Arabic
				cmbShowBy.DropDownStyle = ComboBoxStyle.DropDownList; // Make it a dropdown list

				// Load Search By options (for search criteria)
				cmbSearchBy.Items.Clear();
				cmbSearchBy.Items.Add("معرف الطلب");
				cmbSearchBy.Items.Add("اسم العميل");
				cmbSearchBy.Items.Add("رقم هاتف العميل");
				cmbSearchBy.Items.Add("مكان التوصيل");
				cmbSearchBy.Items.Add("حاله الطلب");
				cmbSearchBy.SelectedIndex = 0; // Default search by order ID
				cmbSearchBy.RightToLeft = RightToLeft.Yes; // Right-to-left layout for Arabic
				cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList; // Make it a dropdown list
			}
			catch (Exception)
			{
				MessageBox.Show("Error loading data into combo boxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvOrdersConfigration()
		{
			// Right-to-left layout
			dgvOrders.RightToLeft = RightToLeft.Yes;

			// Prevent editing
			dgvOrders.ReadOnly = true;

			// Optional: prevent adding new rows
			dgvOrders.AllowUserToAddRows = false;

			// Optional: prevent deleting rows
			dgvOrders.AllowUserToDeleteRows = false;

			// Optional: prevent resizing
			dgvOrders.AllowUserToResizeRows = false;
			dgvOrders.AllowUserToResizeColumns = false;

			// Optional: make selection full row
			dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


			dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

			dgvOrders.RowTemplate.Height = 40;

			dgvOrders.RowHeadersWidth = 100;

		}


		private void ApplyFilters()
		{
			try
			{
				if (dvOrders == null)
					return;

				// Start with no filter
				string filterExpression = "";
				List<string> filters = new List<string>();

				// Apply Show By filter (filtering display)
				if (cmbShowBy.SelectedIndex > 0) // Skip "جميع الطلبات" (Show All)
				{
					string showByFilter = cmbShowBy.SelectedItem.ToString();
					switch (showByFilter)
					{
						case "قيد التسليم":
							filters.Add("[حاله الطلب] = 'قيد التسليم'");
							break;
						case "مكتمل":
							filters.Add("[حاله الطلب] = 'مكتمل'");
							break;
						case "ملغي":
							filters.Add("[حاله الطلب] = 'ملغي'");
							break;
						case "الرهن مُسترد":
							filters.Add("[حاله الرهن] = True");
							break;
						case "الرهن غير مُسترد":
							filters.Add("[حاله الرهن] = False");
							break;
						case "طلبات غير مسددة بالكامل للمنتجات": // NEW FILTER: Orders not fully paid
							filters.Add("[قيمه المنتجات المطلوبه] > [قيمه المدفوع للمنتجات]");
							break;
						case "طلبات غير مسددة بالكامل للرهن": // NEW FILTER: Orders not fully paid
							filters.Add("[قيمه الرهن المطلوب] > [قيمه المدفوع للرهن]");
							break;
						case "طلبات غير مسددة بالكامل": // NEW FILTER: Orders not fully paid
							filters.Add("[قيمه المبلغ المطلوب] > [قيمه المبلغ المدفوع الكلي]");
							break;
					}
				}

				// Apply Search filter
				if (!string.IsNullOrWhiteSpace(txtSearchBy.Text) && cmbSearchBy.SelectedIndex >= 0)
				{
					string searchValue = txtSearchBy.Text.Trim();
					string searchColumn = cmbSearchBy.SelectedItem.ToString();

					switch (searchColumn)
					{
						case "معرف الطلب":
							if (int.TryParse(searchValue, out int orderId))
							{
								filters.Add($"[معرف الطلب] = {orderId}");
							}
							break;
						case "اسم العميل":
							filters.Add($"[اسم العميل] LIKE '%{searchValue}%'");
							break;
						case "رقم هاتف العميل":
							filters.Add($"[رقم هاتف العميل] LIKE '%{searchValue}%'");
							break;
						case "مكان التوصيل":
							filters.Add($"[مكان التوصيل] LIKE '%{searchValue}%'");
							break;
						case "حاله الطلب":
							filters.Add($"[حاله الطلب] LIKE '%{searchValue}%'");
							break;
					}
				}

				// Combine all filters with AND
				if (filters.Count > 0)
				{
					filterExpression = string.Join(" AND ", filters);
				}

				// Apply the filter
				dvOrders.RowFilter = filterExpression;

				// Apply sorting (Order By)
				if (cmbOrderBy.SelectedIndex >= 0)
				{
					string sortColumn = cmbOrderBy.SelectedItem.ToString();
					string sortDirection = rdASC.Checked ? "ASC" : "DESC"; // radioButton1 = تصاعدي, radioButton2 = تنازلي

					dvOrders.Sort = $"[{sortColumn}] {sortDirection}";
				}

				UpdateLabelOrdersCount();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error applying filters: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadDataIntoDgvOrders()
		{
			try
			{
				DataTable dt = clsOrdersBussiness.GetAllOrders();
				dvOrders = new DataView(dt);
				dgvOrders.DataSource = dvOrders;
				ApplyFilters();
			}
			catch (Exception)
			{
			}
		}

		private int GetSelectedOrderId()
		{
			try

			{  if (dgvOrders.SelectedRows.Count > 0)
				{
					return Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["معرف الطلب"].Value);
				}
				else
				{
					return -1; // No row selected
				}
			}
			catch (Exception)
			{
				return -1; // Error in getting selected order ID
			}
		}

		

		private void LoadData()
		{
			dgvOrdersConfigration();
			LoadDataIntoDgvOrders();
			LoadDataIntoComboBoxes();
			rdASC.Checked = true; // Default to ascending order

		}

		/// <summary>
		/// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		/// </summary>

		private void ManagingOrdersForm_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnAddNewOrder_Click(object sender, EventArgs e)
		{

			frmManagingOrderDetails.frmManagingOrderDetails frm = new frmManagingOrderDetails.frmManagingOrderDetails();
			frm.ShowDialog();
			LoadDataIntoDgvOrders();

		}

		private void dgvOrders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			int OrderID = GetSelectedOrderId();	

			
			
				frmManagingOrderDetails.frmManagingOrderDetails frm = new frmManagingOrderDetails.frmManagingOrderDetails(OrderID);
				frm.ShowDialog();
				LoadDataIntoDgvOrders();
			
			



		}

		private void btnDeleteOrder_Click(object sender, EventArgs e)
		{
			try
			{
				int orderID = GetSelectedOrderId();

				if (orderID == -1)
				{
					return;
				}

				// First confirmation
				var result1 = MessageBox.Show(
					"هل أنت متأكد أنك تريد حذف هذا الطلب؟",
					"تأكيد الحذف",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result1 != DialogResult.Yes)
				{
					return;
				}

				// Second confirmation
				var result2 = MessageBox.Show(
					"سيتم حذف الطلب نهائياً ولا يمكن استرجاعه. هل تريد المتابعة؟",
					"تأكيد نهائي",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result2 != DialogResult.Yes)
				{
					return;
				}

				clsOrdersBussiness.DeleteCompleteOrder(orderID);

				LoadDataIntoDgvOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeleteAllOrders_Click(object sender, EventArgs e)
		{
			try
			{
				// Confirmation 1
				var result1 = MessageBox.Show(
					"هل أنت متأكد من حذف جميع الطلبات؟",
					"تأكيد الحذف",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result1 != DialogResult.Yes)
					return;

				// Confirmation 2
				var result2 = MessageBox.Show(
					"سيتم حذف جميع الطلبات نهائياً ولا يمكن استرجاعها. هل تريد المتابعة؟",
					"تأكيد نهائي",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result2 != DialogResult.Yes)
					return;

				// Confirmation 3
				var result3 = MessageBox.Show(
					"تنبيه: حذف جميع الطلبات سيؤثر على جميع السجلات المرتبطة بها. هل أنت متأكد أنك تريد الاستمرار؟",
					"تنبيه هام",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result3 != DialogResult.Yes)
					return;

				// Confirmation 4
				var result4 = MessageBox.Show(
					"آخر تأكيد: هل تريد فعلاً حذف جميع الطلبات؟",
					"تأكيد أخير",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Warning);

				if (result4 != DialogResult.Yes)
					return;

				clsOrdersBussiness.DeleteAllOrders();
				LoadDataIntoDgvOrders();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting all orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtSearchBy_MouseClick(object sender, MouseEventArgs e)
		{
			var TextBox = sender as TextBox;

			frmKeyboard keyboardForm = new frmKeyboard(TextBox.Text);
			keyboardForm.ShowDialog();

			TextBox.Text = keyboardForm._text;


		}

		private void btnPrint_Click(object sender, EventArgs e)
		{

			try
			{ 
				
				int OrderID = GetSelectedOrderId();

				if (OrderID == -1)
				{
					MessageBox.Show("يرجى تحديد طلب للطباعة.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				clsPrintMethods.PrintOrderDetailsOn80mmThermalPrinter(OrderID);


			}
			catch (Exception ex)
			{
				MessageBox.Show("Error printing orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{

			LoadDataIntoDgvOrders();


		}
	}
}
