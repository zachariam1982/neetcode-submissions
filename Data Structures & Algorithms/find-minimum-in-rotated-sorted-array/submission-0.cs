public class Solution {
    public int FindMin(int[] nums) {
        if(nums[0] < nums[nums.Length - 1]){
            //Array is in proper order
            return nums[0];
        }
        int l = 0, r = nums.Length - 1;
        int mid = (l+r)/2;

        while(l < r)
        {
            if(nums[mid] < nums[nums.Length - 1]){
                r = mid;
            }
            else{
                l = mid + 1;
            }

            mid = (l+r)/2;
        }

        return nums[l];
    }
}
