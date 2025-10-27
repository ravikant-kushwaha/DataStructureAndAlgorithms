using System;
using System.Text;

namespace DSA.Greedy
{
    public class RemoveKDigits
    {
        public void start()
        {
            Console.WriteLine(remove("1432219", 3));
        }
        
        private string remove(string num, int k)
        {
            Stack<char> stack = new Stack<char>();
            StringBuilder sb = new StringBuilder();
            foreach (char c in num)
            {
                while (k > 0 && stack.Count() > 0 && stack.Peek() > c)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(c);
            }

            while (k > 0) stack.Pop();

            while (stack.Count > 0)
            {
                sb.Insert(0, stack.Pop());
            }

            while (sb.Length > 0 && sb[0] == 0) sb.Remove(0, 1);

            return sb.ToString();
        }
    }
}
