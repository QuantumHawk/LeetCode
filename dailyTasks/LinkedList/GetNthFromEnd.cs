using System;

namespace dailyTasks.LinkedList
{
    public class GetNthFromEnd
    {
        public ListNode getNthFromEnd(ListNode head, int n) {
            if (n <1 || head == null)
                return null;

            ListNode pntr1 = head;
            ListNode pntr2 = head;

//advance pntr2 by n-1 nodes;    
            for  (int  i  =  0;  i  <  n  - 1;  ++i)  {  

                if  (pntr2  ==  null)  {
                    /*this is an error condition to check to see if
                       the linked list is less than n nodes long, in which
                       case we just return null indicating an error
                    */
                    return null; 
                }

                     //go to the next node
                    pntr2 = pntr2.next;

            }

            /*Now, keep going until you hit a null node,
              and then you've reached the end, and
              pntr1 will be pointing to the nth from
             last node
            */

            while(pntr2.next != null)
            {
                pntr1 = pntr1.next;
                pntr2 = pntr2.next;
            }

            return pntr1;
        }
    }
    
    public class Solution {
       // public static void Main(string[] args) {
       //     ListNode a = new ListNode(1);
       //     ListNode b = new ListNode(2);
       //     ListNode c = new ListNode(3);
       //     ListNode d = new ListNode(2);
       //     ListNode e = new ListNode(1);
       //     a.next = b;
       //     b.next = c;
       //     c.next = d;
       //     d.next = e;
       //     e.next = null;
       //     GetNthFromEnd s = new GetNthFromEnd();
       //     ListNode result = s.getNthFromEnd(a,3);
       //     Console.ReadLine();
       // }
   }

}