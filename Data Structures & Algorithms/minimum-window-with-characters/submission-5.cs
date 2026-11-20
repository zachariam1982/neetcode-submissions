public class Solution {
    bool IsMatch(Dictionary<char, int> arg1, Dictionary<char, int> arg2){
        if(arg1 == null || arg2 == null) return false;
        if(arg1 == arg2) return true;

        foreach(var node in arg1){
            if(!arg2.ContainsKey(node.Key)) return false;
            if(arg2[node.Key] < node.Value) return false;
            //Console.WriteLine($"Key = {node.Key} Value = {node.Value}");
        }

        return true;
    }   

    void AddIntoDictionary(string s, int start, int end, Dictionary<char, int> arg){
        for(int i = start; i < end; i++){
            if(arg.ContainsKey(s[i])) arg[s[i]] += 1;
            else arg.Add(s[i], 1);
        }
    }

    public string MinWindow(string s, string t) {
        var t_dict = new Dictionary<char, int>();
        var s_dict = new Dictionary<char, int>();
        int min = s.Length + 1;
        int l = 0, r = 0;
        string ret = "";

        if(t.Length > s.Length) return "";

        AddIntoDictionary(t, 0, t.Length, t_dict);
        int j = t.Length;

        AddIntoDictionary(s, 0, t.Length, s_dict);
        for(int i = 0; i < s.Length;) {
            for(; j <= s.Length; j++){
                if(IsMatch(t_dict, s_dict)){
                    if(min > j - i){
                        l = i;
                        r = j;
                        min = j - i;
                        Console.WriteLine($"{i} , {j} and min = {min}");
                    }
                    break;
                }
                if(j == s.Length)
                    break;
                else if(!s_dict.ContainsKey(s[j]))
                    s_dict.Add(s[j], 1);
                else
                    s_dict[s[j]] += 1;
            }
            while(IsMatch(t_dict, s_dict)){
                if(min > j - i){
                    l = i;
                    r = j;
                    min = j - i;
                    //Console.WriteLine($"{i} , {j} and min = {min}");
                }
                s_dict[s[i]] -= 1;
                ++i;
            }
            if(min == t.Length || j == s.Length)
                break;
        }

        StringBuilder sb = new StringBuilder();
        for(int i = l; i < r; i++){
            sb.Append(s[i]);
        }
        ret = sb.ToString();

        return ret;
    }
}
