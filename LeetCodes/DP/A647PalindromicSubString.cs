using System;

namespace LeetCodes
{
    public class A647PalindromicSubString
    {
        [Solution(IsSolution = true)]
        public int CountSubstrings(String s) {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            bool[,] dp = new bool[s.Length,s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    dp[i, j] = false;
                }
            }

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                dp[i, i] = true;
                count++;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i + 1] = true;
                    count++;
                }
            }

            for (int substrLen = 3; substrLen <= s.Length; substrLen++)
            {
                for (int i = 0; i < s.Length - substrLen + 1; i++)
                {
                    int j = i + substrLen - 1;
                    if (s[i] == s[j] && dp[i + 1, j - 1])
                    {
                        dp[i, j] = true;
                        count++;
                    }
                }
            }

            return count;
        }
    }
}