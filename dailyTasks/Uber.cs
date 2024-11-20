using System;
using System.Collections.Generic;

namespace dailyTasks
{

    /*
     
     https://leetcode.com/discuss/interview-experience/4718477/Uber-or-Phone-Screen-or-Amsterdam/
    Given a 2D grid

    {1, 0, 0, 0, 2},
    {0, 1, 2, 2, 2},
    {0, 0, 0, 0, 0},
    {2, 0, 1, 0, 0},
    {2, 0, 2, 0, 2}

    composed of robots equal to 1, empties equal to 0,
     and blockers equal to 2. you will receive a query like [2,2,4,1],
      which means a distances to the blockers where 2 to the left blocker,
      2 to the top blocker, 4 to the bottom blocker and 1 to the right blocker.
       Consider all boundries as blockers as well. Find the robot satisfying
       the query.
       
       
       
       or
       
       
       
       
       Uber
       
       https://leetcode.com/discuss/interview-experience/4718477/Uber-or-Phone-Screen-or-Amsterdam/
       
       Given a 2D grid composed of robots, empties, and blockers, you will receive a query like [a, b, c, d], which means the right distance, left distance, top distance, and bottom distance to the nearest blocker. Find the robot satisfying the query.
       
       
       Given two inputs,
       
       First input is the location map, a 2D array
       
        {0, E, E, E, X},
       {E, 0, X, X, X},
       {E, E, E, E, E},
       {X, E, 0, E, E},
       {X, E, X, E, X}
       
       O = Robot, E = Empty, X = blocker
       
       {{'O','E','E','E','X'},{'E','O','X','X','X'},{'E','E','E','E','E'},{'X','E','O','E','E'},{'X','E','X','E','X'}}
       
       Second input is the query. It’s a 1D array consisting of distance to the closest blocker in the order from left, top, bottom and right [2, 2, 4, 1] -> This means distance of 2 to the left blocker, 2 to the top blocker, 4 to the bottom blocker and 1 to the right blocker
       
       The location map boundary is also considered blocker, meaning if the robot hits the boundary it also means it’s hitting the blocker.
       
       Task: Write a function that takes these two inputs and returns the index of the robots (if any) that matches the query that we’re looking for. Answer: [[1, 1]]
    */


    //Find Robot




    public class RobotFinder
    {
        private const int LEFT = 0;
        private const int TOP = 1;
        private const int BOTTOM = 2;
        private const int RIGHT = 3;

        public static void Solution(char[,] matrix, int[] query)
        {
            int R = matrix.GetLength(0);
            int C = matrix.GetLength(1);

            // Initialize dictionary with default values of [null, null, null, null] (or equivalent)
            var map = new Dictionary<(int, int), int[]>();

            int[] top = new int[C];
            Array.Fill(top, -1); // Initialize the top array with -1

            // First pass: fill LEFT and TOP distances
            for (int r = 0; r < R; r++)
            {
                int left = -1;
                for (int c = 0; c < C; c++)
                {
                    if (matrix[r, c] == 'O')
                    {
                        if (!map.ContainsKey((r, c)))
                            map[(r, c)] = new int[4];

                        map[(r, c)][LEFT] = Math.Abs(c - left);
                        map[(r, c)][TOP] = Math.Abs(r - top[c]);
                    }

                    if (matrix[r, c] == 'X')
                    {
                        left = c;
                        top[c] = r;
                    }
                }
            }

            int[] bottom = new int[C];
            Array.Fill(bottom, R); // Initialize the bottom array with R

            // Second pass: fill BOTTOM and RIGHT distances
            for (int r = R - 1; r >= 0; r--)
            {
                int right = C;
                for (int c = C - 1; c >= 0; c--)
                {
                    if (matrix[r, c] == 'O')
                    {
                        if (!map.ContainsKey((r, c)))
                            map[(r, c)] = new int[4];

                        map[(r, c)][BOTTOM] = Math.Abs(r - bottom[c]);
                        map[(r, c)][RIGHT] = Math.Abs(c - right);

                        // Check if the robot's distances match the query
                        if (IsMatch(map[(r, c)], query))
                        {
                            Console.WriteLine($"Answer is: [{r}, {c}]");
                        }
                    }

                    if (matrix[r, c] == 'X')
                    {
                        right = c;
                        bottom[c] = r;
                    }
                }
            }
        }

        private static bool IsMatch(int[] distances, int[] query)
        {
            for (int i = 0; i < 4; i++)
            {
                if (distances[i] != query[i])
                    return false;
            }

            return true;
        }

        public static void Main()
        {
            char[,] matrix =
            {
                { 'O', 'E', 'E', 'E', 'X' },
                { 'E', 'O', 'X', 'X', 'X' },
                { 'E', 'E', 'E', 'E', 'E' },
                { 'X', 'E', 'O', 'E', 'E' },
                { 'X', 'E', 'X', 'E', 'X' }
            };

            //int[] query = { 2, 2, 4, 1 }; //left, top, bottom, right
            //int[] query = { 1, 1, 3, 4 }; 
            int[] query = { 2, 2, 1, 3 }; 
            Solution(matrix, query);
        }
    }
}