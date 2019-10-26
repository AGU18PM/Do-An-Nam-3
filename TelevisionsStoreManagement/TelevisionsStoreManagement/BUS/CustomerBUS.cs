using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
