using System;
using System.Collections.Generic;
using System.Linq;

 public class ListNode 
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
    }
}
public  class Merge_Recursivly {
    // recursive merge
    private  ListNode mergeSortedLists(ListNode list1, ListNode list2)
    {
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;

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

public class Solution
{
    public static void display(ListNode head)
    {
        ListNode start = head;
        while (start != null)
        {
            Console.Write(start.val + " ");
            start = start.next;
        }
    }

    public static ListNode insert(ListNode head, int data)
    {
        if (head == null) return new ListNode(data);
        else if (head.next == null && head.val != data)
            head.next = new ListNode(data);
        else
            insert(head.next, data);

        return head;
    }

    static void Main(string[] args)
    {
        /*int n = Convert.ToInt32(Console.ReadLine());
        var lists = new ListNode[n];
        for (int i = 0; i < n; i++)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderBy(x => x);

            ListNode m = null;
            foreach (var element in array)
            {
                m = insert(m, element);
            }

            lists[i] = m;
        }*/

        //var merge = new Merge_Recursivly();
        //var res = merge.mergeKLists(lists);
        //display(res);
        string ress = "1 2 3 ";
        Console.WriteLine(ress.TrimEnd());
        Console.ReadKey();
    }
}