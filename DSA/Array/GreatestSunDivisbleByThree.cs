using System;

namespace DSA.Array
{
    public class GreatestSunDivisbleByThree
    {
        public void Start()
        {
            MaxSumDivThree([1,2,3,4,4]);
        }
        public int MaxSumDivThree(int[] nums) 
        {
            int total = nums.Sum();
            var mod1 = nums.Where(x => x % 3 == 1).OrderBy(x => x).ToList();
            var mod2 = nums.Where(x => x % 3 == 2).OrderBy(x => x).ToList();

            if (total % 3 == 0) return total;

            int opt1 = int.MaxValue;
            int opt2 = int.MaxValue;

            if (total % 3 == 1) {
                if (mod1.Count >= 1) opt1 = mod1[0];
                if (mod2.Count >= 2) opt2 = mod2[0] + mod2[1];
            } else {
                if (mod2.Count >= 1) opt1 = mod2[0];
                if (mod1.Count >= 2) opt2 = mod1[0] + mod1[1];
            }

            int minLoss = Math.Min(opt1, opt2);
            return minLoss == int.MaxValue ? 0 : total - minLoss;
        }
    }
}
