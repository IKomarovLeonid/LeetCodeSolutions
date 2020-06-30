namespace Easy.Solutions.Solutions
{
    public class CheckIfNAndItsDoubleExist_1346
    {
        // Given an array arr of integers, check if there exists two integers N and M such that N is the double of M(i.e.N = 2 * M).

        // More formally check if there exists two indices i and j such that :

        // i != j
        // 0 <= i, j<arr.length
        //  arr[i] == 2 * arr[j]

        // Input: arr = [10,2,5,3]
        // Output: true
        // Explanation: N = 10 is the double of M = 5,that is, 10 = 2 * 5.

        public bool CheckIfExist(int[] arr)
        {

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int j = index - 1;
                int k = index + 1;
                while (j > -1 && k < arr.Length)
                {
                    if (arr[j] == arr[index] * 2 || arr[index] == arr[j] * 2) return true;
                    j--;
                    if (arr[index] * 2 == arr[k] || arr[k] * 2 == arr[index]) return true;
                    k++;
                }
            }

            return false;


        }
    }
}
