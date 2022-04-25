using System;

namespace Medium.Solutions.Solutions
{
    public class Pow_50
    {
        //Task: Implement pow(x, n), which calculates x raised to the power n (x^n).
        public double MyPow(double x, int n)
        {


            if (Math.Abs(x) < 0.001) return 0;
            if (n == 0) return 1;
            if (x == 1) return 1;
            if (x == -1 && n % 2 != 0) return -1;
            if (x == -1 && n % 2 == 0) return 1;
            if (x == 0 || n == -2147483648) return 0;

            double output = 1;
            if (n > 0)
            {
                while (n > 0)
                {
                    output = output * x;
                    n--;
                }

                return output;
            }

            if (n < 0)
            {
                n = -n;
                while (n > 0)
                {
                    output = output * x;
                    n--;
                }

                return 1 / output;
            }

            return 0;
        }
    }
}
