using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelevisionsStoreManagement.DAL
{
    class Products
    {
        Product[] list;
        int count;


        private static Products instance;
        public static Products Instance
        {
            get { if (instance == null) instance = new Products(); return instance; }
            private set { instance = value; }
        }

        public  Products()
        {
            string query = "Select count(*) from TIVI";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            Instance.Count = Convert.ToInt32(result.Rows[0][0]);
            Instance.List = new Product[Instance.Count];
            for(int i = 0; i < Instance.Count; i++)
            {
                Instance.List[i] = new Product();
            }
        }

        public void load_Data()
        {
            string query = "Select * from TIVI";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            for(int i = 0; i < Instance.Count; i++)
            {
                Instance.List[i].ProductId1 = Convert.ToInt32(result.Rows[i][0]);
                Instance.List[i].ProductName1 = result.Rows[i][1].ToString();
                Instance.List[i].Price1 = Convert.ToDouble(result.Rows[i][3]);
                Instance.List[i].Picture = result.Rows[i][4].ToString();
            }
        }

        

        internal Product[] List { get => list; set => list = value; }
        public int Count { get => count; set => count = value; }
    }
}
