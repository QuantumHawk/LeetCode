using System;
using System.Text;

namespace dailyTasks.LinkedList
{
    public class ListNode : IComparable<ListNode>
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public int CompareTo(ListNode other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            ListNode current = this;
            while (current != null)
            {
                sb.Append(current.val + "->");
                current = current.next;
            }

            return sb.ToString();
        }    
    }
}