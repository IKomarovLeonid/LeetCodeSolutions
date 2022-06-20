namespace Easy.Solutions.Solutions
{
    public class MonotonicArray_896
    {
        public bool IsMonotonic(int[] nums)
        {
            bool? isIncrease = null;

            for (var i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1] && isIncrease == null) continue;

                if (nums[i] <= nums[i + 1] && isIncrease == null)
                {
                    isIncrease = true;
                }
                if (nums[i] >= nums[i + 1] && isIncrease == null)
                {
                    isIncrease = false;
                }

                if (nums[i] > nums[i + 1] && isIncrease.Value) return false;

                if (nums[i] < nums[i + 1] && !isIncrease.Value) return false;
            }
            return true;
        }
    }
}
