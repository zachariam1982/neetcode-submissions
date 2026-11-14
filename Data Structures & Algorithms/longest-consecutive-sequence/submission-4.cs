public class Solution {
    public int LongestConsecutive(int[] nums) {
        SortedSet<int> set = new SortedSet<int>();

        if(nums.Length == 0){
            return 0;
        }

        for(int i = 0; i < nums.Length; i++) {
            set.Add(nums[i]);
        }

        List<int> lst = set.ToList();
        int length = 0;
        int maxLength = 0;

        for(int start = 0, end = 0; end < lst.Count; end++){
            if(lst[start] + length == lst[end]){
                if(maxLength < length){
                    maxLength = length;
                }
                ++length;
            }
            else{
                start = end;
                end = end - 1;
                length = 0;
            }
        }

        return maxLength + 1;
    }
}
