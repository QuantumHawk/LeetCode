using System;

namespace dailyTasks.Arrays
{
    
    /**
 11. Container With Most Water
 https://leetcode.com/problems/container-with-most-water/
 Given n non-negative integers a1, a2, ..., an,
 where each represents a point at coordinate (i, ai). n vertical
 lines are drawn such that the two endpoints of line i is at (i, ai)
 and (i, 0). Find two lines, which together with x-axis forms a container,
 such that the container contains the most water.
 Note: You may not slant the container.
 
 s.maxArea(new int[]{2,3,10,5,7,8,9})
 */
    public class ContainerWithWater
    {
        // Good solution
        // https://discuss.leetcode.com/topic/16754/simple-and-fast-c-c-with-explanation
        // https://discuss.leetcode.com/topic/50763/from-dp-to-greedy-o-n-with-explanation-easy-way-to-see-this-problem
        public int maxArea(int[] height) {
            if (height == null || height.Length<2) return 0;
            int left = 0;
            int right = height.Length-1;
            int max = 0;
            while (left < right) {
                int area = (right - left) * Math.Min(height[left], height[right]);
                if (area > max) max = area;
                if (height[left] <= height[right]) {
                    left++;
                } else {
                    right--;
                }
            }
            return max;
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            System.out.print(s.maxArea(new int[]{2,3,10,5,7,8,9}));
        }
    }*/

}