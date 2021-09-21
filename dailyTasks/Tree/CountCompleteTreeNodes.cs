using System;

namespace dailyTasks.Tree
{
    
    /*Given the root of a complete binary tree, return the number of the nodes in the tree.

According to Wikipedia, every level, except possibly the last, is completely filled in a complete binary tree, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.

Design an algorithm that runs in less than O(n) time complexity.

 

Example 1:


Input: root = [1,2,3,4,5,6]
Output: 6
Example 2:

Input: root = []
Output: 0
Example 3:

Input: root = [1]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [0, 5 * 104].
0 <= Node.val <= 5 * 104
The tree is guaranteed to be complete.

A good question on Complete Binary Tree. LC has explained the requirements, approach and code well.
I got upto the thought of: the problem actually asks the no. of nodes in the last level. But then lost track thinking how to reach all last level nodes, since I already ruled out Binary Search Traversal due to non BST and what remained was O(n) Pre, Post, Inorder traversals. Had I observed the monotonicity property (mentioned below), I would have thought of Binary Search.
I guess the problem is based on 'Binary search on the answer' concept. Reason being the last level (the search space) has monotonicity: isLeafPresent = T or F, and nodes are in either of the two states - TTTT...TT, TTT...FF
In a Full Binary Tree:
height, w.r.t edge, starts from d = 0 (this means for level 1, d = 0)
Taking height on the basis of edge instead of node helps while calculating no. of nodes in a level:
No. of nodes in a level = 2^d
level 1 | d = 0 | no. of nodes = 2^0 = 1
level 2 | d = 1 | no. of nodes = 2^1 = 2
level 3 | d = 2 | no. of nodes = 2^2 = 4
Total no. of nodes upto second last level = no. of nodes in last level - 1 (-1 for the single node scenrio at level 1 or d=0) (Happy to gain this insight).
This actually helps for Complete Binary Tree problems like this.
Here, total no. of nodes in Complete Binary Tree = return (int)Math.pow(2, d) - 1 + left;,
Total no. of nodes upto second last level (calculated w.r.t no.of last level nodes if Tree was Full): (int)Math.pow(2, d) - 1
actual no. of nodes in last level: left
Found 2 new patterns:
Nested binary search pattern: binary search on binary search
Binary search on non-BST pattern: for BST we used to leverage node values, whereas here for non-BST, we leverage height and existance of last nodes (but hat maybe because this is a Complete Binary Tree)
*/
    public class CountCompleteTreeNodes
    {
        public int computeDepth(TreeNode node)
        {
            int d = 0;
            while (node.left != null)
            {
                node = node.left;
                ++d;
            }

            return d;
        }



        public bool exists(int idx, int d, TreeNode node)
        {
            int left = 0, right = (int)Math.Pow(2, d) - 1;
            int pivot;
            for (int i = 0; i < d; ++i)
            {
                // Note 1a: Our aim, is to travel all the way from root to leaf (ie, d iterations is the terminal condition) (so no usual BS termination like left <= right etc)
                pivot = left + (right - left) / 2;
                if (idx <= pivot)
                {
                    // Note 1b: (and not to stop if idx = pivot, so even if idx = pivot, you continue searching on left)
                    node = node.left;
                    right = pivot;
                }
                else
                {
                    node = node.right;
                    left = pivot + 1;
                }
            }

            return node != null; // Note 1c: ..and Check if searching leaf is present or not at 'd'
        }

        public int countNodes(TreeNode root)
        {
            if (root == null) return 0;
            int d = computeDepth(root);
            if (d == 0) return 1;

            int left = 0,
                right = (int)Math.Pow(2, d) -
                        1; // changed LC's left = 1 to left = 0 for readability. left = 1 works siince last level will always have 1 node
            int pivot;

            while (left <= right)
            {
                pivot = left + (right - left) / 2;
                if (exists(pivot, d, root)) left = pivot + 1;
                else right = pivot - 1;
            }

            return (int)Math.Pow(2, d) - 1 + left;
        }
    }
}