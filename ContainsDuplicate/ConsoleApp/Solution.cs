using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            if (0 == nums.Length)
                return false;

            var hs = new HashSet<int>() { nums[0] };
            for (int i = 1, iMax = nums.Length; i < iMax; i++)
            {
                if (hs.Contains(nums[i]))
                    return true;

                hs.Add(nums[i]);
            }

            return false;
        }
    }
}
