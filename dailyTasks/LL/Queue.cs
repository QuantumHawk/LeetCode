
using System.Collections.Generic;
//using LL;

namespace dailyTasks
{
    
    //#2
    public class Queue<T>
    {
        private LinkedList<T> queue;

        public Queue()
        {
            queue = new LinkedList<T>();
        }

        //public bool isEmpty => queue.isEmpty();
        //public int size => queue.size;

        //implement
        public void enqueue(T n)
        {
            queue.AddLast(n);
        }

        public void dequeue(T n)
        {
            queue.Remove(n);
        }

        public LinkedListNode<T> peek()
        { 
            return queue.First;
        }
    }
}