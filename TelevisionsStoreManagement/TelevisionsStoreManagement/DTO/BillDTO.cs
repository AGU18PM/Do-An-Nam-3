using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class BillDTO
    {
        int iD;
        DateTime dateCheckin;
        CustomerDTO customer;
        double totalPrice;
        int status;

        public int ID { get => iD; set => iD = value; }
        public DateTime DateCheckin { get => dateCheckin; set => dateCheckin = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int Status { get => status; set => status = value; }
        internal CustomerDTO Customer { get => customer; set => customer = value; }
    }
}
