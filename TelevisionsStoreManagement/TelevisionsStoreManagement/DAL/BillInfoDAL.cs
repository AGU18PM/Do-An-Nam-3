using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;
using System.Windows.Forms;
using System.Data;

namespace TelevisionsStoreManagement.DAL
{
    class BillInfoDAL
    {
        public void createBillInfo(BillDTO bill, string idTV, NumericUpDown nUD, string totalPrice)
        {
            string sql = "INSERT INTO BILL_INFO ( ID_BILL , ID_TV , COUNT , TOTAL_PRICE ) VALUES ( " + bill.ID + " , " + idTV + " , " + nUD.Value.ToString() + " , " + totalPrice + " )";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public BillDTO getTotalPriceByIDBill(BillDTO bill)
        {
            string sql = "SELECT TOTAL_PRICE FROM BILL_INFO WHERE ID_BILL = " + bill.ID;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            bill.TotalPrice = 0;
            for(int i = 0; i < result.Rows.Count; i++)
            {
                bill.TotalPrice += Convert.ToDouble(result.Rows[i][0]);
            }
            return bill;
        }

        public DataTable getListBillInfoByBillID(BillDTO bill)
        {
            string sql = "SELECT ID_TV , COUNT FROM BILL_INFO WHERE ID_BILL = " + bill.ID;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            return result;
        }

        public void DeleteAndGetBill(BillInfoDTO billInfo)
        {
            BillDTO bill = new BillDTO();
            bill.ID = billInfo.IDBill;
            string sql = "SELECT ID_BILL FROM BILL_INFO WHERE ID_TV = " + billInfo.Tivi.ProductId;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            
            for (int i = 0; i < result.Rows.Count; i++)
            {
                sql = "DELETE BILL_INFO WHERE ID_BILL = " + Convert.ToInt32(result.Rows[i][0]);
                DataProvider.Instance.ExecuteNonQuery(sql);
                bill.ID = Convert.ToInt32(result.Rows[i][0]);
                sql = "DELETE BILL_OUT WHERE ID = " + bill.ID;
                DataProvider.Instance.ExecuteNonQuery(sql);
            }
            
        }
    }
}
