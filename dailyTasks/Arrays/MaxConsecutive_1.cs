using System;

namespace dailyTasks.Arrays
{
    /**
 485. Max Consecutive Ones
 https://leetcode.com/problems/max-consecutive-ones/#/description
 Given a binary array, find the maximum number of consecutive 1s in this array.
 Example 1:
 Input: [1,1,0,1,1,1]
 Output: 3
 Explanation: The first two digits or the last three digits are consecutive 1s.
 The maximum number of consecutive 1s is 3.
 Note:
 The input array will only contain 0 and 1.
 The length of input array is a positive integer and will not exceed 10,000
 */
    public class MaxConsecutive_1
    {
        public static int findMaxConsecutiveOnes(int[] nums) {
            int maxHere = 0, max = 0;
            foreach (int n in nums)
                max = Math.Max(max, maxHere = n == 0 ? 0 : maxHere + 1);
            return max; 
        } 
        

        public static int findMaxConsecutiveOnes_2(int[] nums, int k)
        {
            int i = 0;
            int j = 0;
            while (i<nums.Length)
            {
                if (nums[i] == 0) k--;
                i++;
            }
            return i - j;
        }

        /*public static void Main(string[] args)
        {
            int[] nums = {1, 0, 1, 1};
            int max = findMaxConsecutiveOnes(nums);
            Console.WriteLine(max);

        }*/
    }
}