using System;

namespace DSA.Strings
{
    public class Palndromeof3Chars
    {
        public void Start()
        {
            CountPalindromicSubsequence("aabca");
        }
        public int CountPalindromicSubsequence(string s) 
        {
            HashSet<string> valids = new HashSet<string>();

            Dictionary<char,List<int>> map = new Dictionary<char, List<int>>();
            int i =0;
            foreach(var item in s)
            {
                if(map.ContainsKey(item)) map[item].Add(i);
                else
                {
                    var list = new List<int>();
                    list.Add(i);
                    map.Add(item, list);
                }
                i++;
            }

            foreach(var keypair in map)
            {
                if(keypair.Value.Count >=2)
                {
                    if(keypair.Value.Count >2)addString(valids, s, keypair.Value.First(),keypair.Value.First(),keypair.Value.First());
                    int start = keypair.Value.First();
                    int end = keypair.Value.Last();
                    int next = start + 1;
                    while(next < end)
                    {
                        addString(valids, s, start,next,end);
                        next++;
                    }
                }
            }
            return valids.Count;
        }

        private void addString(HashSet<string> hash, string s, int index1, int index2, int index3)
        {
            string result = s[index1].ToString() + s[index2].ToString() + s[index3].ToString();
            if(!hash.Contains(result)) hash.Add(result);
        }
    }
}
