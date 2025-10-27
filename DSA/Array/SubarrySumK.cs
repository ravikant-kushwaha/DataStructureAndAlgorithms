using System;

namespace DSA.Array
{
    public class SubarrySumK
    {
        
        int[] input = [1, 1, 1, 2, 2, 3];
        public void Start()
        {
            SubarraySum(input, 2);
        }

        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            map[0] = 1; // base case: prefix sum 0 occurs once

            int currSum = 0;
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currSum += nums[i];

                if (map.ContainsKey(currSum - k))
                {
                    count += map[currSum - k];
                }

                if (!map.ContainsKey(currSum))
                {
                    map[currSum] = 0;
                }
                map[currSum]++;
            }

            return count;
        }
    }
}
