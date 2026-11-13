public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int prod = 1;
        int numZero = 0;
        List<int> ret = new List<int>();

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                numZero++;
            }
        }

        if(numZero == 0){
            for(int i = 1; i < nums.Length; i++){
                prod *= nums[i];
            }

            ret.Add(prod);

            for(int i  = 1; i < nums.Length; i++) {
                prod = prod / nums[i];
                prod = prod * nums[i - 1];

                ret.Add(prod);
            }
        }
        else if (numZero == 1) {
            int zeroIndex = 0;

            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == 0){ 
                    zeroIndex = i;
                    continue;
                }
                prod *= nums[i];
            }

            for(int i = 0;i < nums.Length; i++){
                if(zeroIndex == i){
                    ret.Add(prod);
                }
                else {
                    ret.Add(0);
                }
            }
        }
        else{
            for(int i = 0;i < nums.Length; i++){
                ret.Add(0);
            }
        }

        return ret.ToArray();
    }
}
