using System.Collections.Generic;
using System.Linq;

namespace dailyTasks.LinkedList
{
/*
138. Copy List with Random Pointer
https://leetcode.com/problems/copy-list-with-random-pointer/
A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.
Return a deep copy of the list.
*/


  //Definition for singly-linked list with a random pointer.
  public class RandomListNode {
     public int label;
     public RandomListNode next, random;
     public RandomListNode(int x) { this.label = x; }
 };
 
    public class CopyListWithRandomPointer
    {
        // My O(n) time and space complexity.
        private Dictionary<int, RandomListNode> cache = new Dictionary<int, RandomListNode>();
        public RandomListNode copyRandomList1(RandomListNode head) {
            if (head == null) return null;
            if (!cache.ContainsKey(head.label)) {
                RandomListNode clone = new RandomListNode(head.label);
                cache[head.label] = clone;
                clone.next = copyRandomList1(head.next);
                clone.random = copyRandomList1(head.random);
            }
            return cache[head.label];
        }

        // https://discuss.leetcode.com/topic/18086/java-o-n-solution
        /*private HashMap<RandomListNode, RandomListNode> map = new HashMap<RandomListNode, RandomListNode>();
        public RandomListNode copyRandomList(RandomListNode head) {
            if (head == null) return null;

            // step 1: create map which contains pairs <OrigNode, CloneNode>.
            // Clone node has only label at this stage, next and random are null.
            RandomListNode node = head;
            while (node != null) {
                map.put(node, new RandomListNode(node.label));
                node = node.next;
            }

            // step 2: run through orig list and make updates to clone nodes: set next and random.
            node = head;
            while (node != null) {
                RandomListNode clone = map.get(node);
                clone.next = map.get(node.next);
                clone.random = map.get(node.random);
                node = node.next;
            }
            RandomListNode cloneHead = map.get(head);
            return cloneHead;
        }*/
    }
    
    /*public class Main {
        public static void main(String[] args) {
            RandomListNode a = new RandomListNode(1);
            RandomListNode b = new RandomListNode(2);
            RandomListNode c = new RandomListNode(3);
            RandomListNode d = new RandomListNode(4);
            RandomListNode e = new RandomListNode(5);

            a.next = b;
            a.random = e;

            b.next = c;
            c.next = d;
            d.next = e;
            e.random = a;

            Solution s = new Solution();
            RandomListNode clone = s.copyRandomList(a);

            System.out.print(clone);
        }
    }*/
}