using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public int TitleToNumber(string s)
        {
            var num = 0;
            for (int i = 0, iMax = s.Length; i < iMax; i++)
            {
                num = num * 26 + s[i] - 'A' + 1;
            }

            return num;
        }
    }
}
