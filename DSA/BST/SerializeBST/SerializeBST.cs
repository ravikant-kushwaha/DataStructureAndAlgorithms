using System;
using System.Text;

namespace DSA.BST.SerializeBST
{
    public class SerializeBST
    {
        private Node root { get; set; }
        public SerializeBST()
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
            var data = serialize(root);
            Console.WriteLine(data);
            var newtree = Deserialize(data);
            Console.WriteLine(serialize(newtree));
        }

        private string serialize(Node root)
        {
            var sb = new StringBuilder();
            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                sb.Append(root.data);
                if(root.Right != null)stack.Push(root.Right);
                if(root.Left != null) stack.Push(root.Left);
            }
            var value = sb.ToString().Substring(0, sb.Length - 1);
            Console.WriteLine(value);
            return value;
        }

        private Node Deserialize(string value)
        {
            var chararr = value.Split('-');
            var root = new Node(Int32.Parse(chararr[0].ToString()));
            for (int i = 1; i < chararr.Length; i++)
            {
                Insert(root, Int32.Parse(chararr[i].ToString()));
            }
            return root;
        }
        private void Insert(Node root, int val)
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
                if (val < root.data) Insert(root.Left, val);
                else Insert(root.Right, val);
            }
            return;
        }
    }
}
