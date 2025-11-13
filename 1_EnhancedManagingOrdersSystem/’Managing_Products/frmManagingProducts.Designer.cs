namespace _1_EnhancedManagingOrdersSystem._Managing_Products
{
    partial class frmManagingProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dgvProducts = new System.Windows.Forms.DataGridView();
			this.lblPrice = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtMortgage = new System.Windows.Forms.TextBox();
			this.lblMortgageValue = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProducts
			// 
			this.dgvProducts.AllowUserToAddRows = false;
			this.dgvProducts.AllowUserToDeleteRows = false;
			this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProducts.Location = new System.Drawing.Point(8, 6);
			this.dgvProducts.Name = "dgvProducts";
			this.dgvProducts.ReadOnly = true;
			this.dgvProducts.Size = new System.Drawing.Size(859, 384);
			this.dgvProducts.TabIndex = 0;
			this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
			this.dgvProducts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_RowHeaderMouseDoubleClick);
			// 
			// lblPrice
			// 
			this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPrice.AutoSize = true;
			this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrice.Location = new System.Drawing.Point(777, 495);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPrice.Size = new System.Drawing.Size(83, 37);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "السعر";
			// 
			// txtPrice
			// 
			this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(543, 489);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPrice.Size = new System.Drawing.Size(225, 44);
			this.txtPrice.TabIndex = 2;
			this.txtPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMortgage_MouseClick);
			// 
			// txtName
			// 
			this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(543, 419);
			this.txtName.Name = "txtName";
			this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtName.Size = new System.Drawing.Size(225, 44);
			this.txtName.TabIndex = 4;
			this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMortgage_MouseClick);
			// 
			// lblName
			// 
			this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(786, 426);
			this.lblName.Name = "lblName";
			this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblName.Size = new System.Drawing.Size(74, 37);
			this.lblName.TabIndex = 3;
			this.lblName.Text = "الاسم";
			// 
			// txtMortgage
			// 
			this.txtMortgage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMortgage.Location = new System.Drawing.Point(543, 559);
			this.txtMortgage.Name = "txtMortgage";
			this.txtMortgage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtMortgage.Size = new System.Drawing.Size(225, 44);
			this.txtMortgage.TabIndex = 6;
			this.txtMortgage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMortgage_MouseClick);
			// 
			// lblMortgageValue
			// 
			this.lblMortgageValue.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMortgageValue.AutoSize = true;
			this.lblMortgageValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMortgageValue.Location = new System.Drawing.Point(777, 565);
			this.lblMortgageValue.Name = "lblMortgageValue";
			this.lblMortgageValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblMortgageValue.Size = new System.Drawing.Size(84, 37);
			this.lblMortgageValue.TabIndex = 5;
			this.lblMortgageValue.Text = "الرهن";
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnSave.BackColor = System.Drawing.Color.LightGreen;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(18, 402);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(139, 61);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "حفظ";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(18, 552);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(139, 61);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "حذف";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Location = new System.Drawing.Point(18, 477);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(139, 61);
			this.btnEdit.TabIndex = 9;
			this.btnEdit.Text = "تعديل";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnClear.BackColor = System.Drawing.Color.Moccasin;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(448, 467);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(72, 105);
			this.btnClear.TabIndex = 10;
			this.btnClear.Text = "مسح";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmManagingProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(177)))), ((int)(((byte)(130)))));
			this.ClientSize = new System.Drawing.Size(874, 621);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtMortgage);
			this.Controls.Add(this.lblMortgageValue);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.dgvProducts);
			this.Name = "frmManagingProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Managing Products";
			this.Load += new System.EventHandler(this.frmManagingProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMortgage;
        private System.Windows.Forms.Label lblMortgageValue;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
    }
}