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
            string rowNum = "AA";
            var solution = new Solution();

            Console.WriteLine("{0} = {1}", rowNum, solution.TitleToNumber(rowNum));
        }

        private readonly Solution solution;

        public Program()
        {
            solution = new Solution();
        }

        [Theory]
        [InlineData("A", 1)]
        [InlineData("Z", 26)]
        [InlineData("AA", 27)]
        [InlineData("AB", 28)]
        [InlineData("BA", 53)]
        public void Test(string rowNum, int expected)
        {
            Assert.Equal(expected, solution.TitleToNumber(rowNum));
        }
    }
}
