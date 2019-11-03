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
    class CustomerBUS
    {
        CustomerDAL data = new CustomerDAL();

        public bool CheckCustomer(CustomerDTO customer)
        {
            return data.checkCustomer(customer);
        }

        public CustomerDTO getDiscount(CustomerDTO customer)
        {
            return data.getDiscount(customer);
        }

        public void UpdatePayCount(CustomerDTO customer, BillDTO bill)
        {
            data.UpdatePayCount(customer, bill);
        }

        public bool Addcustomer(CustomerDTO customerDto)
        {
            return data.AddCustomer(customerDto);
        }

        public void CountCustomer(Label customer)
        {
            customer.Text = data.CountCustomer().Rows.Count.ToString();
        }
    }
}
