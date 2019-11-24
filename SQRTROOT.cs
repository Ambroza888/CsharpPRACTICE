using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class SumSqrtRoot
  {
    public static bool solution(int c)
    {
      int left = 0;
      int right = (int)Math.Sqrt(c);
      while(left <= right)
      {
        int result = left * left + right * right;

        if(result < c)
        {
          left++;
        }
        else if( result > c)
        {
          right++;
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