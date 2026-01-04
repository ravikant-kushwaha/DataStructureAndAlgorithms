using System;
using DSA.Array;

namespace DSA.Maths
{
    public class ExactFourDivisors
    {
        public void Start()
        {
            SumFourDivisors([90779,36358,90351,75474,32986]);
        }
        public int SumFourDivisors(int[] nums) 
        {
            int TotalSum = 0;
            foreach(int num in nums)
            {
                int Count = 0;
                int Sum = 0;
                for(int j = 1; j*j <= num; j++)
                {
                    if(num%j == 0)
                    {
                        Sum += j;
                        Count++;
                        
                        if(j!=num/j){
                            Count++;
                            Sum+=num/j;
                        }
                    }   
                    if(Count > 4)
                    {
                        break;
                    }
                }
                if(Count == 4)
                {                
                    TotalSum += Sum;
                }
            }
            return TotalSum;
        }
    }
}
