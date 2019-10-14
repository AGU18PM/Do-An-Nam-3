using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class ProductDAL
    {
        public DataTable ListProduct(string typeInput)
        {
            string sql = "";
            string sql2 = "";
            if (typeInput == "")
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT from tivi";
                sql2 = "select count(*) from TIVI";
            }
            else
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT from tivi WHERE TYPE = '" + typeInput + "'";
                sql2 = "select count(*) from TIVI WHERE TYPE = '" + typeInput + "'";
            }

            DataTable result = DataProvider.Instance.ExecuteQuery(sql);

            int count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(sql2).Rows[0][0]);
            for (int i = 0; i < count; i++)
            {
                result.Rows[i][4] += " inch";
                if (Convert.ToInt32(result.Rows[i][3]) == 1)
                {
                    result.Rows[i][3] = "Smart";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 2)
                {
                    result.Rows[i][3] = "Internet";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 3)
                {
                    result.Rows[i][3] = "Cong";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 4)
                {
                    result.Rows[i][3] = "Thuong";
                }
            }
            return result;
        }

        public DataTable getListProductByCategory(string category, string typeInput)
        {
            string sql = "";
            if (typeInput == "")
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT from tivi WHERE " + category;
            }
            else
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT from tivi WHERE ( " + category + " ) AND TYPE = '" + typeInput + "'";
                
            }

            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new object[] { category });
            //sql = "GETTVBYCATEGORY @CATEGORY_NAME";
            //int count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(sql,new object[] {product.Category}).Rows[0][0]);
            int count = result.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                result.Rows[i][4] += " inch";
                if (Convert.ToInt32(result.Rows[i][3]) == 1)
                {
                    result.Rows[i][3] = "Smart";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 2)
                {
                    result.Rows[i][3] = "Internet";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 3)
                {
                    result.Rows[i][3] = "Cong";
                }
                else if (Convert.ToInt32(result.Rows[i][3]) == 4)
                {
                    result.Rows[i][3] = "Thuong";
                }
            }
            return result;
        }
    }
}
