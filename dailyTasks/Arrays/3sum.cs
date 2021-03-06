using System;

namespace dailyTasks.Arrays
{
    /**
 259. 3Sum Smaller
 https://leetcode.com/problems/3sum-smaller/#/description
 Given an array of n integers nums and a target, find the number of index triplets
 i, j, k with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.
 For example, given nums = [-2, 0, 1, 3], and target = 2.
 Return 2. Because there are two triplets which sums are less than 2:
 [-2, 0, 1]
 [-2, 0, 3]
 Follow up:
 Could you solve it in O(n2) runtime?
 */
    public class sum_3
    {
        public int threeSumSmaller(int[] nums, int target) {
            if (nums == null || nums.Length == 0) return 0;

            Array.Sort(nums);
            int len = nums.Length;
            int counter = 0;

            for(int i=0; i<len-2; i++) {
                int left = i+1, right = len-1;
                while (left < right) {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum < target) {
                        counter += right - left;
                        left++;
                    } else {
                        right--;
                    }
                }
            }
            return counter;
        }
    }
}