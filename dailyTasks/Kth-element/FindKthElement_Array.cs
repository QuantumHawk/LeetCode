using System.Collections.Generic;

namespace dailyTasks.LinkedList
{
    /**
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
        public int findKthLargest(int[] nums, int k)
        {
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

        private int partion(int[] nums, int start, int end)
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
    }
}