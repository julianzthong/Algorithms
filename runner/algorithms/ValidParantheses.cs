namespace Runner.Algorithms;

public partial class Solution
{
  public bool IsValid(string s) {
    Stack<char> stack = new();
    foreach (char c in s)
    {
      if (c == '(' || c == '{' || c == '[')
      {
        stack.Push(c);
      }
      else if (c == ')')
      {
        if (stack.Count == 0 || stack.Peek() != '(')
        {
          return false;
        }

        stack.Pop();
        continue;
      }
      else if (c == '}')
      {
        if (stack.Count == 0 || stack.Peek() != '{')
        {
          return false;
        }

        stack.Pop();
        continue;
      }
      else if (c == ']')
      {
        if (stack.Count == 0 || stack.Peek() != '[')
        {
          return false;
        }

        stack.Pop();
        continue;
      }
    }

    if (stack.Count != 0)
    {
      return false;
    }

    return true;
  }
}

/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.

Example 1:

Input: s = "()"

Output: true

Example 2:

Input: s = "()[]{}"

Output: true

Example 3:

Input: s = "(]"

Output: false

Example 4:

Input: s = "([])"

Output: true

Example 5:

Input: s = "([)]"

Output: false

*/
