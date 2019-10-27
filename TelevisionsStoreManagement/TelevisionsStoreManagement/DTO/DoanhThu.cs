using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class DoanhThu
    {
        int thang;
        double value;

        public DoanhThu()
        {
            thang = DateTime.Now.Month;
            Value = 0;
        }

        public DoanhThu(int _thang, double _value)
        {
            thang = _thang;
            Value = _value;
        }

        public int Thang { get => thang; set => thang = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
