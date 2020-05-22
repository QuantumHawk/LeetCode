using System;
using System.Collections;
using System.Collections.Generic;

namespace dailyTasks.Arrays
{
    
    public class Interval 
    { 
        public int start,end; 
        Interval(int start, int end) 
        { 
            this.start=start; 
            this.end=end; 
        } 
    }

    public class MergeAllOverlappingIntervals
    {
       public static void mergeIntervals(Interval[] arr)
        {
            // Test if the given set has at least one interval  
            if (arr.Length <= 0)
                return;

            // Create an empty stack of intervals  
            var stack = new Stack<Interval>();

            // sort the intervals in increasing order of start time  
            Array.Sort(arr,
                new Comparison<Interval>((Interval i1, Interval i2) =>
                    (i1.start - i2.start).CompareTo(i1.start - i2.start)));
 
            // push the first interval to stack  
            stack.Push(arr[0]);

            // Start from the next interval and merge if necessary  
            for (int i = 1; i < arr.Length; i++)
            {
                // get interval from stack top  
                Interval top = stack.Peek();

                // if current interval is not overlapping with stack top,  
                // push it to the stack  
                if (top.end < arr[i].start)
                    stack.Push(arr[i]);

                // Otherwise update the ending time of top if ending of current  
                // interval is more  
                else if (top.end < arr[i].end)
                {
                    top.end = arr[i].end;
                    stack.Pop();
                    stack.Push(top);
                }
            }

            // Print contents of stack  
            Console.WriteLine("The Merged Intervals are: ");
            while (!(stack.Count==0))
            {
                Interval t = stack.Pop();
              Console.WriteLine("[" + t.start + "," + t.end + "] ");
            }
        }
       
       
       //Оптимальное решение без стека
       /*// Function that takes a set of intervals, merges  
       // overlapping intervals and prints the result  
       public static void mergeIntervals(Interval arr[])  
       {  
           // Sort Intervals in decreasing order of  
           // start time  
           Arrays.sort(arr,new Comparator<Interval>(){ 
               public int compare(Interval i1,Interval i2) 
               { 
               return i2.start - i1.start; 
           } 
           }); 
    
           int index = 0; // Stores index of last element  
           // in output array (modified arr[])  
    
           // Traverse all input Intervals  
           for (int i=1; i<arr.length; i++)  
           {  
               // If this is not first Interval and overlaps  
               // with the previous one  
               if (arr[index].end >=  arr[i].start)  
               {  
                   // Merge previous and current Intervals  
                   arr[index].end = Math.max(arr[index].end, arr[i].end);  
                   arr[index].start = Math.min(arr[index].start, arr[i].start);  
               }  
               else { 
                   arr[index] = arr[i];  
                   index++; 
               }     
           } 
          
           // Now arr[0..index-1] stores the merged Intervals  
           System.out.print("The Merged Intervals are: "); 
           for (int i = 0; i <= index; i++)  
           { 
               System.out.print("[" + arr[i].start + "," 
                                + arr[i].end + "]");  
           } 
       }  */

    }
}