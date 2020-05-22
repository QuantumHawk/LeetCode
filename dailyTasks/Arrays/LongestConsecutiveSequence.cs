using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    
    /**
 128. Longest Consecutive Sequence
 https://leetcode.com/problems/longest-consecutive-sequence/
 Given an unsorted array of integers, find the length of the longest consecutive elements sequence.
 For example,
 Given [100, 4, 200, 1, 3, 2],
 The longest consecutive elements sequence is [1, 2, 3, 4]. Return its length: 4.
 Your algorithm should run in O(n) complexity.
 */
    public class LongestConsecutiveSequence
    {
        // O(n) time complexity
        // https://discuss.leetcode.com/topic/15383/simple-o-n-with-explanation-just-walk-each-streak
        // https://discuss.leetcode.com/topic/25493/simple-fast-java-solution-using-set

        public int longestConsecutive(int[] nums) {
            var hashSet = new HashSet<int>();
            foreach(int num in nums) {
                hashSet.Add(num);
            }
            int max = 0;

            foreach(int i in nums) {
                if (hashSet.Contains(i-1)) continue;
                int j = i;
                while(hashSet.Contains(j)) j++;
                max = Math.Max(max, j-i);
            }
            return max;
        }
    }
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] nums = {100,4,200,1,3,2};
            int min = s.longestConsecutive(nums);
            System.out.print(min);
        }
    }*/

}