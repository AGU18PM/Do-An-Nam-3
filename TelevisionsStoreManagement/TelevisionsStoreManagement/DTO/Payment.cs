using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelevisionsStoreManagement.DTO
{
    class Payment
    {
        string[] iD = new string[100];
        private int[] countByList = new int[100];
        private double[] price = new double[100];
        int count;
        public Payment()
        {
            Count = 0;
        }

        public int[] CountByList { get => countByList; set => countByList = value; }
        public int Count { get => count; set => count = value; }
        public string[] ID { get => iD; set => iD = value; }
        public double[] Price { get => price; set => price = value; }
    }
}
