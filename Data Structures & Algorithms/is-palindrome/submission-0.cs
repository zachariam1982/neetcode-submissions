public class Solution {
    public bool IsPalindrome(string s) {
        s =s.ToLower();
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < s.Length; i++){
            if((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= '0' && s[i]<= '9'))
                sb.Append(s[i]);
        }
        s = sb.ToString();
        for(int st = 0, end = s.Length - 1; st < end; st++, end--){
            if(s[st] != s[end]){
                return false;
            }
        }

        return true;
    }
}
