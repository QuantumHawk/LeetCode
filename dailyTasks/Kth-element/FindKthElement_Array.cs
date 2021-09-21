using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks.LinkedList
{
    /**
     * https://www.programmerinterview.com/data-structures/find-nth-to-last-element-in-a-linked-list/
 * Quick selection problem: find Kth element in array.
 */

    /**
 215. Kth Largest Element in an Array
 https://leetcode.com/problems/kth-largest-element-in-an-array/description/
 Find the kth largest element in an unsorted array.
 Note that it is the kth largest element in the sorted order, not the kth distinct element.
 For example,
 Given [3,2,1,5,6,4] and k = 2, return 5.
 Note:
 You may assume k is always valid, 1 ? k ? array's length.
 
 
         Arrays.sort(nums);
        return nums[nums.length -1 -(k-1)];
        
 Its correct but time complexity of your solution is O(nlogn) + O(logn) stack space assuming the sort method uses merge sort.
  The QuickSelect Algorithm allows you to find kth largest number on O(n) amortized time.
 */
// use quick selection algorithm
// https://github.com/Semaserg/LeetCodeProblems/blob/master/sorting/QuickSort/QuickSelection.java
    public class QuickSelection
    {
        public static int findKthLargest(int[] nums, int k)
        {
            int i = 0;
            var ttt = new List<int>() {1, 2, 3};
            var s = ttt.Select(_ => i++).First();

            var d = new Dictionary<object,object>();
            d.Add(new object(), new object());
            d.Add(new object(), new object());
            var t =d[new object()];
            int start = 0, end = nums.Length - 1, index = nums.Length - k;
            while (start < end)
            {
                int pivot = partion(nums, start, end);
                if (pivot < index) start = pivot + 1;
                else if (pivot > index) end = pivot - 1;
                else return nums[pivot];
            }

            return nums[start];
        }

        private static int partion(int[] nums, int start, int end)
        {
            int pivot = start, temp;
            while (start <= end)
            {
                while (start <= end && nums[start] <= nums[pivot]) start++;
                while (start <= end && nums[end] > nums[pivot]) end--;
                if (start > end) break;
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
            }

            temp = nums[end];
            nums[end] = nums[pivot];
            nums[pivot] = temp;
            return end;
        }

        // public static void Main(string[] args)
        // {
        //     int[] A = {5,7,2,3,1,6};
        //     int N = 3;
        //     int res = findKthLargest(A, N);
        //     //int m = 4;
        //     // Console.WriteLine("Input  : " + String.Join(",", A));
        //     // Console.WriteLine("Result : " + String.Join(",", B));
        //     Console.ReadKey();
        //
        // }
    }
}