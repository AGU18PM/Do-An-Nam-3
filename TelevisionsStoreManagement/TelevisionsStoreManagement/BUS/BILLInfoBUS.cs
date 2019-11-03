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
    class BILLInfoBUS
    {
        BillInfoDAL data = new BillInfoDAL();

        public void createBillInfo(BillDTO bill, string idTV, NumericUpDown nUD, string totalPrice)
        {
            data.createBillInfo(bill, idTV, nUD, totalPrice);
        }

        public BillDTO getTotalPriceByIDBill(BillDTO bill)
        {
            return data.getTotalPriceByIDBill(bill);
        }

        public DataTable getListBillInfoByBillID(BillDTO bill)
        {
            return data.getListBillInfoByBillID(bill);
        }

        public void DelNGetBill(BillInfoDTO billInfo)
        {
            data.DeleteAndGetBill(billInfo);
        }

        public void TotalSold(Label result)
        {
            result.Text = data.totalSold().Rows[0][0].ToString();
        }

        public void SoldInDay(Label result)
        {
            BillDTO billDTO = new BillDTO();
            BillBUS billBUS = new BillBUS();
            billDTO = billBUS.GetDate();
            result.Text = data.SoldInDay(billDTO).Rows[0][0].ToString();
        }
    }
}
