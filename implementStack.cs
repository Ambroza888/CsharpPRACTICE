using System;
using System.Collections.Generic;

namespace Csharp
{
  class stak
  {
    int top;
    int[] stack;
    public stak()
    {
      top = -1;
      stack = new int[Int32.MaxValue];
    }
  }
}