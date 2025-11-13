using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_EnhancedManagingOrdersSystem.Utilties.CustomDateTimePicker;
using _2_BussinessLayer;

namespace _1_EnhancedManagingOrdersSystem.GetProductQuantitiesByDateRange
{
	public partial class frmGetProductQuantitiesByDateRange : Form
	{
		public frmGetProductQuantitiesByDateRange()
		{
			InitializeComponent();
		}





		private void DateTimePickerConfigration()
		{
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd hh:mm tt";
			dateTimePicker2.Format = DateTimePickerFormat.Custom;
			dateTimePicker2.CustomFormat = "yyyy-MM-dd hh:mm tt";

			dateTimePicker1.RightToLeft = RightToLeft.Yes;
			dateTimePicker2.RightToLeft = RightToLeft.Yes;

			
		}

		private void DataGridViewConfigration()
		{
			// Basic appearance
			dataGridView1.AutoGenerateColumns = true;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.MultiSelect = false;
			dataGridView1.ReadOnly = true;
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, GraphicsUnit.Point);

			// Optional: alternate row color
			dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

			// Optional: column header style
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
			dataGridView1.EnableHeadersVisualStyles = false;
		}

		private void LoadData()
		{ 
		
			DateTimePickerConfigration();
			DataGridViewConfigration();

		}


		private void frmGetProductQuantitiesByDateRange_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
		{

			DateTimePicker dt = sender as DateTimePicker;

			frmCustomDateTimePicker frm = new frmCustomDateTimePicker();

			frm.ShowDialog();

			
			dt.Value = frm.SelectedDateTime;
			


		}

		private void button1_Click(object sender, EventArgs e)
		{


			try
			{ 
			
				dataGridView1.DataSource = clsOrdersBussiness.GetProductQuantitiesByDateRange(dateTimePicker1.Value, dateTimePicker2.Value);

			}
			catch (Exception ex)
			{
				MessageBox.Show("حدث خطأ أثناء الحصول على كميات المنتجات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{

		    Utilties.PrintMethods.clsPrintMethods.PrintQuantityReportIn80mmThermalPrinter(dateTimePicker1.Value, dateTimePicker2.Value);

		}
	}
}
