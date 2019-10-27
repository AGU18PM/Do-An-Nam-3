namespace TelevisionsStoreManagement.UC
{
    partial class RevenCtr
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGVHistory = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistory)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dGVHistory);
            this.panel1.Location = new System.Drawing.Point(4, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 193);
            this.panel1.TabIndex = 0;
            // 
            // dGVHistory
            // 
            this.dGVHistory.AllowUserToAddRows = false;
            this.dGVHistory.AllowUserToDeleteRows = false;
            this.dGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColDATE,
            this.Col,
            this.colIDKH,
            this.ColName,
            this.ColSDT});
            this.dGVHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVHistory.Location = new System.Drawing.Point(0, 0);
            this.dGVHistory.MultiSelect = false;
            this.dGVHistory.Name = "dGVHistory";
            this.dGVHistory.ReadOnly = true;
            this.dGVHistory.RowHeadersVisible = false;
            this.dGVHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVHistory.Size = new System.Drawing.Size(1173, 193);
            this.dGVHistory.TabIndex = 0;
            this.dGVHistory.DoubleClick += new System.EventHandler(this.dGVHistory_DoubleClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // ColDATE
            // 
            this.ColDATE.DataPropertyName = "DATE_CHECKIN";
            this.ColDATE.HeaderText = "NGÀY BÁN";
            this.ColDATE.Name = "ColDATE";
            this.ColDATE.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.DataPropertyName = "TOTALPRICE";
            this.Col.HeaderText = "Tổng giá";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // colIDKH
            // 
            this.colIDKH.DataPropertyName = "ID1";
            this.colIDKH.HeaderText = "ID KHÁCH HÀNG";
            this.colIDKH.Name = "colIDKH";
            this.colIDKH.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "NAME";
            this.ColName.HeaderText = "TÊN KH";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColSDT
            // 
            this.ColSDT.DataPropertyName = "PHONE_NUMBER";
            this.ColSDT.HeaderText = "SDT";
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(4, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 246);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lịch sử giao dịch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doanh thu theo tháng";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(12, 57);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 2);
            this.Label.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1173, 246);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "RevenChart";
            // 
            // RevenCtr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RevenCtr";
            this.Size = new System.Drawing.Size(1180, 545);
            this.Load += new System.EventHandler(this.RevenCtr_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVHistory)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
