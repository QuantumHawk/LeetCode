using System;

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
  public  class Merge_Recursivly {
      
      //public int prev = 0;

        // recursive merge
        private  ListNode mergeSortedLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (list1.next!=null && list1.val == list1.next.val)
            {
                list1.next = list1.next.next;
                mergeSortedLists(list1, list2);
            }
            if (list2.next !=null && list2.val == list2.next.val)
            {
                list2.next = list2.next.next;
                mergeSortedLists(list1, list2);
            }
            
            if (list1.val == list2.val)
            {
                mergeSortedLists(list1.next, list2);
                return list2;

            }
            if (list1.val < list2.val) 
            {
                list1.next = mergeSortedLists(list1.next, list2);
                return list1;
            } else 
            {
                list2.next = mergeSortedLists(list2.next, list1);
                return list2;
            }
        }

        public ListNode mergeKLists(ListNode[] lists, int start, int end) {

            // base cases
            if (start > end)
                return null;
            if (start == end)
                return lists[start];

            // divide and conquer
            int middle = (end + start) / 2;
            ListNode leftList = mergeKLists(lists, start, middle);
            ListNode rightList = mergeKLists(lists, middle + 1, end);
            return mergeSortedLists(leftList, rightList);
        }

        public ListNode mergeKLists(ListNode[] lists) {
            return mergeKLists(lists, 0, lists.Length - 1);
        }
    }

    public static class MegreKSortedLists
    {
        // No priority Queue solution
        // n - lists array length, s - max linked list size
        // Time complexity O(n^2*s), space O(n)
        // Time limit exceeded in leetcode => need to use Heap.
        public static ListNode mergeKLists1(ListNode[] lists) {
            ListNode fakeHead = new ListNode(0);
            ListNode head = fakeHead;
            bool hasNext = lists.Length != 0;
            while (hasNext) {
                int notNullCounter = 0;
                int currIndex = 0;
                ListNode minNode = lists[0];
                for (int i=0; i<lists.Length; i++) {
                    if (lists[i] != null) {
                        if (minNode == null 
                            || (lists[i].val < minNode.val 
                            && lists[i].val!= minNode.val)) {
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
        public static ListNode mergeKLists(ListNode[] lists) {
            ListNode fakeHead = new ListNode(0);
            ListNode head = fakeHead;
            //lambda for comparing ListNode elements
            PriorityQueue<ListNode> heap = new PriorityQueue<ListNode>((a,b) => a.val - b.val);
            foreach(ListNode node in lists) {
                if (node != null) heap.Enqueue(node);
            }
            while (heap.Count()>0) { //!heap.IsEmpty
                ListNode current = heap.Dequeue();
                head.next = current;
                head = head.next;
        
                if (current.next != null) {
                    heap.Enqueue(current.next);
                }
            }
            return fakeHead.next;
        }


        // public static void Main(string[] args)
        // {
        //     ListNode a = new ListNode(0);
        //     ListNode b = new ListNode(0);
        //     ListNode c = new ListNode(0);
        //     ListNode d = new ListNode(10);
        //     ListNode e = new ListNode(10);
        //     a.next = b;
        //     b.next = c;
        //     c.next = d;
        //     d.next = e;
        //
        //     ListNode a1 = new ListNode(0);
        //     ListNode b1 = new ListNode(10);
        //     ListNode c1 = new ListNode(11);
        //     a1.next = b1;
        //     b1.next = c1;
        //
        //     ListNode a2 = new ListNode(6);
        //     //ListNode b2 = new ListNode(7);
        //     //ListNode c2 = new ListNode(20);
        //     //a2.next = b2;
        //     //b2.next = c2;
        //
        //     ListNode[] array = new[] {a, a1, a2};
        //     //ListNode res = mergeKLists1(new ListNode[] {a, a1, a2});
        //     var merge = new Merge_Recursivly();
        //     //merge.prev = a.val;
        //     var res = merge.mergeKLists(array);
        //     Console.ReadKey();
        //     //Console.WriteLine(res);
        // }
    }
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