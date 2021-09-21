namespace dailyTasks.Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
        
        public override string ToString() {
            if (this == null) return "NULL";
            string leftStr = this.left != null ? this.left.ToString() : "NULL";
            string rightStr = this.right != null ? this.right.ToString() : "NULL";
            return "ROOT: " + val + " LEFT: " + leftStr + " RIGHT: " + rightStr;
        }
    }

    public class Input
    {
        
    }
}