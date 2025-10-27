using System;
using System.Text;

namespace DSA.Array
{
    public class RemoveAllDuplicatesII
    {
        public void Start()
        {
            Console.WriteLine(RemoveDuplicates("abcd", 2));
        }

        public string RemoveDuplicates(string s, int k)    
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(s[i]);
                int j = sb.Length - 1;
                int count = 1;
                while (sb.Length >= k && j >=0 && sb[j - 1] == sb[j])
                {
                    j--;
                    count++;
                    if (count == k)
                    {
                        sb = sb.Remove(sb.Length - k, k);
                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
