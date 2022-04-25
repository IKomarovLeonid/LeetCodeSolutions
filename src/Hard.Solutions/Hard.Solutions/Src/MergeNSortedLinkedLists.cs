using System.Collections.Generic;
using System.Linq;

namespace Hard.Solutions
{
    public class MergeNSortedLinkedLists
    {
        private List<int> _items = new List<int>();

        public ListNode MergeKLists(ListNode[] lists)
        {
            ListNode start = null;
            ListNode currentStart = null;

            foreach (var listNode in lists)
            {
                if (listNode == null) continue;

                if (start == null)
                {
                    start = listNode;
                }
                else
                {
                    currentStart.next = listNode;
                }
                currentStart = GetTail(listNode);
            }

            _items.Sort();

            var node = start;

            while (node != null)
            {
                var val = _items.FirstOrDefault();
                if (val == null) break;
                node.val = val;
                _items.RemoveAt(0);
                node = node.next;
            }

            return start;



        }

        private ListNode GetTail(ListNode node)
        {
            var temp = node;
            ListNode tail = null;

            while (temp != null)
            {
                _items.Add(temp.val);
                tail = temp;
                temp = temp.next;
            }
            return tail;
        }


    }

    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;

        }
    }
}
