namespace _1_EnhancedManagingOrdersSystem.frmManagingOrderDetails
{
	partial class frmManagingOrderDetails
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
			this.components = new System.ComponentModel.Container();
			this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.اضافهاختصارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.حذفاختصارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.lblOrderID = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.lblCustomerName = new System.Windows.Forms.Label();
			this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblDeliveryDate = new System.Windows.Forms.Label();
			this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
			this.txtAmountPaidForProducts = new System.Windows.Forms.TextBox();
			this.lblAmountPaidForProducts = new System.Windows.Forms.Label();
			this.txtPaidAmountForMortgage = new System.Windows.Forms.TextBox();
			this.lblForMortgage = new System.Windows.Forms.Label();
			this.btnAddNewOrderOrUpdateOrderAndPrint = new System.Windows.Forms.Button();
			this.brnDeleteSelectedProduct = new System.Windows.Forms.Button();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			this.chkTheMortgageIsReturned = new System.Windows.Forms.CheckBox();
			this.rdComplete = new System.Windows.Forms.RadioButton();
			this.rdOnDelivery = new System.Windows.Forms.RadioButton();
			this.rdCancel = new System.Windows.Forms.RadioButton();
			this.gBOrderStatus = new System.Windows.Forms.GroupBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDeliveryLocation = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPriceForMortage = new System.Windows.Forms.TextBox();
			this.txtPriceForProducts = new System.Windows.Forms.TextBox();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lblPriceRequredForMortgage = new System.Windows.Forms.Label();
			this.lblPriceRequredForProducts = new System.Windows.Forms.Label();
			this.lblPriceForTotal = new System.Windows.Forms.Label();
			this.lblPriceRequred = new System.Windows.Forms.Label();
			this.btnFastPaid = new System.Windows.Forms.Button();
			this.btnAddNewOrderOrUpdateOrder = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.gBOrderStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOrderDetails
			// 
			this.dgvOrderDetails.AllowUserToAddRows = false;
			this.dgvOrderDetails.AllowUserToDeleteRows = false;
			this.dgvOrderDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetails.Location = new System.Drawing.Point(11, 12);
			this.dgvOrderDetails.Name = "dgvOrderDetails";
			this.dgvOrderDetails.ReadOnly = true;
			this.dgvOrderDetails.Size = new System.Drawing.Size(546, 297);
			this.dgvOrderDetails.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.PaleGreen;
			this.button1.ContextMenuStrip = this.contextMenuStrip1;
			this.button1.Location = new System.Drawing.Point(863, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 69);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهاختصارToolStripMenuItem,
            this.حذفاختصارToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(258, 92);
			// 
			// اضافهاختصارToolStripMenuItem
			// 
			this.اضافهاختصارToolStripMenuItem.Name = "اضافهاختصارToolStripMenuItem";
			this.اضافهاختصارToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
			this.اضافهاختصارToolStripMenuItem.Text = "اضافه اختصار";
			this.اضافهاختصارToolStripMenuItem.Click += new System.EventHandler(this.اضافهاختصارToolStripMenuItem_Click);
			// 
			// حذفاختصارToolStripMenuItem
			// 
			this.حذفاختصارToolStripMenuItem.Name = "حذفاختصارToolStripMenuItem";
			this.حذفاختصارToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
			this.حذفاختصارToolStripMenuItem.Text = "حذف اختصار";
			this.حذفاختصارToolStripMenuItem.Click += new System.EventHandler(this.حذفاختصارToolStripMenuItem_Click);
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.Color.PaleGreen;
			this.button2.ContextMenuStrip = this.contextMenuStrip1;
			this.button2.Location = new System.Drawing.Point(729, 23);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 69);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.BackColor = System.Drawing.Color.PaleGreen;
			this.button3.ContextMenuStrip = this.contextMenuStrip1;
			this.button3.Location = new System.Drawing.Point(596, 23);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 69);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button4.BackColor = System.Drawing.Color.PaleGreen;
			this.button4.ContextMenuStrip = this.contextMenuStrip1;
			this.button4.Location = new System.Drawing.Point(863, 175);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 69);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button5.BackColor = System.Drawing.Color.PaleGreen;
			this.button5.ContextMenuStrip = this.contextMenuStrip1;
			this.button5.Location = new System.Drawing.Point(729, 175);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 69);
			this.button5.TabIndex = 8;
			this.button5.Text = "button5";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button6.BackColor = System.Drawing.Color.PaleGreen;
			this.button6.ContextMenuStrip = this.contextMenuStrip1;
			this.button6.Location = new System.Drawing.Point(595, 175);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(128, 69);
			this.button6.TabIndex = 7;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button7.BackColor = System.Drawing.Color.PaleGreen;
			this.button7.ContextMenuStrip = this.contextMenuStrip1;
			this.button7.Location = new System.Drawing.Point(595, 251);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(128, 69);
			this.button7.TabIndex = 6;
			this.button7.Text = "button7";
			this.button7.UseVisualStyleBackColor = false;
			// 
			// button8
			// 
			this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button8.BackColor = System.Drawing.Color.PaleGreen;
			this.button8.ContextMenuStrip = this.contextMenuStrip1;
			this.button8.Location = new System.Drawing.Point(729, 251);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(128, 69);
			this.button8.TabIndex = 5;
			this.button8.Text = "button8";
			this.button8.UseVisualStyleBackColor = false;
			// 
			// button9
			// 
			this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button9.BackColor = System.Drawing.Color.PaleGreen;
			this.button9.ContextMenuStrip = this.contextMenuStrip1;
			this.button9.Location = new System.Drawing.Point(863, 251);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(128, 69);
			this.button9.TabIndex = 12;
			this.button9.Text = "button9";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// button10
			// 
			this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button10.BackColor = System.Drawing.Color.PaleGreen;
			this.button10.ContextMenuStrip = this.contextMenuStrip1;
			this.button10.Location = new System.Drawing.Point(596, 99);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(128, 69);
			this.button10.TabIndex = 11;
			this.button10.Text = "button10";
			this.button10.UseVisualStyleBackColor = false;
			// 
			// button11
			// 
			this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button11.BackColor = System.Drawing.Color.PaleGreen;
			this.button11.ContextMenuStrip = this.contextMenuStrip1;
			this.button11.Location = new System.Drawing.Point(729, 99);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(128, 69);
			this.button11.TabIndex = 10;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = false;
			// 
			// button12
			// 
			this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button12.BackColor = System.Drawing.Color.PaleGreen;
			this.button12.ContextMenuStrip = this.contextMenuStrip1;
			this.button12.Location = new System.Drawing.Point(863, 99);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(128, 69);
			this.button12.TabIndex = 9;
			this.button12.Text = "button12";
			this.button12.UseVisualStyleBackColor = false;
			// 
			// lblOrderID
			// 
			this.lblOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblOrderID.AutoSize = true;
			this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrderID.Location = new System.Drawing.Point(894, 346);
			this.lblOrderID.Name = "lblOrderID";
			this.lblOrderID.Size = new System.Drawing.Size(83, 25);
			this.lblOrderID.TabIndex = 13;
			this.lblOrderID.Text = "رقم الطلب";
			// 
			// txtOrderID
			// 
			this.txtOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtOrderID.Enabled = false;
			this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrderID.Location = new System.Drawing.Point(599, 327);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtOrderID.Size = new System.Drawing.Size(277, 44);
			this.txtOrderID.TabIndex = 14;
			this.txtOrderID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmManagingOrderDetails_MouseClick);
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerName.Location = new System.Drawing.Point(599, 382);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtCustomerName.Size = new System.Drawing.Size(276, 44);
			this.txtCustomerName.TabIndex = 16;
			this.txtCustomerName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmManagingOrderDetails_MouseClick);
			// 
			// lblCustomerName
			// 
			this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCustomerName.AutoSize = true;
			this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCustomerName.Location = new System.Drawing.Point(894, 398);
			this.lblCustomerName.Name = "lblCustomerName";
			this.lblCustomerName.Size = new System.Drawing.Size(85, 25);
			this.lblCustomerName.TabIndex = 15;
			this.lblCustomerName.Text = "اسم العميل";
			// 
			// txtCustomerPhoneNumber
			// 
			this.txtCustomerPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCustomerPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(599, 437);
			this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
			this.txtCustomerPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(277, 44);
			this.txtCustomerPhoneNumber.TabIndex = 18;
			this.txtCustomerPhoneNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmManagingOrderDetails_MouseClick);
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhoneNumber.Location = new System.Drawing.Point(894, 456);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(86, 25);
			this.lblPhoneNumber.TabIndex = 17;
			this.lblPhoneNumber.Text = "رقم الهاتف";
			// 
			// lblDeliveryDate
			// 
			this.lblDeliveryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblDeliveryDate.AutoSize = true;
			this.lblDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDeliveryDate.Location = new System.Drawing.Point(894, 606);
			this.lblDeliveryDate.Name = "lblDeliveryDate";
			this.lblDeliveryDate.Size = new System.Drawing.Size(102, 25);
			this.lblDeliveryDate.TabIndex = 19;
			this.lblDeliveryDate.Text = "وقت الاستلام";
			// 
			// dtpOrderDate
			// 
			this.dtpOrderDate.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpOrderDate.Location = new System.Drawing.Point(597, 602);
			this.dtpOrderDate.Name = "dtpOrderDate";
			this.dtpOrderDate.Size = new System.Drawing.Size(277, 35);
			this.dtpOrderDate.TabIndex = 20;
			this.dtpOrderDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpOrderDate_MouseDown);
			// 
			// txtAmountPaidForProducts
			// 
			this.txtAmountPaidForProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtAmountPaidForProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmountPaidForProducts.Location = new System.Drawing.Point(755, 647);
			this.txtAmountPaidForProducts.Multiline = true;
			this.txtAmountPaidForProducts.Name = "txtAmountPaidForProducts";
			this.txtAmountPaidForProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtAmountPaidForProducts.Size = new System.Drawing.Size(119, 36);
			this.txtAmountPaidForProducts.TabIndex = 22;
			this.txtAmountPaidForProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPaidAmountForMortgage_MouseClick);
			
			// 
			// lblAmountPaidForProducts
			// 
			this.lblAmountPaidForProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblAmountPaidForProducts.AutoSize = true;
			this.lblAmountPaidForProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAmountPaidForProducts.Location = new System.Drawing.Point(878, 646);
			this.lblAmountPaidForProducts.Name = "lblAmountPaidForProducts";
			this.lblAmountPaidForProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAmountPaidForProducts.Size = new System.Drawing.Size(128, 25);
			this.lblAmountPaidForProducts.TabIndex = 21;
			this.lblAmountPaidForProducts.Text = "المدفوع للمنتجات";
			// 
			// txtPaidAmountForMortgage
			// 
			this.txtPaidAmountForMortgage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPaidAmountForMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaidAmountForMortgage.Location = new System.Drawing.Point(595, 647);
			this.txtPaidAmountForMortgage.Multiline = true;
			this.txtPaidAmountForMortgage.Name = "txtPaidAmountForMortgage";
			this.txtPaidAmountForMortgage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPaidAmountForMortgage.Size = new System.Drawing.Size(101, 35);
			this.txtPaidAmountForMortgage.TabIndex = 24;
			this.txtPaidAmountForMortgage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPaidAmountForMortgage_MouseClick);
			
			// 
			// lblForMortgage
			// 
			this.lblForMortgage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblForMortgage.AutoSize = true;
			this.lblForMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForMortgage.Location = new System.Drawing.Point(700, 647);
			this.lblForMortgage.Name = "lblForMortgage";
			this.lblForMortgage.Size = new System.Drawing.Size(52, 25);
			this.lblForMortgage.TabIndex = 23;
			this.lblForMortgage.Text = "للرهن";
			// 
			// btnAddNewOrderOrUpdateOrderAndPrint
			// 
			this.btnAddNewOrderOrUpdateOrderAndPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAddNewOrderOrUpdateOrderAndPrint.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnAddNewOrderOrUpdateOrderAndPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewOrderOrUpdateOrderAndPrint.Location = new System.Drawing.Point(12, 607);
			this.btnAddNewOrderOrUpdateOrderAndPrint.Name = "btnAddNewOrderOrUpdateOrderAndPrint";
			this.btnAddNewOrderOrUpdateOrderAndPrint.Size = new System.Drawing.Size(118, 111);
			this.btnAddNewOrderOrUpdateOrderAndPrint.TabIndex = 25;
			this.btnAddNewOrderOrUpdateOrderAndPrint.Text = "اضافه طلب مع طباعه";
			this.btnAddNewOrderOrUpdateOrderAndPrint.UseVisualStyleBackColor = false;
			this.btnAddNewOrderOrUpdateOrderAndPrint.Click += new System.EventHandler(this.btnAddNewOrderOrUpdateOrderAndPrint_Click);
			// 
			// brnDeleteSelectedProduct
			// 
			this.brnDeleteSelectedProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.brnDeleteSelectedProduct.BackColor = System.Drawing.Color.Salmon;
			this.brnDeleteSelectedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.brnDeleteSelectedProduct.Location = new System.Drawing.Point(438, 315);
			this.brnDeleteSelectedProduct.Name = "brnDeleteSelectedProduct";
			this.brnDeleteSelectedProduct.Size = new System.Drawing.Size(122, 73);
			this.brnDeleteSelectedProduct.TabIndex = 26;
			this.brnDeleteSelectedProduct.Text = "حذف منتج";
			this.brnDeleteSelectedProduct.UseVisualStyleBackColor = false;
			this.brnDeleteSelectedProduct.Click += new System.EventHandler(this.brnDeleteSelectedProduct_Click);
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnDeleteAll.BackColor = System.Drawing.Color.OrangeRed;
			this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteAll.Location = new System.Drawing.Point(295, 315);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(122, 73);
			this.btnDeleteAll.TabIndex = 27;
			this.btnDeleteAll.Text = "حذف الجميع";
			this.btnDeleteAll.UseVisualStyleBackColor = false;
			this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
			// 
			// chkTheMortgageIsReturned
			// 
			this.chkTheMortgageIsReturned.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chkTheMortgageIsReturned.Appearance = System.Windows.Forms.Appearance.Button;
			this.chkTheMortgageIsReturned.BackColor = System.Drawing.Color.White;
			this.chkTheMortgageIsReturned.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.chkTheMortgageIsReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkTheMortgageIsReturned.Location = new System.Drawing.Point(251, 417);
			this.chkTheMortgageIsReturned.Name = "chkTheMortgageIsReturned";
			this.chkTheMortgageIsReturned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkTheMortgageIsReturned.Size = new System.Drawing.Size(290, 51);
			this.chkTheMortgageIsReturned.TabIndex = 28;
			this.chkTheMortgageIsReturned.Text = "تمت استعاده الرهن";
			this.chkTheMortgageIsReturned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chkTheMortgageIsReturned.UseVisualStyleBackColor = false;
			// 
			// rdComplete
			// 
			this.rdComplete.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rdComplete.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdComplete.BackColor = System.Drawing.Color.White;
			this.rdComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.rdComplete.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdComplete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdComplete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdComplete.Location = new System.Drawing.Point(98, 26);
			this.rdComplete.Name = "rdComplete";
			this.rdComplete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdComplete.Size = new System.Drawing.Size(91, 86);
			this.rdComplete.TabIndex = 29;
			this.rdComplete.TabStop = true;
			this.rdComplete.Tag = "1";
			this.rdComplete.Text = "مكتمل";
			this.rdComplete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdComplete.UseVisualStyleBackColor = false;
			// 
			// rdOnDelivery
			// 
			this.rdOnDelivery.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rdOnDelivery.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdOnDelivery.BackColor = System.Drawing.Color.White;
			this.rdOnDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.rdOnDelivery.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdOnDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdOnDelivery.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdOnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdOnDelivery.Location = new System.Drawing.Point(190, 25);
			this.rdOnDelivery.Name = "rdOnDelivery";
			this.rdOnDelivery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdOnDelivery.Size = new System.Drawing.Size(106, 86);
			this.rdOnDelivery.TabIndex = 30;
			this.rdOnDelivery.TabStop = true;
			this.rdOnDelivery.Tag = "0";
			this.rdOnDelivery.Text = "قيد التنفيذ";
			this.rdOnDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdOnDelivery.UseVisualStyleBackColor = false;
			// 
			// rdCancel
			// 
			this.rdCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rdCancel.Appearance = System.Windows.Forms.Appearance.Button;
			this.rdCancel.BackColor = System.Drawing.Color.White;
			this.rdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.rdCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rdCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdCancel.Location = new System.Drawing.Point(6, 26);
			this.rdCancel.Name = "rdCancel";
			this.rdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdCancel.Size = new System.Drawing.Size(91, 86);
			this.rdCancel.TabIndex = 31;
			this.rdCancel.TabStop = true;
			this.rdCancel.Tag = "2";
			this.rdCancel.Text = "ملغي";
			this.rdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rdCancel.UseVisualStyleBackColor = false;
			// 
			// gBOrderStatus
			// 
			this.gBOrderStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gBOrderStatus.Controls.Add(this.rdCancel);
			this.gBOrderStatus.Controls.Add(this.rdOnDelivery);
			this.gBOrderStatus.Controls.Add(this.rdComplete);
			this.gBOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gBOrderStatus.Location = new System.Drawing.Point(245, 479);
			this.gBOrderStatus.Name = "gBOrderStatus";
			this.gBOrderStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gBOrderStatus.Size = new System.Drawing.Size(303, 122);
			this.gBOrderStatus.TabIndex = 32;
			this.gBOrderStatus.TabStop = false;
			this.gBOrderStatus.Text = "حاله الطلب";
			// 
			// txtNotes
			// 
			this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotes.Location = new System.Drawing.Point(598, 547);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtNotes.Size = new System.Drawing.Size(277, 44);
			this.txtNotes.TabIndex = 34;
			this.txtNotes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmManagingOrderDetails_MouseClick);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(894, 559);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 25);
			this.label1.TabIndex = 33;
			this.label1.Text = "ملاحظات";
			// 
			// txtDeliveryLocation
			// 
			this.txtDeliveryLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDeliveryLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDeliveryLocation.Location = new System.Drawing.Point(599, 492);
			this.txtDeliveryLocation.Name = "txtDeliveryLocation";
			this.txtDeliveryLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtDeliveryLocation.Size = new System.Drawing.Size(277, 44);
			this.txtDeliveryLocation.TabIndex = 36;
			this.txtDeliveryLocation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmManagingOrderDetails_MouseClick);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(894, 504);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 25);
			this.label2.TabIndex = 35;
			this.label2.Text = "مكان التوصيل";
			// 
			// txtPriceForMortage
			// 
			this.txtPriceForMortage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPriceForMortage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPriceForMortage.ForeColor = System.Drawing.Color.Lime;
			this.txtPriceForMortage.Location = new System.Drawing.Point(19, 435);
			this.txtPriceForMortage.Name = "txtPriceForMortage";
			this.txtPriceForMortage.ReadOnly = true;
			this.txtPriceForMortage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPriceForMortage.Size = new System.Drawing.Size(148, 29);
			this.txtPriceForMortage.TabIndex = 38;
			// 
			// txtPriceForProducts
			// 
			this.txtPriceForProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPriceForProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPriceForProducts.ForeColor = System.Drawing.Color.Lime;
			this.txtPriceForProducts.Location = new System.Drawing.Point(19, 391);
			this.txtPriceForProducts.Name = "txtPriceForProducts";
			this.txtPriceForProducts.ReadOnly = true;
			this.txtPriceForProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtPriceForProducts.Size = new System.Drawing.Size(148, 29);
			this.txtPriceForProducts.TabIndex = 40;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.ForeColor = System.Drawing.Color.Lime;
			this.txtTotalPrice.Location = new System.Drawing.Point(19, 479);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtTotalPrice.Size = new System.Drawing.Size(148, 29);
			this.txtTotalPrice.TabIndex = 42;
			// 
			// lblPriceRequredForMortgage
			// 
			this.lblPriceRequredForMortgage.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPriceRequredForMortgage.AutoSize = true;
			this.lblPriceRequredForMortgage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceRequredForMortgage.Location = new System.Drawing.Point(190, 438);
			this.lblPriceRequredForMortgage.Name = "lblPriceRequredForMortgage";
			this.lblPriceRequredForMortgage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPriceRequredForMortgage.Size = new System.Drawing.Size(46, 24);
			this.lblPriceRequredForMortgage.TabIndex = 43;
			this.lblPriceRequredForMortgage.Text = "للرهن";
			// 
			// lblPriceRequredForProducts
			// 
			this.lblPriceRequredForProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPriceRequredForProducts.AutoSize = true;
			this.lblPriceRequredForProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceRequredForProducts.Location = new System.Drawing.Point(173, 396);
			this.lblPriceRequredForProducts.Name = "lblPriceRequredForProducts";
			this.lblPriceRequredForProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPriceRequredForProducts.Size = new System.Drawing.Size(63, 24);
			this.lblPriceRequredForProducts.TabIndex = 44;
			this.lblPriceRequredForProducts.Text = "للمنتجات";
			// 
			// lblPriceForTotal
			// 
			this.lblPriceForTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPriceForTotal.AutoSize = true;
			this.lblPriceForTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceForTotal.Location = new System.Drawing.Point(176, 482);
			this.lblPriceForTotal.Name = "lblPriceForTotal";
			this.lblPriceForTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPriceForTotal.Size = new System.Drawing.Size(60, 24);
			this.lblPriceForTotal.TabIndex = 45;
			this.lblPriceForTotal.Text = "الاجمالي";
			// 
			// lblPriceRequred
			// 
			this.lblPriceRequred.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblPriceRequred.AutoSize = true;
			this.lblPriceRequred.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPriceRequred.Location = new System.Drawing.Point(19, 340);
			this.lblPriceRequred.Name = "lblPriceRequred";
			this.lblPriceRequred.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPriceRequred.Size = new System.Drawing.Size(161, 31);
			this.lblPriceRequred.TabIndex = 46;
			this.lblPriceRequred.Text = "السعر المطلوب";
			// 
			// btnFastPaid
			// 
			this.btnFastPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnFastPaid.BackColor = System.Drawing.Color.Plum;
			this.btnFastPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFastPaid.Location = new System.Drawing.Point(438, 627);
			this.btnFastPaid.Name = "btnFastPaid";
			this.btnFastPaid.Size = new System.Drawing.Size(110, 91);
			this.btnFastPaid.TabIndex = 47;
			this.btnFastPaid.Text = "الدفع السريع";
			this.btnFastPaid.UseVisualStyleBackColor = false;
			this.btnFastPaid.Click += new System.EventHandler(this.btnFastPaid_Click);
			// 
			// btnAddNewOrderOrUpdateOrder
			// 
			this.btnAddNewOrderOrUpdateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAddNewOrderOrUpdateOrder.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnAddNewOrderOrUpdateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewOrderOrUpdateOrder.Location = new System.Drawing.Point(143, 607);
			this.btnAddNewOrderOrUpdateOrder.Name = "btnAddNewOrderOrUpdateOrder";
			this.btnAddNewOrderOrUpdateOrder.Size = new System.Drawing.Size(118, 111);
			this.btnAddNewOrderOrUpdateOrder.TabIndex = 48;
			this.btnAddNewOrderOrUpdateOrder.Text = "اضافه طلب";
			this.btnAddNewOrderOrUpdateOrder.UseVisualStyleBackColor = false;
			this.btnAddNewOrderOrUpdateOrder.Click += new System.EventHandler(this.btnAddNewOrderOrUpdateOrder_Click_1);
			// 
			// frmManagingOrderDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(177)))), ((int)(((byte)(130)))));
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.btnAddNewOrderOrUpdateOrder);
			this.Controls.Add(this.btnFastPaid);
			this.Controls.Add(this.lblPriceRequred);
			this.Controls.Add(this.lblPriceForTotal);
			this.Controls.Add(this.lblPriceRequredForProducts);
			this.Controls.Add(this.lblPriceRequredForMortgage);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.txtPriceForProducts);
			this.Controls.Add(this.txtPriceForMortage);
			this.Controls.Add(this.txtDeliveryLocation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gBOrderStatus);
			this.Controls.Add(this.chkTheMortgageIsReturned);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.brnDeleteSelectedProduct);
			this.Controls.Add(this.btnAddNewOrderOrUpdateOrderAndPrint);
			this.Controls.Add(this.txtPaidAmountForMortgage);
			this.Controls.Add(this.lblForMortgage);
			this.Controls.Add(this.txtAmountPaidForProducts);
			this.Controls.Add(this.lblAmountPaidForProducts);
			this.Controls.Add(this.dtpOrderDate);
			this.Controls.Add(this.lblDeliveryDate);
			this.Controls.Add(this.txtCustomerPhoneNumber);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.lblCustomerName);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.lblOrderID);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvOrderDetails);
			this.Name = "frmManagingOrderDetails";
			this.Text = "Managing Order Details";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmManagingOrderDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.gBOrderStatus.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvOrderDetails;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Label lblOrderID;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label lblCustomerName;
		private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
		private System.Windows.Forms.Label lblPhoneNumber;
		private System.Windows.Forms.Label lblDeliveryDate;
		private System.Windows.Forms.DateTimePicker dtpOrderDate;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem اضافهاختصارToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem حذفاختصارToolStripMenuItem;
		private System.Windows.Forms.TextBox txtAmountPaidForProducts;
		private System.Windows.Forms.Label lblAmountPaidForProducts;
		private System.Windows.Forms.TextBox txtPaidAmountForMortgage;
		private System.Windows.Forms.Label lblForMortgage;
		private System.Windows.Forms.Button btnAddNewOrderOrUpdateOrderAndPrint;
		private System.Windows.Forms.Button brnDeleteSelectedProduct;
		private System.Windows.Forms.Button btnDeleteAll;
		private System.Windows.Forms.CheckBox chkTheMortgageIsReturned;
		private System.Windows.Forms.RadioButton rdComplete;
		private System.Windows.Forms.RadioButton rdOnDelivery;
		private System.Windows.Forms.RadioButton rdCancel;
		private System.Windows.Forms.GroupBox gBOrderStatus;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDeliveryLocation;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPriceForMortage;
		private System.Windows.Forms.TextBox txtPriceForProducts;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label lblPriceRequredForMortgage;
		private System.Windows.Forms.Label lblPriceRequredForProducts;
		private System.Windows.Forms.Label lblPriceForTotal;
		private System.Windows.Forms.Label lblPriceRequred;
		private System.Windows.Forms.Button btnFastPaid;
		private System.Windows.Forms.Button btnAddNewOrderOrUpdateOrder;
	}
}