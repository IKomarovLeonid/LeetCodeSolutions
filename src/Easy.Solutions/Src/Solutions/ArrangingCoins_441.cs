namespace Easy.Solutions.Src.Solutions
{

    public class ArrangingCoins_441
    {
        // Task:
        //You have a total of n coins that you want to form in a staircase shape, where every k-th row must have exactly k coins.
        //Given n, find the total number of full staircase rows that can be formed.
        //n is a non-negative integer and fits within the range of a 32-bit signed integer.

        public int ArrangeCoins(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int j = 1;
            int counter = 0;
            while (j <= n)
            {
                n = n - j;
                if (n < 0) break;
                j++;
                counter++;
            }
            return counter;
        }
    }
}
