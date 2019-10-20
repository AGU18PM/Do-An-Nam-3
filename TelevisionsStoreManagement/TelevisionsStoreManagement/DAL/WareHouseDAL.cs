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
    class WareHouseDAL
    {
        public bool checkCount(string productID, int billCount)
        {
            string sql = "SELECT COUNT FROM WAREHOUSE WHERE ID_TV = " + productID;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            if (result.Rows.Count == 0 || Convert.ToInt32(result.Rows[0][0]) < billCount)
            {
                return false;
            }
            else return true;
        }

        public DataTable getData(string productID)
        {
            string sql = "SELECT COUNT FROM WAREHOUSE WHERE ID_TV = " + productID;
            DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            return result;
        }

        public bool update(DataTable updateData)
        {

            //for (int i = 0; i < updateData.Rows.Count; i++)
            //{
            //    string sql = "SELECT COUNT FROM WAREHOUSE WHERE ID_TV = " + updateData.Rows[i][0];
            //    DataTable result = DataProvider.Instance.ExecuteQuery(sql);
            //    int a = Convert.ToInt32(result.Rows[0][0]);
            //    int b = Convert.ToInt32(updateData.Rows[i][1]);
            //    a -= b;
            //    if (a < 0)
            //        return false;
            //}
            int[] count = new int[100];
            int[] id = new int[100];
            int n = 0;
            int flag = 0;
            for (int i = 0; i < updateData.Rows.Count; i++)
            {
                string sql = "SELECT COUNT FROM WAREHOUSE WHERE ID_TV = " + updateData.Rows[i][0];
                DataTable result = DataProvider.Instance.ExecuteQuery(sql);
                int a = Convert.ToInt32(result.Rows[0][0]);
                int b = Convert.ToInt32(updateData.Rows[i][1]);//a so luong san pham nam trong bill, b so luong san pham con trong kho
                count[i] = b;
                id[i] = Convert.ToInt32(updateData.Rows[i][0]);
                n++;
                a -= b;
                
                sql = "UPDATE WAREHOUSE SET COUNT = " + a + " WHERE ID_TV = " + updateData.Rows[i][0];
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
                string sql = "SELECT COUNT FROM WAREHOUSE WHERE ID_TV = " + id[i];
                DataTable result = DataProvider.Instance.ExecuteQuery(sql);
                int a = Convert.ToInt32(result.Rows[0][0]);
                int b = Convert.ToInt32(count[i]);
                a += b;
                sql = "UPDATE WAREHOUSE SET COUNT = " + a + " WHERE ID_TV = " + id[i];
                DataProvider.Instance.ExecuteNonQuery(sql);
            }
        }
    }
}
