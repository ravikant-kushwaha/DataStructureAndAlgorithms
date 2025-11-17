using System;

namespace DSA.Array.Easy
{
    public class FixedkSum
    {
        public void Start()
        {
            Console.WriteLine(FindXSum([1,1,2,2,3,4,2,3], 6, 2));
        }
        public int[] FindXSum(int[] nums, int k, int x)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> result = new List<int>();
            int l = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])) dic[nums[i]] += 1;
                else dic.Add(nums[i], 1);
                
                int len = i - l + 1;
                if (len == k)
                {
                    int sum = findTopElements(dic, x);
                    result.Add(sum);
                    dic[nums[l]]--;
                    l++;
                }
            }
            return result.ToArray();
        }
        
        private int findTopElements(Dictionary<int,int> dic, int x)
        {
            var sortedarr = dic.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key);
            int sum = 0;
            int Length = 0;
            foreach(var item in sortedarr)
            {
                sum += item.Key * item.Value;
                Length += 1;
                if (Length == x) break;
            }
            return sum;
        }
    }
}
