public class Solution {
    public int MaxProfit(int[] prices) {
        var n = prices.Length;
        var res = 0;
        var l = 0;
        for (int i = 1; i < n; i++) {
            if (prices[i - 1] < prices[l]) {
                l = i - 1;
            }
            var profit = prices[i] - prices[l];
            if (profit > res) {
                res = profit;
            }
        }

        return res;
    }
}
