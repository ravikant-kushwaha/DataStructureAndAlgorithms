using System;
using System.Text;

namespace DSA.Strings
{
    public class StringToNum
    {
        public void Start()
        {
            Console.WriteLine(MyAtoi("21474836460"));
        }
        public int MyAtoi(string s)
        {         
            int i = 0;

            while (i < s.Length && s[i] == ' ') i++;
            if (i >= s.Length) return 0;

            int sign = s[i] == '-' ? -1 : 1;
            if(s[i] == '+') i++;
            if (sign < 0) i++;
            if (i >= s.Length) return 0;

            while (i < s.Length  && s[i] == '0') i++;
            if (i >= s.Length) return 0;

            long number = 0;
            int place = 10;
            while (i < s.Length)
            {
                int ascii = (int)s[i];
                if (ascii <= 47 || ascii >= 58) return (int)number * sign;

                int currNum = ascii - 48;
                number = number * place;
                number += currNum;
                i++;
                
                if (number * sign <= int.MinValue) return int.MinValue;
                if (number * sign >= int.MaxValue) return int.MaxValue;
            }

            return (int)number * sign;
        }
    }
}
