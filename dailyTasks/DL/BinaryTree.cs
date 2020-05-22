using DL;

namespace dailyTasks
{
    public class NodeTree
    {
        public int Data { get; set; }
        public NodeTree Left { get; set; }
        public NodeTree Right { get; set; }

        public NodeTree(int data)
        {
            this.Data = data;
            Left = Right = null;
        }
    }

    class BinaryTree
    {
        static NodeTree prev;
        static bool isBinaryTree(NodeTree root)
        {
            // traverse the tree in inorder fashion and  
            // keep track of prev node 
            if (root != null)
            {
                if (!isBinaryTree(root.Left))
                    return false;

                // Allows only distinct valued nodes  
                if (prev != null &&
                    root.Data <= prev.Data)
                    return false;

                prev = root;

                return isBinaryTree(root.Right);
            }

            return true;
        }

        static bool CheckBinaryTree(NodeTree root)
        {
            return isBinaryTree(root);
        }
        
        static NodeTree Insert(NodeTree root, int data){
            if(root==null){
                return new NodeTree(data);
            }
            else{
                NodeTree cur;
                if(data<=root.Data){
                    cur=Insert(root.Left,data);
                    root.Left=cur;
                }
                else{
                    cur=Insert(root.Right,data);
                    root.Right=cur;
                }
                return root;
            }
        }

        // public static void Main(String[] args)
        // {
        //     NodeTree root = new NodeTree(3);
        //     root.left = new NodeTree(2);
        //     root.right = new NodeTree(5);
        //     root.left.left = new NodeTree(1);
        //     root.left.right = new NodeTree(4);
        //
        //     if (CheckBinaryTree(root))
        //         Console.WriteLine("Is BST");
        //     else
        //         Console.WriteLine("Not a BST");
        // }
        
        /*static void Main(String[] args){
            Node root=null;
            int T=Int32.Parse(Console.ReadLine());
            while(T-->0){
                int data=Int32.Parse(Console.ReadLine());
                root=insert(root,data);            
            }
            levelOrder(root);
        
        }*/
    }
}