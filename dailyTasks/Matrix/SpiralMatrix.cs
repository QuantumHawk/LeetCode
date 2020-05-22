using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    /**
 54. Spiral Matrix
 https://leetcode.com/problems/spiral-matrix/
 Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
 For example,
 Given the following matrix:
 [
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
 ]
 You should return [1,2,3,6,9,8,7,4,5].
 */
    public class SpiralMatrix
    {
        public List<int> spiralOrder(int[][] matrix) {
            var res = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return res;
            int top = 0;
            int right = matrix[0].Length - 1;
            int bottom = matrix.Length - 1;
            int left = 0;
            while (true) {
                for (int i=left; i<= right; i++) res.Add(matrix[top][i]);
                top++;
                if (top>bottom || left>right) break;

                for (int i=top; i<=bottom; i++) res.Add(matrix[i][right]);
                right--;
                if (top>bottom || left>right) break;

                for (int i=right; i>=left; i--) res.Add(matrix[bottom][i]);
                bottom--;
                if (top>bottom || left>right) break;

                for (int i=bottom; i>=top; i--) res.Add(matrix[i][left]);
                left++;
                if (top>bottom || left>right) break;
            }
            return res;
        }
    }
}