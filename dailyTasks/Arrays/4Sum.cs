using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 18. 4Sum
 https://leetcode.com/problems/4sum/description/
 Given an array S of n integers, are there elements a, b, c, and d in S
 such that a + b + c + d = target? Find all unique quadruplets in the
 array which gives the sum of target.
 Note: The solution set must not contain duplicate quadruplets.
 For example, given array S = [1, 0, -1, 0, -2, 2], and target = 0.
 A solution set is:
 [
 [-1,  0, 0, 1],
 [-2, -1, 1, 2],
 [-2,  0, 0, 2]
 ]
 */
    public class Sum_4
    {
        public List<List<int>> fourSum(int[] nums, int target) {
            var res = new List<List<int>>();
            if (nums == null || nums.Length < 4) return res;
            int len = nums.Length;
            Array.Sort(nums);
            for (int i=0; i<len-3; i++) {
                if (i>0 && nums[i] == nums[i-1]) continue;
                for (int j=i+1; j<len-2; j++) {
                    if (j > i+1 && nums[j] == nums[j-1]) continue;
                    int l=j+1, r = len-1;
                    while (l<r) {
                        if (l>j+1 && nums[l] == nums[l-1]) {
                            l++;
                            continue;
                        }
                        if (r<len-1 && nums[r] == nums[r+1]) {
                            r--;
                            continue;
                        }
                        int sum = nums[i] + nums[j] + nums[l] + nums[r];
                        if (sum == target)
                        {
                            res.Add(new List<int>() {nums[i], nums[j], nums[l], nums[r]});
                            l++;
                            r--;
                        } else if (sum > target) {
                            r--;
                        } else {l++;}
                    }
                }
            }
            return res;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            List<List<Integer>> res = s.fourSum(new int[]{1,2,3,4,5}, 10);
        }
    }*/
}