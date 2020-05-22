namespace dailyTasks.LinkedList
{
    /*
142. Linked List Cycle II
https://leetcode.com/problems/linked-list-cycle-ii/
Given a linked list, return the node where the cycle begins.
If there is no cycle, return null.
Note: Do not modify the linked list.
Follow up:
Can you solve it without using extra space?
// Explanation
// https://discuss.leetcode.com/topic/5284/concise-o-n-solution-by-using-c-with-detailed-alogrithm-description
// https://discuss.leetcode.com/topic/19367/java-o-1-space-solution-with-detailed-explanation
// https://discuss.leetcode.com/topic/2975/o-n-solution-by-using-two-pointers-without-change-anything
*/
    public class Cycle
    {
        public ListNode detectCycle(ListNode head) {
            if (head == null || head.next == null) return null;
            ListNode walker = head;
            ListNode runner = head;
            while (runner != null && runner.next != null) {
                walker = walker.next;
                runner = runner.next.next;
                if (runner == walker) {
                    ListNode entry = head;
                    while (entry != walker) {
                        entry = entry.next;
                        walker = walker.next;
                    }
                    return entry;
                }
            }
            return null;
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
            e.next = b;

            Solution s = new Solution();
            ListNode n = s.detectCycle(a);
            System.out.print(n.val);
        }
    }*/
}