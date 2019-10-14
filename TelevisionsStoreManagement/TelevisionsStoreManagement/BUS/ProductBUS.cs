using System;
using System.Collections.Generic;
using System.Data;
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
        public void ShowProductData(DataGridView dGV, TextBox iD, TextBox category, TextBox name, TextBox type, TextBox size, TextBox price, string typeInput)
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
            addHeaderText(dGV);
        }

        //public DataTable getAllProduct()
        //{
        //    DataTable reslut = data.ListProduct(typeInput);
        //    return reslut;
        //}

        public void ShowProductDataByCategory(DataGridView dGV, string category, TextBox iD, TextBox txbcategory, TextBox name, TextBox type, TextBox size, TextBox price, string typeInput)
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
            dGV.Columns[3].Width = 50;
            dGV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[4].Width = 80;
            dGV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dGV.Columns[5].Width = 184;
        }
    }
}
