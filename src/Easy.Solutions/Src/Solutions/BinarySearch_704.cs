namespace Easy.Solutions.Src.Solutions
{
    public class BinarySearch_704
    {
        //Task:
        //Given a sorted (in ascending order) integer array nums of n elements and a target value, write a function to search target in nums. 
        //If target exists, then return its index, otherwise return -1.

        public int Search(int[] nums, int target)
        {
            int start = 0; // first index of nums
            int end = nums.Length - 1; // last index of nums
            while (start <= end)
            {
                int i = (start + end) / 2;
                if (nums[i] < target)
                {
                    start = i + 1;
                }
                if (nums[i] > target)
                {
                    end = i - 1;
                }
                if (nums[i] == target) return i;
            }
            return -1; // target not found, so return -1
        }
    }
}
