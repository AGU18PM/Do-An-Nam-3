using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DAL
{
    class Category
    {
        int ID;
        string Name;

        public Category()
        {
            ID1 = 0;
            Name1 = "";
        }

        public string Name1 { get => Name; set => Name = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}
