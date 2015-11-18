using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            var len = nums.Length;
            if (1 == len)
                return 0 == nums[0] ? 1 : (nums[0] - 1);

            nums = nums.OrderBy(x => x).ToArray();
            int last = nums[0];

            for (int i = 1; i < len; i++)
            {
                if (nums[i] - last > 1)
                    return nums[i] - 1;

                last = nums[i];
            }

            return 0 == nums[0] ? last + 1 : 0;
        }
    }
}
