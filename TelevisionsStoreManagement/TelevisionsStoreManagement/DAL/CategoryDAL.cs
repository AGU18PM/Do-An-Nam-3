using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class CategoryDAL
    {
        public void AddCategory(CategoryDTO category)
        {
            string sql = "INSERT INTO TVCATEGORY(NAME) VALUES('" + category.Name + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void DeleteCategory(CategoryDTO category)
        {
            string sql = "DELETE FROM TVCATEGORY WHERE NAME = '" + category.Name + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public void EditCategory(CategoryDTO category)
        {
            string sql = "UPDATE TVCATEGORY SET NAME = '" + category.Name + "' WHERE NAME = '" + category.ChangeName + "'";
        }
    }
}
