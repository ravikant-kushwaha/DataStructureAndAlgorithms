using System;

namespace DSA.Array.Easy
{
    public class Sneakynums
    {
        public void Start()
        {
            GetSneakyNumbers([0,3,2,1,3,2]);
        }
        
        public int[] GetSneakyNumbers(int[] nums) 
        {
            bool[] hash = new bool[nums.Length];
            List<int> duplicate = new List<int>();
            foreach (var item in nums)
            {
                if (hash[item])
                {
                    duplicate.Add(item);
                }
                else
                {
                    hash[item] = true;
                }
            }
            return duplicate.ToArray();
        }
    }
}
