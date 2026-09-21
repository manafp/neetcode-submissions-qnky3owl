public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

       var s1freq = new int[26];
       var windowFreq = new int[26];

       for(int i=0;i<s1.Length;i++)
       {
        s1freq[s1[i] - 'a']++;
        windowFreq[s2[i] - 'a']++;
       }

       int matches = 0;

       for(int i=0;i<26;i++)
       {
        if(s1freq[i] == windowFreq[i]) matches++;
       }

        int l=0;
        for(int r = s1.Length ; r < s2.Length; r++)
        {
            if(matches == 26) return true;

            int index = s2[r] - 'a';
            windowFreq[index]++;
            if(s1freq[index] == windowFreq[index]) matches++;
            if(s1freq[index] + 1 == windowFreq[index]) matches--;

            index = s2[l] -'a';
            windowFreq[index]--;
            if(s1freq[index] == windowFreq[index]) matches++;
            if(s1freq[index] - 1 == windowFreq[index]) matches--;

            l++;
        }
       return matches == 26;

    }
}
