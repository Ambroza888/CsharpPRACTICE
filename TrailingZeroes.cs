using System;
using System.Collections.Generic;

namespace Csharp
{
  class TrailingZeroes
  {
    public static int  Solution(int n)
    {
      int result = 0;
      while(n >0)
      {
        result += n /5;
        n = n/5;
      }
      return result;
    } 
  }
}