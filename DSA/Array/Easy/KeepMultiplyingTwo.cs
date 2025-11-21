using System;

namespace DSA.Array.Easy
{
    public class KeepMultiplyingTwo
    {
        public void Start()
        {
            FindFinalValue([8,19,4,2,15,3], 2);
        }
        public int FindFinalValue(int[] nums, int original) 
        {
            HashSet<int> hash = new HashSet<int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == original)
                {
                    while(hash.Contains(original*2)) 
                    {
                        original *= 2;
                    }
                    original *= 2;
                }
                else
                {
                    hash.Add(nums[i]);
                }
            }
            return original;
        }
    }
}
