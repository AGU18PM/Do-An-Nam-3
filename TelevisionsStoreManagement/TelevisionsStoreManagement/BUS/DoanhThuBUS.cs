using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using TelevisionsStoreManagement.DAL;
using TelevisionsStoreManagement.DTO;

namespace TelevisionsStoreManagement.BUS
{
    class DoanhThuBUS
    {
        DoanhThuDAL data = new DoanhThuDAL();

        public void UpdateDoanhThu(DoanhThu doanhThu)
        {
            double dtTam = doanhThu.Value;
            doanhThu = data.getDoanhThuAt(doanhThu);
            doanhThu.Value += dtTam;
            data.UpdateDoanhThu(doanhThu);
        }

        public void ShowDoanhThu(Chart a, DoanhThu doanhThu)
        {
            doanhThu = data.getDoanhThuAt(doanhThu);
            a.DataSource = data.GetDoanhThu();
            a.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            a.ChartAreas["ChartArea1"].AxisY.Title = "Tổng số lượng";
            a.Series["Series1"].Name = "Giá trị";
            a.Series["Giá trị"].XValueMember = "THANG";
            a.Series["Giá trị"].YValueMembers = "VALUE";
        }
    }
}
