namespace Medium.Solutions.Solutions
{
    public class RemoveNthNodeFromEndOfList_19
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n == 0) return head;
            ListNode temp = head;
            int count = 0;
            while (temp != null)
            { // count number of elements in linked list
                count++;
                temp = temp.next;
            }
            count = count - n; // find position
            temp = head;    // setup temp as a head
            if (count == 0)
            {   // if position is a head node: make next node head, and return it
                head = null;
                head = temp.next;
                return head;
            }
            ListNode prev = null;
            while (count > -1)
            {
                if (count == 0)
                {
                    if (temp.next == null)
                    {
                        prev.next = null; // if next element is n element
                        break;
                    }
                    prev.next = temp.next;
                    break;
                }
                if (prev == null)
                {
                    prev = temp;
                }
                else
                {
                    prev = temp;
                }
                count--;
                temp = temp.next;
            }
            return head;
        }
    }
}
