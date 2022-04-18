using System;
using System.Collections;

namespace Medium.Solutions.Src.Solutions
{
    public class linked_list_cycle_ii
    {
        // 142. Linked List Cycle II

        // Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.

        // There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer.Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.

        // Do not modify the linked list.

        public ListNode DetectCycle(ListNode head)
        {
            if (head == null) return null;

            ListNode target = null;

            var node = head;
            var array = new ArrayList();

            while (node.next != null)
            {
                var index = array.IndexOf(node.next);
                if (index != -1) return (ListNode)array[index];
                array.Add(node);
                node = node.next;
            }

            return target;

        }
    }

    
     // Definition for singly-linked list.
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
         val = x;
         next = null;
      }
 }

}
