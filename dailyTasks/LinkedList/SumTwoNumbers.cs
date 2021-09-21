using System;

namespace dailyTasks.LinkedList
{
    /*2. Add Two Numbers
    https://leetcode.com/problems/add-two-numbers/
    You are given two linked lists representing two non-negative numbers.
    The digits are stored in reverse order and each of their nodes contain
    a single digit. Add the two numbers and return it as a linked list.
    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8*/
    public class SumTwoNumbers
    {
        public ListNode reverseList(ListNode head) {
            if (head == null || head.next == null) return head;
            return reverseListRecursive(null, head);
        }
        public ListNode reverseListRecursive(ListNode prev, ListNode head) {
            if (head == null) return prev;
            
            ListNode newPrev = head;
            ListNode newHead = head.next;
            head.next = prev;
            return reverseListRecursive(newPrev, newHead);
        }
        
        public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
            ListNode l11 = reverseList(l1);
            ListNode l22 = reverseList(l2);
            if (l11 == null) return l22;
            if (l22 == null) return l11;
            ListNode beforeHead = new ListNode(-1);
            int extra = 0;
            ListNode current = beforeHead;
            while (l11 != null || l22 != null || extra>0) {
                int a = (l11 == null) ? 0 : l11.val;
                int b = (l22 == null) ? 0 : l22.val;
                int sum = (a + b + extra) % 10;
                extra = (a + b + extra) > 9 ? 1 : 0;
                current.next = new ListNode(sum);
                current = current.next;
                if (l11 != null) l11 = l11.next;
                if (l22 != null) l22 = l22.next;
            }
            return beforeHead.next;
        }
    }
    
    // public class Main {
    //     public static void main(string[] args) {
    //         ListNode a = new ListNode(1);
    //         ListNode b = new ListNode(2);
    //         ListNode c = new ListNode(3);
    //         ListNode d = new ListNode(4);
    //         ListNode e = new ListNode(5);
    //
    //         a.next = b;
    //         c.next = d;
    //         d.next = e;
    //
    //         SumTwoNumbers s = new SumTwoNumbers();
    //         ListNode res = s.addTwoNumbers(a, c);
    //         Console.WriteLine(res);
    //     }
    // }
}