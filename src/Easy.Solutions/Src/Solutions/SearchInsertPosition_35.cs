namespace Easy.Solutions.Src.Solutions
{
    public class SearchInsertPosition_35
    {
        // Task: Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        //You may assume no duplicates in the array.

        public int SearchInsert(int[] nums, int target)
        {
            int output = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    output = i;
                    break;
                }
                if (target < nums[i])
                {
                    if ((i - 1) < 0)
                    {
                        output = 0;
                        break;
                    }
                    else
                    {
                        output = i;
                        break;
                    }
                }
                if (target > nums[nums.Length - 1])
                {
                    output = nums.Length;
                }
            }
            return output;
        }
    }
}
