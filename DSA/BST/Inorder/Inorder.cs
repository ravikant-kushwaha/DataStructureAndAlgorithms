using System;

namespace DSA.BST.Inorder
{
    public class Inorder
    {
        private Node root { get; set; }
        public Inorder()
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
            // PrintInorder(root);
            PrintInorderiterative(root);
        }
        private void PrintInorder(Node root)
        {
            if (root == null) return;
            PrintInorder(root.Left);
            System.Console.WriteLine(root.data);
            PrintInorder(root.Right);
        }

        private void PrintInorderiterative(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            AddToStack(root, stack);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                Console.WriteLine(root.data);
                if (root.Right != null)
                {
                    AddToStack(root.Right, stack);
                }
            }
        }

        private void AddToStack(Node root, Stack<Node> stack)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.Left;
            }
        }
    }
}
