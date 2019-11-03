namespace TelevisionsStoreManagement.UC
{
    partial class WareHouseCtr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouseCtr));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nUDUpdate = new System.Windows.Forms.NumericUpDown();
            this.txbSize = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txbPriceOut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPriceIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.dGVWareHouse = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWareHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dGVWareHouse);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 545);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.nUDUpdate);
            this.panel2.Controls.Add(this.txbSize);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cboCategory);
            this.panel2.Controls.Add(this.cboType);
            this.panel2.Controls.Add(this.txbPriceOut);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txbPriceIn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.nUDCount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txbName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbID);
            this.panel2.Location = new System.Drawing.Point(776, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 491);
            this.panel2.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(78, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 68);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(156, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 68);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(2, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 68);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(234, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 68);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nUDUpdate
            // 
            this.nUDUpdate.Location = new System.Drawing.Point(235, 167);
            this.nUDUpdate.Name = "nUDUpdate";
            this.nUDUpdate.Size = new System.Drawing.Size(45, 20);
            this.nUDUpdate.TabIndex = 37;
            this.nUDUpdate.Visible = false;
            // 
            // txbSize
            // 
            this.txbSize.BackColor = System.Drawing.Color.White;
            this.txbSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSize.Enabled = false;
            this.txbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSize.Location = new System.Drawing.Point(101, 170);
            this.txbSize.Multiline = true;
            this.txbSize.Name = "txbSize";
            this.txbSize.Size = new System.Drawing.Size(52, 17);
            this.txbSize.TabIndex = 33;
            this.txbSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPriceOut_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(312, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 68);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(101, 78);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(179, 21);
            this.cboCategory.TabIndex = 30;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(101, 138);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(179, 21);
            this.cboType.TabIndex = 29;
            // 
            // txbPriceOut
            // 
            this.txbPriceOut.BackColor = System.Drawing.Color.White;
            this.txbPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPriceOut.Enabled = false;
            this.txbPriceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceOut.Location = new System.Drawing.Point(99, 196);
            this.txbPriceOut.Multiline = true;
            this.txbPriceOut.Name = "txbPriceOut";
            this.txbPriceOut.Size = new System.Drawing.Size(179, 22);
            this.txbPriceOut.TabIndex = 28;
            this.txbPriceOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPriceOut_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Giá xuất:";
            // 
            // txbPriceIn
            // 
            this.txbPriceIn.BackColor = System.Drawing.Color.White;
            this.txbPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPriceIn.Enabled = false;
            this.txbPriceIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceIn.Location = new System.Drawing.Point(98, 222);
            this.txbPriceIn.Multiline = true;
            this.txbPriceIn.Name = "txbPriceIn";
            this.txbPriceIn.Size = new System.Drawing.Size(179, 22);
            this.txbPriceIn.TabIndex = 26;
            this.txbPriceIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPriceOut_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Giá nhập:";
            // 
            // nUDCount
            // 
            this.nUDCount.Location = new System.Drawing.Point(235, 167);
            this.nUDCount.Name = "nUDCount";
            this.nUDCount.Size = new System.Drawing.Size(45, 20);
            this.nUDCount.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kích cỡ:";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(101, 110);
            this.txbName.Multiline = true;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(179, 22);
            this.txbName.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hãng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.Color.White;
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(101, 49);
            this.txbID.Multiline = true;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(179, 22);
            this.txbID.TabIndex = 10;
            // 
            // dGVWareHouse
            // 
            this.dGVWareHouse.AllowUserToAddRows = false;
            this.dGVWareHouse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dGVWareHouse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVWareHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVWareHouse.BackgroundColor = System.Drawing.Color.White;
            this.dGVWareHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVWareHouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(197)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVWareHouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVWareHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Category,
            this.productNam,
            this.type,
            this.size,
            this.priceOut,
            this.colPriceIn,
            this.colCount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVWareHouse.DefaultCellStyle = dataGridViewCellStyle6;
            this.dGVWareHouse.EnableHeadersVisualStyles = false;
            this.dGVWareHouse.GridColor = System.Drawing.SystemColors.Control;
            this.dGVWareHouse.Location = new System.Drawing.Point(11, 0);
            this.dGVWareHouse.MultiSelect = false;
            this.dGVWareHouse.Name = "dGVWareHouse";
            this.dGVWareHouse.ReadOnly = true;
            this.dGVWareHouse.RowHeadersVisible = false;
            this.dGVWareHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVWareHouse.Size = new System.Drawing.Size(751, 491);
            this.dGVWareHouse.TabIndex = 1;
            this.dGVWareHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVWareHouse_CellClick);
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
            this.productNam.Width = 150;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.type.DataPropertyName = "TYPE";
            this.type.FillWeight = 50F;
            this.type.HeaderText = "Loại";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 75;
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
            this.priceOut.HeaderText = "Giá xuất";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // colPriceIn
            // 
            this.colPriceIn.DataPropertyName = "PRICE_IN";
            this.colPriceIn.HeaderText = "Gia nhập";
            this.colPriceIn.Name = "colPriceIn";
            this.colPriceIn.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "COUNT";
            this.colCount.HeaderText = "Số lượng";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // WareHouseCtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Name = "WareHouseCtr";
            this.Size = new System.Drawing.Size(1180, 545);
            this.Load += new System.EventHandler(this.WareHouseCtr_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWareHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVWareHouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbPriceOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPriceIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbSize;
        private System.Windows.Forms.NumericUpDown nUDUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
    }
}
