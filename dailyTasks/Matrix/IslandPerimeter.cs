namespace dailyTasks.Arrays
{
    /**
 463. Island Perimeter
 https://leetcode.com/problems/island-perimeter/#/description
 You are given a map in form of a two-dimensional integer grid where 1
 represents land and 0 represents water. Grid cells are connected
 horizontally/vertically (not diagonally). The grid is completely
 surrounded by water, and there is exactly one island (i.e.,
 one or more connected land cells). The island doesn't have "lakes"
 (water inside that isn't connected to the water around the island).
 One cell is a square with side length 1. The grid is rectangular,
 width and height don't exceed 100. Determine the perimeter of the island.

the description of this problem implies there may be an "pattern" in calculating the perimeter of the islands.
and the pattern is islands * 4 - neighbours * 2, since every adjacent islands made two sides disappeared(as picture below).
the next problem is: how to find the neighbours without missing or recounting? i was inspired by the problem: https://leetcode.com/problems/battleships-in-a-board/
+--+     +--+                   +--+--+
|  |  +  |  |          ->       |     |
+--+     +--+                   +--+--+
4 + 4 - ? = 6  -> ? = 2
 */
    public class IslandPerimeter
    {
        public int islandPerimeter(int[][] grid) {
            int islands = 0, neighbours = 0;

            for (int i = 0; i < grid.Length; i++) {
                for (int j = 0; j < grid[i].Length; j++) {
                    if (grid[i][j] == 1) {
                        islands++; // count islands
                        if (i < grid.Length - 1 && grid[i + 1][j] == 1) neighbours++; // count down neighbours
                        if (j < grid[i].Length - 1 && grid[i][j + 1] == 1) neighbours++; // count right neighbours
                    }
                }
            }

            return islands * 4 - neighbours * 2;
        }
    }
}