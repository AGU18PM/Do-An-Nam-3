using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.BUS;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class BillDAL
    {
        CustomerBUS customerBUS = new CustomerBUS();
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

        public void submitOrCancelBill(BillDTO bill, DoanhThu doanhThu)
        {
            double discount = 0;
            string sql;
            if (bill.Status == 1)
            {
                if (customerBUS.CheckCustomer(bill.Customer))
                {
                    bill.Customer = customerBUS.getDiscount(bill.Customer);
                    if (bill.Customer.Type == 1)
                        discount = 20;
                    bill.TotalPrice = bill.TotalPrice - (bill.TotalPrice * discount / 100);
                }
                sql = "UPDATE BILL_OUT SET TOTALPRICE = " + bill.TotalPrice.ToString() + " , STATUS = 1 , ID_CUSTOMER = " + bill.Customer.ID + " WHERE ID = " + bill.ID;
                DataProvider.Instance.ExecuteNonQuery(sql);
                //Them doanh thu
                DoanhThuBUS doanhThuBUS = new DoanhThuBUS();
                double tg = bill.TotalPrice;
                tg -= doanhThu.Value;
                doanhThu.Value = tg;
                doanhThuBUS.UpdateDoanhThu(doanhThu);
                if (customerBUS.CheckCustomer(bill.Customer))
                {
                    customerBUS.UpdatePayCount(bill.Customer, bill);
                }
            }
            else
            {
                sql = "DELETE FROM BILL_INFO WHERE ID_BILL = " + bill.ID;
                DataProvider.Instance.ExecuteNonQuery(sql);
                sql = "DELETE FROM BILL_OUT WHERE ID = " + bill.ID;
                DataProvider.Instance.ExecuteNonQuery(sql);
            }

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

        public DataTable getData()
        {
            string sql = "SELECT * FROM BILL_OUT , CUSTOMER WHERE BILL_OUT.ID_CUSTOMER = CUSTOMER.ID";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            return result;
        }

        public DataTable getMoreForHistory(string ID)
        {
            string sql = "SELECT T.CATEGORY_NAME , T.NAME, T.PRICE_OUT , I.COUNT , I.TOTAL_PRICE FROM BILL_OUT O, BILL_INFO I, TIVI T WHERE O.ID = I.ID_BILL AND I.ID_TV = T.ID AND ID_BILL = " + ID;
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public void Delete(BillDTO bill)
        {
            string sql = "DELETE BILL_OUT WHERE ID = " + bill.ID;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
