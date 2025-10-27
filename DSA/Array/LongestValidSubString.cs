using System;

namespace DSA.Array
{
    public class LongestValidSubString
    {
        public void Start()
        {
            Console.WriteLine(LongestValidSubstring("cbaaaabc", ["aaa", "cb"]));
        }

        public int LongestValidSubstring(string word, IList<string> forbidden)
        {
            HashSet<string> forbiddeSet = new HashSet<string>();
            int ans = 0;
            int i = 0, j = 0;

            foreach (var item in forbidden) forbiddeSet.Add(item);

            while (j < word.Length)
            {
                int k = j;

                while (k >= i)
                {
                    string str = word.Substring(k, j - k + 1);
                    if (forbidden.Contains(str))
                    {
                        i = k + 1;
                        break;
                    }
                    k--;
                }
                ans = Math.Max(ans, j - i + 1);
                j++;
            }
            return ans;
        }
    }
}
