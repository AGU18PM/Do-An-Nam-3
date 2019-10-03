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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.checkButton3 = new DevExpress.XtraEditors.CheckButton();
            this.btnLG = new DevExpress.XtraEditors.CheckButton();
            this.btnSony = new DevExpress.XtraEditors.CheckButton();
            this.groupPrice = new DevExpress.XtraEditors.GroupControl();
            this.cbPriceDown = new System.Windows.Forms.CheckBox();
            this.cbPriceUp = new System.Windows.Forms.CheckBox();
            this.btnSamsung = new DevExpress.XtraEditors.CheckButton();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.ProductListview = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPrice)).BeginInit();
            this.groupPrice.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNameProduct);
            this.panel1.Controls.Add(this.checkButton3);
            this.panel1.Controls.Add(this.btnLG);
            this.panel1.Controls.Add(this.btnSony);
            this.panel1.Controls.Add(this.groupPrice);
            this.panel1.Controls.Add(this.btnSamsung);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Location = new System.Drawing.Point(559, 10);
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(126, 20);
            this.tbNameProduct.TabIndex = 6;
            // 
            // checkButton3
            // 
            this.checkButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("checkButton3.ImageOptions.Image")));
            this.checkButton3.Location = new System.Drawing.Point(378, 7);
            this.checkButton3.Name = "checkButton3";
            this.checkButton3.Size = new System.Drawing.Size(120, 36);
            this.checkButton3.TabIndex = 11;
            this.checkButton3.Text = "Panasonic";
            // 
            // btnLG
            // 
            this.btnLG.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLG.ImageOptions.Image")));
            this.btnLG.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnLG.Location = new System.Drawing.Point(252, 7);
            this.btnLG.Name = "btnLG";
            this.btnLG.Size = new System.Drawing.Size(120, 36);
            this.btnLG.TabIndex = 10;
            // 
            // btnSony
            // 
            this.btnSony.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSony.ImageOptions.Image")));
            this.btnSony.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSony.Location = new System.Drawing.Point(126, 7);
            this.btnSony.Name = "btnSony";
            this.btnSony.Size = new System.Drawing.Size(120, 36);
            this.btnSony.TabIndex = 9;
            this.btnSony.CheckedChanged += new System.EventHandler(this.btnSony_CheckedChanged);
            // 
            // groupPrice
            // 
            this.groupPrice.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupPrice.Appearance.Options.UseBackColor = true;
            this.groupPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupPrice.Controls.Add(this.cbPriceDown);
            this.groupPrice.Controls.Add(this.cbPriceUp);
            this.groupPrice.Location = new System.Drawing.Point(710, -13);
            this.groupPrice.Name = "groupPrice";
            this.groupPrice.Size = new System.Drawing.Size(319, 52);
            this.groupPrice.TabIndex = 8;
            // 
            // cbPriceDown
            // 
            this.cbPriceDown.AutoSize = true;
            this.cbPriceDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriceDown.Location = new System.Drawing.Point(5, 23);
            this.cbPriceDown.Name = "cbPriceDown";
            this.cbPriceDown.Size = new System.Drawing.Size(150, 24);
            this.cbPriceDown.TabIndex = 2;
            this.cbPriceDown.Text = "Giá cao đến thấp";
            this.cbPriceDown.UseVisualStyleBackColor = true;
            this.cbPriceDown.CheckedChanged += new System.EventHandler(this.CbPriceDown_CheckedChanged);
            // 
            // cbPriceUp
            // 
            this.cbPriceUp.AutoSize = true;
            this.cbPriceUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriceUp.Location = new System.Drawing.Point(161, 23);
            this.cbPriceUp.Name = "cbPriceUp";
            this.cbPriceUp.Size = new System.Drawing.Size(150, 24);
            this.cbPriceUp.TabIndex = 3;
            this.cbPriceUp.Text = "Giá thấp đến cao";
            this.cbPriceUp.UseVisualStyleBackColor = true;
            this.cbPriceUp.CheckedChanged += new System.EventHandler(this.CbPriceUp_CheckedChanged);
            // 
            // btnSamsung
            // 
            this.btnSamsung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSamsung.ImageOptions.Image")));
            this.btnSamsung.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnSamsung.Location = new System.Drawing.Point(0, 7);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(120, 36);
            this.btnSamsung.TabIndex = 4;
            this.btnSamsung.CheckedChanged += new System.EventHandler(this.btnSamsung_CheckedChanged);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.ProductListview);
            this.panelProduct.Location = new System.Drawing.Point(3, 60);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1050, 418);
            this.panelProduct.TabIndex = 1;
            // 
            // ProductListview
            // 
            this.ProductListview.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListview.FullRowSelect = true;
            this.ProductListview.HideSelection = false;
            this.ProductListview.Location = new System.Drawing.Point(4, 4);
            this.ProductListview.Name = "ProductListview";
            this.ProductListview.Size = new System.Drawing.Size(681, 411);
            this.ProductListview.TabIndex = 0;
            this.ProductListview.UseCompatibleStateImageBehavior = false;
            this.ProductListview.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ProductListview_DrawItem);
            
            // 
            // ProductCtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panel1);
            this.Name = "ProductCtr";
            this.Size = new System.Drawing.Size(1056, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupPrice)).EndInit();
            this.groupPrice.ResumeLayout(false);
            this.groupPrice.PerformLayout();
            this.panelProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbPriceUp;
        private System.Windows.Forms.CheckBox cbPriceDown;
        private System.Windows.Forms.Panel panelProduct;
        private DevExpress.XtraEditors.CheckButton btnSamsung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameProduct;
        private DevExpress.XtraEditors.GroupControl groupPrice;
        private DevExpress.XtraEditors.CheckButton checkButton3;
        private DevExpress.XtraEditors.CheckButton btnLG;
        private DevExpress.XtraEditors.CheckButton btnSony;
        private System.Windows.Forms.ListView ProductListview;
    }
}
