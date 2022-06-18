namespace Easy.Solutions.Solutions
{
    public class MoveZeroes_283
    {
        /// <summary>
        /// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        // Note that you must do this in-place without making a copy of the array.
        /// </summary>

        public void MoveZeroes(int[] nums)
        {
            for (var i = nums.Length - 1; i > -1; i--)
            {
                if (nums[i] != 0) continue;

                // shift
                var j = i;
                while (j < nums.Length - 1)
                {
                    if (nums[j + 1] != 0)
                    {
                        var temp = nums[j + 1];
                        nums[j + 1] = 0;
                        nums[j] = temp;
                        j++;
                    }
                    else break;
                }
            }
        }
    }
}
