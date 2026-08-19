public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(dic.ContainsKey(num))
            {
                dic[num]++;
            }
            else
            {
                dic[num] = 1;
            }
        }
        return                 dic.OrderByDescending(x=>x.Value).Select(x=>x.Key).Take(k).ToArray();
    }
}
