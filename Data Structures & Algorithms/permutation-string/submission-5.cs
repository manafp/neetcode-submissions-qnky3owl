public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        
        var s1Array = s1.ToArray();

        Array.Sort(s1Array);
        
        for(int i =0; i < s2.Length;i++)
        {
            for(int j=i;j<s2.Length;j++)
            {

                var subArray = s2.Substring(i,j-i+1).ToArray();
                Array.Sort(subArray);
                if(new String(subArray)== new String(s1Array)) 
                    return true;
            }
        }
        return false;
    }
}
