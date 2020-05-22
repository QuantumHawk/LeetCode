namespace dailyTasks.LinkedList
{
    public class InsertionSort
    {
        // main idea to build new list from items of existing one.
        // because this is linked list - no space overhead.
        // https://discuss.leetcode.com/topic/8570/an-easy-and-clear-way-to-sort-o-1-space
        // Time complexity O(n^2), Space complexity O(1)
        public ListNode insertionSortList(ListNode head) {
            if (head == null || head.next == null) return head;

            // start of absolutely new linked list
            ListNode fakeHead = new ListNode(0);

            // runner which starts from the beginning for each element starting from 2nd.
            ListNode pre = fakeHead;
            ListNode curr = head;
            ListNode next = null;

            while (curr != null) {
                next = curr.next;
                // find correct place in new list
                while (pre.next != null && pre.next.val < curr.val) {
                    pre = pre.next;
                }
                curr.next = pre.next;
                pre.next = curr;

                // set pre to the beginning of new list.
                pre = fakeHead;
                curr = next;
            }
            return fakeHead.next;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            ListNode a = new ListNode(3);
            ListNode b = new ListNode(4);
            ListNode c = new ListNode(1);
            ListNode d = new ListNode(1);
            ListNode e = new ListNode(2);

            a.next = b;
            b.next = c;
//        c.next = d;
//        d.next = e;

            Solution s = new Solution();
            ListNode head = s.insertionSortList(a);
            System.out.print(head);
        }
    }*/
}