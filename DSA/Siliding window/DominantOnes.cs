using System;

namespace DSA.Siliding_window
{
    public class DominantOnes
    {
        public void Start()
        {
            NumberOfSubstrings("101101");
        }
        public int NumberOfSubstrings(string s) 
        {
            int l = 0;
            int r = 0;
            int numOfZeros = 0;
            int numOfOnes = 0;
            int dominantCount = 0;
            while(r < s.Length)
            {
                if(numOfZeros > Math.Sqrt(s.Length))
                {
                    if(s[l] == '1') numOfOnes--;
                    else numOfZeros--;
                    l++;
                    while(l < r-1 && s[l] == '0') { numOfZeros--; l++; }
                }    

                if( s[r] == '1') { numOfOnes++; dominantCount++; }
                else numOfZeros++;
                r++;


                if(numOfOnes > 0 && numOfOnes >= Math.Pow(numOfZeros, 2)) dominantCount++;
            }

            while(l < s.Length -1)
            {
                if( s[l] == '1') { numOfOnes--; }
                else numOfZeros--;
                l++;

                if(l != s.Length -1 && numOfOnes >= Math.Pow(numOfZeros, 2)) dominantCount++;
            }

            return dominantCount;
        }
    }
}
