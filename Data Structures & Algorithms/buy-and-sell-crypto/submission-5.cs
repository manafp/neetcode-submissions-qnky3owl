public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;
        int l = 0;
        int r = l + 1;
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
