using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 350. Intersection of Two Arrays II
 https://leetcode.com/problems/intersection-of-two-arrays-ii/
 Given two arrays, write a function to compute their intersection.
 Example:
 Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2, 2].
 Note:
 Each element in the result should appear as many times as it shows in both arrays.
 The result can be in any order.
 Follow up:
 What if the given array is already sorted? How would you optimize your algorithm?
 What if nums1's size is small compared to nums2's size? Which algorithm is better?
 What if elements of nums2 are stored on disk, and the memory is limited such that you
 cannot load all elements into the memory at once?
 https://discuss.leetcode.com/topic/45893/c-hash-table-solution-and-sort-two-pointers-solution-with-time-and-space-complexity
 time complexity O(log n + log m + m + n) - I`m not really sure
 https://discuss.leetcode.com/topic/45992/solution-to-3rd-follow-up-question
 If only nums2 cannot fit in memory, put all elements of nums1 into a HashMap,
 read chunks of array that fit into the memory, and record the intersections.
 If both nums1 and nums2 are so huge that neither fit into the memory,
 sort them individually (external sort), then read 2 elements from each
 array at a time in memory, record intersections.
 https://discuss.leetcode.com/topic/45920/ac-solution-using-java-hashmap
 */
    public class Intersection
    {
        public int[] intersect(int[] nums1, int[] nums2) {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i=0,j=0;
            var list = new List<int>();
            while (i<nums1.Length && j<nums2.Length) {
                if (nums1[i]<nums2[j]) i++;
                else if (nums1[i]>nums2[j]) j++;
                else {
                    list.Add(nums1[i]);
                    i++;
                    j++;
                }
            }
            int[] res = new int[list.Count];
            int ind=0;
            foreach (int k in list) res[ind++]=k;
            return res;
        }
    }
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] nums1 = {1, 2, 3, 4, 5, 5, 6, 6};
            int[] nums2 = {5, 6, 6, 0, 30, 76};
            int[] res = s.intersect(nums1, nums2);
            System.out.print(Arrays.toString(res));
        }
    }*/
}