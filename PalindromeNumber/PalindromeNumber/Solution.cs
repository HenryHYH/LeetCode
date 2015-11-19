using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            var res = 0;
            var y = x;

            while (y != 0)
            {
                res = res * 10 + y % 10;
                y = y / 10;
            }

            return x == res;
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(11, true)]
        [InlineData(121, true)]
        [InlineData(101, true)]
        [InlineData(1001, true)]
        [InlineData(12, false)]
        public void Test(int x, bool expected)
        {
            var actual = IsPalindrome(x);

            Assert.Equal(expected, actual);
        }
    }
}
