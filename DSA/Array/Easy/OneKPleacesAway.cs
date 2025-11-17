using System;

namespace DSA.Array.Easy
{
    public class OneKPleacesAway
    {
        public void Start()
        {
            MaxOperations([0,0,0,1,0,1], 2);
        }

        public bool MaxOperations(int[] nums, int k) 
        {
            int distance = 0;
            bool foundOne = false;
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] == 1 && !foundOne) foundOne = true;
                else if(nums[i] == 1)
                {
                    if(distance < k) return false;
                    distance = 0;
                }
                else
                {
                    distance++;
                }
            }
            return true;
        }
    }
}
