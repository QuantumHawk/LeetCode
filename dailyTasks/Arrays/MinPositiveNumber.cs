namespace dailyTasks.Arrays
{
    public class MinPositiveNumber
    {
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

        // Write a function:
        //
        // class Solution { public int solution(int[] A); }
        //
        // that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
        //
        //     For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
        //
        // Given A = [1, 2, 3], the function should return 4.
        //
        // Given A = [−1, −3], the function should return 1.
        //
        // Write an efficient algorithm for the following assumptions:
        //
        // N is an integer within the range [1..100,000];
        // each element of array A is an integer within the range [−1,000,000..1,000,000].
        // Copyright 2009–2021 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.
        public int firstMissingPositive(int[] arr, int n) 
        {
            // Check if 1 is present in array or not
            for(int i = 0; i < n; i++)
            {
        
                // Loop to check boundary
                // condition and for swapping
                while (arr[i] >= 1 && arr[i] <= n
                                   && arr[i] != arr[arr[i] - 1])
                {

                    int temp = arr[arr[i] - 1];
                    arr[arr[i] - 1] = arr[i];
                    arr[i] = temp;
                }
            }
        
            // Finding which index has value less than n
            for(int i = 0; i < n; i++)
                if (arr[i] != i + 1)
                    return (i + 1);
        
            // If array has values from 1 to n
            return (n + 1);
        }

        public int solution(int[] A) {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A.Length;
            return firstMissingPositive(A, n);
        }
    }
    
}