using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT , COUNT from tivi";
                sql2 = "select count(*) from TIVI";
            }
            else
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT , COUNT from tivi WHERE TYPE = '" + typeInput + "'";
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
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT , COUNT from tivi WHERE " + category;
            }
            else
            {
                sql = "select ID , CATEGORY_NAME , NAME , TYPE , SIZE , PRICE_OUT , COUNT from tivi WHERE ( " + category + " ) AND TYPE = '" + typeInput + "'";
                
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

        public bool Update(DataTable updateData)
        {
            int[] count = new int[100];
            int[] id = new int[100];
            int n = 0;
            for (int i = 0; i < updateData.Rows.Count; i++)
            {
                string sql = "SELECT COUNT FROM TIVI WHERE ID = " + updateData.Rows[i][0];
                DataTable result = DataProvider.Instance.ExecuteQuery(sql);
                int a = Convert.ToInt32(result.Rows[0][0]);
                int b = Convert.ToInt32(updateData.Rows[i][1]);//a so luong san pham nam trong bill, b so luong san pham con trong kho
                count[i] = b;
                id[i] = Convert.ToInt32(updateData.Rows[i][0]);
                n++;
                a -= b;

                sql = "UPDATE TIVI SET COUNT = " + a + " WHERE ID = " + updateData.Rows[i][0];
                DataProvider.Instance.ExecuteNonQuery(sql);
                if (a < 0)
                {
                    MessageBox.Show("So luong trong kho khong du");
                    refundData(count, id, n);
                    return false;
                }
            }
            return true;
        }

        public void refundData(int[] count, int[] id, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string sql = "SELECT COUNT FROM TIVI WHERE ID = " + id[i];
                DataTable result = DataProvider.Instance.ExecuteQuery(sql);
                int a = Convert.ToInt32(result.Rows[0][0]);
                int b = Convert.ToInt32(count[i]);
                a += b;
                sql = "UPDATE TIVI SET COUNT = " + a + " WHERE ID = " + id[i];
                DataProvider.Instance.ExecuteNonQuery(sql);
            }
        }

        public DataTable LoadDataToWareHouseDGV()
        {
            string sql = "SELECT * FROM TIVI";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);

            for (int i = 0; i < result.Rows.Count; i++)
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
