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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.cbPriceUp = new System.Windows.Forms.CheckBox();
            this.cbPriceDown = new System.Windows.Forms.CheckBox();
            this.TVCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbNameProduct);
            this.panel1.Controls.Add(this.cbPriceUp);
            this.panel1.Controls.Add(this.cbPriceDown);
            this.panel1.Controls.Add(this.TVCategory);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 51);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(543, 15);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên:";
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Location = new System.Drawing.Point(301, 16);
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(126, 20);
            this.tbNameProduct.TabIndex = 4;
            // 
            // cbPriceUp
            // 
            this.cbPriceUp.AutoSize = true;
            this.cbPriceUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriceUp.Location = new System.Drawing.Point(883, 12);
            this.cbPriceUp.Name = "cbPriceUp";
            this.cbPriceUp.Size = new System.Drawing.Size(150, 24);
            this.cbPriceUp.TabIndex = 3;
            this.cbPriceUp.Text = "Giá thấp đến cao";
            this.cbPriceUp.UseVisualStyleBackColor = true;
            this.cbPriceUp.CheckedChanged += new System.EventHandler(this.CbPriceUp_CheckedChanged);
            // 
            // cbPriceDown
            // 
            this.cbPriceDown.AutoSize = true;
            this.cbPriceDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPriceDown.Location = new System.Drawing.Point(703, 12);
            this.cbPriceDown.Name = "cbPriceDown";
            this.cbPriceDown.Size = new System.Drawing.Size(150, 24);
            this.cbPriceDown.TabIndex = 2;
            this.cbPriceDown.Text = "Giá cao đến thấp";
            this.cbPriceDown.UseVisualStyleBackColor = true;
            this.cbPriceDown.CheckedChanged += new System.EventHandler(this.CbPriceDown_CheckedChanged);
            // 
            // TVCategory
            // 
            this.TVCategory.AutoSize = true;
            this.TVCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVCategory.Location = new System.Drawing.Point(17, 12);
            this.TVCategory.Name = "TVCategory";
            this.TVCategory.Size = new System.Drawing.Size(61, 24);
            this.TVCategory.TabIndex = 1;
            this.TVCategory.Text = "Hãng:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(84, 16);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 0;
            // 
            // panelProduct
            // 
            this.panelProduct.Location = new System.Drawing.Point(3, 60);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(1050, 418);
            this.panelProduct.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.CheckBox cbPriceUp;
        private System.Windows.Forms.CheckBox cbPriceDown;
        private System.Windows.Forms.Label TVCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panelProduct;
    }
}
