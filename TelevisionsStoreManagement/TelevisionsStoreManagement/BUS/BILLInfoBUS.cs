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
    }
}
