using System;

namespace DSA.Maths
{
    public class ReverseNumber
    {
        public void Start()
        {
            Reverse(123);
            Console.WriteLine();
        }
        public int Reverse(int x) 
        {
            int reversenum = 0;
            int negative = x < 0 ? -1 : 1;
            x = negative  * x;
            while (x > 0)
            {
                reversenum *= 10;
                reversenum += (x % 10);
                if (reversenum > int.MaxValue) return 0;
                x = x / 10;
            }
            return reversenum * negative;
        }
    }
}
