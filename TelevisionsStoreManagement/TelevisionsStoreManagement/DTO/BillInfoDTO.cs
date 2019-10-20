using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class BillInfoDTO
    {
        int iD;
        int iDBill;
        ProductDTO tivi;
        int count;
        double totalPrice;

        public int IDBill { get => iDBill; set => iDBill = value; }
        
        public int Count { get => count; set => count = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        internal ProductDTO Tivi { get => tivi; set => tivi = value; }

        public BillInfoDTO()
        {
            iDBill = 0;
            count = 0;
            tivi = new ProductDTO();
            totalPrice = 0;
        }
    }
}
