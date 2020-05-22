using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    public class MaxNonNegativeSubArray
    {
        public List<int> maxset(List<int> a) {
            long maxSum = 0;
            var res = new  List<int>();
            if (a == null || a.Count == 0) return res;

            long sum = 0;
            var current = new List<int>();
            for(int k=0; k<a.Count ; k++) {
                int i = a[k];
                if (i < 0) {
                    if (sum > maxSum || (sum == maxSum && current.Count  > res.Count )) {
                        res = new List<int>(current);
                        maxSum = sum;
                    }
                    sum = 0;
                    current = new List<int>();
                } else {
                    sum += i;
                    current.Add(i);
                }
            }
            if (sum > maxSum || (sum == maxSum && current.Count  > res.Count )) {
                res = new List<int>(current);
                maxSum = sum;
            }
            return res;
        }
    }
}