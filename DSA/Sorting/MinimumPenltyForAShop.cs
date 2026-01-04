using System;

namespace DSA.Sorting
{
    public class MinimumPenltyForAShop
    {
        public void Start()
        {
            BestClosingTime("YYYY");
        }
        public int BestClosingTime(string customers) 
        {
            int cutomersHours = 0;
            foreach(var charItem in customers)
            {
                if(charItem == 'Y') cutomersHours++;
            }

            int MiniMumPenlty = cutomersHours;
            int index = 0;
            int minPenltyIndex = 0;
            foreach(var charItem in customers)
            {
                index++;
                if(charItem == 'Y') cutomersHours--;
                else cutomersHours++;

                if(cutomersHours < MiniMumPenlty) 
                {
                    MiniMumPenlty = cutomersHours;
                    minPenltyIndex = index;
                }
            }

            return minPenltyIndex;
        }
    }
}
