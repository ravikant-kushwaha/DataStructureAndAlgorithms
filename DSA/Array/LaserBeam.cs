using System;

namespace DSA.Array
{
    public class LaserBeam
    {
        public void Start()
        {
            NumberOfBeams(["000","111","000"]);
        }

        public int NumberOfBeams(string[] bank) 
        {
            int totalbeam = 0;
            int lastbeam = 0;
            for (int i = 0; i < bank.Length; i++)
            {
                int currentbeam = 0;
                for (int j = 0; j < bank[i].Length; j++)
                {
                    if (bank[i][j] == '1')
                    {
                        currentbeam++;
                    }
                }
                totalbeam += lastbeam * currentbeam;
                if(currentbeam != 0)
                    lastbeam = currentbeam;
            }
            return totalbeam;
        }
    }
}
