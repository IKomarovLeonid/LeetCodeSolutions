using System.Collections.Generic;

namespace Easy.Solutions.Src.Solutions
{
    public class NRepeatedElementInSize2NArray_961
    {
        //Task:
        //In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.
        //Return the element repeated N times.

        public int RepeatedNTimes(int[] A)
        {
            HashSet<int> hash = new HashSet<int>(); // add element to hashset and then if hashset contains element => we return element
            for (int i = 0; i < A.Length; i++)
            {
                if (!hash.Contains(A[i]))
                    hash.Add(A[i]);
                else return A[i];
            }
            return 0;
        }
    }
}
