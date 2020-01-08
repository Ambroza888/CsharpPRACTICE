using System;
using System.Collections.Generic;

namespace Csharp
{
  class LongestCommongPrefix
  {
    //Input: ["flower","flow","flight"]
    //Output: "fl"
    public static string solution(string[] strs)
    {
      string prefix = "";
      if(strs.Length == 0) return prefix;
      for(int i =0 ; i < strs[0].Length;i++)
      {
        char c = strs[0][i];
        foreach(string s in strs)
        {
          if(i > s.Length-1 || s[i] != c) return prefix;
        }
        prefix += c;
      }
      return prefix;
    }
  }
}