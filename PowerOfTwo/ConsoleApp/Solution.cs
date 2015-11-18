using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            if (0 == n)
                return false;
            else if (n == 1 || n == 2)
                return true;

            return n % 2 == 0 && IsPowerOfTwo(n / 2);
        }
    }
}
