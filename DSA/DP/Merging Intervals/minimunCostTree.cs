using System;

namespace DSA.DP.Merging_Intervals
{
    public class minimunCostTree
    {
        public void start()
        {
            Console.WriteLine(MctFromLeafValues([6,2,4]));
        }
        public int MctFromLeafValues(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(int.MaxValue);
            int res = 0;

            foreach (int num in arr)
            {
                while (stack.Peek() <= num)
                {
                    int mid = stack.Pop();
                    res += mid * Math.Min(stack.Peek(), num);
                }
                stack.Push(num);
            }

            while (stack.Count > 2)
            {
                int mid = stack.Pop();
                res += mid * stack.Peek();
            }

            return res;
        }
    }
}
