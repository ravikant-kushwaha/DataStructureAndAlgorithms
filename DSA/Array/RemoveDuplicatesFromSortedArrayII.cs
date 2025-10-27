using System;

namespace DSA.Array
{
    public class RemoveDuplicatesFromSortedArrayII
    {
        public void Start()
        {
            Console.WriteLine(RemoveDuplicates([1,2,2,2]));
        }

        public int RemoveDuplicates(int[] nums)
        {
            int j = 1;
            int i = 1;

            int count = 1;
            int curretnum = nums[0];

            while (j < nums.Length)
            {
                if (count == 2)
                {
                    while (j < nums.Length && nums[j] == curretnum) j++;
                    if (j < nums.Length) curretnum = nums[j];
                    count = 0;
                }
                else if(nums[j] != curretnum)
                {
                    curretnum = nums[j];
                    count = 0;
                }
                else
                {
                    nums[i] = nums[j];
                    i++;
                    j++;
                    count++;
                }
            }
            return i;
        }
    }
}
