public class Solution {
    public int CharacterReplacement(string s, int k) {
        var set = new HashSet<char>();

        foreach(char c in s)
        {
            set.Add(c);
        }
        int max = 0;
        foreach(var c in set)
        {
            int l = 0;
            int r = 0;
            int count = 0;
            while(r < s.Length)
            {
                if(s[r] != c)
                {
                    count++;
                }
                while(count > k)
                {
                    if(s[l] != c)
                      count--;

                    l++;
                }
                max = Math.Max((r - l) + 1 , max);
                r++;
            }
        }
        return max;
    }
}
