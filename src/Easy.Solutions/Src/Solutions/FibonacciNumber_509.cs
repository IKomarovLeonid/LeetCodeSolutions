namespace Easy.Solutions.Solutions
{
    public class FibonacciNumber_509
    {
        // Task: The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,
        // F(0) = 0,   F(1) = 1
        // F(N) = F(N - 1) + F(N - 2), for N > 1.

        public int Fib(int N)
        {
            if (N == 1) return 1;
            if (N == 0) return 0;
            return Fib(N - 1) + Fib(N - 2); // Unfortunately, not good runtime. Using "for" is much better here...
        }
    }
}
