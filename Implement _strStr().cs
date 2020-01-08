using System;
using System.Collections.Generic;

namespace Csharp
{
  class Implement_strStr
  {
    public static int Solution(string haystack, string needle)
    {
      if(needle.Length == 0) return 0;
      if(needle.Length > haystack.Length) return -1;
      
      int needleIndex = 0;
      for(int i = 0; i < haystack.Length;i++)
      {
        if(haystack[i] == needle[needleIndex])
        {
          needleIndex++;
          if(needleIndex == needle.Length) return i - needleIndex + 1;
        }
        else
        {
            i -= needleIndex;
            needleIndex = 0;
        }
      }
      return -1;
      
    }
  }
}