namespace dailyTasks.Tree
{
    /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    /*
    Given the root of a binary search tree and the lowest and highest boundaries as low and high, trim the tree so that all its elements lies in [low, high]. Trimming the tree should not change the relative structure of the elements that will remain in the tree (i.e., any node's descendant should remain a descendant). It can be proven that there is a unique answer.

    Return the root of the trimmed binary search tree. Note that the root may change depending on the given bounds.
    */
    /*Constraints:

    The number of nodes in the tree in the range [1, 104].
    0 <= Node.val <= 104
    The value of each node in the tree is unique.
    root is guaranteed to be a valid binary search tree.
    0 <= low <= high <= 104*/
    public class Solution
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null) return root;
            if (root.val > high) return TrimBST(root.left, low, high);
            if (root.val < low) return TrimBST(root.right, low, high);

            root.left = TrimBST(root.left, low, high);
            root.right = TrimBST(root.right, low, high);
            return root;

        }
    }
}