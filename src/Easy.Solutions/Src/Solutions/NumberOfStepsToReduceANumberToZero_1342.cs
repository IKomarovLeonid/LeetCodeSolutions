namespace Easy.Solutions.Solutions
{
    public class NumberOfStepsToReduceANumberToZero_1342
    {
        // Given a non-negative integer num, return the number of steps to reduce it to zero.
        // If the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.


        public int NumberOfSteps(int num)
        {
            var steps = 0;
            while (num > 0)
            {
                if (num % 2 != 0)
                {
                    num -= 1;
                    steps++;

                }
                else
                {
                    steps++;
                    num = num / 2;
                }


            }

            return steps;
        }
    }
}
