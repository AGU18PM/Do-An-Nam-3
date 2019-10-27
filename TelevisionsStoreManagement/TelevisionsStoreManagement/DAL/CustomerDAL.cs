using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class CustomerDAL
    {
        public bool checkCustomer(CustomerDTO customer)
        {
            string sql = "SELECT * FROM CUSTOMER WHERE PHONE_NUMBER =" + customer.PhoneNumber;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            if (result.Rows.Count == 0)
                return false;
            return true;
        }

        public CustomerDTO getDiscount(CustomerDTO customer)
        {
            string sql = "SELECT * FROM CUSTOMER WHERE PHONE_NUMBER =" + customer.PhoneNumber;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            customer.ID = Convert.ToInt32(result.Rows[0][0]);
            customer.Name = result.Rows[0][1].ToString();
            customer.Type = Convert.ToInt32(result.Rows[0][3]);
            customer.PayCount = Convert.ToInt32(result.Rows[0][4]);
            return customer;
        }

        public void UpdatePayCount(CustomerDTO customerDto, BillDTO bill)
        {
            string sql = "SELECT PAYCOUNT FROM CUSTOMER WHERE PHONE_NUMBER = " + customerDto.PhoneNumber;
            customerDto.PayCount = Convert.ToDouble(DataProvider.Instance.ExecuteQuery(sql).Rows[0][0]);
            customerDto.PayCount += bill.TotalPrice;
            if (customerDto.PayCount > 30000000 && customerDto.PhoneNumber != "1")
            {
                UpdateType(customerDto);
            }
            sql = "UPDATE CUSTOMER SET PAYCOUNT = " + customerDto.PayCount + " WHERE PHONE_NUMBER = " + customerDto.PhoneNumber;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void UpdateType(CustomerDTO customerDto)
        {
            string sql = "UPDATE CUSTOMER SET TYPE = 1 WHERE PHONE_NUMBER = " + customerDto.PhoneNumber;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public bool AddCustomer(CustomerDTO customerDto)
        {
            if (checkCustomer(customerDto))
                return false;
            string sql = "INSERT INTO CUSTOMER (NAME, PHONE_NUMBER, TYPE, PAYCOUNT) VALUES (N'" + customerDto.Name + "' , '" + customerDto.PhoneNumber + "' , 0 , 0)";
            DataProvider.Instance.ExecuteNonQuery(sql);
            return true;
        }
    }
}
