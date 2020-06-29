using Shared.Common.Src;

namespace Medium.Solutions.Src.Solutions
{
    public class AddTwoNumbers_2
    {
        // Task:
        // You are given two non-empty linked lists representing two non-negative integers. 
        // The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
        // You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        /**
         * Definition for singly-linked list.
         * public class ListNode {
         *     public int val;
         *     public ListNode next;
         *     public ListNode(int x) { val = x; }
         * }
         */


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode output = null; // output node - answer 
            ListNode temp = null;   // prev node
            int count = 0;  // flag of time where we need to add +1 to (l1.val+l2.val)
            while (l1 != null && l2 != null)
            {
                int value = l1.val + l2.val;
                if (count != 0)
                {
                    value++;
                }
                if (value > 9)
                {
                    count = 1;
                    value = value - 10;
                }
                else count = 0;
                ListNode node = new ListNode(value);
                if (temp == null)
                {
                    temp = node;
                    output = node;
                }
                else
                {
                    temp.next = node;
                    temp = node;
                }
                if (count == 1 && l1.next == null && l2.next == null)
                { // 109 and 101 => 2001 for example
                    ListNode node1 = new ListNode(1);
                    temp.next = node1;
                }
                if (count == 0 && l1.next != null && l2.next == null)
                { // 10134 and 102 => 20334 for example
                    temp.next = l1.next;
                }
                if (count == 0 && l1.next == null && l2.next != null)
                { // 102 and 102345 => 104345 
                    temp.next = l2.next;
                }
                if (count == 1 && l1.next != null && l2.next == null)
                { // continue if both lists next are not empty
                    ListNode current = l1.next;
                    temp.next = current;
                    while (current != null)
                    {
                        if (count == 1)
                        {
                            current.val++;
                        }
                        else
                        {
                            temp.next = current;
                            break;
                        }
                        if (current.val > 9)
                        {
                            current.val = current.val - 10;
                            count = 1;
                            temp.next = current;
                            temp = current;
                        }
                        else
                        {
                            count = 0;
                            temp.next = current;
                            temp = current;
                        }
                        if (current.next == null && count == 1)
                        {
                            ListNode newnode = new ListNode(1);
                            temp.next = newnode;
                            break;
                        }
                        current = current.next;
                    }
                }

                if (count == 1 && l1.next == null && l2.next != null)
                {
                    ListNode cur = l2.next;
                    temp.next = cur;
                    while (cur != null)
                    {
                        if (count == 1)
                        {
                            cur.val++;
                        }
                        else
                        {
                            temp.next = cur;
                            break;
                        }
                        if (cur.val > 9)
                        {
                            cur.val = cur.val - 10;
                            count = 1;
                            temp.next = cur;
                            temp = cur;
                        }
                        else
                        {
                            count = 0;
                            temp.next = cur;
                            temp = cur;
                        }
                        if (cur.next == null && count == 1)
                        {
                            ListNode newnode = new ListNode(1);
                            temp.next = newnode;
                            break;
                        }
                        cur = cur.next;
                    }
                }

                l1 = l1.next;
                l2 = l2.next;
            }


            return output;
        }
    }
}
