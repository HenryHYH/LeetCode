using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        [InlineData(127, false)]
        [InlineData(128, true)]
        public void Test(int n, bool expected)
        {
            var actual = new Solution().IsPowerOfTwo(n);

            Assert.Equal(expected, actual);
        }
    }
}
