﻿namespace TelevisionsStoreManagement.UC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
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
            this.txbSize = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nUDUpdate = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dGVWareHouse);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 497);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nUDUpdate);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txbSize);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnAdd);
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
            this.panel2.Location = new System.Drawing.Point(760, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 491);
            this.panel2.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(108, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 54);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 54);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(101, 78);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(179, 21);
            this.cboCategory.TabIndex = 30;
            // 
            // cboType
            // 
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
            this.txbPriceOut.Location = new System.Drawing.Point(101, 191);
            this.txbPriceOut.Multiline = true;
            this.txbPriceOut.Name = "txbPriceOut";
            this.txbPriceOut.Size = new System.Drawing.Size(179, 22);
            this.txbPriceOut.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Gia xuat:";
            // 
            // txbPriceIn
            // 
            this.txbPriceIn.BackColor = System.Drawing.Color.White;
            this.txbPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPriceIn.Enabled = false;
            this.txbPriceIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceIn.Location = new System.Drawing.Point(101, 220);
            this.txbPriceIn.Multiline = true;
            this.txbPriceIn.Name = "txbPriceIn";
            this.txbPriceIn.Size = new System.Drawing.Size(179, 22);
            this.txbPriceIn.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Gia nhap";
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
            this.label6.Text = "So luong:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kich co";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.Color.White;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbName.Enabled = false;
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(101, 105);
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
            this.dGVWareHouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVWareHouse.BackgroundColor = System.Drawing.Color.White;
            this.dGVWareHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dGVWareHouse.GridColor = System.Drawing.SystemColors.Control;
            this.dGVWareHouse.Location = new System.Drawing.Point(3, 3);
            this.dGVWareHouse.Name = "dGVWareHouse";
            this.dGVWareHouse.RowHeadersVisible = false;
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
            this.priceOut.HeaderText = "Giá xuat";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // colPriceIn
            // 
            this.colPriceIn.DataPropertyName = "PRICE_IN";
            this.colPriceIn.HeaderText = "Gia nhap";
            this.colPriceIn.Name = "colPriceIn";
            this.colPriceIn.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.DataPropertyName = "COUNT";
            this.colCount.HeaderText = "So luong";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
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
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 54);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(109, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 54);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(5, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 54);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Hủy";
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
            // WareHouseCtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "WareHouseCtr";
            this.Size = new System.Drawing.Size(1056, 504);
            this.Load += new System.EventHandler(this.WareHouseCtr_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
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
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbSize;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nUDUpdate;
    }
}
