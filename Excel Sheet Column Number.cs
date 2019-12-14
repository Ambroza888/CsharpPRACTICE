using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class TittleToNumber
  {
    public static int Solution(string s)
    {
      var result = 0;
      int temp = 1;
      for ( int i = 0 ; i < s.Length; i++)
      {
        result +=  (s[i] - 64) * temp;
        temp = temp * 26;
      }
      return result;
    }
  }
}