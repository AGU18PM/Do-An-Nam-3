using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DAL;

namespace TelevisionsStoreManagement
{
    class Categorys
    {
        Category[] Categorylist;
        int Count;

        Categorys()
        {
            string query = "Select count(*) from TIVICATEGORY";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            Count = Convert.ToInt32(result.Rows[0][0]);
            for(int i = 0; i < Count; i++)
            {
                Categorylist[i] = new Category();
            }
        }

        public void loadCategorysToListCategorys()
        {
            string query = "select * from TIVICATEGORY";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            for(int i = 0; i< Count; i++)
            {
                Categorylist[i].ID1 = Convert.ToInt32(result.Rows[i][0]);
                Categorylist[i].Name1 = result.Rows[i][1].ToString();
            }
        }
    }
}
