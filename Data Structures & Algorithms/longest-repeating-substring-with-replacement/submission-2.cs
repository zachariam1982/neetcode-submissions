public class Solution {
    (int total, int len) Acceptable(int []arg, int mistake){
        int total = 0, max = 0;

        for(int i = 0; i < arg.Length; i++){
            max = Math.Max(arg[i], max);
            total += arg[i];
        }

        if((total - max) <= mistake){
            return (total, total);
        }
        else{
            return (total, 0);
        }
    }
    public int CharacterReplacement(string s, int k) {
        int max = 0;
        int l = 0, len = 0, mistake = k, total = 0;
        int[] dict = new int[26];

        while(l < s.Length) {
            dict[s[l] - 'A'] += 1;
            (total, len) = Acceptable(dict, k);
            //Console.WriteLine($"total = {total} and len = {len}.");
            max = Math.Max(max, len);
            l++;
            if(len == 0)
                dict[s[l - total] - 'A'] -= 1;
        }

        return max;
    }
}
