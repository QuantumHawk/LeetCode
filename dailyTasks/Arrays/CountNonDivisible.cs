using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dailyTasks.Arrays
{
    public class CountNonDivisible
    {
        /*public static void Main(string[] args)
        {
            var A = new int[5] {3, 1, 2, 3, 6};

            CountNonDivisible s = new CountNonDivisible();
            int[] B = s.solution(A);
            Console.WriteLine("Input  : " + String.Join(",", A));
            Console.WriteLine("Result : " + String.Join(",", B));
        }*/

        public int[] solution(int[] A)
        {
            int max = A.Max();
            
            int[] count = new int [max + 1];
            for (int i = 0; i < A.Length; i++)
            {
                count[A[i]]++;
            }

            int[] nonDiv = new int [max + 1];
            for (int i = 1; i < nonDiv.Length; i++)
            {
                if (count[i] != 0)
                {
                    nonDiv[i] = A.Length - count[i];
                }
            }

            //sieve
            for (int i = 1; i < nonDiv.Length; i++)
            {
                if (count[i] != 0)
                {
                    //skip numbers which don't exists in table A
                    int s = i * 2;
                    while (s < nonDiv.Length)
                    {
                        if (nonDiv[s] != 0)
                        {
                            //Sieve. Most important part. Decrease number of non-divisible by the number of occurrences of number 'i'.
                            nonDiv[s] -= count[i];
                        }

                        s += i;
                    }
                }
            }
            //produce the output
            int []res = new int [A.Length];
            for (int i = 0 ; i < A.Length ; i++) {
                res[i] = nonDiv[A[i]];
            }

            return res;
        }
    }
}