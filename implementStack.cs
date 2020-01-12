using System;
using System.Collections.Generic;

namespace Csharp
{
  class stak
  {
    public int top;
    public int[] stack;
    public int MAX = Int32.MaxValue;
    public stak()
    {
      top = -1;
      stack = new int[MAX];
    }
    public void Push(int val)
    {
      if(top >= MAX)
      {
        System.Console.WriteLine("Stack Overflow");
      }
      else
      {
          stack[++top] = val;
      }
    }
    public int Pop()
    {
      if(top < 0)
      {
        System.Console.WriteLine("Stack Underflow");
        return 0;
      }
      else
      {
        int val = stack[--top];
        return val;
      }
    }
    public void printstak()
    {
      for(int i = top; i >= 0; i--)
      {
        System.Console.WriteLine(i);
      }
    }
  }
}