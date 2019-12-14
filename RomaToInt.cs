using System;
using System.Collections.Generic;

namespace Csharp
{
  class RomanToInt
  {
    public static int Solution(string s)
    {
      int n = s.Length;
      Dictionary<char,int> map = new Dictionary<char, int>()
      {
        {'I',  1},
        {'V',  5},
        {'X', 10},
        {'L', 50},
        {'C',100},
        {'D',500},
        {'M',1000}
      };
      int result = map[s[n-1]];

      for(int i = n - 2; i >= 0; i--)
      {
        int cur = map[s[i]];
        int post = map[s[i+1]];
        if(cur < post)
        {
          result = result - cur;
        }
        else
        {
            result = result + cur;
        }
      }
      return result;
    }
  }
}