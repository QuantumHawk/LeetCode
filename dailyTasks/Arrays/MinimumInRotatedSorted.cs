namespace dailyTasks.Arrays
{
    /**
 153. Find Minimum in Rotated Sorted Array
 https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
 Suppose a sorted array is rotated at some pivot unknown to you beforehand.
 (i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).
 Find the minimum element.
 You may assume no duplicate exists in the array.
 */
    public class MinimumInRotatedSorted
    {
        // O(log n) time complexity - binary search
        public int findMin(int[] nums) {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];
            int left = 0;
            int right = nums.Length - 1;
            while(left < right) {
                if(nums[left] < nums[right]) return nums[left];
                int mid = (left + right)/2;
                if (nums[mid] > nums[right]) left = mid+1;
                else right = mid;
            }
            return nums[left];
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[] nums = {4, 5, 6, 7, 0, 1, 2};
            int min = s.findMin(nums);
            System.out.print(min);
        }
    }*/
}