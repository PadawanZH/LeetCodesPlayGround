using System;

namespace LeetCodes
{
    public class A714BestTimeToBuyAndSellStockWithFee
    {
        public int MaxProfit(int[] prices, int fee) {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }
            
            int[] sell = new int[prices.Length], buy = new int[prices.Length];

            sell[0] = 0;
            buy[0] = -prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                sell[i] = Math.Max(sell[i - 1], buy[i - 1] - fee + prices[i]);
                buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
            }

            return sell[prices.Length - 1];
        }
    }
}