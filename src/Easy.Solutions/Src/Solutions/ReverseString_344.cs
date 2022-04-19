using System;
namespace Easy.Solutions.Src.Solutions
{
    class ReverseString_344
    {
        /*
         * Write a function that reverses a string. The input string is given as an array of characters s.

           You must do this by modifying the input array in-place with O(1) extra memory.
         */


        public void ReverseString(char[] s)
        {
            int index = 0;
            for (int j = s.Length - 1; j >= 0; j--)
            {
                if (index <= j)
                {
                    var temp = s[j];
                    s[j] = s[index];
                    s[index] = temp;
                    index++;
                    continue;
                }
                break;
            }
        }
    }
}
