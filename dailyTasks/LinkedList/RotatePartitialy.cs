namespace dailyTasks.LinkedList
{
/*
61. Rotate List
https://leetcode.com/problems/rotate-list/
Given a list, rotate the list to the right by k places,
where k is non-negative.
For example:
Given 1->2->3->4->5->NULL and k = 2,
return 4->5->1->2->3->NULL.
*/

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
    public class RotatePartitialy
    {
        // Time complexity O(n)
        public ListNode rotateRight(ListNode head, int k) {
            if (k == 0 || head == null || head.next == null) return head;

            // find length
            int size = 1;
            ListNode node = head;
            while (node.next != null) {
                size++;
                node = node.next;
            }
            ListNode tail = node;

            k %= size;
            if (k == 0) return head;

            int nextHeadIndex = size-k;
            ListNode nextTail = head;
            // big trick here is nextHeadIndex-1
            // because of during one iteration we move pointer to the next item
            // for instance [1,2], k=1, nextHeadIndex=1,
            // if we use in loop condition i<nextHeadIndex; loop would be done once
            // and nextTail would be 2, instead of 1.
            for(int i=0; i<nextHeadIndex-1; i++) {
                nextTail = nextTail.next;
            }

            ListNode nextHead = nextTail.next;
            nextTail.next = null;
            tail.next = head;

            return nextHead;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
//        ListNode c = new ListNode(3);
//        ListNode d = new ListNode(4);
//        ListNode e = new ListNode(5);

            a.next = b;
//        b.next = c;
//        c.next = d;
//        d.next = e;

            Solution s = new Solution();
            ListNode result = s.rotateRight(a, 2);
            System.out.print(result);
        }*/
}