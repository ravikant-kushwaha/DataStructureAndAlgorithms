using System;

namespace DSA.Array
{
    public class MinmunToMakeArrayOne
    {
        public void Start()
        {
            MinOperations([2,6,3,4]);
        }
    public int MinOperations(int[] nums) {
        int n = nums.Length;

        int ocount = 0;
        for (int i = 0; i < n; i++) {
            if (nums[i] == 1) ocount++;
        }

        if (ocount > 0) return n - ocount;

        int total = -1;
        int minsub = 51;
        for (int i = 0; i < n; i++) {
            int gcd = nums[i];
            for (int j = i + 1; j < n; j++) {
                gcd = GCD(gcd, nums[j]);
                if (gcd == 1) {
                    minsub = Math.Min(minsub, j - i + 1);
                    break; 
                }
            }
        }
        if (minsub < 51) {
            total = minsub + n - 2;
        } 
        return total;
    }

    public int GCD(int a, int b) {
        while (b != 0) {
            int tmp = b;
            b = a % b;
            a = tmp;
        }
        return a;
    }
    }
}
