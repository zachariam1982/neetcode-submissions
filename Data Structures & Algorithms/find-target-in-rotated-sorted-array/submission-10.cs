public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        int mid = (l+r)/2;

        while(l < r) {
            if(nums[mid] == target) return mid;

            if(nums[mid] > target){
                if(target >= nums[l] || nums[mid] <= nums[r]){
                    r = mid;
                }
                else {
                    l = mid + 1;
                }
            }
            else{
                if(target <= nums[r] || nums[mid] >= nums[l]){
                    l = mid + 1;
                }
                else{
                    r = mid;
                }
            }

            mid = (l+r)/2;
        }

        if(nums[mid] == target) return mid;

        return -1;
    }
}
