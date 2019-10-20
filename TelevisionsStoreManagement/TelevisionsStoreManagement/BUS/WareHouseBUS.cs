using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
