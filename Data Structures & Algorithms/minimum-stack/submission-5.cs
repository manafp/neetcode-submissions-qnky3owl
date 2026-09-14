public class MinStack {
   
    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        int min;
        if(minStack.Count > 0)
        {
             min = Math.Min(val,minStack.Peek());
        }
        else
        {
            min = val;
        }
        minStack.Push(min);
        stack.Push(val);
    }
    
    public void Pop() {
        minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        var top = stack.Peek();

        return top;
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
