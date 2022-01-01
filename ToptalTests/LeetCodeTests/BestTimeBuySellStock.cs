namespace ToptalTests.LeetCodeTests
{
    public class BestTimeBuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            //find cheapest price
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                else if (prices[i] - minPrice > maxProfit)
                    maxProfit = prices[i] - minPrice;
            }
            return maxProfit;
        }

        public int MaxProfit2(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
