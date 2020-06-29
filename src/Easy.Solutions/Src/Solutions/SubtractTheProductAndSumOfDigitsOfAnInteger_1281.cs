namespace Easy.Solutions.Src.Solutions
{
    public class SubtractTheProductAndSumOfDigitsOfAnInteger_1281
    {
        // Given an integer number n, return the difference between the product of its digits and the sum of its digits.

        // Input: n = 234
        // Output: 15 
        // Explanation: 
        // Product of digits = 2 * 3 * 4 = 24 
        // Sum of digits = 2 + 3 + 4 = 9 
        // Result = 24 - 9 = 15

        // Constraints:
        // 1 <= n <= 10^5

        public int SubtractProductAndSum(int n)
        {

            var product = 1;
            var sum = 0;

            while (n > 0)
            {
                sum += n % 10;
                product *= n % 10;
                n = n / 10;
            }

            return product - sum;

        }

    }
}
