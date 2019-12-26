using System;
using System.Collections.Generic;

namespace Csharp
{
  class Climbing_Stairs
  {
    public static int Solution(int n)
    {
      if (n == 0) return 0;
      if (n == 1) return 1;
      if (n == 2) return 2;

      int prePre = 1;
      int pre = 2;
      int cur = 0;

      for(int i = 2; i < n; i ++)
      {
        cur = prePre + pre;
        prePre = pre;
        pre = cur;
      }
      return cur;
    }
  }
}