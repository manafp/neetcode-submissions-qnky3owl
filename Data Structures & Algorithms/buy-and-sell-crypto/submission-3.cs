public class Solution {
    public int MaxProfit(int[] prices) {
        
        int l = 0;
        int r = 1;
        int profit = 0;

        while(r < prices.Length)
        {
            if(prices[r] < prices[l])
            {
                l = r;
            }
            else
            {
                profit = Math.Max(profit,prices[r] - prices[l]);
            }
            r++;
        }
        return profit;
    }
}
