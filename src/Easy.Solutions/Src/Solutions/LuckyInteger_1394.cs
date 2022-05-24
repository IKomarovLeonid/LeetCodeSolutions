using System;
using System.Collections.Generic;

namespace Easy.Solutions.Src.Solutions
{
    public class LuckyInteger_1394
    {
        /// Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.

        /// Return the largest lucky integer in the array.If there is no lucky integer return -1.
        /// 1<= arr[i] <= 500

        public int FindLucky(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }
            var number = -1;
            foreach (var key in dict.Keys)
            {
                if (key == dict[key] && dict[key] > number) number = dict[key];
            }
            return number;
        }
    }
}
