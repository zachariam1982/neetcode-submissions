public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) { return false; }
        int[] s_array = new int[26], t_array = new int[26];

        for(int i = 0; i < s.Length; i++){
            s_array[s[i] - 'a']++;
            t_array[t[i] - 'a']++;
        }

        for(int i = 0; i < 26; i++){
            if(s_array[i] != t_array[i]) { return false; }
        }

        return true;
    }
}
