using System;

namespace DSA.Array.Medium
{
    public class CountSpecialTriplets
    {
        public void Start()
        {
            SpecialTriplets([0,1,0,0]);
        }

        public int SpecialTriplets(int[] nums) 
        {
        int n = nums.Length;
        int MOD = 1_000_000_007;

        int max = 200000;
        int[] leftFreq = new int[max + 1];
        int[] rightFreq = new int[max + 1];

        foreach (int x in nums) {
            rightFreq[x]++;
        }

        long ans = 0;

        for (int j = 0; j < n; j++) {
            int val = nums[j];
            rightFreq[val]--;      // nums[j] moves out of right side

            int target = val * 2;
            if (target <= max) {
                long leftCount = leftFreq[target];
                long rightCount = rightFreq[target];
                ans = (ans + leftCount * rightCount) % MOD;
            }

            leftFreq[val]++;       // nums[j] moves into left side
        }

        return (int)ans;
        }
        
    }
}
