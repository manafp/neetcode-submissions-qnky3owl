public class Solution {
    public bool IsValid(string s) {

        var dic = new Dictionary<char,char>()
        {
            {')','('},
            {'}','{'},
            {']','['}
        };
        var stack = new Stack<char>();
        for(int i = 0;i<s.Length;i++)
        {
            if(!dic.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
            }
            else
            {
                if(stack.Count == 0)
                   return false;
                var pop = stack.Pop();
                if( pop != dic[s[i]])
                  return false;
            }
        }
        return stack.Count == 0;
    }
}
