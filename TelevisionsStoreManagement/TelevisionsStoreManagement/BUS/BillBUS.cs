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

        public void submitOrCancelPayment(BillDTO bill, string sdt, DoanhThu doanhThu)
        {
            bill.Customer.PhoneNumber = sdt;
            data.submitOrCancelBill(bill, doanhThu);
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

        public void ShowHistory(DataGridView dGV, Label id)
        {
            DataTable result = data.getData();
            BindingSource bS = new BindingSource();
            bS.DataSource = result;
            dGV.DataSource = bS;
            id.DataBindings.Clear();
            id.DataBindings.Add("Text", bS, "ID" ,false, DataSourceUpdateMode.Never);
        }

        public void GetMoreForHistory(DataGridView dGV, string id)
        {
            DataTable result = data.getMoreForHistory(id);
            BindingSource bS = new BindingSource();
            bS.DataSource = result;
            dGV.DataSource = bS;
        }

        public void Delete(BillDTO bill)
        {
            data.Delete(bill);
        }

        public BillDTO GetDate()
        {
            return data.GetDate();
        }
    }
}
