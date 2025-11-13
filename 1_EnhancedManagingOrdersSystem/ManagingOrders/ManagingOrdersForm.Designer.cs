namespace _1_EnhancedManagingOrdersSystem.ManagingOrders
{
	partial class ManagingOrdersForm
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
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.btnAddNewOrder = new System.Windows.Forms.Button();
			this.cmbOrderBy = new System.Windows.Forms.ComboBox();
			this.lblOrderBy = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbShowBy = new System.Windows.Forms.ComboBox();
			this.rdASC = new System.Windows.Forms.RadioButton();
			this.rdDESC = new System.Windows.Forms.RadioButton();
			this.lblSearchBy = new System.Windows.Forms.Label();
			this.cmbSearchBy = new System.Windows.Forms.ComboBox();
			this.txtSearchBy = new System.Windows.Forms.TextBox();
			this.btnDeleteAllOrders = new System.Windows.Forms.Button();
			this.btnDeleteOrder = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.lblOrdersCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOrders
			// 
			this.dgvOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Location = new System.Drawing.Point(12, 209);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.Size = new System.Drawing.Size(984, 425);
			this.dgvOrders.TabIndex = 0;
			this.dgvOrders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrders_RowHeaderMouseDoubleClick);
			// 
			// btnAddNewOrder
			// 
			this.btnAddNewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAddNewOrder.BackColor = System.Drawing.Color.LightGreen;
			this.btnAddNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewOrder.Location = new System.Drawing.Point(800, 24);
			this.btnAddNewOrder.Name = "btnAddNewOrder";
			this.btnAddNewOrder.Size = new System.Drawing.Size(196, 179);
			this.btnAddNewOrder.TabIndex = 1;
			this.btnAddNewOrder.Text = "اضافه طلب جديد";
			this.btnAddNewOrder.UseVisualStyleBackColor = false;
			this.btnAddNewOrder.Click += new System.EventHandler(this.btnAddNewOrder_Click);
			// 
			// cmbOrderBy
			// 
			this.cmbOrderBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbOrderBy.FormattingEnabled = true;
			this.cmbOrderBy.Location = new System.Drawing.Point(349, 45);
			this.cmbOrderBy.Name = "cmbOrderBy";
			this.cmbOrderBy.Size = new System.Drawing.Size(269, 45);
			this.cmbOrderBy.TabIndex = 2;
			// 
			// lblOrderBy
			// 
			this.lblOrderBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblOrderBy.AutoSize = true;
			this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrderBy.ForeColor = System.Drawing.Color.Black;
			this.lblOrderBy.Location = new System.Drawing.Point(624, 45);
			this.lblOrderBy.Name = "lblOrderBy";
			this.lblOrderBy.Size = new System.Drawing.Size(155, 37);
			this.lblOrderBy.TabIndex = 3;
			this.lblOrderBy.Text = "ترتيب حسب";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(624, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "اضهار حسب";
			// 
			// cmbShowBy
			// 
			this.cmbShowBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbShowBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbShowBy.FormattingEnabled = true;
			this.cmbShowBy.Location = new System.Drawing.Point(26, 97);
			this.cmbShowBy.Name = "cmbShowBy";
			this.cmbShowBy.Size = new System.Drawing.Size(592, 45);
			this.cmbShowBy.TabIndex = 4;
			// 
			// rdASC
			// 
			this.rdASC.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rdASC.AutoSize = true;
			this.rdASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdASC.Location = new System.Drawing.Point(164, 46);
			this.rdASC.Name = "rdASC";
			this.rdASC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdASC.Size = new System.Drawing.Size(131, 41);
			this.rdASC.TabIndex = 6;
			this.rdASC.TabStop = true;
			this.rdASC.Text = "تصاعدي";
			this.rdASC.UseVisualStyleBackColor = true;
			// 
			// rdDESC
			// 
			this.rdDESC.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rdDESC.AutoSize = true;
			this.rdDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdDESC.Location = new System.Drawing.Point(26, 46);
			this.rdDESC.Name = "rdDESC";
			this.rdDESC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdDESC.Size = new System.Drawing.Size(106, 41);
			this.rdDESC.TabIndex = 7;
			this.rdDESC.TabStop = true;
			this.rdDESC.Text = "تنازلي";
			this.rdDESC.UseVisualStyleBackColor = true;
			// 
			// lblSearchBy
			// 
			this.lblSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblSearchBy.AutoSize = true;
			this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearchBy.ForeColor = System.Drawing.Color.Black;
			this.lblSearchBy.Location = new System.Drawing.Point(624, 151);
			this.lblSearchBy.Name = "lblSearchBy";
			this.lblSearchBy.Size = new System.Drawing.Size(138, 37);
			this.lblSearchBy.TabIndex = 9;
			this.lblSearchBy.Text = "بحث حسب";
			// 
			// cmbSearchBy
			// 
			this.cmbSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSearchBy.FormattingEnabled = true;
			this.cmbSearchBy.Location = new System.Drawing.Point(349, 149);
			this.cmbSearchBy.Name = "cmbSearchBy";
			this.cmbSearchBy.Size = new System.Drawing.Size(269, 45);
			this.cmbSearchBy.TabIndex = 8;
			// 
			// txtSearchBy
			// 
			this.txtSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearchBy.Location = new System.Drawing.Point(26, 152);
			this.txtSearchBy.Name = "txtSearchBy";
			this.txtSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtSearchBy.Size = new System.Drawing.Size(317, 44);
			this.txtSearchBy.TabIndex = 10;
			this.txtSearchBy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchBy_MouseClick);
			// 
			// btnDeleteAllOrders
			// 
			this.btnDeleteAllOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteAllOrders.BackColor = System.Drawing.Color.Red;
			this.btnDeleteAllOrders.Location = new System.Drawing.Point(871, 660);
			this.btnDeleteAllOrders.Name = "btnDeleteAllOrders";
			this.btnDeleteAllOrders.Size = new System.Drawing.Size(125, 44);
			this.btnDeleteAllOrders.TabIndex = 11;
			this.btnDeleteAllOrders.Text = "حذف جميع الطلبات";
			this.btnDeleteAllOrders.UseVisualStyleBackColor = false;
			this.btnDeleteAllOrders.Click += new System.EventHandler(this.btnDeleteAllOrders_Click);
			// 
			// btnDeleteOrder
			// 
			this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteOrder.BackColor = System.Drawing.Color.Gold;
			this.btnDeleteOrder.Location = new System.Drawing.Point(740, 660);
			this.btnDeleteOrder.Name = "btnDeleteOrder";
			this.btnDeleteOrder.Size = new System.Drawing.Size(125, 44);
			this.btnDeleteOrder.TabIndex = 12;
			this.btnDeleteOrder.Text = "حذف الطلب المحدد";
			this.btnDeleteOrder.UseVisualStyleBackColor = false;
			this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnPrint.BackColor = System.Drawing.Color.Moccasin;
			this.btnPrint.Location = new System.Drawing.Point(12, 640);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(129, 84);
			this.btnPrint.TabIndex = 13;
			this.btnPrint.Text = "طباعه";
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRefresh.BackColor = System.Drawing.Color.Moccasin;
			this.btnRefresh.Location = new System.Drawing.Point(198, 640);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(129, 84);
			this.btnRefresh.TabIndex = 14;
			this.btnRefresh.Text = "تحديث";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// lblOrdersCount
			// 
			this.lblOrdersCount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblOrdersCount.AutoSize = true;
			this.lblOrdersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrdersCount.ForeColor = System.Drawing.Color.Black;
			this.lblOrdersCount.Location = new System.Drawing.Point(490, 640);
			this.lblOrdersCount.Name = "lblOrdersCount";
			this.lblOrdersCount.Size = new System.Drawing.Size(29, 20);
			this.lblOrdersCount.TabIndex = 15;
			this.lblOrdersCount.Text = "00";
			// 
			// ManagingOrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(177)))), ((int)(((byte)(130)))));
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.lblOrdersCount);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnDeleteOrder);
			this.Controls.Add(this.btnDeleteAllOrders);
			this.Controls.Add(this.txtSearchBy);
			this.Controls.Add(this.lblSearchBy);
			this.Controls.Add(this.cmbSearchBy);
			this.Controls.Add(this.rdDESC);
			this.Controls.Add(this.rdASC);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbShowBy);
			this.Controls.Add(this.lblOrderBy);
			this.Controls.Add(this.cmbOrderBy);
			this.Controls.Add(this.btnAddNewOrder);
			this.Controls.Add(this.dgvOrders);
			this.Name = "ManagingOrdersForm";
			this.Text = "Managing Orders";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ManagingOrdersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrders;
		private System.Windows.Forms.Button btnAddNewOrder;
		private System.Windows.Forms.ComboBox cmbOrderBy;
		private System.Windows.Forms.Label lblOrderBy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbShowBy;
		private System.Windows.Forms.RadioButton rdASC;
		private System.Windows.Forms.RadioButton rdDESC;
		private System.Windows.Forms.Label lblSearchBy;
		private System.Windows.Forms.ComboBox cmbSearchBy;
		private System.Windows.Forms.TextBox txtSearchBy;
		private System.Windows.Forms.Button btnDeleteAllOrders;
		private System.Windows.Forms.Button btnDeleteOrder;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label lblOrdersCount;
	}
}