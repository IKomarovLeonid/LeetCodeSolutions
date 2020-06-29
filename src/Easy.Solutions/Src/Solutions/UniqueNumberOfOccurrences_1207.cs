using System.Collections.Generic;

namespace Easy.Solutions.Src.Solutions
{
    public class UniqueNumberOfOccurrences_1207
    {
        // Given an array of integers arr, write a function that returns true if and only if the number of occurrences of each value in the array is unique.

        // Input: arr = [1,2,2,1,1,3]
        // Output: true
        // Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.

        // Constraints:
        // 1 <= arr.length <= 1000
        // -1000 <= arr[i] <= 1000

        public bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            for (int index = 0; index < arr.Length; index++)
            {
                if (!dict.ContainsKey(arr[index]))
                {
                    dict.Add(arr[index], 1);
                }
                else dict[arr[index]]++;
            }

            var hash = new HashSet<int>();

            foreach (var value in dict.Values)
            {
                if (hash.Contains(value)) return false;
                hash.Add(value);
            }

            return true;
        }
    }
}
