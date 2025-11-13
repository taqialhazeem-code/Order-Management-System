using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_EnhancedManagingOrdersSystem._Managing_Products;
using _1_EnhancedManagingOrdersSystem.GetProductQuantitiesByDateRange;

namespace _1_EnhancedManagingOrdersSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ادارهالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManagingProducts frm = new frmManagingProducts();

            frm.ShowDialog();

        }

		private void شاشاهاضافهالطلباتToolStripMenuItem_Click(object sender, EventArgs e)
		{
            ManagingOrders.ManagingOrdersForm frm = new ManagingOrders.ManagingOrdersForm();
            frm.ShowDialog();
		}

		private void الحصولعلىكمياتالمنتجاتحسبنطاقالتاريخToolStripMenuItem_Click(object sender, EventArgs e)
		{

            frmGetProductQuantitiesByDateRange frm = new frmGetProductQuantitiesByDateRange();
            frm.ShowDialog();


		}
	}
}
