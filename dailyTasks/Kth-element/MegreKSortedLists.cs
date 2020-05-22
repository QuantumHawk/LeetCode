namespace dailyTasks.LinkedList
{
    
/*
23. Merge k Sorted Lists
https://leetcode.com/problems/merge-k-sorted-lists/
Merge k sorted linked lists and return it as one sorted list.
Analyze and describe its complexity.

Initially when the PQ is created, only first elements of each list is added to PQ, and not the entire linked list.
Consider the following example:

[
1->4->5,
1->3->4,
2->6
]
Here , the PQ will have 1,1,2 initially. And each while loop will remove 1 element from the queue using

tail.next=queue.poll();
tail=tail.next;
However, the key point here is the node returned by queue.poll() will still have link to its next node. i.e queue.poll() will return 1 from the PQ and 1 still has a link to next element to 4 in list 1 . Then the below statements will add 4 to priority queue

if (tail.next!=null)
queue.add(tail.next);
*/

    public class MegreKSortedLists
    {
        // No priority Queue solution
        // n - lists array length, s - max linked list size
        // Time complexity O(n^2*s), space O(n)
        // Time limit exceeded in leetcode => need to use Heap.
        public ListNode mergeKLists1(ListNode[] lists) {
            ListNode fakeHead = new ListNode(0);
            ListNode head = fakeHead;
            bool hasNext = lists.Length != 0;
            while (hasNext) {
                int notNullCounter = 0;
                int currIndex = 0;
                ListNode minNode = lists[0];
                for (int i=0; i<lists.Length; i++) {
                    if (lists[i] != null) {
                        if (minNode == null || lists[i].val < minNode.val) {
                            minNode = lists[i];
                            currIndex = i;
                        }
                        notNullCounter++;
                    }
                }
                hasNext = notNullCounter > 0;
                head.next = minNode;
                head = head.next;
                lists[currIndex] = (minNode == null) ? null : minNode.next;

            }
            return fakeHead.next;
        }

        // https://discuss.leetcode.com/topic/2780/a-java-solution-based-on-priority-queue
        // n - lists array length, k - total node count
        //PriorityQueue is a MinHeap
        // Time complexity O(k*log n), space O(n)
        /*public ListNode mergeKLists(ListNode[] lists) {
            ListNode fakeHead = new ListNode(0);
            ListNode head = fakeHead;
            //lambda for comparing ListNode elements
            PriorityQueue<ListNode> heap = new PriorityQueue<ListNode>((a,b) => a.val - b.val);
            foreach(ListNode node in lists) {
                if (node != null) heap.add(node);
            }
            while (!heap.IsEmpty()) {
                ListNode current = heap.poll();
                head.next = current;
                head = head.next;

                if (current.next != null) {
                    heap.add(current.next);
                }
            }
            return fakeHead.next;
        }*/
    }

    /*public class Main
    {
        public static void main(String[] args)
        {
            ListNode a = new ListNode(1);
            ListNode b = new ListNode(5);
            ListNode c = new ListNode(10);
            a.next = b;
            b.next = c;

            ListNode a1 = new ListNode(2);
            ListNode b1 = new ListNode(3);
            ListNode c1 = new ListNode(11);
            a1.next = b1;
            b1.next = c1;

            ListNode a2 = new ListNode(6);
            ListNode b2 = new ListNode(7);
            ListNode c2 = new ListNode(20);
            a2.next = b2;
            b2.next = c2;

            Solution s = new Solution();
            ListNode res = s.mergeKLists(new ListNode[] {a, a1, a2});
            System.out.print(res);
        }
    }*/
}

/*class Solution {
    public ListNode mergeKLists(ListNode[] lists) {

        // initial check
        if (lists == null || lists.length == 0) {
            return null;
        }
        // add first node of each list to the minHeap
        PriorityQueue<ListNode> minHeap = new PriorityQueue<ListNode>((n1, n2) -> n1.val - n2.val);
        for (ListNode node : lists) {
            if (node != null) {
                minHeap.add(node);
            }
        }
        // if no node was added to the minHeap we return null
        if (minHeap.isEmpty()) {
            return null;
        }
        
        // save head since we need to return it
        ListNode head = minHeap.peek();
    
        while(!minHeap.isEmpty()) {
            // extract node from minHeap
            ListNode node = minHeap.poll();
            if (node.next != null) {
                // add next node to minHeap
                minHeap.add(node.next);
            }
            // set node.next
            if (minHeap.peek() != null) {
                node.next = minHeap.peek();
            }
        }
        return head;
    }
}*/