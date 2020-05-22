using System;
using System.Diagnostics;

namespace dailyTasks
{
    
    //Array.Sort
    // If the collection has less than 16 elements, the algorithm “Insertion Sort” will be used
    // If the number of partitions exceeds 2 log *array size*, then Heapsort is used.
    // Otherwise Quicksort is used.
    //in place
    public class BasicSortingAlgorithms
    {
        public static void swap(ref int x, ref int y)
        {
            int loverElement = x;
            y = x;
            x = loverElement;
        }
        public static void BubbleSort(int[] input) //On^2
        {
            bool moved = false;
            do
            {
                moved = false;
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                       //swap(ref input[i+1], ref input[i]);
                       //or C#7
                        (input[i], input[i + 1]) = (input[i + 1], input[i]);
                        moved = true;
                    }
                }
            } while (moved);
        }

        public static void InsertionSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int current = input[i];
                int currentIndex = i;
                while (currentIndex > 0 && input[currentIndex + 1] > current)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }
                input[currentIndex] = current;
            }
        }
        
        public  static  bool comp(int a, int b){
            if(a!=0 && b!=0)
                return (a * Math.Pow(10,(1+(int)Math.Log10(b))) +b)
                       > ( b* Math.Pow(10,(1+(int)Math.Log10(a))) + a);
            else 
                return a > b;
        }
    
        private static int[] InsertionSort_FastComparator(int[] keys, int lo, int hi)
        {
            Debug.Assert(keys != null);
            Debug.Assert(lo >= 0);
            Debug.Assert(hi >= lo);
            Debug.Assert(hi <= keys.Length);

            int i, j;
            int t;
            for (i = lo; i < hi; i++)
            {
                j = i;
                t = keys[i + 1];
                while (j >= lo && comp(t, keys[j]))
                {
                    keys[j + 1] = keys[j];
                    j--;
                }
                keys[j + 1] = t;
            }

            return keys;
        }
    }
}