using System;

namespace dailyTasks.Arrays
{
    /**
 55. Jump Game
 https://leetcode.com/problems/jump-game/
 Given an array of non-negative integers, you are initially positioned at the first index of the array.
 Each element in the array represents your maximum jump length at that position.
 Determine if you are able to reach the last index.
 For example:
 A = [2,3,1,1,4], return true.
 A = [3,2,1,0,4], return false.
 */
    public class CanJump
    {
        // Great explanation
        // https://discuss.leetcode.com/topic/19931/6-line-java-solution-in-o-n
        // Time complexity O(n), space - O(1).
        public bool canJump(int[] nums) {
            int reachable = 0;
            for (int i=0; i<nums.Length; i++){
                if (i>reachable) return false;
                reachable = Math.Max(i+nums[i], reachable);
            }
            return true;
        }
    }
    
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] nums = {2,3,1,4};
            int[] nums1 = {3,2,1,0,4};
            boolean res = s.canJump(nums1);
            System.out.print(res);
        }
    }*/
}