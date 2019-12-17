using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class FirstUniqueLetter
  {
    public static int Solution(string s)
    {
      // if (s.Length == 0) return -1;
      int[] charAndCount = new int[256];
      foreach(char c in s)
      {
        charAndCount[c]++;
      }
      for(int i = 0; i < s.Length;i++)
      {
        if(charAndCount[s[i]] == 1)
        {
          return i;
        }
      }
      return -1;
    }

    public static int Solution2(string s)
    {
      if(s.Length == 0) return -1;
      Dictionary<char,int> d = new Dictionary<char, int>();
      for(int i = 0; i < s.Length;i++)
      {
        if(d.ContainsKey(s[i]))
        {
          d[s[i]] = -1;
        }
        else
        {
            d.Add(s[i], i);
        }
      }
      foreach(char i in d.Keys)
      {
        if(d[i] != -1) return d[i];
      }
      return -1;
    }
  }
}