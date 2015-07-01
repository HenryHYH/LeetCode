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

        private readonly Solution solution;

        public Program()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(19, true)]
        [InlineData(18, false)]
        public void Test(int number, bool expected)
        {
            Assert.Equal(expected, solution.IsHappy(number));
        }
    }
}
