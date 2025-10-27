using System;

namespace DSA.Siliding_window
{
    public class Windowmaximun
    {
        int[]  nums = [1,3,-1,-3,5,3,6,7];
        public void Start()
        {
            var res = max(nums, 3);
        }

        private int[] max(int[] nums, int k)
        {
        if (nums.Length == 0) return new int[0];

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>(); // stores indices
        int resIndex = 0;

        for (int i = 0; i < n; i++)
        {
            // Remove indices out of the current window
            if (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst();

            // Remove elements smaller than current from back
            while (deque.Count > 0 && nums[i] >= nums[deque.Last.Value])
                deque.RemoveLast();

            deque.AddLast(i);

            // Window has formed
            if (i >= k - 1)
                result[resIndex++] = nums[deque.First.Value];
        }

        return result;
        }
    }
}
