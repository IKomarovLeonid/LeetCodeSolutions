using System;
using Shared.Common;

namespace Easy.Solutions.Src.Solutions
{
    public class MergeTwoSortedLists_21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var node1 = list1;
            var node2 = list2;

            ListNode output = null;
            ListNode current = null;

            while (node1 != null && node2 != null)
            {
                output = node1;
                node2 = node2.next;
                node1 = node1.next;
            }

            return output;
        }
    }
}
