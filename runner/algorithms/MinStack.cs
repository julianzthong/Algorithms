namespace Runner.Algorithms;

public partial class Solution
{
  public class MinStack {
    readonly Stack<int> _mainStack = new();
    readonly Stack<int> _minStack = new();

    public void Push(int val)
    {
      _mainStack.Push(val);
      if (_minStack.Count == 0 || _minStack.Peek() >= val)
      {
        _minStack.Push(val);
      }
    }

    public void Pop()
    {
      if (_mainStack.Peek() == _minStack.Peek())
      {
        _minStack.Pop();
      }
      _mainStack.Pop();
    }

    public int Top()
    {
      return _mainStack.Peek();
    }

    public int GetMin()
    {
      if (_minStack.TryPeek(out int min))
      {
        return min;
      }
      return 0;
      ;
    }
  }

  public class SingleMinStack {
    readonly Stack<(int, int)> _minStack = new();

    public void Push(int val)
    {
      if (_minStack.TryPeek(out (int top, int min) tuple))
      {
        if (val <= tuple.min)
        {
          _minStack.Push((val,val));
        }
        else
        {
          _minStack.Push((val,tuple.min));
        }
      }
      else
      {
        _minStack.Push((val, val));
      }
    }

    public void Pop()
    {
      _minStack.Pop();
    }

    public int Top()
    {
      return _minStack.Peek().Item1;
    }

    public int GetMin()
    {
      if (_minStack.TryPeek(out (int top, int min) tuple))
      {
        return tuple.min;
      }
      return 0;
      ;
    }
  }
}

/*
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

    MinStack() initializes the stack object.
    void push(int val) pushes the element val onto the stack.
    void pop() removes the element on the top of the stack.
    int top() gets the top element of the stack.
    int getMin() retrieves the minimum element in the stack.

You must implement a solution with O(1) time complexity for each function.

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2

*/

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */