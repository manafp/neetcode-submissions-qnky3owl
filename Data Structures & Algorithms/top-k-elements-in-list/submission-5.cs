public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int,int>();
        var freq = new List<int>[nums.Length + 1];
        for(int i=0;i<freq.Length;i++)
        {
            freq[i] = new List<int>();
        }
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

        foreach(var kvp in dic)
        {
            freq[kvp.Value].Add(kvp.Key);
        }

        int[] res = new int[k];
        int index = 0;
        for(int i = freq.Length -1;i>0 ;i--)
        {
            foreach(var n in freq[i])
            {
                res[index++] = n;
                if(index == k) return res;
            }
        }
        return res;
    }
}
