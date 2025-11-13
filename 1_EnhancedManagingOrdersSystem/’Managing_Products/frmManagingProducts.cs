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
using _2_BussinessLayer;

namespace _1_EnhancedManagingOrdersSystem._Managing_Products
{
    public partial class frmManagingProducts : Form
    {

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>


        private DataView dvProducts;


        private bool isCalledForAddShortCut = false;

        public int SelectedProductId;

        public string SelectedProductName;



        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>


        private void dgvProductsConfigration()
        {
            // Make columns fill the full width
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Right-to-left layout
            dgvProducts.RightToLeft = RightToLeft.Yes;

            // Prevent editing
            dgvProducts.ReadOnly = true;

            // Optional: prevent adding new rows
            dgvProducts.AllowUserToAddRows = false;

            // Optional: prevent deleting rows
            dgvProducts.AllowUserToDeleteRows = false;

            // Optional: prevent resizing
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AllowUserToResizeColumns = false;

            // Optional: make selection full row
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Make text/font bigger
            dgvProducts.Font = new Font(dgvProducts.Font.FontFamily, 14F, FontStyle.Regular); // Increase font size to 14pt
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dgvProducts.Font.FontFamily, 16F, FontStyle.Bold); // Make headers bigger and bold
            dgvProducts.RowHeadersDefaultCellStyle.Font = new Font(dgvProducts.Font.FontFamily, 14F, FontStyle.Regular); // Row headers font

            // 🔹 Make rows bigger to accommodate larger text
            dgvProducts.RowTemplate.Height = 50; // You can increase this number for bigger rows
            dgvProducts.ColumnHeadersHeight = 60; // Increase header height for larger font
            dgvProducts.RowHeadersWidth = 100; // You can increase this value for wider row headers
        }

        private void LoadDataIntodgvProducts()
        {

            try
            {
                DataTable dt = clsProductsBussiness.GetAllProducts();

                dvProducts = new DataView(dt);

                dgvProducts.DataSource = dvProducts;



            }
            catch (Exception ex)
            {

            }


        }

        private void LoadData()
        {

            dgvProductsConfigration();
            LoadDataIntodgvProducts();


        }

        private void ClearControls()
        {

            txtName.Clear();
            txtPrice.Clear();
            txtMortgage.Clear();

        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>


        public frmManagingProducts(bool isCalledForAddShortCuts = false)
        {
            InitializeComponent();

            this.isCalledForAddShortCut = isCalledForAddShortCuts;

        }




        private void frmManagingProducts_Load(object sender, EventArgs e)
        {

            LoadData();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {


                string productsName = txtName.Text.Trim();
                decimal Price;
                decimal.TryParse(txtPrice.Text.Trim(), out Price);
                decimal Mortgage;
                decimal.TryParse(txtMortgage.Text.Trim(), out Mortgage);

                clsProductsBussiness.InsertProduct(productsName, Price, Mortgage);
                LoadDataIntodgvProducts();
                ClearControls();


            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ المنتج: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                int productId = 0;
                int.TryParse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString(), out productId);
                if (productId == 0)
                {
                    MessageBox.Show("يرجى اختيار منتج للحذف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                clsProductsBussiness.DeleteProduct(productId);



                LoadDataIntodgvProducts();
                ClearControls();




            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حذف المنتج: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = 0;
                int.TryParse(dgvProducts.SelectedRows[0].Cells[0].Value.ToString(), out productId);

                if (productId == 0)
                {
                    MessageBox.Show("يرجى اختيار منتج للتعديل.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newproductname = txtName.Text.Trim();
                decimal newPrice;
                decimal.TryParse(txtPrice.Text.Trim(), out newPrice);
                decimal newMortgage;
                decimal.TryParse(txtMortgage.Text.Trim(), out newMortgage);

                clsProductsBussiness.EditProduct(productId, newproductname, newPrice, newMortgage);


                LoadDataIntodgvProducts();
                ClearControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تعديل المنتج: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {

            ClearControls();

        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (isCalledForAddShortCut)
                {
                    if (dgvProducts.SelectedRows.Count > 0)
                    {
                        DataRow dataRow = ((DataRowView)dgvProducts.SelectedRows[0].DataBoundItem).Row;

                        SelectedProductId = Convert.ToInt32(dataRow["معرف المنتج"]);
                        SelectedProductName = dataRow["اسم المنتج"].ToString();

                        // Close this form with OK result if called for shortcut selection
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                else
                {
                    if (dgvProducts.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                        // Using the correct column indices based on database structure
                        txtName.Text = selectedRow.Cells[1].Value.ToString(); // اسم المنتج
                        txtPrice.Text = selectedRow.Cells[2].Value.ToString(); // سعر المنتج
                        txtMortgage.Text = selectedRow.Cells[3].Value.ToString(); // قيمه رهن المنتج
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtMortgage_MouseClick(object sender, MouseEventArgs e)
        {

            var TextBox = sender as TextBox;

            frmKeyboard keyboardForm = new frmKeyboard(TextBox.Text);
            keyboardForm.ShowDialog();
           
            TextBox.Text = keyboardForm._text;
			
           
        }

    }
}
