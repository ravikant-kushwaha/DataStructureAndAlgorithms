using System;

namespace DSA.BST
{
    public class Node
    {
        public Node(int data)
        {
            this.data = data;
        }
        public int data { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
    }
}
