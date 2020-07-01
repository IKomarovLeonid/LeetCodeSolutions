namespace Easy.Solutions.Solutions
{
    public class FindNUniqueIntegersSumUpToZero_1304
    {
        // Given an integer n, return any array containing n unique integers such that they add up to 0.

        // Input: n = 5
        // Output: [-7,-1,1,3,4]
        // Explanation: These arrays also are accepted[-5, -1, 1, 2, 3] , [-3,-1,2,-2,4].

        public int[] SumZero(int n)
        {

            var arr = new int[n];
            var number = 1;
            for (int index = 0; index < arr.Length; index++)
            {
                if (index == arr.Length - 1)
                {
                    if (n % 2 != 0)
                    {
                        arr[index] = 0;
                    }
                    else
                    {
                        arr[index] = -number;
                    }
                    break;
                }

                if (index % 2 == 0)
                {
                    arr[index] = number;
                }
                else
                {
                    arr[index] = -number;
                    number++;
                }



            }


            return arr;

        }
    }
}
