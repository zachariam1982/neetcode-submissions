public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;

        for(int i = 0, j = heights.Length - 1; i < j;){
            int pro = 0;
            int diff = j - i;
            int a = heights[i], b = heights[j];

            if(a < b){
                pro = a * diff;
                i++;
            }else{
                pro = b * diff;
                j--;
            }

            max = max < pro ? pro : max;


        }

        return max;
    }
}
