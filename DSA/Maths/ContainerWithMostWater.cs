using System;

namespace DSA.Maths
{
    public class ContainerWithMostWater
    {
        public void Start()
        {
            MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
        }
        public int MaxArea(int[] height)
        {
        int[] leftmax = new int[height.Length];
            int[] rightmax = new int[height.Length];
            int leftMax = 0;
            int rightMax = 0;
            for (int i = 0; i < height.Length; i++)
            {
                leftMax = Math.Max(leftMax, height[i]);
                leftmax[i] = leftMax;
                rightMax = Math.Max(rightMax, height[height.Length - i - 1]);
                rightmax[height.Length - i - 1] = rightMax;
            }

            int maxArea = 0;
            int k = 0;
            int j = height.Length - 1;
            while(k < j)
            {
                int currentArea = Math.Min(leftmax[k], rightmax[j]) * Math.Abs(j - k);
                maxArea = Math.Max(currentArea, maxArea);
                if (leftmax[k] > rightmax[j]) j--;
                else k++;
            }

            return maxArea;
        }
    }
}
