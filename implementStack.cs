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
    }
  }
}