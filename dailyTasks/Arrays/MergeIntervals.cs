using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks.Arrays
{
    /*
     https://leetcode.com/discuss/interview-question/1165018/Microsoft-or-OA-or-India
     https://leetcode.com/problems/merge-intervals/
     Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals, and return an array of the non-overlapping intervals that cover all the intervals in the input.

 

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
 

Constraints:

1 <= intervals.length <= 104
intervals[i].length == 2
0 <= starti <= endi <= 104*/
    public class MergeIntervals
    {
        /*public int[][] merge(int[][] intervals) {
            Array.Sort(intervals, (a, b) => Compare(a[0], b[0]));
            var merged = new LinkedList<int[]>();
            foreach (var interval in intervals)
            {
                // if the list of merged intervals is empty or if the current
                // interval does not overlap with the previous, simply append it.
                if (merged.Count==0 || merged.Last()[1] < interval[0]) {
                    merged.AddAfter(interval);
                }
                // otherwise, there is overlap, so we merge the current and previous
                // intervals.
                else {
                    merged.Last()[1] = Math.Max(merged.Last()[1], interval[1]);
                }
            }
            return merged.ToArray(new int[merged.size()][]);
        }*/
    }
}