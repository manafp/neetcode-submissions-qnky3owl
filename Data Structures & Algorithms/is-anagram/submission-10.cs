public class Solution {
    public bool IsAnagram(string s, string t) {

      var sArray = s.ToArray();
      var tArray = t.ToArray();

      Array.Sort(sArray);
      Array.Sort(tArray);

      return new String(sArray) == new String(tArray);
    }
}
