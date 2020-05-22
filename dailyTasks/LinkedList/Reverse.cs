namespace dailyTasks.LinkedList
{
    /*
206. Reverse Linked List
https://leetcode.com/problems/reverse-linked-list/
Reverse a singly linked list.
*/

    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
    public class Reverse
    {
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
           
            ListNode current = head;
            ListNode prev = null;
            ListNode next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            
            return prev;
        }
        
        // Great iterative and recursive solutions
        // https://discuss.leetcode.com/topic/13268/in-place-iterative-and-recursive-java-solution
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
    }
    
    
    /*public static void Main(String[] args)
{
    Item item = new Item(){Value = 10};
    Item item2 = new Item(){Value = 3};
    Item item3 = new Item(){Value = 6};
    Item item4 = new Item(){Value = 7};

    item.Next = item2;
    item2.Next = item3;
    item3.Next = item4;
    item4.Next = null;
    
    ReverseList(item);
    Console.ReadKey();



}*/

}