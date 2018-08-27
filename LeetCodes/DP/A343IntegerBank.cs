namespace LeetCodes
{
    public class A343IntegerBank
    {
        [Solution(IsSolution = true)]
        public int IntegerBreak(int n)
        {
            if (n <= 1)
            {
                return 0;
            }else if (n == 2)
            {
                return 1;
            }else if (n == 3)
            {
                return 2;
            }
            
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;

            for (int i = 4; i <= n; i++)
            {
                int max = 0;
                for (int j = 1; j <= i/2; j++)
                {
                    int mul = dp[j] * dp[i - j];
                    dp[i] = max = (max > mul) ? max : mul;
                    
                }
            }

            return dp[n];
        }
    }
}