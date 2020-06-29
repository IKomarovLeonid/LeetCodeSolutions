namespace Easy.Solutions.Src.Solutions
{
    public class LargestNumberAtLeastTwiceOfOthers_747
    {
        // In a given integer array nums, there is always exactly one largest element.
        // Find whether the largest element in the array is at least twice as much as every other number in the array.
        // If it is, return the index of the largest element, otherwise return -1

        public int DominantIndex(int[] nums)
        {
            int max = 0;
            int maxSecond = 0;
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    maxSecond = max;
                    max = nums[i];
                    index = i;
                }
                else
                {
                    if (nums[i] > maxSecond)
                    {
                        maxSecond = nums[i];
                    }
                }
            }

            if (max >= 2 * maxSecond) return index;
            return -1;
        }
    }
}
