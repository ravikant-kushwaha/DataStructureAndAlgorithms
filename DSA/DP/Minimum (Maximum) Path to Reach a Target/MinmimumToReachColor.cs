using System;

namespace DSA.DP.Minimum_Path_to_Reach_a_Target
{
    public class MinmimumToReachColor
    {
        public void Start()
        {
            Console.WriteLine(MinCost("aaabbbabbbb", [3,5,10,7,5,3,5,5,4,8,1]));
        }

        public int MinCost(string colors, int[] neededTime) 
        {
            int totalCost = 0;
            int cost = neededTime[0];
            char prev = colors[0];
            for (int i = 1; i < colors.Length; i++)
            {
                if (colors[i] == prev)
                {
                    totalCost += Math.Min(neededTime[i], cost);
                    cost = Math.Max(neededTime[i], cost);
                }
                else
                {
                    cost = neededTime[i];
                    prev = colors[i];
                }
            }
            return totalCost;
        }
    }
}
