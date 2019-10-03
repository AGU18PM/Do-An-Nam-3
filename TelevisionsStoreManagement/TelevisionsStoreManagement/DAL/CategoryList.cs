using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DAL
{
    class CategoryList
    {
        private static CategoryList instance;
        public static CategoryList Instance
        {
            get { if (instance == null) instance = new CategoryList(); return CategoryList.instance; }
            private set { CategoryList.instance = value; }
        }

        Category[] list;
        int count;

        int loadCountCategory()
        {
            string query = "select count(*) from TIVICATEGORY";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return Convert.ToInt32(result.Rows[0][0]);
        }

        public CategoryList()
        {
            count = loadCountCategory();
            list = new Category[count];
        }

        public void loadCategoryList()
        {
            string query = "select * from TIVICATEGORY";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            for(int i = 0; i < count; i++)
            {
                list[i] = new Category();
                list[i].ID1 = Convert.ToInt32(result.Rows[i][0]);
                list[i].Name1 = result.Rows[i][1].ToString();
            }
        }
    }
}
