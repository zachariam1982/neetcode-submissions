public class Solution {

    string linebreaker = "@::@";

    public string Encode(IList<string> strs) 
    {
        StringBuilder strB = new StringBuilder();

        foreach(var str in strs){
            strB.Append(str).Append(linebreaker);
        }

        return strB.ToString();
    }

    public List<string> Decode(string s) 
    {
        var ret = s.Split(linebreaker).ToList();
        
        ret.RemoveAt(ret.Count - 1);

        return ret;
    }
}
