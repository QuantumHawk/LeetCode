using System;

namespace dailyTasks.Arrays
{
    /*This is a demo task.

Write a function:

class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].
Copyright 2009–2020 by Codility Limited. All Rights Reserved. Unauthorized copying, publication or disclosure prohibited.*/

    // O(n*log n)
    public class MissingNumber_Min
    {
        //int res =solution(new int[] {0, 3,4,5,6,7,8,9,10, 12});
        public static int minMissingNumber(int[] A)
        {
            int min = 0;
            int prev = 0;
            Array.Sort(A);
            for (int i = 0; i < A.Length;)
            {
                //negative
                if (A[i] <= 0) i++;
                else
                {
                    if (A[i] == min) i++;
                    else
                    {
                        if (min < A[i])
                        {
                            prev = min;
                            min = A[i];
                            i++;
                        }

                        if (min != prev + 1) return ++prev;
                    }
                }
            }

            if (min == A[A.Length - 1] || min == 0) return ++min;
            return min;
        }
    }
    
    
    // int res =findMiss(new int[] {-1, -3, 1});
    /*int t;
    t = int.Parse(Console.ReadLine());
    while(t>0){
        int n = int.Parse(Console.ReadLine());
        int[] a= new int [n-1];
        for(int i=0;i<a.Length ; i++)
            a[i]=int.Parse(Console.ReadLine());
        Console.WriteLine(findMiss(n-1, a));
        t--;
    }*/
}