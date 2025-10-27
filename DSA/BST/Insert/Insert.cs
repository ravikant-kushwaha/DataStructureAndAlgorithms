using System;

namespace DSA.BST.Insert
{
    public class Insert
    {
        private Node root { get; set; }
        public Insert()
        {
            var node1 = new Node(1);
            var node2 = new Node(2);
            var node3 = new Node(3);
            var node4 = new Node(4);
            var node5 = new Node(5);
            var node6 = new Node(6);
            var node7 = new Node(7);
            var node8 = new Node(8);
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
            recursion(root, 10);
        }

        private void recursion(Node root, int val)
        {
            if (root.Left == null && val < root.data)
            {
                root.Left = new Node(val);
            }
            else if (root.Right == null && val > root.data)
            {
                root.Right = new Node(val);
            }
            else
            {
                if (val < root.data) recursion(root.Left, val);
                else recursion(root.Right, val);
            }
            return;
        }
    }
}
