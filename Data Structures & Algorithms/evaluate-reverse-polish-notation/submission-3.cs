public class Solution {
    public int EvalRPN(string[] tokens) {
        
        var stack = new Stack<int>();

        foreach(var c in tokens)
        {
            if(int.TryParse(c,out int digit))
            {
                stack.Push(digit);
            }
            else
            {
                int op2 = stack.Pop();
                int op1 = stack.Pop();
                var result = c switch
                {
                    "+" => op1 + op2,
                    "-" => op1 - op2,
                    "*" => op1 * op2,
                    "/" => op1 / op2,
                };
                stack.Push(result);
            }
        }
    
        return stack.Peek();
    }
}
