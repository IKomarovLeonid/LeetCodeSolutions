namespace Easy.Solutions.Solutions
{
    public class FindNumbersWithEvenNumberOfDigits_1295
    {
        // Given an array nums of integers, return how many of them contain an even number of digits.

        // Input: nums = [555,901,482,1771]
        // Output: 1 
        // Explanation: 
        // Only 1771 contains an even number of digits.

        // Constraints:
        // 1 <= nums.length <= 500
        // 1 <= nums[i] <= 10^5

        public int FindNumbers(int[] nums)
        {

            var resultCount = 0;

            for (int index = 0; index < nums.Length; index++)
            {
                var str = nums[index].ToString();
                if (str.Length % 2 == 0) resultCount++;
            }

            return resultCount;

        }
    }
}
