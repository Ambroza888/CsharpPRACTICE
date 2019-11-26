using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class InterSectionTwoArrays
  {
    public static int[] solution(int[] a, int[] b)
    {
      HashSet<int> set  = new HashSet<int>(a);
      List<int> result = new List<int>();
      for(int i = 0; i < b.Length;i++)
      {
        if(set.Contains(b[i]))
        {
          result.Add(b[i]);
        }
      }
      return result.ToArray();
    }
  }
}