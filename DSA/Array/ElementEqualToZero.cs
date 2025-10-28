using System;

namespace DSA.Array
{
    public class ElementEqualToZero
    {
        public void Start()
        {
            CountValidSelections([16,13,10,0,0,0,10,6,7,8,7]);
        }
        
        public int CountValidSelections(int[] nums) 
        {
            int toalsum = 0;

            foreach (var item in nums) toalsum += item;

            int leftsum = 0;
            int totalways = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && toalsum == leftsum) totalways += 2;
                else if(nums[i] == 0 && ((toalsum == leftsum - 1) || (toalsum == leftsum + 1))) totalways += 1;
                else
                {
                    leftsum += nums[i];
                    toalsum -= nums[i];
                }
            }

            return totalways;
        }
    }
}
