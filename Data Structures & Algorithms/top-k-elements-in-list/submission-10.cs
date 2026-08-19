public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
       var count = new Dictionary<int,int>();
       var freq = new List<int>[nums.Length + 1];

       for(int i=0;i<freq.Length;i++)
       {
         freq[i] = new List<int>();
       }

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

       foreach(var entry in count)
       {
          freq[entry.Value].Add(entry.Key);
       }
       
       var res = new int[k];
       var index = 0;
       for(int i = freq.Length - 1;i>=0 && index<k; i--)
       {
         foreach(var entry in freq[i])
         {
            res[index++] = entry;
            if(index > k) return res;
         }
       }

       return res;
    }
}
