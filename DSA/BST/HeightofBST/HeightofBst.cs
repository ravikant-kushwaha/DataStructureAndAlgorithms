using System;

namespace DSA.BST.HeightofBST
{
    public class HeightofBst
    {
        private Node root { get; set; }
        public HeightofBst()
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
            Console.WriteLine(Height(root, 0));
        }

        private int Height(Node node, int height)
        {
            if (node == null) return height;
            height += 1;
            int leftheight = Height(node.Left, height);
            int rightheight = Height(node.Right, height);
            return Math.Max(leftheight, rightheight);
        }
    }
}
