namespace LeetCodes
{
    public class A650TwoKeyKeyBoard
    {
        public int MinSteps(int n) {
            if (n <= 1)
            {
                return 0;
            }

            if (SmallestDivider(n) == -1)
            {
                return n;
            }

            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                int sd = SmallestDivider(i);
                if (sd != -1)
                {
                    dp[i] = dp[sd] + dp[i / sd];
                }
                else
                {
                    dp[i] = i;
                }
            }

            return dp[n];
        }

        int SmallestDivider(int m)
        {
            for (int i = 2; i <= m / 2; i++)
            {
                if (m % i == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}