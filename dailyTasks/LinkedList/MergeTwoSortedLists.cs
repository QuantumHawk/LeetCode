using System;
using System.Text;

namespace dailyTasks.LinkedList
{

    /*Merge two sorted linked lists and return it as a new list.
    The new list should be made by splicing together the nodes of the first two lists.

    Example:

    Input: 1->2->4, 1->3->4
    Output: 1->1->2->3->4->4*/
    public class MergeTwoSortedLists
    {

        // Definition for singly-linked list.
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

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            // Validation;
            if (l1 == null && l2 == null) return null;
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            // Set head of new list;
            ListNode res = new ListNode(-1);

            ListNode current = res;
            while (l1 != null || l2 != null)
            {
                int val1 = (l1 == null) ? int.MaxValue : l1.val;
                int val2 = (l2 == null) ? int.MaxValue : l2.val;
                if (val1 < val2)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            return res.next;
        }

    }
    // public class Main {
    //     public static void Main(string[] args) {
    //         ListNode a = new ListNode(1);
    //         ListNode b = new ListNode(3);
    //         ListNode c = new ListNode(5);
    //         ListNode d = new ListNode(2);
    //         ListNode e = new ListNode(4);
    //
    //         // first list
    //         a.next = b;
    //         b.next = c;
    //
    //         // second list
    //         d.next = e;
    //         
    //         MergeTwoSortedLists s = new MergeTwoSortedLists();
    //         ListNode result = s.MergeTwoLists(a,d);
    //         Console.WriteLine(result);
    //     }
    // }
}
