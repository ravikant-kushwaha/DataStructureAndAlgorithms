using System;
using System.Text;

namespace DSA.Array
{
    public class RemoveAllDuplicatesI
    {
        public void Start()
        {
            Console.WriteLine(RemoveDuplicates("azxxzy"));
        }

        public string RemoveDuplicates(string s) 
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

                if (stack.Count > 0 && stack.Peek() == s[i]) stack.Pop();
                else stack.Push(s[i]);
            }

            StringBuilder sb = new StringBuilder();

            while (stack.Count > 0)
            {
                sb.Insert(0, stack.Pop());
            }

            return sb.ToString();
        }
    }
}
