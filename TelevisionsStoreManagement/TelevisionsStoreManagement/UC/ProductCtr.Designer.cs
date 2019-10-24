namespace TelevisionsStoreManagement.UC
{
    partial class ProductCtr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCtr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPanasonic = new DevExpress.XtraEditors.CheckButton();
            this.btnLG = new DevExpress.XtraEditors.CheckButton();
            this.btnSony = new DevExpress.XtraEditors.CheckButton();
            this.btnSamsung = new DevExpress.XtraEditors.CheckButton();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.txbCustomerPhonenumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nUDCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.dGVProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPanasonic);
            this.panel1.Controls.Add(this.btnLG);
            this.panel1.Controls.Add(this.btnSony);
            this.panel1.Controls.Add(this.btnSamsung);
            this.panel1.Location = new System.Drawing.Point(11, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnPanasonic
            // 
            this.btnPanasonic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPanasonic.ImageOptions.Image")));
            this.btnPanasonic.Location = new System.Drawing.Point(378, 8);
            this.btnPanasonic.Name = "btnPanasonic";
            this.btnPanasonic.Size = new System.Drawing.Size(120, 39);
            this.btnPanasonic.TabIndex = 11;
            this.btnPanasonic.Text = "Panasonic";
            this.btnPanasonic.CheckedChanged += new System.EventHandler(this.btnPanasonic_CheckedChanged);
            // 
            // btnLG
            // 
            this.btnLG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLG.ImageOptions.Image")));
            this.btnLG.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnLG.Location = new System.Drawing.Point(252, 8);
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(120, 39);
            this.btnLG.TabIndex = 10;
            this.btnLG.CheckedChanged += new System.EventHandler(this.btnLG_CheckedChanged);
            // 
            // btnSony
            // 
            this.btnSony.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSony.ImageOptions.Image")));
            this.btnSony.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSony.Location = new System.Drawing.Point(126, 8);
            this.btnSony.Name = "btnSony";
            this.btnSony.Size = new System.Drawing.Size(120, 39);
            this.btnSony.TabIndex = 9;
            this.btnSony.CheckedChanged += new System.EventHandler(this.btnSony_CheckedChanged);
            // 
            // btnSamsung
            // 
            this.btnSamsung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSamsung.ImageOptions.Image")));
            this.btnSamsung.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnSamsung.Location = new System.Drawing.Point(0, 8);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(120, 39);
            this.btnSamsung.TabIndex = 4;
            this.btnSamsung.CheckedChanged += new System.EventHandler(this.btnSamsung_CheckedChanged);
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panelProduct.Controls.Add(this.panel2);
            this.panelProduct.Controls.Add(this.label10);
            this.panelProduct.Controls.Add(this.lbPayment);
            this.panelProduct.Controls.Add(this.dGVProduct);
            this.panelProduct.Location = new System.Drawing.Point(0, 65);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1180, 522);
            this.panelProduct.TabIndex = 1;
            // 
            // txbCustomerPhonenumber
            // 
            this.txbCustomerPhonenumber.BackColor = System.Drawing.Color.White;
            this.txbCustomerPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCustomerPhonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCustomerPhonenumber.Location = new System.Drawing.Point(186, 318);
            this.txbCustomerPhonenumber.Multiline = true;
            this.txbCustomerPhonenumber.Name = "txbCustomerPhonenumber";
            this.txbCustomerPhonenumber.Size = new System.Drawing.Size(214, 27);
            this.txbCustomerPhonenumber.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "SDT khách hàng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(687, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 19);
            this.label10.TabIndex = 22;
            // 
            // lbPayment
            // 
            this.lbPayment.FormattingEnabled = true;
            this.lbPayment.ItemHeight = 14;
            this.lbPayment.Location = new System.Drawing.Point(11, 253);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(676, 186);
            this.lbPayment.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tổng giá:";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.BackColor = System.Drawing.Color.White;
            this.txbTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotalPrice.Enabled = false;
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(167, 278);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(214, 27);
            this.txbTotalPrice.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "S.Lượng:";
            // 
            // nUDCount
            // 
            this.nUDCount.Location = new System.Drawing.Point(341, 193);
            this.nUDCount.Name = "nUDCount";
            this.nUDCount.Size = new System.Drawing.Size(47, 22);
            this.nUDCount.TabIndex = 14;
            this.nUDCount.ValueChanged += new System.EventHandler(this.nUDCount_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Đơn giá:";
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.White;
            this.txbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPrice.Enabled = false;
            this.txbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(167, 233);
            this.txbPrice.Multiline = true;
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(214, 27);
            this.txbPrice.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kích cỡ:";
            // 
            // txbSize
            // 
            this.txbSize.BackColor = System.Drawing.Color.White;
            this.txbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSize.Enabled = false;
            this.txbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSize.Location = new System.Drawing.Point(167, 195);
            this.txbSize.Multiline = true;
            this.txbSize.Name = "txbSize";
            this.txbSize.Size = new System.Drawing.Size(64, 27);
            this.txbSize.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại:";
            // 
            // txbType
            // 
            this.txbType.BackColor = System.Drawing.Color.White;
            this.txbType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbType.Enabled = false;
            this.txbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbType.Location = new System.Drawing.Point(167, 160);
            this.txbType.Multiline = true;
            this.txbType.Name = "txbType";
            this.txbType.Size = new System.Drawing.Size(214, 27);
            this.txbType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(167, 124);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(214, 27);
            this.txbName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hãng:";
            // 
            // txbCategory
            // 
            this.txbCategory.BackColor = System.Drawing.Color.White;
            this.txbCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCategory.Enabled = false;
            this.txbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCategory.Location = new System.Drawing.Point(167, 83);
            this.txbCategory.Multiline = true;
            this.txbCategory.Name = "txbCategory";
            this.txbCategory.Size = new System.Drawing.Size(214, 27);
            this.txbCategory.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thanh toán";
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.White;
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(167, 50);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(214, 27);
            this.txbID.TabIndex = 1;
            // 
            // dGVProduct
            // 
            this.dGVProduct.AllowUserToAddRows = false;
            this.dGVProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dGVProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVProduct.BackgroundColor = System.Drawing.Color.White;
            this.dGVProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category,
            this.productNam,
            this.type,
            this.size,
            this.priceOut});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVProduct.GridColor = System.Drawing.SystemColors.Control;
            this.dGVProduct.Location = new System.Drawing.Point(11, 0);
            this.dGVProduct.Name = "dGVProduct";
            this.dGVProduct.RowHeadersVisible = false;
            this.dGVProduct.Size = new System.Drawing.Size(676, 233);
            this.dGVProduct.TabIndex = 0;
            this.dGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProduct_CellContentClick);
            this.dGVProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProduct_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 30.45685F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Category.DataPropertyName = "CATEGORY_NAME";
            this.Category.FillWeight = 99.75531F;
            this.Category.HeaderText = "Hãng";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // productNam
            // 
            this.productNam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNam.DataPropertyName = "NAME";
            this.productNam.FillWeight = 99.75531F;
            this.productNam.HeaderText = "Tên sản phẩm";
            this.productNam.Name = "productNam";
            this.productNam.ReadOnly = true;
            this.productNam.Width = 200;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.type.DataPropertyName = "TYPE";
            this.type.FillWeight = 50F;
            this.type.HeaderText = "Loại";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.size.DataPropertyName = "SIZE";
            this.size.FillWeight = 170.5219F;
            this.size.HeaderText = "Kích cỡ";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // priceOut
            // 
            this.priceOut.DataPropertyName = "PRICE_OUT";
            this.priceOut.FillWeight = 99.75531F;
            this.priceOut.HeaderText = "Giá";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(185, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 69);
            this.button1.TabIndex = 25;
            this.button1.Text = "Thanh toán";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(66, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 69);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(300, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 69);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txbID);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txbCategory);
            this.panel2.Controls.Add(this.txbCustomerPhonenumber);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txbType);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txbTotalPrice);
            this.panel2.Controls.Add(this.txbSize);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.nUDCount);
            this.panel2.Controls.Add(this.txbPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(706, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 436);
            this.panel2.TabIndex = 28;
            // 
            // ProductCtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductCtr";
            this.Size = new System.Drawing.Size(1180, 587);
            this.Load += new System.EventHandler(this.ProductCtr_Load);
            this.panel1.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProduct;
        private DevExpress.XtraEditors.CheckButton btnSamsung;
        private DevExpress.XtraEditors.CheckButton btnPanasonic;
        private DevExpress.XtraEditors.CheckButton btnLG;
        private DevExpress.XtraEditors.CheckButton btnSony;
        private System.Windows.Forms.DataGridView dGVProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUDCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.ListBox lbPayment;
        private System.Windows.Forms.TextBox txbCustomerPhonenumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
    }
}
