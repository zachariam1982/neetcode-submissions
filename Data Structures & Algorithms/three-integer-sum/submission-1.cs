public class Solution {

    public List<List<int>> ThreeSum(int[] nums) 
    {
        Dictionary<int, (int A, int B, int C)> dict = new Dictionary<int, (int A, int B, int C)>();
        HashSet<(int A, int B, int C)> set = new HashSet<(int A, int B, int C)>();

        Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++){
            int key = nums[i];
            
            if(!dict.ContainsKey(key)){
                dict[key] = (i, -1, -1);
            }
            else{
                var current = dict[key];
                if(dict[key].B == -1){
                    dict[key] = (current.A, i, -1);
                }
                else if(dict[key].C == -1){
                    dict[key] = (current.A, current.B, i);
                }
                else{
                    continue;
                }
            }
        }

        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                int a = nums[i], b = nums[j];
                int c = 0-(a + b);

                (a, b) = a > b ? (b, a) : (a, b);

                if(dict.ContainsKey(c)){
                    if((dict[c].A != i && dict[c].A != j) ||
                       (dict[c].B != -1 && dict[c].B != i && dict[c].B != j) ||
                       (dict[c].C != -1 && dict[c].C != i && dict[c].C != j) ){
                            if(c <= a){
                                set.Add((c, a, b));
                            }
                            else if( c > a && c < b){
                                set.Add((a,c,b));
                            }
                            else{
                                set.Add((a,b,c));
                            }
                       }
                }
            }
        }

        List<List<int>> ret = new List<List<int>>();
        foreach(var node in set){
            List<int> lst = new List<int>();
            lst.Add(node.A);
            lst.Add(node.B);
            lst.Add(node.C);

            ret.Add(lst);
        }

        return ret;
    }
}
