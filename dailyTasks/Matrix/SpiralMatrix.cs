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
    
    // public List<Integer> spiralOrder(int[][] matrix) {
    // List<Integer> res = new LinkedList<>(); 
    //     if (matrix == null || matrix.length == 0) return res;
    // int n = matrix.length, m = matrix[0].length;
    // int up = 0,  down = n - 1;
    // int left = 0, right = m - 1;
    //     while (res.size() < n * m) {
    //     for (int j = left; j <= right && res.size() < n * m; j++)
    //         res.add(matrix[up][j]);
    //         
    //     for (int i = up + 1; i <= down - 1 && res.size() < n * m; i++)
    //         res.add(matrix[i][right]);
    //                  
    //     for (int j = right; j >= left && res.size() < n * m; j--)
    //         res.add(matrix[down][j]);
    //                     
    //     for (int i = down - 1; i >= up + 1 && res.size() < n * m; i--) 
    //         res.add(matrix[i][left]);
    //             
    //     left++; right--; up++; down--; 
    // }
    // return res;
    // }
}