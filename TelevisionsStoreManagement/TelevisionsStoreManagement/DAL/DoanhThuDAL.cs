using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.DAL
{
    class DoanhThuDAL
    {
        public DoanhThu getDoanhThuAt(DoanhThu doanhThu)
        {
            string sql = "SELECT VALUE FROM REVEN WHERE THANG = " + doanhThu.Thang;
            doanhThu.Value = Convert.ToDouble(DataProvider.Instance.ExecuteQuery(sql).Rows[0][0]);
            return doanhThu;
        }

        public void UpdateDoanhThu(DoanhThu doanhThu)
        {
            string sql = "UPDATE REVEN SET VALUE =" + doanhThu.Value + " WHERE THANG = " + doanhThu.Thang;
            DataProvider.Instance.ExecuteNonQuery(sql);
        }

        public DataTable GetDoanhThu()
        {
            String sql = "SELECT * FROM REVEN";
            return DataProvider.Instance.ExecuteQuery(sql);
        }

        public DataTable GetDoanhThuForHomePage()
        {
            String sql = "select sum(value) from reven";
            return DataProvider.Instance.ExecuteQuery(sql);
        }
    }
}
