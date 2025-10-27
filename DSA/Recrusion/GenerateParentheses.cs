using System;

namespace DSA.Recrusion
{
    public class GenerateParentheses
    {
        private List<string> result = new List<string>();
        public void Start()
        {
            generate(10, "", 0, 0);
            Console.WriteLine();
        }

        private void generate(int n, string current, int open, int close)
        {
            if (open > n || close > n || !Isvalid(current)) return;

            if (current.Length == n*2)
            {
                result.Add(current);
                return;
            }

            generate(n, current + "(", open+1, close);
            generate(n, current + ")", open, close + 1);

            return;
        }

        private bool Isvalid(string current)
        {
            Stack<char> chars = new Stack<char>();
            char[] arr = current.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ')')
                {
                    if (chars.Count > 0 && chars.Pop() == '(') continue;
                    return false;
                }
                else
                {
                    chars.Push(arr[i]);
                }
            }

            return true;
        }
    }
}
