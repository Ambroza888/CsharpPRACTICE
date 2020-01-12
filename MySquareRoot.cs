using System;
using System.Collections.Generic;

namespace Csharp
{
  class MySquareRoot
  {
    public static int Solution(int x)
    {
      if(x == 0) return 0;
      if(x == 1) return 1;
      long min = 0;
      long max = x;

      while(min < max)
      {
        long mid = min + (max - min)/2;
        long candidate = mid * mid;
      }
    }
  }
}