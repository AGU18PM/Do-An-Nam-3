using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class BillDAL
    {
        public int createBillNGetIDBill(BillDTO bill)
        {
            DataTable result;
            string sql = "INSERT INTO BILL_OUT ( DATE_CHECKIN , ID_CUSTOMER , TOTALPRICE , STATUS ) VALUES ( GETDATE() , " + bill.Customer.ID + " , " + bill.TotalPrice + " , " + bill.Status + " )";
            DataProvider.Instance.ExecuteNonQuery(sql);
            sql = "SELECT ID FROM BILL_OUT";
            result = DataProvider.Instance.ExecuteQuery(sql);
            result.Rows[0][0] = result.Rows[result.Rows.Count - 1][0];
            return Convert.ToInt32(result.Rows[0][0]);
        }

        public void submitOrCancelBill(BillDTO bill)
        {
            string sql;
            if(bill.Status == 1)
            {
                sql = "UPDATE BILL_OUT SET TOTALPRICE = " + bill.TotalPrice.ToString() + " , STATUS = 1 WHERE ID = " + bill.ID;
            }
            else
            {
                sql = "DELETE FROM BILL_INFO WHERE ID_BILL = " + bill.ID;
                DataProvider.Instance.ExecuteNonQuery(sql);
                sql = "DELETE FROM BILL_OUT WHERE ID = " + bill.ID;
            }
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public double getTypeCustomer(CustomerDTO customer)
        {
            string sql = "SELECT TYPE FROM CUSTOMER WHERE PHONE_NUMBER = " + customer.PhoneNumber.ToString();
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            if (result.Rows.Count == 1)
                return Convert.ToDouble(result.Rows[0][0]);
            else
                return 2;
        }
    }
}
