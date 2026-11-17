public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;

        for(int i = 0; i < prices.Length - 1; i++){
            for(int j = i + 1; j < prices.Length; j++){
                if(prices[i] < prices[j]){
                    var tmp = prices[j] - prices[i];

                    max = max > tmp? max : tmp;
                }
            }
        }

        return max;
    }
}
