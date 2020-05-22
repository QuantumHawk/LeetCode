namespace dailyTasks.LinkedList
{
    /*
203. Remove Linked List Elements
https://leetcode.com/problems/remove-linked-list-elements/
Remove all elements from a linked list of integers that have value val.
Example
Given: 1 --> 2 --> 6 --> 3 --> 4 --> 5 --> 6, val = 6
Return: 1 --> 2 --> 3 --> 4 --> 5
*/

    public class RemoveAt
    {
        public ListNode removeAt(ListNode head, int val) {
            if (head == null) return null;
            ListNode newHead = new ListNode(-1);
            newHead.next = head;
            ListNode current = newHead;
            while (current != null) {
                ListNode nextItem = current.next;
                if(nextItem != null && nextItem.val == val) {
                    current.next = nextItem.next;
                } else {
                    current = current.next;
                }
            }
            return newHead.next;
        }
        
        //   recursive solution
        //https://discuss.leetcode.com/topic/12580/3-line-recursive-solution
        public ListNode removeAtRecursive(ListNode head, int val) {
            if (head == null) return null;
            head.next = removeAtRecursive(head.next, val);
            return head.val == val ? head.next : head;
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
            s.deleteNode(c);
            System.out.print(a);
        }
    }*/
    

}