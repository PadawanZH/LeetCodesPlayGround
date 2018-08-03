namespace LeetCodes
{
    public class A121BestTimeToBuyAndSellStock
    {
        //price[i+2] - price[i] == (price[i+2] - price[i+1]) + (price[i+1] - price[i])
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
                return 0;
            int max = 0, tmp = 0;
            

            for(int i = 1; i < prices.Length; i++){
                tmp += (prices[i] - prices[i-1]);
                if(tmp < 0){
                    tmp = 0;
                }
                if(tmp > max){
                    max = tmp;
                }
            }

            return max;
        }
    }
}