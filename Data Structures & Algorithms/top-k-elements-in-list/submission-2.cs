public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

     var dict = new Dictionary<int,int>();
     foreach(var num in nums){
        
        dict[num] = dict.GetValueOrDefault(num,0) + 1;
     } 
      return dict.OrderByDescending(kv=>kv.Value).Take(k)
          .Select(kv=>kv.Key)
          .ToArray();

    }
}
