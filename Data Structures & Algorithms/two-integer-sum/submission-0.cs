public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])){
                dict[nums[i]] = new List<int>();
            }
            dict[nums[i]].Add(i);
        }

        for(int i = 0; i < nums.Length; i++){
            int result = target - nums[i];
            if(dict.ContainsKey(result)) {
                foreach( var t in dict[result]){
                    if(i == t) continue;
                    return new int[] {i, t};
                }
            }
        }

        return new int[]{};
    }
}
