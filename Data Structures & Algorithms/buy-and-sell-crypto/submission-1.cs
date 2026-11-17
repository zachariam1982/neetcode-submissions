public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;
        int smallest = prices[0];

        for(int i = 1; i < prices.Length; i++){
            if(smallest > prices[i]){
                smallest = prices[i];
            }
            else{
                int tmp = prices[i] - smallest;

                max = max > tmp ? max : tmp;
            }
        }

        return max;
    }
}
