using System;
using System.Collections.Generic;

namespace Csharp
{
  class Contain_common_item
  {
    public static bool Solution(char[] a, char[] b)
    {
      HashSet<char> s = new HashSet<char>();
      for(int i = 0 ; i < a.Length; i ++)
      {
        s.Add(a[i]);
      }
      for(int j = 0; j < b.Length; j ++)
      {
        if(s.Contains(b[j]))
        {
          return true;
        }
      }
      return false;
    }
    public static bool Solution2(char[] a, char[] b)
    {
      Dictionary<char,bool> map = new Dictionary<char, bool>();
      for (int i =0 ; i < a.Length;i++)
      {
        map.Add(a[i], true);
      }
      for(int i =0 ; i < b.Length;i++)
      {
        if(map.ContainsKey(b[i])) return true;
      }
      return false;
    }
  }
}