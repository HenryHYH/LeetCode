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
        [InlineData(new[] { 0, 1, 3 }, 2)]
        [InlineData(new[] { 0 }, 1)]
        [InlineData(new[] { 1 }, 0)]
        [InlineData(new[] { 0, 1 }, 2)]
        [InlineData(new[] { 1, 0 }, 2)]
        [InlineData(new[] { 1, 2 }, 0)]
        public void Test(int[] arr, int expected)
        {
            int actual = new Solution().MissingNumber(arr);

            Assert.Equal(expected, actual);
        }
    }
}
