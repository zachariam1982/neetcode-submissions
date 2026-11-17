public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int l = 0, r = 1;
        int max = 0;
        Dictionary<char,int> dict = new Dictionary<char,int>();
        if(s.Length == 0) return 0;
        if(s.Length == 1) return 1;   

        dict.Add(s[l],0);

        while(r < s.Length){
            if(dict.ContainsKey(s[r])){
                var index = dict[s[r]];
                foreach(var node in dict){
                    if(node.Value <= index){
                        dict.Remove(node.Key);
                    }
                }
            }
            dict.Add(s[r], r);

            max = Math.Max(dict.Count(), max);
            ++r;
        }

        return max;
    }
}
