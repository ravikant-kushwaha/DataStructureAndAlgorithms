using System;

namespace DSA.Array
{
    public class MoveOnetoEnd
    {
        public void Start()
        {
            MaxOperations("1001100");
        }
        public int MaxOperations(string s)
        {
            int maxMove = 0;
            int NumofOnes = 0;
            bool gapZero = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    if (gapZero)
                    {
                        maxMove += NumofOnes;
                        gapZero = false;
                    }
                    NumofOnes++;
                }
                else if (s[i] == '0')
                {
                    gapZero = true;
                }
            }
            if (gapZero)
            {
                maxMove += NumofOnes;
                gapZero = false;
            }
            return maxMove;
        }
    }
}
