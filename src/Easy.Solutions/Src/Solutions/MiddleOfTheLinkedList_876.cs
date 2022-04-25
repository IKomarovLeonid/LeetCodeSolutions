using Shared.Common;

namespace Easy.Solutions.Solutions
{
    class MiddleOfTheLinkedList_876
    {
        //Task: Given a non-empty, singly linked list with head node head, return a middle node of linked list.
        // If there are two middle nodes, return the second middle node.


        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */

        public ListNode MiddleNode(ListNode head)
        {
            ListNode temp = head;
            ListNode node = head;
            bool Flag = false;
            while (node != null)
            {
                if (Flag)
                {
                    temp = temp.next;
                    Flag = !Flag;
                }
                else Flag = !Flag;
                node = node.next;
            }
            return temp;
        }
    }
}
