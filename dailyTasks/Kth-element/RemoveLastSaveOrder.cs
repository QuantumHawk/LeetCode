using System;
using System.Collections.Generic;
using System.Linq;

namespace dailyTasks.LinkedList
{
    public static class RemoveLastSaveOrder
    {
        public static IEnumerable<T> DropLast<T>(this IEnumerable<T> source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            return InternalDropLast(source);
        }

        private static IEnumerable<T> InternalDropLast<T>(IEnumerable<T> source)
        {
            T buffer = default(T);
            bool buffered = false;

            foreach (T x in source)
            {
                if (buffered)
                    yield return buffer;

                buffer = x;
                buffered = true;
            }
        }
        public static IEnumerable<T> DropLast<T>(this IEnumerable<T> source, int n)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (n < 0)
                throw new ArgumentOutOfRangeException("n", 
                    "Argument n should be non-negative.");

            return InternalDropLast(source, n);
        }

        private static IEnumerable<T> InternalDropLast<T>(IEnumerable<T> source, int n)
        {
            Queue<T> buffer = new Queue<T>(n + 1);

            foreach (T x in source)
            {
                buffer.Enqueue(x);

                if (buffer.Count == n + 1)
                    yield return buffer.Dequeue();
            }
        }
        
        // public static void Main(string[] args) {
        //     var Seq = Enumerable.Range(1, 4);
        //
        //     Console.WriteLine(string.Join(", ", Seq.Select(x => x.ToString()).ToArray()));
        //     Console.WriteLine(string.Join(", ", Seq.DropLast(3).Select(x => x.ToString()).ToArray()));
        // }
    }
}