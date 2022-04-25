namespace Easy.Solutions.Solutions
{
    public class SumOfTwoIntegers_371
    {
        public int GetSum(int a, int b)
        {
            if (b == 0) return a;
            int sum = a ^ b;
            int tempValue = (a & b) << 1;
            return GetSum(sum, tempValue);
        }
    }
}
