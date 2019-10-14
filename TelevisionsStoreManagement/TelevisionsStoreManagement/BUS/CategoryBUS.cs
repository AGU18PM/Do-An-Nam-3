using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.BUS
{
    class CategoryBUS
    {
        CategoryDAL data = new CategoryDAL();
        public void AddCategory(CategoryDTO category)
        {
            data.AddCategory(category);
        }

        public void DeleteCategory(CategoryDTO category)
        {
            data.DeleteCategory(category);
        }

        public void EditCategory(CategoryDTO category)
        {
            data.EditCategory(category);
        }
    }
}
