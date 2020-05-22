namespace dailyTasks.LinkedList
{
    /*
234. Palindrome Linked List
https://leetcode.com/problems/palindrome-linked-list/
Given a singly linked list, determine if it is a palindrome.
Follow up:
Could you do it in O(n) time and O(1) space?
*/

    public class Palindrome
    {
        // Great way how to find the middle with two pointers
        // https://discuss.leetcode.com/topic/18304/share-my-c-solution-o-n-time-and-o-1-memory
        // https://discuss.leetcode.com/topic/37978/the-fastest-two-solutions-space-cost-o-n-and-o-1-in-c-with-comments
        // Great explanation
        // https://discuss.leetcode.com/topic/18293/11-lines-12-with-restore-o-n-time-o-1-space
        public bool isPalindrome1(ListNode head)
        {
            if (head == null || head.next == null) return true;
            // 1. find length
            int len = 0;
            ListNode curr = head;
            while (curr != null)
            {
                len++;
                curr = curr.next;
            }

            // 2. revers first half of linked list
            //ListNode secondItem = head.next;
            ListNode prev = null;
            ListNode next = null;
            ListNode current = head;
            for (int i = 1; i <= len / 2; i++)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            // 3. find heads of the fist and second halfs
            ListNode right = (len % 2 == 0) ? current : current.next;
            ListNode left = prev;
            while (left != null && right != null)
            {
                if (left.val == right.val)
                {
                    left = left.next;
                    right = right.next;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public bool isPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            ListNode walker = head, runner = head, prev = null;
            while (runner != null && runner.next != null)
            {
                runner = runner.next.next;
                ListNode next = walker.next;
                walker.next = prev;
                prev = walker;
                walker = next;
            }

            if (runner != null) walker = walker.next;
            while (prev != null)
            {
                if (prev.val != walker.val) return false;
                prev = prev.next;
                walker = walker.next;
            }

            return true;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            ListNode c = new ListNode(3);
            ListNode d = new ListNode(2);
            ListNode e = new ListNode(1);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
            Solution s = new Solution();
            boolean result = s.isPalindrome(a);
            System.out.print(result);
        }
    }*/
}