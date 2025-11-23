using System;

namespace DSA.Array.Easy
{
    public class OpTomakeDivByThree
    {
        public void Start()
        {
            MinimumOperations([1,2,3,4]);
        }
        public int MinimumOperations(int[] nums) 
        {
            int allops = 0;

            for(int i= 0; i < nums.Length;i++)
            {
                int forops = 0;
                int backops = 0;
                int currnum = nums[i];
                while(currnum%3 != 0)
                {
                     currnum--;
                     backops++;
                }
                currnum = nums[i];
                while(currnum%3 != 0)
                {
                     currnum++;
                     forops++;
                }

                allops += Math.Min(forops, backops);
            }
            return allops;
        }
    }
}
