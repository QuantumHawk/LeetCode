using System;
using LL;
namespace dailyTasks
{
    public class Stack
    {
        //global top reference variable  
        private Node nodeTop;

        public Stack(Node nodeTop)
        {
            this.nodeTop = null;
        }

        public void push(int x)
        {
            // create new node temp and allocate memory  
            Node temp = new Node();

            // check if stack (heap) is full.  
            // Then inserting an element 
            // would lead to stack overflow  
            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }

            // initialize data into temp data field  
            temp.Data = x;

            // put top reference into temp link  
            temp.Next = nodeTop;

            // update top reference  
            nodeTop = temp;
        }

        // Utility function to check if 
    // the stack is empty or not  
    public bool isEmpty()  
    {  
        return nodeTop == null;  
    }  
  
    // Utility function to return 
    // top element in a stack  
    public int peek()  
    {  
        // check for empty stack  
        if (!isEmpty())  
        {  
            return nodeTop.Data;  
        }  
        else
        {  
            Console.WriteLine("Stack is empty");  
            return -1;  
        }  
    }  
  
    // Utility function to pop top element from the stack  
    public void pop() // remove at the beginning  
    {  
        // check for stack underflow  
        if (nodeTop == null) 
        {  
            Console.Write("\nStack Underflow");  
            return;  
        }  
  
        // update the top pointer to  
        // point to the next node  
        nodeTop = nodeTop.Next;  
    }  
  
    public void display()  
    {  
        // check for stack underflow  
        if (nodeTop == null)  
        {  
            Console.Write("\nStack Underflow");  
            return;  
        }  
        else 
        {  
            Node temp = nodeTop;  
            while (temp != null)  
            {  
  
                // print node data  
                Console.Write("{0}->", temp.Data);  
  
                // assign temp link to temp  
                temp = temp.Next;  
            }  
        }  
    }  
    }
}