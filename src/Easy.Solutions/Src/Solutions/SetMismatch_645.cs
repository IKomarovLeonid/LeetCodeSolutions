﻿using System.Collections.Generic;

namespace Easy.Solutions.Solutions
{
    public class SetMismatch_645
    {
        // Task: The set S originally contains numbers from 1 to n. But unfortunately,
        // due to the data error, one of the numbers in the set got duplicated to another number in the set, 
        // which results in repetition of one number and loss of another number.

        // Given an array nums representing the data status of this set after the error. 
        // Your task is to firstly find the number occurs twice and then find the number that is missing. 
        // Return them in the form of an array


        public int[] FindErrorNums(int[] nums)
        {
            int[] array = new int[2];
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(nums[i])) array[0] = nums[i];
                else hash.Add(nums[i]);
            }

            int j = 1;
            while (true)
            {
                if (!hash.Contains(j))
                {
                    array[1] = j;
                    break;
                }
                j++;
            }
            return array;
        }
    }
}
