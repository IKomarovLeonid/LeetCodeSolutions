using System.Collections.Generic;
using System.Linq;

namespace Easy.Solutions.Src.Solutions
{
    internal class SingleNumber_136
    {
        /*
         * Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
          You must implement a solution with a linear runtime complexity and use only constant extra space.
        */


        public int SingleNumber(int[] nums)
        {
            if(nums == null || nums.Length == 0) return 0;

            var candidates = new HashSet<int>();
            var output = new List<int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!candidates.Add(nums[i]))
                {
                    output.Remove(nums[i]);
                }
                else
                {
                    output.Add(nums[i]);
                }
            }

            return output.Count > 0 ? output.First() : 0;
        }
    }
}
