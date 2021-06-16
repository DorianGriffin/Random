using System;
/* Link: https://leetcode.com/problems/add-two-numbers/
 * 
 */
namespace AddToNumbers
{
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
    //solution class
    class Program
    {
        public ListNode addTwoNums(ListNode l1, ListNode l2)
        {
            int rem = 0;

            while (l1 != null || l2 != null)
            {
                int sum = (l1.val + l2.val) + rem;
                if((l1.val + l2.val) >= 10)
                {
                     rem = (l1.val + l2.val)/ 10;
                }
                sum = sum % 10;
                Console.Write(sum);
                if (l1.next == null)
                {
                    l1.next.val = 0;
                }
                if (l2.next == null)
                {
                    l2.next.val = 0;
                }

                l1 = l1.next;
                l2 = l2.next;

                
            }

            return l1;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            //ListNode e3 = new ListNode(0, null);
            //ListNode e2 = new ListNode(2, e3);
            ListNode e1 = new ListNode(9, null);
            ListNode e0 = new ListNode(9, e1);
            ListNode head0 = new ListNode(9, e0);

            //ListNode e7 = new ListNode(0, null);
            //ListNode e6 = new ListNode(2, e7);
            ListNode e5 = new ListNode(9, null);
            ListNode e4 = new ListNode(9, e5);
            ListNode head1 = new ListNode(9, e4);

            p.addTwoNums(head1, head0);

        }
    }
}
