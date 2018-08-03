using System;
using System.Linq;

namespace LeetCodes
{
    public class A121BestTimeToBuyAndSellStock
    {
        public int MaxProfit_DP(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            int[] dp = new int[prices.Length];

            int minPrice = prices[0];
            dp[0] = minPrice;

            for (int i = 1; i < prices.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], prices[i] - minPrice);
                minPrice = Math.Min(prices[i], minPrice);
            }

            return dp[prices.Length - 1];
        }
    }
}