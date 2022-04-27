using System;
using Shared.Common;

namespace Easy.Solutions.Src.Solutions
{
    public class BinaryToInteger_1290
    {
        /*
         * Given head which is a reference node to a singly-linked list. 
         * The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.

           Return the decimal value of the number in the linked list.
         * 
         * 
         * 
         * 
         */


        public int GetDecimalValue(ListNode head)
        {
            var node = head;
            var rez = 0;
            var j = -1;
            var array = new int[30];
            while (node != null)
            {
                array[++j] = node.val;
                node = node.next;
            }
            for (int i = 0; i < array.Length && j > -1; i++, j--)
            {
                rez += array[i] * (int)Math.Pow(2, j);
            }


            return rez;
        }
    }
}
