using System;
using System.Collections;

namespace Easy.Solutions.Solutions
{
    public class MissingNumber_268
    {
        public int MissingNumber(int[] array)
        {
            var rez = -1;
            var ht = new Hashtable();
            foreach (var t in array)
            {
                ht.Add(t, t);
            }
            Console.WriteLine();
            var j = 0;
            while (j < array.Length)
            {
                if (!ht.ContainsKey(j))
                {
                    rez = j;
                    break;
                }
                j++;
            }
            return rez != -1 ? rez : array.Length;
        }
    }
}
