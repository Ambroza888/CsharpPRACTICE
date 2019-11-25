using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class ValidParenteses
  {
    public static bool solution(string s)
    {
      Stack<char> stack = new Stack<char>();
      foreach(char c in s)
      {
        if(c == '(' || c == '{' || c == '[')
        {
          stack.Push(c);
        }
        else
        {
            if(stack.Count == 0) return false;
            char curr = stack.Peek();
            if(curr != '(' && c == ')'
            || curr != '}' && c == '}'
            || curr != ']' && c == ']' )
            {
              return false;
            }
            stack.Pop();
        }
      }
      return stack.Count == 0;
    }
  }
}