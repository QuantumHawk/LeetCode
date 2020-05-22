using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 216. Combination Sum III
 https://leetcode.com/problems/combination-sum-iii/
 Find all possible combinations of k numbers that add up to a number n,
 given that only numbers from 1 to 9 can be used and each combination should be a unique set of numbers.
 Example 1:
 Input: k = 3, n = 7
 Output:
 [[1,2,4]]
 Example 2:
 Input: k = 3, n = 9
 Output:
 [[1,2,6], [1,3,5], [2,3,4]]
 */
    public class CombinationSum
    {
        public List<List<int>> combinationSum3(int k, int n) {
            int[] nums = {1,2,3,4,5,6,7,8,9};
            var result = new List<List<int>>();
            var current = new List<int>();
            int start = 0;
            int target = n;
            int length = k;
            combinationSumRecursive(start, length, target, result, current, nums);
            return result;
        }

        // https://discuss.leetcode.com/topic/37962/fast-easy-java-code-with-explanation - good explanation
        private void combinationSumRecursive(int start, int length, int target, List<List<int>> result,
            List<int> current, int[] nums) {
            if (length == 0 && target == 0) {
                result.Add(new List<int>(current));
            } else {
                for (int i=start; i<nums.Length; i++) {
                    if(target<0) break;
                    current.Add(nums[i]);
                    int nextTarget = target - nums[i];
                    int nextLength = length - 1;
                    combinationSumRecursive(i+1, nextLength, nextTarget, result, current, nums);
                    current.RemoveAt(current.Count-1); //size
                }
            }
        }   
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            List<List<Integer>> result = s.combinationSum3(3,9);
            for (List<Integer> l : result) {
                System.out.print("[ ");
                for (Integer i : l) {
                    System.out.print(i + ", ");
                }
                System.out.print(" ]");
            }

        }
    }*/
}