using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.BUS
{
    class ProductBUS
    {
        ProductDAL data = new ProductDAL();
        BILLInfoBUS billInfoBUS = new BILLInfoBUS();
        public void ShowProductData(DataGridView dGV, TextBox iD, TextBox category, TextBox name, TextBox type, TextBox size, TextBox price, string typeInput, NumericUpDown count)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.ListProduct(typeInput);
            iD.DataBindings.Clear();
            iD.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);
            category.DataBindings.Clear();
            category.DataBindings.Add("Text", bS, "CATEGORY_NAME", false, DataSourceUpdateMode.Never);
            dGV.DataSource = bS;
            name.DataBindings.Clear();
            name.DataBindings.Add("Text", bS, "NAME", false, DataSourceUpdateMode.Never);
            type.DataBindings.Clear();
            type.DataBindings.Add("Text", bS, "TYPE", false, DataSourceUpdateMode.Never);
            size.DataBindings.Clear();
            size.DataBindings.Add("Text", bS, "SIZE", false, DataSourceUpdateMode.Never);
            price.DataBindings.Clear();
            price.DataBindings.Add("Text", bS, "PRICE_OUT", false, DataSourceUpdateMode.Never);
            count.DataBindings.Clear();
            count.DataBindings.Add("Maximum", bS, "COUNT", false, DataSourceUpdateMode.Never);
            addHeaderText(dGV);


        }

        //public DataTable getAllProduct()
        //{
        //    DataTable reslut = data.ListProduct(typeInput);
        //    return reslut;
        //}

        public void ShowProductDataByCategory(DataGridView dGV, string category, TextBox iD, TextBox txbcategory, TextBox name, TextBox type, TextBox size, TextBox price, string typeInput, NumericUpDown count)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = data.getListProductByCategory(category, typeInput);
            iD.DataBindings.Clear();
            iD.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);
            txbcategory.DataBindings.Clear();
            txbcategory.DataBindings.Add("Text", bS, "CATEGORY_NAME", false, DataSourceUpdateMode.Never);
            dGV.DataSource = bS;
            name.DataBindings.Clear();
            name.DataBindings.Add("Text", bS, "NAME", false, DataSourceUpdateMode.Never);
            type.DataBindings.Clear();
            type.DataBindings.Add("Text", bS, "TYPE", false, DataSourceUpdateMode.Never);
            size.DataBindings.Clear();
            size.DataBindings.Add("Text", bS, "SIZE", false, DataSourceUpdateMode.Never);
            price.DataBindings.Clear();
            price.DataBindings.Add("Text", bS, "PRICE_OUT", false, DataSourceUpdateMode.Never);
            count.DataBindings.Clear();
            count.DataBindings.Add("Maximum", bS, "COUNT", false, DataSourceUpdateMode.Never);
            addHeaderText(dGV);
        }

        private void addHeaderText(DataGridView dGV)
        {
            dGV.Columns[0].HeaderText = "ID";
            dGV.Columns[1].HeaderText = "Hãng";
            dGV.Columns[2].HeaderText = "Tên";
            dGV.Columns[3].HeaderText = "Loại";
            dGV.Columns[4].HeaderText = "Kích cỡ";
            dGV.Columns[5].HeaderText = "Giá";

            dGV.Columns[0].DataPropertyName = "ID";
            dGV.Columns[1].DataPropertyName = "CATEGORY_NAME";
            dGV.Columns[2].DataPropertyName = "NAME";
            dGV.Columns[3].DataPropertyName = "TYPE";
            dGV.Columns[4].DataPropertyName = "SIZE";
            dGV.Columns[5].DataPropertyName = "PRICE_OUT";

            dGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[0].Width = 30;
            dGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[1].Width = 150;
            dGV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[2].Width = 184;
            dGV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[3].Width = 94;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[4].Width = 120;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[5].Width = 100;

            dGV.EnableHeadersVisualStyles = false;
            dGV.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);
            dGV.Columns[1].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);
            dGV.Columns[2].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);
            dGV.Columns[3].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);
            dGV.Columns[4].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);
            dGV.Columns[5].HeaderCell.Style.BackColor = Color.FromArgb(86, 197, 250);

            dGV.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dGV.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            dGV.Columns[2].HeaderCell.Style.ForeColor = Color.White;
            dGV.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            dGV.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            dGV.Columns[5].HeaderCell.Style.ForeColor = Color.White;

            dGV.Columns[0].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[1].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[2].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[3].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[4].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[5].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
            dGV.Columns[0].HeaderCell.Style.Font = new Font("Calibri", 12, FontStyle.Regular);
        }
        public bool Update(BillDTO bill)
        {
            BILLInfoBUS billInfo = new BILLInfoBUS();
            return data.Update(billInfo.getListBillInfoByBillID(bill));
        }

        #region WareHouse
        public void loadDataToDGV(DataGridView dGV, TextBox iD, ComboBox category, TextBox productName, ComboBox type, TextBox size, NumericUpDown count, TextBox priceOut, TextBox priceIn)
        {
            BindingSource bS = new BindingSource();
            DataTable result = data.LoadDataToWareHouseDGV();
            bS.DataSource = result;
            iD.DataBindings.Clear();
            iD.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);
            category.DataBindings.Clear();
            category.DataBindings.Add("Text", bS, "CATEGORY_NAME", false, DataSourceUpdateMode.Never);
            productName.DataBindings.Clear();
            productName.DataBindings.Add("Text", bS, "NAME", false, DataSourceUpdateMode.Never);
            type.DataBindings.Clear();
            type.DataBindings.Add("Text", bS, "TYPE", false, DataSourceUpdateMode.Never);
            size.DataBindings.Clear();
            size.DataBindings.Add("Text", bS, "SIZE", false, DataSourceUpdateMode.Never);
            priceOut.DataBindings.Clear();
            priceOut.DataBindings.Add("Text", bS, "PRICE_OUT", false, DataSourceUpdateMode.Never);
            priceIn.DataBindings.Clear();
            priceIn.DataBindings.Add("Text", bS, "PRICE_IN", false, DataSourceUpdateMode.Never);
            count.DataBindings.Clear();
            count.DataBindings.Add("Maximum", bS, "COUNT", false, DataSourceUpdateMode.Never);
            dGV.DataSource = bS;
        }

        public bool AddProduct(ProductDTO product)
        {
            return data.AddProduct(product);
        }

        public void UpdateProduct(ProductDTO product)
        {
            data.UpdateProduct(product);
        }

        public void DeleteProduct(ProductDTO product)
        {
            BillInfoDTO billInfo = new BillInfoDTO();
            BillDTO billDTO = new BillDTO();
            billInfo.Tivi = product;
            billInfoBUS.DelNGetBill(billInfo);
            data.DeleteProduct(product);
        }
        #endregion



    }
}
