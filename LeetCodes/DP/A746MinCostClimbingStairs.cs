using System;

namespace LeetCodes
{
    public class A746MinCostClimbingStairs
    {
        public int MinCostClimbingStairs(int[] cost) {
            int[] dp = new int[cost.Length + 1];

            dp[0] = cost[0];
            dp[1] = cost[1];

            for (int i = 2; i <= cost.Length; i++)
            {
                //((i < cost.Length)? cost[i] : 0) is for last step i.e. for step 10 15 30, result should be 15 because take 2 step to 15 and 2 step to reach the top
                //hence 10 15 30 should be "10, 15, 30, 0"
                dp[i] = Math.Min(dp[i - 2], dp[i - 1]) + ((i < cost.Length)? cost[i] : 0);
            }

            return dp[cost.Length];
        }
    }
}