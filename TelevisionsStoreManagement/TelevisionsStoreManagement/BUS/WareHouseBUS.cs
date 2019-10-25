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
    class WareHouseBUS
    {
        WareHouseDAL data = new WareHouseDAL();
        public bool CheckCount(string product, int billCount, BillDTO bill)
        {
            #region cmt
            //if (flag == 0)
            //{
            //    if (data.checkCount(product, bill)) ;
            //    DataTable result = data.getData(product, bill);
            //    if (result.Rows.Count == 0)
            //        return -1;
            //    else
            //        return Convert.ToInt32(result.Rows[0][0]);
            //}
            //else
            //{
            //    DataTable result = data.getData(product, bill);
            //    if (soLuong < Convert.ToInt32(result.Rows[0][0]))
            //        return -1;
            //    else
            //    {
            //        int tam = Convert.ToInt32(result.Rows[0][0]);
            //        tam -= soLuong;
            //        return tam;
            //    }
            //}
            #endregion

            //if (data.checkCount(product, billCount))
            //{
            //    BILLInfoBUS billInfo = new BILLInfoBUS();
            //    data.update(billInfo.getListBillInfoByBillID(bill));
            //}
            return data.checkCount(product, billCount);
        }

        public DataTable getCountByIDTV(string id)
        {
            DataTable result = data.getData(id);
            return result;
        }

        public bool Update(BillDTO bill)
        {
            BILLInfoBUS billInfo = new BILLInfoBUS();
            return data.update(billInfo.getListBillInfoByBillID(bill));
        }

        public void loadDataToDGV(DataGridView dGV, TextBox iD, ComboBox category, TextBox productName, ComboBox type, NumericUpDown size, NumericUpDown count, TextBox priceOut, TextBox priceIn)
        {
            BindingSource bS = new BindingSource();
            DataTable result = data.ListProduct();
            dGV.DataSource = result;
            bS.DataSource = result;
            //iD.DataBindings.Clear();
            //iD.DataBindings.Add("Text", bS, "ID", false, DataSourceUpdateMode.Never);
            //category.DataBindings.Clear();
            //category.DataBindings.Add("Text", bS, "CATEGORY_NAME", false, DataSourceUpdateMode.Never);
            //productName.DataBindings.Clear();
            //productName.DataBindings.Add("Text", bS, "NAME", false, DataSourceUpdateMode.Never);
            //type.DataBindings.Clear();
            //type.DataBindings.Add("Text", bS, "TYPE", false, DataSourceUpdateMode.Never);
            //size.DataBindings.Clear();
            //size.DataBindings.Add("Text", bS, "SIZE", false, DataSourceUpdateMode.Never);
            //priceOut.DataBindings.Clear();
            //priceOut.DataBindings.Add("Text", bS, "PRICE_OUT", false, DataSourceUpdateMode.Never);
            //priceIn.DataBindings.Clear();
            //priceIn.DataBindings.Add("Text", bS, "PRICE_IN", false, DataSourceUpdateMode.Never);
            //count.DataBindings.Clear();
            //count.DataBindings.Add("Text", bS, "COUNT", false, DataSourceUpdateMode.Never);
        }
    }
}
