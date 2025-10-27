using System;

namespace DSA.BST.Postorder
{
    public class Postorder
    {
        private Node root { get; set; }
        public Postorder()
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
            iterative(root);
        }

        private void Recursion(Node root)
        {
            if (root == null) return;
            Recursion(root.Left);
            Recursion(root.Right);
            Console.WriteLine(root.data);
        }

        private void iterative(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            Node last_visited = null;
            while (stack.Count > 0 || root != null)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }
                else
                {
                    var n = stack.Peek();
                    if (n.Right != null && last_visited != n.Right)
                    {
                        root = n.Right;
                    }
                    else
                    {
                        n = stack.Pop();
                        Console.WriteLine(n.data);
                        last_visited = n;
                    }
                }
            }
        }
    }
}
