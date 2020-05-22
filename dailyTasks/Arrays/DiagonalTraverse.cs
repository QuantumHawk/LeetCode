using System;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{

    /**
 498. Diagonal Traverse
 https://leetcode.com/problems/diagonal-traverse/#/description
 Given a matrix of M x N elements (M rows, N columns), return all elements
 of the matrix in diagonal order as shown in the below image.
 Input:
 [
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
 ]
 Output:  [1,2,4,7,5,3,6,8,9]
 */
    public class DiagonalTraverse
    {
        // Good solution
        // https://discuss.leetcode.com/topic/77865/concise-java-solution
        public int[] findDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return new int[] { };

            int h = matrix.Length, w = matrix[0].Length;
            var res = new List<int>();
            int col = 0, row = 0;
            bool topToBottom = false;

            while (row < h && col < w)
            {
                int current = matrix[row][col];
                res.Add(current);
                if (row == 0 && col < w - 1 && !topToBottom)
                {
                    col++;
                    topToBottom = true;
                }
                else if (col == w - 1 && row < h - 1 && !topToBottom)
                {
                    row++;
                    topToBottom = true;
                }
                else if (col == 0 && row + 1 < h && topToBottom)
                {
                    row++;
                    topToBottom = false;
                }
                else if (row == h - 1 && col < w - 1 && topToBottom)
                {
                    col++;
                    topToBottom = false;
                }
                else
                {
                    if (topToBottom)
                    {
                        col--;
                        row++;
                    }
                    else
                    {
                        col++;
                        row--;
                    }
                }
            }

            int[] arr = new int[res.Capacity];
            for (int i = 0; i < res.Count; i++)
            {
                arr[i] = res[i];
            }

            return arr;
        }

        public int[] findDiagonalOrder1(int[][] matrix)
        {
            if (matrix == null) throw new ArgumentException("ex");
            if (matrix.Length == 0 || matrix[0].Length == 0) return new int[] { };
            int m = matrix.Length, n = matrix[0].Length;
            int[] res = new int[m * n];
            int step = 1, r = 0, c = 0;
            for (int i = 0; i < m * n; i++)
            {
                res[i] = matrix[r][c];
                r += -1 * step;
                c += step;
                // bottom border
                if (r == m)
                {
                    step *= -1;
                    r = m - 1;
                    c += 2;
                }

                // right border
                if (c == n)
                {
                    step *= -1;
                    c = n - 1;
                    r += 2;
                }

                // top border
                if (r < 0)
                {
                    step *= -1;
                    r = 0;
                }

                // left border
                if (c < 0)
                {
                    step *= -1;
                    c = 0;
                }
            }

            return res;
        }

//    https://discuss.leetcode.com/topic/77865/concise-java-solution
//    public class Solution {
//        public int[] findDiagonalOrder(int[][] matrix) {
//            if (matrix == null || matrix.length == 0) return new int[0];
//            int m = matrix.length, n = matrix[0].length;
//
//            int[] result = new int[m * n];
//            int row = 0, col = 0, d = 0;
//            int[][] dirs = {{-1, 1}, {1, -1}};
//
//            for (int i = 0; i < m * n; i++) {
//                result[i] = matrix[row][col];
//                row += dirs[d][0];
//                col += dirs[d][1];
//
//                if (row >= m) { row = m - 1; col += 2; d = 1 - d;}
//                if (col >= n) { col = n - 1; row += 2; d = 1 - d;}
//                if (row < 0)  { row = 0; d = 1 - d;}
//                if (col < 0)  { col = 0; d = 1 - d;}
//            }
//
//            return result;
//        }
//    }

    }

    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[][] matrix = new int[][] {
                {1,2,6},
                {3,5,7},
                {4,8,9}
            };
            int[] res = s.findDiagonalOrder(matrix);
            System.out.print(Arrays.toString(res));
        }
    }*/
}