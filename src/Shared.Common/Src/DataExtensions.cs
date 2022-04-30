using System;
using System.Collections.Generic;
using ListNode = Shared.Common.ListNode;

namespace Shared.Common.Src
{
    public static class DataExtensions
    {
        public static ICollection<int> ToListOfValues(this ListNode node)
        {
            if (node == null) return new List<int>();
            var list = new List<int>();
            var n = node;

            while (n != null)
            {
                list.Add(n.val);
                n = n.next;
            }

            return list;
        }
    }
}
