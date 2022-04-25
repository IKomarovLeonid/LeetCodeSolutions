using System;

namespace Easy.Solutions.Solutions
{
    public class MergeSortedArray_88
    {

        // Task:
        // Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array

        // The number of elements initialized in nums1 and nums2 are m and n respectively
        // You may assume that nums1 has enough space (size that is greater or equal to m + n) to hold additional elements from nums2

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int k = 0;
            for (int i = m; i < nums1.Length; i++)
            {
                nums1[i] = nums2[k];
                k++;
            }
            Array.Sort(nums1);
        }
    }
}
