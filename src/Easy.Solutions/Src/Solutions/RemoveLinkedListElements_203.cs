using Easy.Solutions.Src.Objects;

namespace Easy.Solutions.Src.Solutions
{
    public class RemoveLinkedListElements_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {

            ListNode prev = null;
            ListNode node = head;

            while (node != null)
            {
                if (node.val == val)
                {
                    if (prev == null)
                    {
                        if (node.next == null)
                        {
                            head = null;
                            break;
                        }
                        else
                        {
                            head = node.next;
                            node = node.next;
                            continue;
                        }
                    }
                    else
                    {
                        prev.next = node.next;
                        node = node.next;
                        continue;
                    }
                }
                prev = node;
                node = node.next;
            }

            return head;
        }
    }
}
