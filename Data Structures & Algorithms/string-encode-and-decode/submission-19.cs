public class Solution {
    public string Encode(IList<string> strs) {
        var encode = "";
        foreach(var str in strs)
        {
            encode += str.Length + "#" + str; 
        }
        return encode;
    }

    public List<string> Decode(string s) {
       int l = 0;
       int r = 0;
       var list = new List<string>();
       while(l < s.Length)
       {
          while(s[r] != '#')
            r++;
          
          var length = int.Parse(s.Substring(l, r - l));

          var item = s.Substring(r+1,length);

          list.Add(item);
          
          l = r + length + 1;
          r = l;

       }

       return list;
   }
}
