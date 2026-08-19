public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        var dic = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(!dic.ContainsKey(num))
            {
                dic[num] = 0;
            }
            dic[num]++;
        }
        return dic.OrderByDescending(x=>x.Value)
        .Select(x=>x.Key)
        .Take(k).ToArray();
    }
}
