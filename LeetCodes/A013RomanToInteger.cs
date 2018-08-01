using System;

namespace LeetCodes
{
    public class A013RomanToInteger
    {
        private string[] pattern = {"A", "AA", "AAA", "AB", "B", "BA", "BAA", "BAAA", "AE"};
        private char[] ABook = {'I', 'X', 'C', 'M'};
        private char[] BBook = {'V', 'L', 'D'};

        
        public int RomanToInt(string s)
        {
            int digitIndex = 0;
            int res = 0;
            while (s.Length != 0)
            {
                int longestMatch = 0, matchIndex = -1;
                for (int i = pattern.Length - 1; i >= 0; i--)
                {
                    if (digitIndex == 3 && i >= 3)
                    {
                        continue;
                    }
                    string template = Replace(pattern[i], digitIndex);
                    
                    if (s.Length >= template.Length && s.EndsWith(template))
                    {
                        if (longestMatch < template.Length)
                        {
                            longestMatch = template.Length;
                            matchIndex = i;
                        }
                    }
                }

                if (matchIndex != -1)
                {
                    res = res + (matchIndex + 1) * (int)Math.Pow(10, digitIndex);
                    s = (s.Length - pattern[matchIndex].Length == 0) ? "" : s.Substring(0, s.Length - pattern[matchIndex].Length);
                }
                digitIndex++;
            }

            return res;
        }

        public string Replace(string str, int currentDigit)
        {
            string res = "";
            foreach (var ch in str)
            {
                if (ch == 'A')
                {
                    res += ABook[currentDigit];
                }else if (ch == 'B')
                {
                    res += BBook[currentDigit];
                }
                else
                {
                    res += ABook[currentDigit + 1];
                }
            }

            return res;
        }
        
        
    }
}