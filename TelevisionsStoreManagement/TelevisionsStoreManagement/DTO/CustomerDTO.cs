using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class CustomerDTO
    {
        int iD;
        string name;
        string phoneNumber;
        string cMND;
        int type;
        double payCount;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public int Type { get => type; set => type = value; }
        public double PayCount { get => payCount; set => payCount = value; }
    }
}
