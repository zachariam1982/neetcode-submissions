public class Solution {
    private string CreateUniqueHash(string arg)
    {
        int[] a = new int[26];
        string s = new string("");

        foreach(var t in arg.ToLower()){
            a[t - 'a']++;
        }

        for(int i = 0; i < 26; i++){
            s += 'a' + i;
            s += a[i];
        }

        return s;
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach( var str in strs){
            string t = CreateUniqueHash(str);

            if(!dict.ContainsKey(t)) { dict.Add(t, new List<string>());}

            dict[t].Add(str);
        }

        List<List<string>> ret = new List<List<string>>();

        foreach(var t in dict) {
            ret.Add(t.Value);
        }

        return ret;
    }
}
