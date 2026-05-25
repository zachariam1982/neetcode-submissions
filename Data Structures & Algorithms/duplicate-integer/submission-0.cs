public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> storage = new HashSet<int>();

        foreach(var i in nums){
            if(!storage.Add(i)) { return true;}
        }
        return false;
    }
}