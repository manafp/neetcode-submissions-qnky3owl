public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length == 1)
          return true;
        int i = 0;
        int j = s.Length -1;

        while(i <= j)
        {
            while(!char.IsLetter(s[i]) && !char.IsDigit(s[i]) && i <= j)
            {
                i++;               
            }
            while(!char.IsLetter(s[j]) && !char.IsDigit(s[j]) && i <= j)
            {
                j--;
            }
            if(char.ToLower(s[i]) != char.ToLower(s[j]))
              return false;

            i++;
            j--;
        }
        return true;
    }
}
