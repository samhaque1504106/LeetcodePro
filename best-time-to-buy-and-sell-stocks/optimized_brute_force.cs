public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        int max_profit = 0;
        int buy = prices[0];
        for(int i=1;i<n;i++)
        {
            if(prices[i]<buy)
            {
                buy = prices[i];
            }
            if(prices[i]>buy)
            {
                max_profit = Math.Max(prices[i] - buy,max_profit);
            }
           
        }

        return max_profit;
    }
    
}