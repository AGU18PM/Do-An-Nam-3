using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.BUS
{
    class BillBUS
    {
        BillDAL data = new BillDAL();
        public BillDTO createBill(CustomerDTO custommer)
        {
            BillDTO bill = new BillDTO();
            bill.Customer = custommer;
            bill.Status = 0;
            bill.TotalPrice = 0;
            bill.ID = data.createBillNGetIDBill(bill);
            return bill;
        }

        public void submitOrCancelPayment(BillDTO bill, string sdt)
        {
            CustomerDTO customer = new CustomerDTO();
            customer.PhoneNumber = sdt;
            data.submitOrCancelBill(bill);
           // double type = data.getTypeCustomer(customer);
           //    double disCount;
            //if(type == 1)
            //{
            //    disCount = 10;
            //}
            //else if(type == 0)
            //{
            //    disCount = 0;
            //}
            //else
            //{
                
            //}
        }
    }
}
