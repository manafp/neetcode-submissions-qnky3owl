public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length != t.Length) return false;
       var check = new int[26];
       for(int i = 0;i<s.Length;i++)
       {
          check[s[i] - 'a']++;
          check[t[i] - 'a']--;
       }
       return !check.Any(x => x!=0);
    }
}
