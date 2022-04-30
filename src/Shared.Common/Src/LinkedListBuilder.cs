using System;
namespace Shared.Common.Src
{
    public class LinkedListBuilder
    {
        public static ListNode Build(params int[] values)
        {
            if (values == null || values.Length == 0) throw new ArgumentException(nameof(values));

            ListNode head = null;
            ListNode prev = null;

            foreach(var item in values)
            {
                if(head == null)
                {
                    head = new ListNode(item);
                    prev = head;
                    continue;
                }
                var node = new ListNode(item);
                prev.next = node;
            }

            return head;
        }
    }
}
