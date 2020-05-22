namespace dailyTasks.LinkedList
{
    /*
86. Partition List
https://leetcode.com/problems/partition-list/#/description
Given a linked list and a value x, partition it such that all
nodes less than x come before nodes greater than or equal to x.
You should preserve the original relative order of the nodes in each of the two partitions.
For example,
Given 1->4->3->2->5->2 and x = 3,
return 1->2->2->4->3->5.
*/

    public class Partition
    {
        public ListNode partition(ListNode head, int x)
        {
            if (head == null) return null;
            ListNode less = new ListNode(0);
            ListNode lessHead = less;
            ListNode more = new ListNode(0);
            ListNode moreHead = more;
            ListNode curr = head;
            while (curr != null)
            {
                if (curr.val < x)
                {
                    less.next = curr;
                    less = less.next;
                }
                else
                {
                    more.next = curr;
                    more = more.next;
                }

                curr = curr.next;
            }

            more.next = null;
            less.next = moreHead.next;
            return lessHead.next;
        }

        /*public class Main {
            public static void main(String[] args) {
                ListNode a = new ListNode(2);
                ListNode b = new ListNode(1);
                a.next = b;
                Solution s = new Solution();
                ListNode result = s.partition(a, 2);
                System.out.print(result);
            }
        }*/
    }
}