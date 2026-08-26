public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(dict.ContainsKey(num))
            {
                dict[num] ++;
            }
            else
            {
                dict[num] = 0;
            }
        }

        return dict.ToList().OrderByDescending(x=>x.Value)
            .Take(k)
            .Select(x=>x.Key)
            .ToArray();
    }
}
