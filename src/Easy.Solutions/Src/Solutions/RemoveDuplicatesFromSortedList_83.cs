using Shared.Common.Src;

namespace Easy.Solutions.Src.Solutions
{
    public class RemoveDuplicatesFromSortedList_83
    {
        // Task:
        // Given a sorted linked list, delete all duplicates such that each element appear only once.

        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */

        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode node = head;
            ListNode temp = null;
            while (node != null)
            {
                if (node.next == null) break;
                else
                {
                    if (node.next.val == node.val)
                    {
                        ListNode n = node.next;
                        while (n != null)
                        {
                            if (n.val != node.val)
                            {
                                node.next = n;
                                break;
                            }

                            if (n.next == null)
                            {
                                node.next = null;
                                break;
                            }

                            n = n.next;
                        }
                    }
                }

                node = node.next;
            }

            return head;
        }
    }
}
