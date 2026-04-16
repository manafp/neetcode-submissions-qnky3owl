public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res = 0;
        for(int i=0;i<s.Length;i++)
        {
          int maxF = 0;
          var count = new Dictionary<char,int>();
           for(int j = i;j<s.Length;j++ )
           {
              if(count.ContainsKey(s[j]))
              {
                count[s[j]]++;
              }
              else
              {
                count[s[j]] = 1;
              }
              maxF = Math.Max(maxF,count[s[j]]);
              if( (j - i + 1) - maxF <= k )
              {
                res = Math.Max(res,j-i+1);
              }
           }
        }
        return res;
    }
}
