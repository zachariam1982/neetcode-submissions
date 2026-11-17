public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;

        for(int i = 0, j = heights.Length - 1; i < j;){
            (int a, int b) = (heights[i], heights[j]);

            (a, b) = a > b? (b, a):(a, b);

            int pro = (a * (j - i));

            max = max < pro ? pro : max;

            if(a == heights[i])
                i++;
            else
                j--;
        }

        return max;
    }
}
