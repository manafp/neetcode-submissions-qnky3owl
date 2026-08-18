public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,List<string>>();

        foreach(var str in strs)
        {
            var strArray = str.ToArray();

            Array.Sort(strArray);

            var key = new String(strArray);

            if(!dic.ContainsKey(key))
            {
                dic[key] = new List<string>();
                
            }

            dic[key].Add(str);
        }

        return dic.Values.ToList();
    }
}
