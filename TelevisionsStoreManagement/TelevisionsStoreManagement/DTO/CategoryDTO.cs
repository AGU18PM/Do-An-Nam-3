using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class CategoryDTO
    {
        string name;
        string changeName;

        public string Name { get => name; set => name = value; }
        public string ChangeName { get => changeName; set => changeName = value; }
    }
}
