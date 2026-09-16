public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
       var stack = new Stack<int[]>();


       var result = new int[temperatures.Length];

       for(int i = 0;i<temperatures.Length;i++)
       {
           while( stack.Count > 0 && temperatures[i] > stack.Peek()[1])
           {
              var temp = stack.Pop();
              result[temp[0]] = i - temp[0]; 
           }
           stack.Push(new int[]{i,temperatures[i]});
       }

       return result;
    }
}
