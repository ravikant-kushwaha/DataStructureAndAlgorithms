using System;

namespace DSA.Array.Easy
{
    public class FixedKSumHard
    {
        public void Start()
        {
            Console.WriteLine(FindXSum([1, 1, 2, 2, 3, 4, 2, 3], 6, 2));
        }
        public long[] FindXSum(int[] nums, int k, int x)
        {
            Dictionary<long, long> dic = new Dictionary<long, long>();
            PriorityQueue<int, (int, int)> heap = new PriorityQueue<int, (int, int)>();
            List<long> result = new List<long>();
            int l = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i])) dic[nums[i]] += 1;
                else dic.Add(nums[i], 1);

                int len = i - l + 1;
                if (len == k)
                {
                    long sum = findTopElements(dic, x);
                    result.Add(sum);
                    dic[nums[l]]--;
                    l++;
                }
            }
            return result.ToArray();
        }
        private long findTopElements(Dictionary<long, long> dic, int x)
        {
            var sortedarr = dic.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key);
            long sum = 0;
            int Length = 0;
            foreach (var item in sortedarr)
            {
                sum += item.Key * item.Value;
                Length += 1;
                if (Length == x) break;
            }
            return sum;
        }
    }
}
