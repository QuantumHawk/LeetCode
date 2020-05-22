using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dailyTasks.StringManipulation
{
    //            string input = "Here i come.";
    // to I here come.
   // string res = arrange(input);
    
    public static class ExtensionMethods
    {
        public static LinkedListNode<T> RemoveAt<T>(this LinkedList<T> list, int index)
        {
            LinkedListNode<T> currentNode = list.First;
            for (int i = 0; i <= index && currentNode != null; i++)
            {
                if (i != index)
                {
                    currentNode = currentNode.Next;
                    continue;
                }

                list.Remove(currentNode);
                return currentNode;
            }

            throw new IndexOutOfRangeException();
        }
    }
    public class Arrange
    {
        public static string arrange(string sentence)
        {
            StringBuilder res = new StringBuilder("");
            string[] words = sentence.Replace(".", " ").Split(" ");
            //     string[] words = sentence.Split(new char[] { ' ' });
            var linkedlist = new LinkedList<string>(words);
            while (linkedlist.Count!=0)
            {
                int i = 0;
                for (int j = 0; j < linkedlist.Count; j++)
                {
                    if (linkedlist.ElementAt(j).Length < linkedlist.ElementAt(i).Length)
                    {
                        i = j;
                    }
                }

                res.Append(linkedlist.ElementAt(i).ToLower());
                if (res.Length > 0) res.Append(" ");
                linkedlist.RemoveAt(i);
            }
            
            res = new StringBuilder(res.ToString().Substring(0, 1).ToUpper() + res.ToString().Substring(1));
            res = new StringBuilder( res.ToString().Substring(0,res.Length-1));
            return res + ".";
        }
    }
}