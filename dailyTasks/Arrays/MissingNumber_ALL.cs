using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 448. Find All Numbers Disappeared in an Array
 https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/#/description
 Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.
 Find all the elements of [1, n] inclusive that do not appear in this array.
 Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.
 Example:
 Input:
 [4,3,2,7,8,2,3,1]
 Output:
 [5,6]
 */
    public class MissingNumber_ALL
    {
        public List<int> missingNumbers(int[] nums)
        {
            var res = new List<int>();
            if (nums == null || nums.Length == 0) return res;
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0) nums[index] *= -1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]>0) res.Add(i+1);
            }

            return res;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] arr = new int[]{4,3,2,7,8,2,3,1};
            List<Integer> res = s.findDisappearedNumbers(arr);
            System.out.print(res);
        }
    }*/
}