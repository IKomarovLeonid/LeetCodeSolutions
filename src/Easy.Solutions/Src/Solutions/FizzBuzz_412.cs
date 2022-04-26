using System.Collections.Generic;
namespace Easy.Solutions.Src.Solutions
{
    public class FizzBuzz_412
    {
        /*
         * Given an integer n, return a string array answer (1-indexed) where:

           answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
           answer[i] == "Fizz" if i is divisible by 3.
           answer[i] == "Buzz" if i is divisible by 5.
           answer[i] == i (as a string) if none of the above conditions are true.
         * 
         * 
         * 
         */


        public IList<string> FizzBuzz(int n)
        {
            var i = 1;
            var list = new List<string>();
            while (i <= n)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        list.Add("Fizz");
                    }
                    else
                    {
                        if (i % 5 == 0) list.Add("Buzz");
                        else list.Add(i.ToString());
                    }
                }
                i++;
            }

            return list;
        }
    }
}
