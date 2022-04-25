namespace Easy.Solutions.Solutions
{
    public class ValidPerfectSquare_367
    {
        // Task:
        // Given a positive integer num, write a function which returns True if num is a perfect square else False.
        // Note: Do not use any built-in library function such as sqrt.

        public bool IsPerfectSquare(int num)
        {
            if (num == 1) return true;
            int i = 2;
            while (true)
            {
                if ((double)num / i == i) return true;
                if (num / i < i) break;
                i++;
            }
            return false;
        }
    }
}
