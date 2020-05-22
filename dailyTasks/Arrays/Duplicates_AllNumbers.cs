using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{ 
    
    /**
 442. Find All Duplicates in an Array
 https://leetcode.com/problems/find-all-duplicates-in-an-array/#/description
 Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array),
 some elements appear twice and others appear once.
 Find all the elements that appear twice in this array.
 Could you do it without extra space and in O(n) runtime?
 Example:
 Input:
 [4,3,2,7,8,2,3,1]
 Output:
 [2,3]
 */
// https://discuss.leetcode.com/topic/64908/java-solution-without-destroying-the-input-array-o-n-time-o-1-space
    public class Duplicates_AllNumbers
    {
        public List<int> findDuplicates(int[] nums)
        {
            var result = new List<int>();
            if (nums == null) throw new ArgumentException("ex");

            foreach (int i in nums) {
                int location = Math.Abs(i) - 1; // index of element where we store the marker
                if (nums[location] < 0) result.Add(Math.Abs(i));
                else nums[location] = -nums[location]; // use -nums[location] like a marker that location item exists in nums
            }
            for (int i=0; i<nums.Length; i++) {
                nums[i] = Math.Abs(nums[i]); // recover array
            }
            return result;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] arr = new int[]{1,2,3,4,4};
            List<Integer> res = s.findDuplicates(arr);
            System.out.print(res);
        }
    }*/
}