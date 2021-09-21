using System;
using System.Collections.Generic;

namespace dailyTasks.LinkedList
{
    public class QueueNode : IComparable<QueueNode>
    {
        public int array, index, value;

        public QueueNode(int array, int index, int value)
        {
            this.array = array;
            this.index = index;
            this.value = value;
        }


        public int CompareTo(QueueNode n)
        {
            if (value > n.value) return 1;
            if (value < n.value) return -1;
            return 0;
        }
    }

    public class MergekSortedAnotherApproach
    {
        public int[] merge(int[][] arrays)
        {
            PriorityQueue<QueueNode> pq = new PriorityQueue<QueueNode>();

            int size = 0;
            for (int i = 0; i < arrays.Length; i++)
            {
                size += arrays[i].Length;
                if (arrays[i].Length > 0)
                {
                    pq.Enqueue(new QueueNode(i, 0, arrays[i][0]));
                }
            }

            int[] result = new int[size];
            for (int i = 0; pq.Count() > 0; i++)
            {
                QueueNode n = pq.Dequeue();
                result[i] = n.value;
                int newIndex = n.index + 1;
                if (newIndex < arrays[n.array].Length)
                {
                    pq.Enqueue(new QueueNode(n.array, newIndex,
                        arrays[n.array][newIndex]));
                }
            }

            return result;
        }
        
        /*public static void Main(string[] args)
        {
            ListNode a = new ListNode(0);
            ListNode b = new ListNode(0);
            ListNode c = new ListNode(0);
            ListNode d = new ListNode(10);
            ListNode e = new ListNode(10);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = e;
        
            ListNode a1 = new ListNode(0);
            ListNode b1 = new ListNode(10);
            ListNode c1 = new ListNode(11);
            a1.next = b1;
            b1.next = c1;
        
            ListNode a2 = new ListNode(6);
            ListNode b2 = new ListNode(7);
            ListNode c2 = new ListNode(20);
            a2.next = b2;
            b2.next = c2;

            int[][] arr = new int[][] {new int[]{1,2,3,4,5}, new []{6,7,8} };
            MergekSortedAnotherApproach m = new MergekSortedAnotherApproach();
            var rs = m.merge(arr);
        
            ListNode[] array = new[] {a, a1, a2};
            //ListNode res = mergeKLists1(new ListNode[] {a, a1, a2});
            var merge = new Merge_Recursivly();
            //merge.prev = a.val;
            var res = merge.mergeKLists(array);
            Console.ReadKey();
            //Console.WriteLine(res);
        }*/

    }
}

    
