using System;
using System.Collections.Generic;

namespace Csharp
{
  class BalanceString
  {
    // input: s = "RLRRLLRLRL" ----> output : "4"
    // input: s = "RLLLLRRRLR" ----> output : "3"
    public static int BalanceString1(string s)
    {
      int lcount = 0;
      int rcount = 0;
      int result = 0;
      for (int i = 0; i < s.Length; i++)
      {
        if(s[i] == 'L')
        {
          lcount++;
        }
        else
        {
            rcount++;
        }
        if(lcount == rcount)
        {
          result++;
          
        }
      }
      Console.WriteLine(result);
      return result;
    }
  }
}