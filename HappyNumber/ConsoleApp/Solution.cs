using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            if (1 == n)
                return true;
            else if (4 == n)
                return false;
            else
            {
                int tmp = 0;
                while (n > 0)
                {
                    tmp += (int)Math.Pow(n % 10, 2);
                    n = (n - n % 10) / 10;
                }

                return IsHappy(tmp);
            }
        }
    }
}
