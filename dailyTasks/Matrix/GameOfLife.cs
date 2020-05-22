using System;

namespace dailyTasks.Arrays
{
    /**
 289. Game of Life
 https://leetcode.com/problems/game-of-life/description/
 According to the Wikipedia's article: "The Game of Life, also known simply as Life,
 is a cellular automaton devised by the British mathematician John Horton Conway in 1970."
 Given a board with m by n cells, each cell has an initial state live (1) or dead (0).
 Each cell interacts with its eight neighbors (horizontal, vertical, diagonal) using
 the following four rules (taken from the above Wikipedia article):
 Any live cell with fewer than two live neighbors dies, as if caused by under-population.
 Any live cell with two or three live neighbors lives on to the next generation.
 Any live cell with more than three live neighbors dies, as if by over-population..
 Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.
 Write a function to compute the next state (after one update) of the board given its current state.
 Follow up:
 Could you solve it in-place? Remember that the board needs to be updated at the same time: You
 cannot update some cells first and then use their updated values to update other cells.
 In this question, we represent the board using a 2D array. In principle, the board is infinite,
 which would cause problems when the active area encroaches the border of the array. How would
 you address these problems?
 Credits:
 Special thanks to @jianchao.li.fighter for adding this problem and creating all test cases.
 */
    public class GameOfLife
    {
        // 1 - alive now, and stay alive
        // 0 - dead now, stay dead
        // 3 - was alive to be dead
        // 2 - was dead to be alive
        // https://discuss.leetcode.com/topic/29054/easiest-java-solution-with-explanation
        public void gameOfLife(int[][] board)
        {
            if (board == null || board.Length == 0) return;
            int m = board.Length, n = board[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int aliveNib = aliveAround(i, j, board);
                    if (board[i][j] == 1 && (aliveNib < 2 || aliveNib > 3))
                    {
                        board[i][j] = 3;
                    }
                    else if (board[i][j] == 0 && aliveNib == 3)
                    {
                        board[i][j] = 2;
                    }
                }
            }

            finalize(board);
        }

        private void finalize(int[][] board)
        {
            int m = board.Length, n = board[0].Length;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 2) board[i][j] = 1;
                    else if (board[i][j] == 3) board[i][j] = 0;
                }
            }
        }

        int aliveAround(int row, int col, int[][] board)
        {
            int m = board.Length, n = board[0].Length;
            int cnt = 0;
            for (int i = Math.Max(row - 1, 0); i <= Math.Min(row + 1, m - 1); i++)
            {
                for (int j = Math.Max(col - 1, 0); j <= Math.Min(col + 1, n - 1); j++)
                {
                    cnt += board[i][j] % 2;
                }
            }

            return cnt - (board[row][col] % 2);
        }
    }
    
    /*public class Main {
        public static void main(String[] args) {
            Solution s = new Solution();
            int[][] nums = {{1,1},{1,0}};
            s.gameOfLife(nums);
        }
    }*/
}


