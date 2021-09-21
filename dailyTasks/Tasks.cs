using System;
using System.Collections.Generic;
using System.Linq;
//using dailyTasks.LinkedList;

namespace dailyTasks
{
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


    public class input
    {
        public static void Display(ListNode head)
        {
            ListNode start=head;
            while(start!=null)
            {
                Console.Write(start.val+" ");
                start=start.next;
            }
        }
        public static ListNode insert(ListNode head,int data)
        {
            if (head == null) return new ListNode(data);
            else
            if (head.next == null) //&& head.val != data)
                    head.next = new ListNode(data);
                else 
                    insert(head.next, data);
                
                return head;
        }
        // public static void Main(string[] args)
        // {
        //     int n = Convert.ToInt32(Console.ReadLine());
        //     var lists = new ListNode[n];
        //     for (int i = 0; i < n; i++)
        //     {
        //         var array = Console.ReadLine()
        //             .Split(' ')
        //             .Select(int.Parse)
        //             .OrderBy(x => x);
        //         
        //         ListNode m = null;
        //         foreach (var element in array)
        //         {
        //             m = insert(m, element);
        //         }
        //
        //         lists[i] = m;
        //     }
        //
        //     var merge = new Merge_Recursivly();
        //     var res = merge.mergeKLists(lists);
        //     display(res);
        //     Console.ReadKey();
        // }
    }

    public static class IDictionaryExtensions
        {
            public static TKey FindKeyByValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
            {
                if (dictionary == null)
                    throw new ArgumentNullException("dictionary");

                foreach (KeyValuePair<TKey, TValue> pair in dictionary)
                    if (value.Equals(pair.Value))
                        return pair.Key;

                throw new Exception("the value is not found in the dictionary");
            }
        }

        public class Tasks
        {
            #region k-lists



            public static void OptimalMergeSort(int[] a, ref int j, ref int k)
            {
                int min1 = a[0];
                int min2 = a[1];
                for (int i = 2; i < a.Length; i++)
                {
                    if (a[i] < min1)
                    {
                        min2 = min1;
                        min1 = a[i];
                        j = i;
                    }
                    else if (a[i] < min2)
                    {
                        min2 = a[i];
                        k = i;
                    }
                }
            }


            public void merge(int[] nums1, int m, int[] nums2, int n)
            {
                if (nums2.Length == 0) return;
                int p = m - 1;
                int q = n - 1;
                int i = m + n - 1;
                while (p >= 0 && q >= 0)
                {
                    if (nums1[p] > nums2[q])
                    {
                        nums1[i] = nums1[p];
                        p--;
                    }
                    else
                    {
                        nums1[i] = nums2[q];
                        q--;
                    }

                    i--;
                }

                while (q >= 0)
                {
                    nums1[i] = nums2[q];
                    q--;
                    i--;
                }
            }

            public static byte[] MergeSort(byte[] array1, byte[] array2, int m, int n)
            {
                byte[] result = new byte[n + m];
                int i = 0;
                int k = 0;
                int j = 0;
                while (i < m && j < n)
                {
                    if (array1[i] == array2[j])
                    {
                        result[k] = array1[i];
                        i++;
                        j++;
                        k++;
                    }
                    else
                    {
                        if (array1[i] < array2[j])
                        {
                            result[k] = array1[i];
                            i++;
                            k++;
                        }
                        else
                        {
                            result[k] = array2[j];
                            j++;
                            k++;
                        }
                    }
                }

                if (i < m) AddTail(ref result, ref array1, i, ref k);
                if (j < n) AddTail(ref result, ref array2, j, ref k);
                //Package to reference type
                Array.Resize(ref result, k);
                return result;
            }

            public static void AddTail(ref byte[] result, ref byte[] array, int i, ref int k)
            {
                for (int j = i; j < array.Length; j++)
                {
                    result[k] = array[j];
                    k++;
                }
            }


            /*public static void Main(string[] args)
            {
                #region input
                // int n = Convert.ToInt32(Console.ReadLine());
                // byte[][] input = new byte[n+1][];
                // int[] optimalOrder = new int[n];
                // for(int i=0; i<n; i++)
                // {
                //     byte[] array = Console.ReadLine()
                //                           .Split(' ')
                //                           .Select(byte.Parse)
                //                           .ToArray();
                //     Array.Sort(array);
                //     optimalOrder[i] = array.Length;
                //     input[i] = array; 
                // }
                #endregion
    
                int n = 5;
                byte[][] a = new byte[n][];
                byte[] n1 = new byte[] { 6, 2, 26, 64, 88, 96, 96 };
                byte[] n2 = new byte[] { 4, 8, 20, 65, 86 };
                byte[] n3 = new byte[] { 7, 1, 4, 16, 42, 58, 61, 69 };
                //byte[] n4 = new byte[] { 84, 1 };//
                byte[] n5 = new byte[] { 1, 16 };
                //byte[] n6 = new byte[] { 1, 84 };
                //byte[] n7 = new byte[] { 1, 84 };// Contain?
                a[0] = n1;
                a[1] = n2;
                a[2] = n3;
                a[3] = n5;
                a[4] = null;
                
                int j = 0;
                int k = 1;
                
                int[] r = new int[] { n1.Length, n2.Length, n3.Length, n5.Length }; //change to massive.Values
                
                while (n !=0)
                {
                    //OptimalMergeSort(r, ref j, ref k);
                    a[4] = MergeSort(a[j], a[k], a[j].Length, a[k].Length);
                    n--;
                }
              
    
                Console.ReadLine();
    
                /*for (int i = 0; i < n; i++)
                {
                    byte[] b = Console.ReadLine().Split(' ')
                        .GroupBy(x => x).Select(x => Convert.ToByte(x)).ToArray();
                    Array.Sort(b);
                    massive.Add(b, b.Length);
                }#2#
               Array.Sort(n1);
               Array.Sort(n2);
               Array.Sort(n3);
               Array.Sort(n4);
               Array.Sort(n5);
    
               massive.Add(new KeyValuePair<byte,int>(0,n1.Length),n1);
               massive.Add(new KeyValuePair<byte,int>(1,n2.Length),n2);
               massive.Add(new KeyValuePair<byte,int>(2,n3.Length),n3);
               massive.Add(new KeyValuePair<byte,int>(3,n4.Length),n4);
               massive.Add(new KeyValuePair<byte,int>(4,n5.Length),n5);
    
    
    
               while (n >= 0)
               {
                   int min1 = 0;
                   int min2 = 0;
                   OptimalMergeSort(r, out min1, out min2);
                   var q = new KeyValuePair<byte, int>(0, min1);
                   byte[] result = MergeSort(massive[q], massive, min1, min2);
                   massive.Remove();
                   massive.Add(result, result.Length);
    
                   n--;
               }
    
    
               //Remove arrays from dictionary? time<
               //Do nothing Space x2
               #1#
    
            }*/

            #endregion

        }
    }
