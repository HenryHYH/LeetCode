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
        [InlineData(new int[] { }, false)]
        [InlineData(new[] { 0 }, false)]
        [InlineData(new[] { 0, 1 }, false)]
        [InlineData(new[] { 0, 1, 1 }, true)]
        public void Test(int[] nums, bool expected)
        {
            var actual = new Solution().ContainsDuplicate(nums);

            Assert.Equal(expected, actual);
        }
    }
}
