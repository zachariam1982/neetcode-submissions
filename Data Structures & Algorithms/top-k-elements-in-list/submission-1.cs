public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        
        foreach(int num in nums)
        {
            if(dict.ContainsKey(num) == false){
                dict[num] = 1;
            }
            else{
                dict[num] += 1;
            }
        }

        var maxQueue = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        foreach(var tmp in dict){
            maxQueue.Enqueue(tmp.Key, tmp.Value);
        }

        List<int> ret = new List<int>();

        for(int i = 0; i < k; i++){
            var val = maxQueue.Dequeue();
            ret.Add(val);
        }

        return ret.ToArray();
    }
}
