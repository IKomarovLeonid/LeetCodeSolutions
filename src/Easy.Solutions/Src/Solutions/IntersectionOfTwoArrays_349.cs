using System.Collections.Generic;
using System.Linq;

namespace Easy.Solutions.Solutions
{
    public class IntersectionOfTwoArrays_349
    {
        // Task:
        // Given two arrays, write a function to compute their intersection.

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            IEnumerable<int> filter = nums1.Intersect(nums2);
            int[] result = new int[filter.Count()];
            int i = 0;
            foreach (int item in filter)
            {
                result[i] = item;
                i++;
            }
            return result;
        }
    }
}
