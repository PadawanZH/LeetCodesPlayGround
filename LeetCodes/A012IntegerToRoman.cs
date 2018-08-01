using System.Linq;

namespace LeetCodes
{
    public class A012IntegerToRoman
    {
        
        private string[] pattern = {"A", "AA", "AAA", "AB", "B", "BA", "BAA", "BAAA", "AE"};
        private char[] ABook = {'I', 'X', 'C', 'M'};
        private char[] BBook = {'V', 'L', 'D'};
        
        public string IntToRoman(int num)
        {
            string res = "";
            int digitIndex = 0;
            while (num != 0)
            {
                int digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    digitIndex++;
                    continue;
                }

                string temp = pattern[digit - 1];
                string digRest = "";
                foreach (var a in temp)
                {
                    if (a == 'A')
                    {
                        digRest += ABook[digitIndex];
                    }else if (a == 'B')
                    {
                        digRest += BBook[digitIndex];
                    }
                    else
                    {
                        digRest += ABook[digitIndex + 1];
                    }
                }


                res = digRest + res;

                digitIndex++;
            }

            return res;
        }
    }
}