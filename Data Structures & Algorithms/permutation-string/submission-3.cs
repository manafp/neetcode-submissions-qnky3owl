public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        var s1Array = s1.ToCharArray();
        Array.Sort(s1Array);
        for(int i=0; i<=s2.Length - s1.Length;i++)
        {
            var sub = s2.Substring(i,s1.Length);
            var subArray = sub.ToCharArray();
            Array.Sort(subArray);
            if(new string(s1Array) == new string(subArray))
             return true;

        }
        return false;
    }
}
