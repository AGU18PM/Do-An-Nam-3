using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class WareHouseDTO
    {
        int iD;
        int iDTV;
        int count;

        public int ID { get => iD; set => iD = value; }
        public int IDTV { get => iDTV; set => iDTV = value; }
        public int Count { get => count; set => count = value; }
    }
}
