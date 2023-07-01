using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기말프로젝트
{
    internal class propay
    {
        int[] amount = new int[5]; //음료 잔 수 인덱서로 받음
        public int this[int index]
        {
            get { return amount[index]; }
            set { amount[index] = value; }
        }
        public int Amount()
        {
            int asum = 0;
            for (int i = 0; i < 5; i++)
                asum += amount[i];
            return asum;
        }
    }

    internal class TotalPr : propay //총 금액
    {
        int[] price = new int[1];
        public int this[int index]
        {
            get { return price[index]; }
            set { price[index] = value; }
        }
    }
}
