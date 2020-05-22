namespace dailyTasks.LinkedList
{
    /*
24. Swap Nodes in Pairs
https://leetcode.com/problems/swap-nodes-in-pairs/
Given a linked list, swap every two adjacent nodes and return its head.
For example,
Given 1->2->3->4, you should return the list as 2->1->4->3.
Your algorithm should use only constant space. You may not modify the values in the list,
 only nodes itself can be changed.
*/

    public class SwapPairs
    {
        // Time complexity O(n), space complexity O(n) - because recursion affects the stack.
        // https://discuss.leetcode.com/topic/10649/my-simple-java-solution-for-share/2 - non recursive solution
        public ListNode swapPairs(ListNode head) {
            if (head == null || head.next == null) return head;
            ListNode a = head;
            ListNode b = head.next;
            ListNode nextA = b.next;
            b.next = a;
            a.next = swapPairs(nextA);
            return b;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(4);
            ListNode e = new ListNode(5);

            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;

            Solution s = new Solution();
            ListNode result = s.swapPairs(a);
            System.out.print(result);
        }
    }*/
}