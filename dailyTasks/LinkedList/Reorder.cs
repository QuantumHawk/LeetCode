namespace dailyTasks.LinkedList
{
    
    /*
    143. Reorder List
    https://leetcode.com/problems/reorder-list/
    Given a singly linked list L: L0→L1→…→Ln-1→Ln,
    reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…
    You must do this in-place without altering the nodes' values.
    For example,
    Given {1,2,3,4}, reorder it to {1,4,2,3}.
    */

    public class Reorder
    {
        // It works but I`ve got "time limit exceeded" exception in leetcode.
        // Time complexity O(n* (n/2)) => O(n^2)
        public void reorderList1(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null) return;
            ListNode first = head;
            ListNode second = head.next;
            ListNode current = head;
            while (current.next.next != null) current = current.next;
            ListNode beforeLast = current;
            ListNode last = beforeLast.next;
            first.next = last;
            last.next = second;
            beforeLast.next = null;
            reorderList(second);
        }

        // Tree step solution
        // https://discuss.leetcode.com/topic/4090/accepted-answer-in-java
        // 1. find middle with two pointers
        // 2. reverse second half
        // 3. merge two lists.
        public void reorderList(ListNode head)
        {
            if (head == null || head.next == null || head.next.next == null) return;
            ListNode beforeMiddle = getItemBeforeMiddle(head);
            ListNode head2 = beforeMiddle.next;
            beforeMiddle.next = null;
            head2 = reverse(head2);
            merge(head, head2);
        }

        private ListNode getItemBeforeMiddle(ListNode head)
        {
            ListNode walker = head;
            ListNode runner = head.next;
            while (runner != null && runner.next != null)
            {
                walker = walker.next;
                runner = runner.next.next;
            }

            return walker;
        }

        private ListNode reverse(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode prev = null;
            ListNode curr = head;
            ListNode next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        private void merge(ListNode head1, ListNode head2)
        {
            while (head1 != null && head2 != null)
            {
                ListNode next1 = head1.next;
                ListNode next2 = head2.next;
                head1.next = head2;
                head2.next = next1;

                head1 = next1;
                head2 = next2;
            }
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
            s.reorderList(a);
            System.out.print(a);
        }
    }*/
}