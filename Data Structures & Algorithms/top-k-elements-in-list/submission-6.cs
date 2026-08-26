public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int,int>();
        var freq = new List<int>[nums.Length + 1];

        foreach(var num in nums)
        {
            if(count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        for(int i =0;i<freq.Length;i++)
        {
            freq[i] = new List<int>();
        }
        
        foreach(var kvp in count)
        {
            freq[kvp.Value].Add(kvp.Key);
        }
        int[] res = new int[k];
        int c = 0;
        for(int i = freq.Length-1 ; i>=0;i--)
        {
            foreach(var num in freq[i])
            {
                res[c++] = num;
                if(c == k)
                {
                    return res;
                }
            }
        }
        return res;
    }
}
