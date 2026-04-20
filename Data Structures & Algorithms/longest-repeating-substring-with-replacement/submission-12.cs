public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int res = 0;
        var charSet  = new Dictionary<char,int>();

           int l = 0;int maxF = 0;
           for(int r = 0;r < s.Length;r++)
           {
             if(charSet.ContainsKey(s[r]))
             {
               charSet[s[r]]++;
             }
             else
             {
              charSet[s[r]] = 1;
             }
             maxF = Math.Max(maxF,charSet[s[r]]);
             
             if((r-l+1) - maxF > k)
             {
              charSet[s[l]]--;
              l++;
             }
              res = Math.Max(r-l+1,res);

           }
        return res;
    }
}

