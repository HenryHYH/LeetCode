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
        [InlineData(38, 2)]
        public void Test(int num, int expected)
        {
            var actual = new Solution().AddDigits(num);

            Assert.Equal(expected, actual);
        }
    }
}
