using System;

namespace DSA.BST.Symmetric
{
    public class symmetric
    {
        private Node root { get; set; }
        public symmetric()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(1);
            var node7 = new Node(3);
            var node8 = new Node(4);
            root = node5;
            root.Left = node3;
            node3.Left = node1;
            node3.Right = node4;
            root.Right = node7;
            node7.Left = node6;
            node7.Right = node8;

        }

        public void start()
        {
            Console.WriteLine(isSymmetric(root.Left, root.Right));
        }

        private bool isSymmetric(Node left, Node right)
        {
            if (left == null && right != null) return false;
            if (left != null && right == null) return false;
            if (left == null && right == null) return true;
            if (left.data != right.data) return false;
            bool val1 = isSymmetric(left.Left, right.Right);
            bool val2 = isSymmetric(left.Right, right.Left);
            return val1 && val2; 
        }
    }
}
