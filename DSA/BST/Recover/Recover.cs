using System;

namespace DSA.BST.Recover
{
    public class Recover
    {
        private Node root { get; set; }
        public Recover()
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
            inorder(root);
            int temp = first.data;
            first.data = second.data;
            second.data = temp;
        }

        Node first = null;
        Node second = null;
        Node previous = new Node(int.MinValue);
        private void inorder(Node curr)
        {
            if (curr == null) return;
            inorder(curr.Left);

            if (first == null && previous.data > curr.data)
            {
                first = previous;
            }

            if (first != null && previous.data > curr.data)
            {
                second = curr;
            }
            previous = curr;
            inorder(curr.Right);
        }
    }
}
