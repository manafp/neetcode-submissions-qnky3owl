public class Solution {
    public int LengthOfLongestSubstring(string s) {
      var set = new HashSet<char>();
      int max = 0;
      int l = 0;
      int r = 0;

      while(r < s.Length)
      {
          if(!set.Add(s[r]))
          {
             max = Math.Max(max,set.Count);
             set.Remove(s[l]);
             l++;
          }
          else
          {
           r++;

          }
      }

      return Math.Max(max,set.Count);
    }
}
