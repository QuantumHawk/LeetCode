namespace dailyTasks.LinkedList
{
    /*
148. Sort List
https://leetcode.com/problems/sort-list/
Sort a linked list in O(n log n) time using constant space complexity.
*/

    public class Sort
    {
        // Time complexity O(n*log n) - because of merge sort.
        // Good solution: use two pointers to get middle.
        // https://discuss.leetcode.com/topic/643/i-have-a-pretty-good-mergesort-method-can-anyone-speed-up-the-run-time-or-reduce-the-memory-usage
        public ListNode sortList1(ListNode head)
        {
            if (head == null || head.next == null) return head;
            int len = 0;
            ListNode curr = head;
            while (curr != null)
            {
                curr = curr.next;
                len++;
            }

            return mergeSort1(head, len);
        }

        private ListNode mergeSort1(ListNode head, int len)
        {
            if (len < 2 || head == null || head.next == null)
            {
                head.next = null;
                return head;
            }

            ListNode headRight = head;
            for (int i = 0; i < len / 2; i++)
            {
                headRight = headRight.next;
            }

            int lenA = len / 2, lenB = len - len / 2;
            ListNode headA = mergeSort1(head, lenA);
            ListNode headB = mergeSort1(headRight, lenB);
            ListNode headNext = new ListNode(0);
            ListNode curr = headNext;
            while (headA != null && headB != null)
            {
                if (headA.val < headB.val)
                {
                    curr.next = headA;
                    headA = headA.next;
                }
                else
                {
                    curr.next = headB;
                    headB = headB.next;
                }

                curr = curr.next;
            }

            curr.next = (headA == null) ? headB : headA;
            return headNext.next;
        }

        

        #region https://discuss.leetcode.com/topic/11021/basically-it-seems-like-merge-sort-problem-really-easy-understand

        

        
        public ListNode sortListSecond(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode walker = head; // head of second list.
            ListNode runner = head; // helper to find middle.
            ListNode tail = head; // tail of first list
            while (runner != null && runner.next != null)
            {
                tail = walker;
                walker = walker.next;
                runner = runner.next.next;
            }

            tail.next = null; // cut list into two separated lists.

            ListNode headA = sortList(head);
            ListNode headB = sortList(walker);
            ListNode headNext = new ListNode(0);
            ListNode curr = headNext;
            while (headA != null && headB != null)
            {
                if (headA.val < headB.val)
                {
                    curr.next = headA;
                    headA = headA.next;
                }
                else
                {
                    curr.next = headB;
                    headB = headB.next;
                }

                curr = curr.next;
            }

            curr.next = (headA == null) ? headB : headA;
            return headNext.next;
        }

        public ListNode sortList(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode f = head.next.next;
            ListNode p = head;
            while (f != null && f.next != null)
            {
                p = p.next;
                f = f.next.next;
            }

            ListNode h2 = sortList(p.next);
            p.next = null;
            return merge(sortList(head), h2);
        }

        public ListNode merge(ListNode h1, ListNode h2)
        {
            ListNode hn = new ListNode(int.MinValue);
            ListNode c = hn;
            while (h1 != null && h2 != null)
            {
                if (h1.val < h2.val)
                {
                    c.next = h1;
                    h1 = h1.next;
                }
                else
                {
                    c.next = h2;
                    h2 = h2.next;
                }

                c = c.next;
            }

            if (h1 != null)
                c.next = h1;
            if (h2 != null)
                c.next = h2;
            return hn.next;
        }
        #endregion

    }
    
    /*public class Main {
        public static void main(String[] args) {
            ListNode a = new ListNode(5);
            ListNode b = new ListNode(3);
            ListNode c = new ListNode(4);
//        ListNode d = new ListNode(2);
//        ListNode e = new ListNode(1);

            a.next = b;
            b.next = c;
//        c.next = d;
//        d.next = e;

            Solution s = new Solution();
            ListNode result = s.sortList(a);
            System.out.print(result);
        }
    }*/

}