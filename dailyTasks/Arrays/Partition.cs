
using System;

namespace dailyTasks.Arrays
{
    /**
 561. Array Partition I
 https://leetcode.com/problems/array-partition-i/#/description
 Given an array of 2n integers, your task is to group these integers
 into n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn)
 which makes sum of min(ai, bi) for all i from 1 to n as large as possible.
 Example 1:
 Input: [1,4,3,2]
 Output: 4
 Explanation: n is 2, and the maximum sum of pairs is 4.
 Note:
 n is a positive integer, which is in the range of [1, 10000].
 All the integers in the array will be in the range of [-10000, 10000].
 */
    public class Partition
    {
        public int arrayPairSum(int[] nums) {
            Array.Sort(nums);
            int sum = 0;
            for(int i=0; i<nums.Length-1; i=i+2) {
                sum += nums[i];
            }
            return sum;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] arr = {7,3,1,0,0,6};
            int result = s.arrayPairSum(arr);
            System.out.print(result);
        }
    }*/
}