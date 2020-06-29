using System.Collections;
using System.Collections.Generic;

namespace Medium.Solutions.Src.Solutions
{
    public class FindAllDuplicatesInAnArray_442
    {
        //Task: Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
        //Find all the elements that appear twice in this array.

        public IList<int> FindDuplicates(int[] nums)
        {
            IList list = new List<int>();
            Hashtable hash = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i])) list.Add(nums[i]);
                else hash.Add(nums[i], nums[i]);
            }

            return (IList<int>)list;
        }
    }
}
