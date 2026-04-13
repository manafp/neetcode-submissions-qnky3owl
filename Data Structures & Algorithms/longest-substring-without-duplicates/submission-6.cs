public class Solution {
    public int LengthOfLongestSubstring(string s) {
      if(s.Length == 0 ) return 0 ;
      int l = 0;
      int r = 0;
      int count = 1;
      var hashSet = new HashSet<char>();
      while(r < s.Length)
      {
        if(!hashSet.Add(s[r]))
        {
            count = Math.Max(count,hashSet.Count());
            hashSet.Clear();
            l++;
            r = l;
        }
        else
        {
            r++;
        }
       
      }
      return Math.Max(count,hashSet.Count());
    }
}
