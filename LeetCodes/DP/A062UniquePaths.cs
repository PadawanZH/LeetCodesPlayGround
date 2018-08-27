using System;

namespace LeetCodes
{
    public class A062UniquePaths
    {
        public int UniquePaths(int m, int n)
        {
            UniquePaths_DP(m, n);
            UniquePaths_MathSolution(m, n);
            return 0;
        }

        public int UniquePaths_DP(int m, int n)
        {
            int[,] dp = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                dp[0, i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[n - 1, m - 1];
        }
        
        [Solution(IsSolution = true)]
        public int UniquePaths_MathSolution(int m, int n) {
            if (m <= 0 || n <= 0)
            {
                return 0;
            }

            //will overflow if use int for res
            long res = 1;
            int max = Math.Max(m, n);
            int min = Math.Min(m, n);

            int j = 1;
            for (int i = max; i <= m + n - 2; i++)
            {
                res *= i;
                res /= j;
                j++;
            }

            return (int)res;
        }
    }
}