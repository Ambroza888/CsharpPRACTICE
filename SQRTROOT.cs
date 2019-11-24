using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class SumSqrtRoot
  {
    public static bool solution(int c)
    {
      int min = 0;
      int max = (int)Math.Sqrt(c);
      while(min <= max)
      {
        if((min * min) + (max * max) < c)
        {
          min++;
        }
        else if ( (min*min)+(max*max) > c)
        {
          max--;
        }
        else
        {
          return true;
        }
      }
      return false;
    }
  }
}