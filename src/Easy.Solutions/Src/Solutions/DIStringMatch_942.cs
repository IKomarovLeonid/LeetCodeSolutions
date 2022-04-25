namespace Easy.Solutions.Solutions
{
    public class DIStringMatch_942
    {
        // Given a string S that only contains "I" (increase) or "D" (decrease), let N = S.length.
        // Return any permutation A of [0, 1, ..., N] such that for all i = 0, ..., N-1:
        // If S[i] == "I", then A[i] < A[i+1]
        // If S[i] == "D", then A[i] > A[i+1]

        public int[] DiStringMatch(string S)
        {
            int n = S.Length;
            int[] returnArray = new int[n + 1];
            int start = 0;
            int end = n;
            int currentIndex = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                {
                    returnArray[currentIndex] = start;
                    start++;
                    currentIndex++;
                }
                else
                {
                    returnArray[currentIndex] = end;
                    end--;
                    currentIndex++;
                }
            }
            returnArray[n] = end;
            return returnArray;
        }
    }
}
