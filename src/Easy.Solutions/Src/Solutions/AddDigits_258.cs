namespace Easy.Solutions.Solutions
{
    public class AddDigits_258
    {
        /// <summary>
        /// Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.
        /// </summary>

        public int AddDigits(int num)
        {
            if (num < 0) return 0;
            var currentNum = num;
            while (true)
            {
                currentNum = SumDigits(currentNum);
                if (currentNum < 10) break;
            }
            return currentNum;
        }

        private int SumDigits(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
