using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
                return num;

            int tmp = num;
            num = 0;

            while (tmp >= 10)
            {
                num += tmp % 10;
                tmp = tmp / 10;
            }
            num += tmp;

            return AddDigits(num);
        }
    }
}
